using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Person
    {
        public string lastName;
        public string firstName;
        public string furiganaLastName;
        public string furiganaFirstName;
        public DateTime birthday;

        private double _height;

        public double Height
        {
            get { return _height; }
            set
            {
                if (value >= 0)
                {
                    _height = value;
                }
            }
        }
        public double Weight { get; set; }

        public Person()
        {
        }

        public Person(string lastName, string firstName, string furiganaLastName,
            string furiganaFirstName, DateTime birthday)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.furiganaLastName = furiganaLastName;
            this.furiganaFirstName = furiganaFirstName;
            this.birthday = birthday;
        }

        public int getAge()
        {
            int age = 0;
            DateTime now = DateTime.Now;
            TimeSpan ts = now - birthday;
            age = (int)((double)ts.Days / 365.2425);
            return age;
        }
    }

    class Student : Person
    {
        public string id;
        public int grade;
        public Dictionary<string, int> scores;

        public Student() { }

        public Student(string lastName, string firstName, string furiganaLastName,
            string furiganaFirstName, DateTime birthday)
            : base(lastName, firstName, furiganaLastName,
             furiganaFirstName, birthday)
        {
        }


        public int getTotalScore()
        {
            int totalScore = 0;
            foreach (var score in scores.Values)
            {
                totalScore += score;
            }

            return totalScore;
        }
    }

}
