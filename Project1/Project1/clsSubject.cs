using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class clsModule
    {
        string name;
        DateTime startTime;
        DateTime endTime;
        clsPerson instructor; // instructors are people
        List<clsPerson> students; // so are students
        string classRoomNumber; //B10 or A01
    }

    public decimal calculatePercentageOfApprovedStudents()
    {
        // M suffix identifies the number as decimal
        return 100.0M;
    }

    public void generateMockStudentList()
    {
        // i statiate the class
        clsPerson newStudent = new clsPerson();
        // fill in information in the properties
        newStudent.lastName = "Snow";
        newStudent.firstName = "Jon";
        newStudent.age = 30;
        newStudent.eyeColor = "Black";
        newStudent.height = 1.75m;
        newStudent.idCard = "100-99-0-000";
    }

    //we can also assign object to other object´s properties
    Guid uniqueIdentifier = new Guid();
    newStudent.uniqueId = uniqueIdentifier;

    newStudent.hobbies = new List<string>();
        // or call methods / functions
    newStudent.takeTest(Programming in C3);


}
