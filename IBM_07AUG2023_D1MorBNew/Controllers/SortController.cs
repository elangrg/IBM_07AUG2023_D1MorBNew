using Microsoft.AspNetCore.Mvc;

namespace IBM_07AUG2023_D1MorBNew.Controllers
{
    public class SortController : Controller
    {
        public string Index(string values, string id)
        {
            var brokenValues = values.Split('/');
            Array.Sort(brokenValues);
            return String.Join(", ", brokenValues);
        }
    }
}
