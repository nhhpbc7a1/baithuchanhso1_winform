using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class Teacher:Person
    {
        public Teacher() { }
        public Teacher(string name, string address, string pid, DateTime birth) : base(name, address, pid, birth) { }

        public Teacher(string name, string address, string pid, DateTime birth, string email, string id, string phone, string gender) : base(name, address, id, birth, email, id, phone, gender)
        {
        }
    }
}
