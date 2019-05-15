using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PMI
{
    class clsUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }


        public void createNewUser()
        {
            clsUser newUser = new clsUser();
            newUser.firstName = "Jon";
            newUser.lastName = "Silva";
            newUser.email = "ww@ss.com";
        }
    }
}
