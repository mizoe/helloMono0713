using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string title;
        public string author;
        public DateTime publishedDate;
        private int price;
        public const double taxRatio = 0.08;

        public Book() { }
        public Book(string title, string author, DateTime publishedDate, int price)
        {
            this.title = title;
            this.author = author;
            this.publishedDate = publishedDate;
            this.price = price;
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
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


}
