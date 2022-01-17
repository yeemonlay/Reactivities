using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : TestBaseApiController
    {
        private readonly DataContext _ctx;
        public ActivitiesController(DataContext ctx)
        {
            _ctx = ctx;
        }

//list
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetAcitities()
        {
            return await _ctx.Activities.ToListAsync();
        }

//detail
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetAcitities(Guid id)
        {
            return await _ctx.Activities.FindAsync(id);
        }
    }
}