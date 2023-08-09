using Microsoft.AspNetCore.Mvc;

namespace IBM_07AUG2023_D1MorBNew.Controllers
{
    public class BlogController : Controller
    {
        public string Archive(DateTime? entryDate)
        {
            return entryDate.ToString();

        }
    }
}
