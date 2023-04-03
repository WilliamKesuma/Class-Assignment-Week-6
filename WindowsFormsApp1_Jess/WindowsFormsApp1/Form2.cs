using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public int jumlahRed = 0;
        public int jumlahBlue = 0;
        Button[,] buttons;
        public Form2()
        {
            InitializeComponent();
            buttons = new Button[Form1.input, Form1.input];

            int location1 = 50;
            int location2 = 50;
            for (int j = 0; j < Form1.input; j++)
            {
                for (int i = 0; i < Form1.input; i++)
                {
                    buttons[j, i] = new Button();
                    buttons[j, i].Size = new Size(50, 50);
                    buttons[j, i].Location = new Point(location1, location2);
                    buttons[j, i].Click += new EventHandler(Button_Click);
                    buttons[j, i].Tag = j.ToString() + "," + i.ToString() + "," + 0.ToString();
                    this.Controls.Add(buttons[j, i]);
                    location1 += 52;
                }
                location1 = 50;
                location2 += 52;
            }


          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Text = "Blue: " + jumlahBlue;
            label1.Location = new Point(500, 54);
            this.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = "Red: " + jumlahRed;
            label2.Location = new Point(400, 54);
            this.Controls.Add(label2);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int cek = 0;
            int cek2 = 0;

            var buttonn = sender as Button;
            string[] splits = buttonn.Tag.ToString().Split(',');

            int x = Convert.ToInt32(splits[0]);
            int y = Convert.ToInt32(splits[1]);
            int status = Convert.ToInt32(splits[2]);

            if (status == 0)
            {
                buttons[x,y].BackColor = Color.Red;
                buttons[x, y].Tag = x + "," + y + "," + 1;
            }
            else if (status == 1)
            {
                buttons[x, y].BackColor = Color.Blue;
                buttons[x, y].Tag = x + "," + y + "," + 2;
            }
            else if (status == 2)
            {
                buttons[x, y].BackColor = Color.Red;
                buttons[x, y].Tag = x + "," + y + "," + 1;
            }

            if (x - 1 >= 0)
            {
                string[] splits2 = buttons[x - 1, y].Tag.ToString().Split(',');
                int status2 = Convert.ToInt32(splits2[2]);
                if (status2 == 1)
                {
                    buttons[x - 1, y].BackColor = Color.Blue;
                    buttons[x - 1, y].Tag = splits2[0] + "," + splits2[1] + "," + 2;
                }
                else if (status2 == 2)
                {
                    buttons[x - 1, y].BackColor = Color.Red;
                    buttons[x - 1, y].Tag = splits2[0] + "," + splits2[1] + "," + 1;
                }
            }

            if (x + 1 < Form1.input)
            {
                string[] splits3 = buttons[x + 1, y].Tag.ToString().Split(',');
                int status3 = Convert.ToInt32(splits3[2]);
                if (status3 == 1)
                {
                    buttons[x + 1, y].BackColor = Color.Blue;
                    buttons[x + 1, y].Tag = splits3[0] + "," + splits3[1] + "," + 2;
                }
                else if (status3 == 2)
                {
                    buttons[x + 1, y].BackColor = Color.Red;
                    buttons[x + 1, y].Tag = splits3[0] + "," + splits3[1] + "," + 1;
                }
            }

            if (y - 1 >= 0)
            {
                string[] splits4 = buttons[x, y - 1].Tag.ToString().Split(',');
                int status4 = Convert.ToInt32(splits4[2]);
                if (status4 == 1)
                {
                    buttons[x, y - 1].BackColor = Color.Blue;
                    buttons[x, y - 1].Tag = splits4[0] + "," + splits4[1] + "," + 2;
                }
                else if (status4 == 2)
                {
                    buttons[x, y - 1].BackColor = Color.Red;
                    buttons[x, y - 1].Tag = splits4[0] + "," + splits4[1] + "," + 1;
                }
            }


            if (y + 1 < Form1.input)
            {
                string[] splits5 = buttons[x, y + 1].Tag.ToString().Split(',');
                int status5 = Convert.ToInt32(splits5[2]);
                if (status5 == 1)
                {
                    buttons[x, y + 1].BackColor = Color.Blue;
                    buttons[x, y + 1].Tag = splits5[0] + "," + splits5[1] + "," + 2;
                }
                else if (status5 == 2)
                {
                    buttons[x, y + 1].BackColor = Color.Red;
                    buttons[x, y + 1].Tag = splits5[0] + "," + splits5[1] + "," + 1;
                }
            }

            for (int j = 0; j < Form1.input; j++)
            {
                for (int i = 0; i < Form1.input; i++)
                {
                    if (buttons[j, i].BackColor == Color.Red)
                    {
                        cek += 1;
                    }
                    if (buttons[j, i].BackColor == Color.Blue)
                    {
                        cek2 += 1;
                    }
                }
            }
            if (cek == Form1.input*Form1.input)
            {
                MessageBox.Show("Menangg");
            }
            if (cek2 == Form1.input * Form1.input)
            {
                MessageBox.Show("Menangg");
            }

            //foreach (Button buttons in this.Controls)
            //{
            //    if (buttons.ForeColor == Color.Red)
            //    {
            //        cek += 1;
            //    }
            //}

            //if (cek == Form1.input*Form1.input)
            //{
            //    MessageBox.Show("Menangggg");
            //}
        }
    }
}
