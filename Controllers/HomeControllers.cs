using Microsoft.AspNetCore.Mvc;
using Madlibz.Models;

namespace MadLibz.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    [Route("/OSayForm")]
    public ActionResult OSayForm() { return View(); }
    [Route("/OSay")]
    public ActionResult OSay(string verb1, string noun1, string adverb, string verbPast, string pluralNoun1, string pluralNoun2, string adjective1, string pluralNoun3, string verbIng, string color, string pluralNoun4, string noun2, string noun3, string interjection, string adjective2, string verb2, string adjective3, string adjective4)
    {
      OSayVariable myOSayVariable = new OSayVariable();
      myOSayVariable.Verb1 = verb1;
      myOSayVariable.Noun1 = noun1;
      myOSayVariable.Adverb = adverb;
      myOSayVariable.VerbPast = verbPast;
      myOSayVariable.PluralNoun1 = pluralNoun1;
      myOSayVariable.PluralNoun2 = pluralNoun2;
      myOSayVariable.Adjective1 = adjective1;
      myOSayVariable.PluralNoun3 = pluralNoun3;
      myOSayVariable.VerbIng = verbIng;
      myOSayVariable.Color = color;
      myOSayVariable.PluralNoun4 = pluralNoun4;
      myOSayVariable.Noun2 = noun2;
      myOSayVariable.Noun3 = noun3;
      myOSayVariable.Interjection = interjection;
      myOSayVariable.Adjective2 = adjective2;
      myOSayVariable.Verb2 = verb2;
      myOSayVariable.Adjective3 = adjective3;
      myOSayVariable.Adjective4 = adjective4;
      return View(myOSayVariable);
    }
  }
}
