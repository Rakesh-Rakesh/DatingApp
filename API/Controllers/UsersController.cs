
using Microsoft.AspNetCore.Mvc;
using API.DTOS;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;

namespace API.Controllers;

[Authorize]
public class UsersController : BaseApiController
{
  private readonly IUserRepository _userRepository;

  public IMapper _mapper { get; }

  public UsersController(IUserRepository userRepository, IMapper mapper)
  {
    _userRepository = userRepository;
    _mapper = mapper;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
  {

    var users = await _userRepository.GetMembersAsync();

    return Ok(users);


  }
  [HttpGet("{username}")]
  public async Task<ActionResult<MemberDto>> GetUser(string username)
  {
    return await _userRepository.GetMemberAsync(username);



  }
}