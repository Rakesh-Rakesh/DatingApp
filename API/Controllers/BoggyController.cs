using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API;

public class BoggyController : BaseApiController
{
    private readonly DataContext _context;


    public BoggyController(DataContext context)
    {
        this._context = context;
    }
    [Authorize]

    [HttpGet("auth")]
    public ActionResult<string> GetSearch()
    {
        return "Secret text";
    }

    [HttpGet("not-found")]
    public ActionResult<AppUser> GetNotFound()
    {
        var thing =_context.Users.Find(-1);

        if(thing == null) return NotFound();

        return thing;
    }

    [HttpGet("server-error")]
    public ActionResult<string> GetServerError()
    {
        var thing = _context.Users.Find(-1);

        var thingToReturn = thing.ToString(); 

        return thingToReturn;
    }

    [HttpGet("bad-request")]
    public ActionResult<string> GetRequest()
    {
        return BadRequest("This was not a good request ");
    }

    
}
