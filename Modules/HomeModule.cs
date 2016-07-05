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
      Post["/queenAttack/created"] =_=> {
        QueenAttack newQueenAttack = new QueenAttack();
        bool mayAttack = newQueenAttack.CanAttack(
                                                  Request.Form["queenx"],
                                                  Request.Form["queeny"],
                                                  Request.Form["userx"],
                                                  Request.Form["usery"]
        );
        string may = "";
        if(!mayAttack)
        {
          may = "not ";
        }
        string queenOutput = "The queen may " + may + "attack that space.";
        return View["index.cshtml", queenOutput];
      };
      Post["/ClockAngle/created"] =_=> {
        ClockAngle newClockAngle = new ClockAngle();
        double newAngle = newClockAngle.CalculateAngle(
                                                        Request.Form["hour"],
                                                        Request.Form["minute"]
        );
        return View["index.cshtml", newAngle];

      };
    }
  }
}
