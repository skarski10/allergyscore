using Nancy;
using System;
using AllergyApp.Objects;
using System.Collections.Generic;

namespace AllergyApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        Allergy.ClearAll();
        return View["index.cshtml"];
      };

      Post["/"] = _ => {
        Allergy.ClearAll();
        Allergy newAllergy = new Allergy(Request.Form["input"]);
        List<string> result = Allergy.GetAll();
        return View["index.cshtml", result];
      };
    }
  }
}
