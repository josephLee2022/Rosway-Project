using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project.CLASSES
{
    [Serializable]
    class Car
    {
           public string Make;
        public string Model;
        public int Year;
        public string Category;
        public bool HasCDPlayer;
        public bool HasDVDPlayer;
        public bool IsAvailable;

        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Category = "";
            HasCDPlayer = false;
            HasDVDPlayer = false;
            IsAvailable = false;
        }

        public Car(string mk, string mdl,
                   int yr, string cat, bool cd,
                   bool  dvd, bool avl)
        {
            Make = mk;
            Model = mdl;
            Year = yr;
            Category = cat;
            HasCDPlayer = cd;
            HasDVDPlayer = dvd;
            IsAvailable = avl;
        }
    }
}












    

