using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tubular.Data;
using Unosquare.Tubular;
using Unosquare.Tubular.ObjectModel;

namespace Tubular.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TubularController : ControllerBase
    {
        private TubularDbContext _dbContext { get; set; }
        public TubularController(TubularDbContext context)
        {
            _dbContext = context;
        }

        [HttpPost]
        [Route("paged")]
        public IActionResult Post(GridDataRequest request)
        {
            var x = request.CreateGridDataResponse(_dbContext.Orders);
            return Ok(request.CreateGridDataResponse(_dbContext.Orders));
        }
    }
}
