using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userClass
{
    internal class User
    {
        private string name;
        private string companyName;
        public User()
        {
            companyName = "ABC";
        }
        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

        public string CompanyName
        {
            get{ return companyName; }
        }
    }
}