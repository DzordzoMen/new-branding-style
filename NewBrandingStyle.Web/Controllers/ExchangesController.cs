using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Models.Database;

namespace NewBrandingStyle.Web.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ExchangesController : ControllerBase {
        private readonly ExchangesDbContext _dbContext;

        public ExchangesController(ExchangesDbContext dbContext) {
            _dbContext = dbContext;
        }
        public IActionResult Post(CompanyModel item) {
            var entity = new ItemEntity {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
