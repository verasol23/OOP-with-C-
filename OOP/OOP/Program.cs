using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        public static int Id = 0;
        public string Fisrtname;
        public string Lastname;
        public string Major;
        private int _score;

        public int Score
        {
            get { return _score; }
            set 
            {
                if (value < 0)
                    value = 0;
            }
        }
        public Student(string fisrtname, string lastname, string major, int score)
        {
            this.Fisrtname = fisrtname;
            this.Lastname = lastname;
            this.Major = major;
            this.Score = score;
            Id++;
        }
         
        public void Display()
        {
            Console.WriteLine("ID:{4}\nFull name: {0} {1} \nMajor: {2}\nScore: {3}",Fisrtname,Lastname,Major,_score,Id);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student dat = new Student("Nguyen","Dat","AI",90);
            dat.Display();
            Student tuan = new Student("Nguyen", "tuan", "AI", -10);
            tuan.Display();
            Console.ReadLine();

        }
    }
}
