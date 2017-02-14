using Nancy;
using System.Collections.Generic;
using AnagramApp.Objects;


namespace AnagramApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/result"] = _ => {
        Anagram userAnagram = new Anagram(Request.Form["userWord"]);
        userAnagram.Compare(Request.Form["altWord"]);
        return View["index.cshtml", userAnagram];
      };
    }
  }
}
