using Nancy;
using LeapYear.Objects;
using System.Collections.Generic;
using System;

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
      Post["/Anagram/created"] =_=> {
        Anagram newAnagram = new Anagram();
        List<string> inputWords = new List<string>{};
        for(int i = 0; i<Request.Form["number-of-testWords"]; i++)
        {
          inputWords.Add(Request.Form["testWord"+i]);
        }
        List<string> AnagramList = newAnagram.IsAnagram(Request.Form["compareWord"], inputWords);
        string outputString = string.Join(", ", AnagramList);
        return View["index.cshtml", outputString];



      };
    }
  }
}
