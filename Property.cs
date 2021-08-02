using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBanTheory_Project5
{
    class Property: Owner
    {
        int size, floor, age, rooms, bathrooms;
        string id, address, contract, price, options, path;

        public Property(string id,int size, int floor, int age, string address, int rooms, int bathrooms,  string contract, string option, string price, string path)
        {
            Size = size; Floor = floor; Age = age; Rooms = rooms; BathRooms = bathrooms; Address = address; Contract = contract; Price = price; Options = option; ID = id; Path = path;
        }

        public string ID { get { return id; } set { id = value; } }
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
    }
}
