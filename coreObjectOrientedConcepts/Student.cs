using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class Student
    {
        //Data Members
        private int studentId;
        private string studentName;

        public Student()
        {
            studentId = 101;
            studentName = "Annonymous";
        }

        public Student(int sID, string sName)
        {
            studentId = sID;
            studentName = sName;
        }

        public void acceptDetails()
        {
            Console.Write("Enter Student ID: ");
            int.TryParse(Console.ReadLine(), out studentId);
            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();


        }
        public void displayDetails()
        {
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }
    }
}
