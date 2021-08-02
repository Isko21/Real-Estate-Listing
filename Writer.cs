using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BigBanTheory_Project5
{
    class Writer
    {
        public void WriteItDown()
        {
            FileStream fileStream = new FileStream("Property.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine("____________________________________");
            streamWriter.WriteLine($"ID: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].ID}");
            streamWriter.WriteLine($"Size: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Size}");
            streamWriter.WriteLine($"Floor: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Floor}");
            streamWriter.WriteLine($"Age: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Age}");
            streamWriter.WriteLine($"Address: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Address}");
            streamWriter.WriteLine($"Rooms: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Rooms}");
            streamWriter.WriteLine($"Bathrooms: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].BathRooms}");
            streamWriter.WriteLine($"ContractType: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Contract}");
            streamWriter.WriteLine($"Options: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Options}");
            streamWriter.WriteLine($"Price: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Price}");
            streamWriter.WriteLine($"Image: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Path}");

            streamWriter.WriteLine($"OwnerName: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Name}");
            streamWriter.WriteLine($"OwnerLastName: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].LastName}");
            streamWriter.WriteLine($"OwnerDateOfBirth: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].DateOfBirth}");
            streamWriter.WriteLine($"OwnerPhoneNumber: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Number}");
            streamWriter.WriteLine($"OwnerEmail: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].Email}");
            streamWriter.WriteLine($"OwnerAddress: {AllProperties.allPropertiesBeforeTxtFile[Form2.a].OwnerAddress}");

            streamWriter.Close();
            fileStream.Close();
            MessageBox.Show("Property added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
