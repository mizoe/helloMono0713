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
            book1.price = 1000;

            int taxIncludedPrice = book1.getTaxIncludedPrice();
            int tax = book1.getTax();

            Console.WriteLine(tax + " " + taxIncludedPrice);
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);

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

            Console.Write(p2.lastName + " " + p2.firstName);
            Console.Write("(" + p2.furiganaLastName + " "
                + p2.furiganaFirstName + ")、");
            Console.WriteLine(p2.birthday.Year
                + "/" + p2.birthday.Month
                + "/" + p2.birthday.Day + "生 " + p2.getAge() + "才");

        }
    }

    class Book
    {
        public string title;
        public string author;
        public DateTime publishedDate;
        public int price;

        public const double taxRatio = 0.08;

        public int getTax()
        {
            return (int)(price * taxRatio);
        }

        public int getTaxIncludedPrice()
        {
            return price + getTax();
        }
    }

    class Person
    {
        public string lastName;
        public string firstName;
        public string furiganaLastName;
        public string furiganaFirstName;
        public DateTime birthday;

        public int getAge()
        {
            int age = 0;
            DateTime now = DateTime.Now;
            TimeSpan ts = now - birthday;
            age = (int)((double)ts.Days / 365.2425);
            return age;
        } 
    }
}
