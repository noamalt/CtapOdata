using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

using CtapOdata.Models;
using Microsoft.AspNet.OData;

namespace CtapOdata.Controllers
{
    [EnableQuery]
    [Produces("application/json")]
    [Route("api/Depositors")]
    public class DepositorsController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;
        public DepositorsController(ApplicationDbContext ODataDbContext)
        {
            _appDbContext = ODataDbContext;
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_appDbContext.Depositors.AsQueryable());
        }

    }
}