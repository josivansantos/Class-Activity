using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class clsPerson
    {
        // ALL properties and method here
        public string firstName {get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public decimal height { get; set; } // because we are using meters
        public string eyeColor { get; set; } // black, brow or green
        public string idCard { get; set; } // like A290-08SD-23GR
        public Guid uniqueId { get; set; } // something more complex
        public List<string> hobies { get; set; } // you can have many


        // all methods / funciton here - think about school system
        public void registerAsNewStudent(decimal paidAmout, string programNAme)
        {
            //
        }

        public void Take Test (string)
    }

    class clsSubject { }
}
