using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigBanTheory_Project5
{
    public partial class Form2 : Form
    {
        public static int a=0;
        public Form2()
        {
            InitializeComponent();
        }
        string b;
        List<string> listID = new List<string>();
        private void Form2_Load(object sender, EventArgs e)
        {
            
            while (!listID.Contains(b))
            {
                Random random = new Random();
                char a = (char)random.Next('A', 'Z');
                b = $"{a}-";
                for (int i = 0; i < 3; i++)
                {
                    int c = random.Next(0, 10);
                    b += c.ToString();
                }
                idTXT.Text = b;
                listID.Add(b);
            }
            
        }
        OpenFileDialog openFile = new OpenFileDialog();
        string imagePath3;
        private void addBtn_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                images.Image = new Bitmap(openFile.FileName);
                path.Text = openFile.FileName.ToString();
            }
            string imagePath = openFile.FileName.ToString();
            string imagePath1 = imagePath.ToString();
            string imagePath2 = imagePath1.Substring(imagePath1.LastIndexOf("\\"));
            imagePath3 = imagePath2.Remove(0, 1);
        }
        string info = "";
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(sizeBox.Text);
                int floor = Convert.ToInt32(floorBox.Text);
                int age = Convert.ToInt32(ageBox.Text);
                string address = addressBox.Text;
                int rooms = Convert.ToInt32(roomBox.Text);
                int bathrooms = Convert.ToInt32(bathRoomBox.Text);
                string contract = contractBox.SelectedItem.ToString();
                string price = priceBox.Text +" "+ currencyBox.SelectedItem.ToString();
                string ownName = nameBox.Text;
                string owmLast = lastNameBox.Text;
                string ownDate = ownerDateBirth.Value.ToString("dd-MMMM-yyyy");
                string ownNum = numBox.Text;
                string ownEmail = emailBox.Text;
                string ownAddress = ownerAddressBox.Text;

                string newPath = b + "-" + imagePath3;

                File.Copy(path.Text, $@"Images\{b + "-" + imagePath3}");

                Property property = new Property(b, size, floor, age, address, rooms, bathrooms,  contract, info.Remove(info.Length - 2, 1), price, newPath);
                property.Name = ownName; property.LastName = owmLast; property.DateOfBirth = ownDate; 
                property.Number = ownNum; property.Email = ownEmail; property.OwnerAddress = ownAddress;

                AllProperties.allPropertiesBeforeTxtFile.Add(property);
                Writer writer = new Writer();
                writer.WriteItDown();
                a++;
                Default();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void checkedChangeForAllCheckBoxes(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                info += checkBox.Text + ", ";
            }
        }
        public void Default()
        {
            sizeBox.Text = ""; floorBox.Text = ""; roomBox.Text = ""; bathRoomBox.Text = ""; ageBox.Text = "";
            addressBox.Text = ""; ownerAddressBox.Text = ""; nameBox.Text = ""; lastNameBox.Text = ""; numBox.Text = "";
            emailBox.Text = ""; images.Image = Properties.Resources.no_image; priceBox.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}