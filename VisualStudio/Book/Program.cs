using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book();
            book1.title = "C#入門";
            book1.publishedDate = new DateTime(2000, 12, 31);
            book1.author = "七月太郎";
            book1.Price = -1;

            var book2 = new Book("C#大好き", "七月太郎", new DateTime(2015,7,1), 2000);

            Magazine mag1 = new Magazine();
            mag1.title = "ベーシックマガジン";
            mag1.Price = 1000;
            mag1.month = 1;

            int taxIncludedPrice = mag1.getTaxIncludedPrice();
            int tax = mag1.getTax();
            Console.WriteLine("税抜価格 " + book1.Price + " ");
            Console.WriteLine(tax + " " + taxIncludedPrice);
            Console.WriteLine(mag1.title + mag1.getMonth());
            Console.WriteLine(mag1.author);

            Novel nov1 = new Novel();
            nov1.title = "no c#, no life";
            nov1.series = "xxx文庫";


            var p1 = new Person();
            p1.lastName = "田中";
            p1.firstName = "太郎";
            p1.furiganaLastName = "たなか";
            p1.furiganaFirstName = "たろう";
            p1.birthday = new DateTime(2009,1,1);

            Console.Write(p1.lastName + " " + p1.firstName);
            Console.Write("(" + p1.furiganaLastName + " " 
                + p1.furiganaFirstName + ")、");
            Console.WriteLine(p1.birthday.Year 
                + "/" + p1.birthday.Month
                + "/" + p1.birthday.Day + "生 " + p1.getAge() +"才");

            var p2 = new Person();
            p2.lastName = "鈴木";
            p2.firstName = "花子";
            p2.furiganaLastName = "すずき";
            p2.furiganaFirstName = "はなこ";
            p2.birthday = new DateTime(1998, 12, 31);
            p2.Height = 180.3;
            p2.Weight = 90.5;

            Console.Write(p2.lastName + " " + p2.firstName);
            Console.Write("(" + p2.furiganaLastName + " "
                + p2.furiganaFirstName + ")、");
            Console.WriteLine(p2.birthday.Year
                + "/" + p2.birthday.Month
                + "/" + p2.birthday.Day + "生 " + p2.getAge() + "才");
            Console.WriteLine(p2.Height + "cm " + p2.Weight + "kg");

            var s1 = new Student();
            s1.lastName = "伊藤";
            s1.firstName = "四朗";
            s1.id = "aaa";
            s1.grade = 1;
            s1.scores = new Dictionary<string, int>();
            s1.scores["国語"] = 100;
            s1.scores["英語"] = 50;

            Console.Write(s1.lastName + " " + s1.firstName);
            Console.WriteLine("合計点:" + s1.getTotalScore());
        }
    }

    class Book
    {
        public string title;
        public string author;
        public DateTime publishedDate;
        private int price;
        public const double taxRatio = 0.08;

        public Book() { }
        public Book(string title, string author, DateTime publishedDate, int price) {
            this.title = title;
            this.author = author;
            this.publishedDate = publishedDate;
            this.price = price;
        }

        public int Price {
            get { return price; }
            set
            {
                if(value >= 0)
                {
                    price = value;
                }
            }
        }

        public int getTax()
        {
            return (int)(price * taxRatio);
        }

        public int getTaxIncludedPrice()
        {
            return price + getTax();
        }
    }

    class Magazine : Book
    {
        public int month;
        public string getMonth()
        {
            return month + "月号";
        }
    }

    class Novel : Book
    {
        public string series;
    }

    class Person
    {
        public string lastName;
        public string firstName;
        public string furiganaLastName;
        public string furiganaFirstName;
        public DateTime birthday;
        private double _height;

        public double Height {
            get { return _height; }
            set {
                if (value >= 0)
                {
                    _height = value;
                }
            }
        }
        public double Weight { get; set; }

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
