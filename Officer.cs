using System;
namespace Practical_Assignment_OOP_2
{
    class Officer
    {
        //Copy the Officer class in the new project. Delete the variable workingDistrict
        string name;
        string surname;
        int officerID;       
        int crimeSolved;

        /* No-argument constructor
        public Officer()
        {
            name = "Janet";
            surname = "Snow";
            officerID = 3346;
            crimeSolved = 19;
        }
        */
        //Argument constructor
        public Officer() : this("Janet", "Snow", 3346, 19 )
         {
         }
        public Officer(string name, string surname, int officerID, int crimeSolved)
        {
            this.name = name;
            this.surname = surname;
            this.officerID = officerID;
            this.crimeSolved = crimeSolved;
        }
       
         //Get and Set function
         public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            name = value;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetSurname(string value)
        {
            surname = value;
        }
        // Or another way more shorter
        public int OfficerID { get => officerID; set => officerID = value; }
        public int CrimeSolved { get => crimeSolved; set => crimeSolved = value; }
        
        //ToString() is the method where information about the object values are returned as String value.
        public override string ToString()
        {
            return $"{name} {surname} {officerID}, ID {officerID}, Crimes solved {crimeSolved}";
        }
        /*calculatedLevel() is the method where Officer level is calculated: 
        a. If the crimeSolved value is less than 20, the level is 1. 
        b. If the crimeSolved value is larger than 20 and less than 40, the level is 2. 
        c. If the crimeSolveed value is larger than 40, the level is 3 */
        public int CalculateLevel()
        {
            if (crimeSolved < 20)
            {
                return 1;
            }
            else if (crimeSolved < 40)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        } 

    }

}


