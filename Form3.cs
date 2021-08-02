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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        List<string> allPropertiesFromTxtFile = File.ReadAllLines(@"Property.txt").ToList();
        int i = 1;
        int currentPage = 1;
        int maxPage;
        private void Form3_Load(object sender, EventArgs e)
        {
            maxPage = allPropertiesFromTxtFile.Count / 18;
            if(allPropertiesFromTxtFile.Count == 0)
            {
                MessageBox.Show("Nothing to show!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                ReadIT();
            }
        }
        
        private void previous_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                previous.Enabled = true;
            }
            else
            {
                i -= 18;
                currentPage -= 1;
                ReadIT();
            }
        }
        public void ReadIT()
        {
            idTXT.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i]);
            size.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 1]);
            floor.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 2]);
            age.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 3]);
            address.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 4]);
            rooms.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 5]);
            baths.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 6]);
            contract.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 7]);
            option.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 8]);
            price.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 9]);
            images.ImageLocation = (@"Images\" + Reader.FirstRemover(allPropertiesFromTxtFile[i + 10]));
            name.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 11]);
            lastName.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 12]);
            dateBirth.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 13]);
            number.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 14]);
            email.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 15]);
            ownerAddress.Text = Reader.FirstRemover(allPropertiesFromTxtFile[i + 16]);
            navigation.Text = $"{currentPage}/{maxPage}";
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (currentPage == maxPage)
            {
                next.Enabled = true;
            }
            else
            {
                i += 18;
                currentPage += 1;
                ReadIT();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
