using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpGet()]
        public string GetBook()
        {
            var smallBook = new PhotoBook();
            var mediumBook = new PhotoBook(24);
            var bigBook = new BigPhotoBook();

            return $"$El libro pequeño{smallBook.GetNumberPages()}\n El libro mediano {mediumBook.GetNumberPages()}\n El libro mediano {bigBook.GetNumberPages()}";
        }
    }
}
