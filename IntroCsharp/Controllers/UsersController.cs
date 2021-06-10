using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using IntroCsharp.Models;
using dbcontext.DB;
using System.Configuration;

namespace UsersControllers.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

      private readonly TicDB _context;

      public UsersController(TicDB context)
      {
        _context = context;
      }

      [HttpGet]
      public IEnumerable<User> GetAllUsers() {
        var list = _context.Users.ToList();
        if (list == null) {
          return null;
        }
        return list;
      }
      /*[HttpPost("users/{id}")] 
      {

      }*/

      
    }
/*
      [HttpPut("users/update/{id}")] 
      {

      }

      [HttpDelete("users/delete/{id}")] 
      {

      }*/
}