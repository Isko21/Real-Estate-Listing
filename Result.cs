using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBanTheory_Project5
{
    public class Result
    {
        int size, floor, age, rooms, bathrooms;
        string id, address, contract, price, options, path, name, lastName, dateOfBirth, number, email, ownerAddress;
        public Result(string ID, int SIZE, int FLOOR, int AGE, int ROOMS, int BATHROOMS, string ADDRESS, string CONTRACT, string PRICE, string OPTION, string PATH, string NAME, string LASTNAME, string DATEBIRTH, string NUMBER, string EMAIL, string OWNERADDRESS)
        {
            Size = SIZE; Id = ID; Floor = FLOOR; Age = AGE; Rooms = ROOMS; BathRooms = BATHROOMS; Address = ADDRESS;
            Contract = CONTRACT; Price = PRICE; Options = OPTION; Path = PATH; Name = NAME; LastName = LASTNAME;
            DateOfBirth = DATEBIRTH; Number = NUMBER; Email = EMAIL; OwnerAddress = OWNERADDRESS;
        }
        public string Id { get { return id; } set { id = value; } }
        public int Size { get { return size; } set { size = value; } }
        public int Floor { get { return floor; } set { floor = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Rooms { get { return rooms; } set { rooms = value; } }
        public int BathRooms { get { return bathrooms; } set { bathrooms = value; } }

        public string Path { get { return path; } set { path = value; } }
        public string Contract { get { return contract; } set { contract = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Price { get { return price; } set { price = value; } }
        public string Options { get { return options; } set { options = value; } }

        public string Name { get { return name; } set { name = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string Number { get { return number; } set { number = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string OwnerAddress { get { return ownerAddress; } set { ownerAddress = value; } }
    }
}
