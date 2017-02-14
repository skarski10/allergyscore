using System;
using Xunit;
using System.Collections.Generic;
using AllergyApp.Objects;

namespace AllergyAppTest
{
  public class AllergyAppTest
  {
    [Fact]
    public void IsAllergy_Existant_All()
    {
      Allergy newAllergy = new Allergy(255);
      List<string> testResult = new List<string>();
      testResult.Add("cats");
      testResult.Add("pollen");
      testResult.Add("chocolate");
      testResult.Add("tomatoes");
      testResult.Add("strawberries");
      testResult.Add("shellfish");
      testResult.Add("peanuts");
      testResult.Add("eggs");

      List<string> result = Allergy.GetAll();

      Assert.Equal(testResult, result);
    }
  }
}
