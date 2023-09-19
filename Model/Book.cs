using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public struct Book
    {

        public int id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }

        public Book(int id, string title, string publisher)
        {
            this.id = id;
            this.Title = title;
            this.Publisher = publisher;
        }

    }
}
