using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string zaman = DateTime.Now.ToString();
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int eded_rnd = rnd.Next(1,15);

            random_eded_qutusu.Text = (eded_rnd).ToString();


            if (textBox4.Text == "10")
            {
                textBox4.Text = "10";
                
            }
            else
            {
                for (int i = listBox.Items.Count -1; i >= 0; i--)
                {
                    if ((listBox.Items[i].ToString()).Split(' ')[0] == eded_rnd.ToString())
                    {
                        son_isdifadeci.Text = "";
                        listBox1.Items.Add(listBox.Items[i]);
                        son_isdifadeci.Text = listBox.Items[i].ToString();
                        for(int j = 0; j < list.Count; j++)
                        {
                            if (list[j] == eded_rnd)
                            {
                                list.RemoveAt(j);
                            }
                        }
                        listBox.Items.RemoveAt(i);
                        textBox4.Text = (Convert.ToInt32(textBox4.Text) + 1).ToString();
                                                
                    }
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eded_rnd2 = rnd.Next(1, 15);

            random_eded_qutusu1.Text = (eded_rnd2).ToString();
            if (textBox4.Text == "0")
            {
                textBox4.Text = "0";
                MessageBox.Show("Artiq Yer Yoxdur!");
            }
            else
            {
                if (listBox.Items.Count < 10)
                {
                    

                    if (!(list.Contains(eded_rnd2)))
                    {

                        listBox.Items.Add(eded_rnd2 + "         " + DateTime.Now.ToString());
                        list.Add(eded_rnd2);
                        textBox4.Text = (Convert.ToInt32(textBox4.Text) - 1).ToString();
                    }
                }
                
            }

            

            


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
