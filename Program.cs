using System;
using System.Collections;
 
namespace Practical_Assignment_OOP_2
{
  //Create a new class with the main method in it.
  class Program
  {
      static void Main(string[] args)
      {
       //a. Create seven Officers as the objects and two Districts as the objects. 
       Officer officer1 = new Officer();
       Officer officer2 = new Officer("John", "Doe", 3347, 12);
       Officer officer3 = new Officer("Anna", "Black", 3348, 25);
       Officer officer4 = new Officer("Stive", "Roze", 3349, 33);
       Officer officer5 = new Officer("Antuan", "Zeben",3350, 44);
       Officer officer6 = new Officer("Bete", "Deniro", 3351, 10);
       Officer officer7 = new Officer("Alex", "Stone", 3352, 8);
       District district1 = new District();
       District district2 = new District("East", "Riga", 1006, new Officer[0]);
       
       //b. Add three Officers in the first District and others in the second District.
       district1.AddNewOfficer(officer1);
       district1.AddNewOfficer(officer2);
       district1.AddNewOfficer(officer3);
       district2.AddNewOfficer(officer4);
       district2.AddNewOfficer(officer5);
       district2.AddNewOfficer(officer6);
       district2.AddNewOfficer(officer7);
       
       /*c. Print out all information about each District. 
       Console.WriteLine(district1);
       Console.WriteLine(district2);
       There are printed out
       Central #1039 in Riga (Officers:
       Janet Snow 3346, ID 3346, Crimes solved 19
       John Doe 3347, ID 3347, Crimes solved 12
       Anna Black 3348, ID 3348, Crimes solved 25
       East #1006 in Riga (Officers:
       Stive Roze 3349, ID 3349, Crimes solved 33
       Antuan Zeben 3350, ID 3350, Crimes solved 44
       Bete Deniro 3351, ID 3351, Crimes solved 10
       Alex Stone 3352, ID 3352, Crimes solved 8*/

       //d. Remove one Officer from the second District.
       district2.RemoveOfficer(officer4);
       Console.WriteLine(district1);
       Console.WriteLine(district2);
       
       //e. Calculate average level of each District.
       float avg1 = district1.CalculateAvgLevelInDistrict();
       float avg2 = district2.CalculateAvgLevelInDistrict();
       Console.WriteLine($"District 1 average: {avg1.ToString("0.###")} | District 2 average: {avg2.ToString("0.###")}");
       
       //g. Create an Arraylist of the Districts and put both District objects in the arraylist
       ArrayList districts = new ArrayList();
       districts.Add(district1);
       districts.Add(district2);
       Console.WriteLine(districts.Count);
       //There are printed out '2'
      
      //h. Calculate how many Officers are in both Districts.
      int officerCount = 0;
      foreach (District district in districts)
      {
        officerCount += district.GetOfficersInTheDistrict().Length;
      }
      Console.WriteLine($"There are {officerCount} officers across all districts.");

      //i. Calculate the average level of both Districts.
      double levelSum = 0;
      foreach(District district in districts)
      {
        levelSum += district.CalculateAvgLevelInDistrict();
      }
      double levelAvg = levelSum / districts.Count;
      Console.WriteLine($"Average level across all districts: {levelAvg.ToString("0.###")}");

      //Find out which District is the best based on the average level of Officers
      if(district1.CalculateAvgLevelInDistrict() == district2.CalculateAvgLevelInDistrict())
      {
        Console.WriteLine("Both districts are the best based on averages!");
      }
      else if(district1.CalculateAvgLevelInDistrict() > district2.CalculateAvgLevelInDistrict())
      {
        Console.WriteLine("District 1 is the best based on averages!");
      }
      else
      {
        Console.WriteLine("District 2 is the best based on averages!");
      }

      //k. Delete the first District. What’s happening with Officers in there?
      districts.Remove(district1);
      Console.WriteLine(district1);
      /*There are still printed out
      Central #1039 in Riga (Officers:
      Janet Snow 3346, ID 3346, Crimes solved 19
      John Doe 3347, ID 3347, Crimes solved 12
      Anna Black 3348, ID 3348, Crimes solved 25*/

      }
  }
}