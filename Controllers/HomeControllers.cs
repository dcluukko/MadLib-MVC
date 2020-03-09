using Microsoft.AspNetCore.Mvc;
using Madlibz.Models;

namespace MadLibz.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    [Route("/OSayForm")]
    public ActionResult OSayForm() { return View(); }
    [Route("MadLib")]
    public ActionResult OSay(string noun1, string verb1)
    {
      OSayVariable myOSayVariable = new OSayVariable();
      myOSayVariable.Noun1 = noun1;
      myOSayVariable.Verb1 = verb1;
      return View(myOSayVariable);
    }
  }
}
