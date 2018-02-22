using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    class DomainReaders
    {
        int ID;
        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }

        string FirstName;
        public string FirstName1
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        string Surname;
        public string Surname1
        {
            get { return Surname; }
            set { Surname = value; }
        }

        string EMail;
        public string EMail1
        {
            get { return EMail; }
            set { EMail = value; }
        }

        string PhoneNumber;
        public string PhoneNumber1
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        string Book;
        public string Book1
        {
            get { return Book; } 
            set {Book = value;}
        }
        
    }
}
