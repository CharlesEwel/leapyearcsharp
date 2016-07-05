using Nancy;
using LeapYear.Objects;
using System.Collections.Generic;

namespace LeapYear
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> {
        return View["index.cshtml", "You haven't entered anything yet"];
      };
      Post["/Leetspeak/created"] =_=> {

        string phrase = Request.Form ["name"];
        LeetSpeakTranslator newLeet = new LeetSpeakTranslator();
        string translatedPhrase = newLeet.Translate(phrase);
        return View["index.cshtml", translatedPhrase];
      };
    }
  }
}
