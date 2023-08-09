using Microsoft.AspNetCore.Mvc;

namespace IBM_07AUG2023_D1MorBNew.Controllers
{
    public class RazorSyntaxEgController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }


  public IActionResult SimpleLayoutContent()
        {
            return View();
        }


public IActionResult NestedLayoutContent()
        {
            return View();
        }

public IActionResult TagHelperEg()
        {
            return View();
        }


        [Route("/demo/abc",
       Name = "nmdRoute")]
        public string SomeActMethod() => "Hello";

        public string anotherActMethod(string EmpName, int EmpID)
        {
            return $"Enm={EmpName} -- eID={EmpID}";
        }


    }
}
