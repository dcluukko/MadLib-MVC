using Microsoft.AspNetCore.Mvc;
using Madlibz.Models;

namespace MadLibz.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("MadLib")]
    public ActionResult MadLib(string noun, string verb)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Verb = verb;
      return View(myMadLibVariable);
    }
  }
}
