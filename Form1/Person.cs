using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public class Person
    {
        string name;
        string address;
        string pid;
        DateTime birth;
        string email;
        string id;
        string phone;
        string gender;

        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public string Pid { get { return pid; } }
        public DateTime Birth { get { return birth; } }
        public string Email { get { return email; } }
        public string Id { get { return id; } }
        public string Phone { get { return phone; } }
        public string Gender { get { return gender; } }

        public Person() { }
        public Person(string name, string address, string pid, DateTime birth)
        {
            this.name = name;
            this.address = address;
            this.pid = pid;
            this.birth = birth;
        }
        public Person(string name, string address, string pid, DateTime birth, string email, string id, string phone, string gender)
        {
            this.name = name;
            this.address = address;
            this.pid = pid;
            this.birth = birth;
            this.email = email;
            this.id = id;
            this.phone = phone;
            this.gender = gender;
        }

    }
}
