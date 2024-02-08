﻿using System.Security.Claims;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[Authorize]
public class UsersController : BaseApiController
{
  private readonly IUserRepository _userRepository;
  private readonly IMapper _mapper;
  public IPhotoService _photoService;

  public UsersController(IUserRepository userRepository, IMapper mapper, IPhotoService photoService)
  {
    _photoService = photoService;
    _mapper = mapper;
    _userRepository = userRepository;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
  {
    var users = await _userRepository.GetMembersAsync();


    return Ok(users);
  }

  [HttpGet("{username}")] // /api/users/username
  public async Task<ActionResult<MemberDto>> GetUser(string username)
  {
    return await _userRepository.GetMemberAsync(username);

  }

  [HttpPut]
  public async Task<ActionResult> UpdateUser(MemberUpdateDto memberUpdateDto)
  {
    // var username = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    // we have username in the token - this above line helps retrive that // above line is refactored by an extension

    var user = await _userRepository.GetUserByUsernameAsync(User.GetUsername());
    if (user == null) return NotFound();
    _mapper.Map(memberUpdateDto, user);
    // this above line updates properties in the memberupdateDto to the user

    if (await _userRepository.SaveAllAsync()) return NoContent(); //if sucessful this one will send a204 status all okay nothing to report

    return BadRequest("Failed to update user");
  }

  [HttpPost("add-photo")]
  public async Task<ActionResult<PhotoDto>> AddPhoto(IFormFile file)
  {
    var user = await _userRepository.GetUserByUsernameAsync(User.GetUsername());

    if (user == null) return NotFound();

    var result = await _photoService.AddPhotoAsync(file);

    if (result.Error != null) return BadRequest(result.Error.Message);

    var photo = new Photo
    {
      Url = result.SecureUrl.AbsoluteUri,
      PublicId = result.PublicId
    };

    if (user.Photos.Count == 0) photo.IsMain = true;
    user.Photos.Add(photo);

    if (await _userRepository.SaveAllAsync()) return _mapper.Map<PhotoDto>(photo);
    return BadRequest("Problem adding photo");
  }

}
