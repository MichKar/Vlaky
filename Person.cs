using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviko {
    internal class Person {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public override string ToString() {
            return ($"jméno: {firstName} {lastName}");
        }
    }
}
