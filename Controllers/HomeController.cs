﻿using BlogAPI.Attrributes;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    [HttpGet("")]
    [ApiKey]
    public IActionResult Get()
    {
        return Ok();
    }
}