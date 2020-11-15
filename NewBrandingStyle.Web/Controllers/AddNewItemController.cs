using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class AddNewItemController : ControllerBase {
        public CompanyAddedViewModel Post(CompanyModel Item) {
            return new CompanyAddedViewModel {
                NumberOfCharsInName = Item.Name.Length,
                NumberOfCharsInDescription = Item.Description.Length,
                IsHidden = !Item.IsVisible,
            }; ;
        }
    }
}
