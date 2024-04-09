using Microsoft.AspNetCore.Mvc;

namespace Web.Ej2
{
    public class PhotoBook 
    {
        protected int numPages { get; set; } 

        public PhotoBook(int numOfPages = 16)
        {
           numPages = numOfPages;
        }
        public string GetNumberPages()
        {
            return $" Contiene {numPages} fotos";
        }

    }
    
}
