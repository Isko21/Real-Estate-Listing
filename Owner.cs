using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBanTheory_Project5
{
    class Owner
    {
        string name, lastName, dateOfBirth, number, email, ownerAddress;

        public string Name { get { return name; } set { name = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string Number { get { return number; } set { number = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string OwnerAddress { get { return ownerAddress; } set { ownerAddress = value; } }

    }
}
