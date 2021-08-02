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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {   

        }
        List<Result> allResults = new List<Result>();
        int currentPage = 1;
        int maxPage;
        int x=0;
        List<string> vs = File.ReadAllLines(@"Property.txt").ToList();
        private void search_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            previous.Enabled = true;
            next.Enabled = true;
            navigation.Enabled = true;
            allResults.Clear();
            if (radioButton1.Checked)
            {
                int min = Convert.ToInt32(textBox1.Text);
                int max = Convert.ToInt32(textBox2.Text);
                for(int i = 10; i < vs.Count; i-=-18)
                {
                    try
                    {
                        int cena = Convert.ToInt32(Reader.LastRemover(Reader.FirstRemover(vs[i])));
                        if (cena > min && cena < max)
                        {
                            Result result = new Result(vs[i - 10], Convert.ToInt32(vs[i - 9]), Convert.ToInt32(vs[i - 8]), Convert.ToInt32(vs[i - 7]), Convert.ToInt32(vs[i - 6]), Convert.ToInt32(vs[i - 5]),
                                vs[i - 4], vs[i - 3], vs[i - 2], vs[i-1], vs[i], vs[i++], vs[i+2], vs[i +3],
                                vs[i + 5], vs[i + 6], vs[i + 7]);
                            allResults.Add(result);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                }
                ReadIt();
            }
            if (radioButton2.Checked)
            {
                int min = Convert.ToInt32(textBox3.Text);
                int max = Convert.ToInt32(textBox4.Text);
                for (int i = 6; i < vs.Count / 18; i++)
                {
                    try
                    {
                        int rooms = Convert.ToInt32(Reader.FirstRemover(vs[i]));
                        if (rooms > min && rooms < max)
                        {
                            Result result = new Result(vs[i - 10], Convert.ToInt32(vs[i - 9]), Convert.ToInt32(vs[i - 8]), Convert.ToInt32(vs[i - 7]), Convert.ToInt32(vs[i - 6]), Convert.ToInt32(vs[i - 5]),
                                vs[i - 4], vs[i - 3], vs[i - 2], vs[i - 1], vs[i], vs[i++], vs[i + 2], vs[i + 3],
                                vs[i + 5], vs[i + 6], vs[i + 7]);
                            allResults.Add(result);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }
                }
                ReadIt();
            }
            if (radioButton3.Checked)
            {
                string find = contractBox.SelectedItem.ToString();
                int i = vs.IndexOf(find);
                ReadIt();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            maxPage = allResults.Count/18;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                previous.Enabled = true;
            }
            else
            {
                x -= 18;
                currentPage -= 1;
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (currentPage == maxPage)
            {
                next.Enabled = true;
            }
            else
            {
                x += 18;
                currentPage += 1;
            }
        }
        public void ReadIt()
        {
            label20.Text = allResults[x].Id;
            size.Text = allResults[x].Size.ToString();
            floor.Text = allResults[x].Floor.ToString();
            age.Text = allResults[x].Floor.ToString();
            address.Text = allResults[x].Address;
            rooms.Text = allResults[x].Rooms.ToString();
            baths.Text = allResults[x].BathRooms.ToString();
            pictureBox1.ImageLocation = (@"Images\" + Reader.FirstRemover(allResults[x].Path));
            contract.Text = allResults[x].Contract;
            price.Text = allResults[x].Price;
            name.Text = allResults[x].Name;
            lastName.Text = allResults[x].LastName;
            number.Text = allResults[x].Number;
            email.Text = allResults[x].Email;
            dateBirth.Text = allResults[x].DateOfBirth;
            ownerAddres.Text = allResults[x].OwnerAddress;
        }
    }
}
