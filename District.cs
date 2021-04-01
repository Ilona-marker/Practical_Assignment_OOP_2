namespace Practical_Assignment_OOP_2
{
    //Create a new class District
    class District
    {
        private string title;
        private string city;
        private int districtID;
        private Officer[] officersInTheDistrict;

        /* No-argument constructor
        public District()
        {
            title = "Central";
            city = "Riga";
            districtID = 1039;
            officersInTheDistrict = new Officer[0];
        }
        */
        //Argument constructor
        public District() : this("Central", "Riga", 1039, new Officer[0] )
         {
         }
        public District(string title, string city, int districtID, Officer[] officers)
        {
            this.title = title;
            this.city = city;
            this.districtID = districtID;
            this.officersInTheDistrict = officers;
        }
        //Get and Set functions
        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string value)
        {
            title = value;
        }

        public string GetCity()
        {
            return city;
        }

        public void SetCity(string value)
        {
            city = value;
        }

        public int GetDistrictID()
        {
            return districtID;
        }

        public void SetDistrictID(int value)
        {
            districtID = value;
        }
        public Officer[] GetOfficersInTheDistrict()
        {
            return officersInTheDistrict;
        }

        public void SetOfficersInTheDistrict(Officer[] value)
        {
            officersInTheDistrict = value;
        }

        //ToString() is the method where information about the object values are returned as String value.
        public override string ToString()
        {
            string result = $"{title} #{districtID} in {city} (Officers:";
            foreach (Officer officer in officersInTheDistrict)
            {
                result += "\n" + officer;
            }
            return result;
        }   

          /* There are printed out:
            Central #1039 in riga, Officers:
            Janet Snow (ID 3346, Crimes solved 19)  
            Stive Black (ID 3347, Crimes solved 33)
          */ 
           //Add new Officer():boolean
           public bool AddNewOfficer(Officer newOfficer) 
           {
            //1.Check that NewOfficer does not exist as part of officerInTheDistrict;
            foreach (Officer existingOfficer in officersInTheDistrict)
            {
              if (existingOfficer.Equals(newOfficer))
              {
                  return false;
              }
            }
            //2.Actually add newOfficer to array as element.
            Officer[] newOfficers = new Officer[officersInTheDistrict.Length + 1];
            for (int i = 0; i < officersInTheDistrict.Length; i++ )
            {
                newOfficers[i] = officersInTheDistrict[i];
            }
            newOfficers[newOfficers.Length - 1] = newOfficer;
            officersInTheDistrict = newOfficers;
            return true;
           }
           //Actually remove officerToRemove from array.
           public bool RemoveOfficer(Officer officerToRemove)
           {
           //1.Check if officerToRemove actually exists in our district.
           int indexToRemove = -1;
           for (int i = 0; i < officersInTheDistrict.Length; i++ )
             {
               Officer existingOfficer = officersInTheDistrict[i];
               if (existingOfficer.Equals(officerToRemove))
               {
                 indexToRemove = i;  
                 break;
               }
               if (i == officersInTheDistrict.Length - 1)
               {
                   return false;
               }
               
             }
            //2.Actually remove officerToRemove from aray.
            Officer[] newOfficers = new Officer[officersInTheDistrict.Length - 1];
            for (int i = 0; i < indexToRemove; i++)
            {
                newOfficers[i] = officersInTheDistrict[i];
            }
            for (int i = indexToRemove + 1; i < officersInTheDistrict.Length; i++)
            {
                newOfficers[i - 1] = officersInTheDistrict[i];
            }
            officersInTheDistrict = newOfficers;
            return true;
        }
           //Calculate Average Level in District
           public float CalculateAvgLevelInDistrict()
           {
               int sum = 0;
               foreach (Officer officer in officersInTheDistrict)
               {
                   sum += officer.CalculateLevel();
               }
               return (float)sum / officersInTheDistrict.Length;
           }

        } 
    }
    

    
