using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int random;
        Button[,] buttons;
        
        public Form2(int transfer)
        {
            InitializeComponent(); 
            random = transfer;
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            buttons = new Button[random, random];
            int Location1 = 50;
            int Location2 = 50;
            for (int i = 0; i < random; i++)
            {
                for (int j = 0; j < random; j++)
                {
                    buttons[i, j] = new Button();
                    
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                    buttons[i, j].Visible = true;
                    buttons[i, j].Size = new Size(50, 50);
                    buttons[i, j].Location = new Point(Location1, Location2);
                    buttons[i, j].BackColor = Color.White;
                    buttons[i, j].Click += Tombol_Click;
                    buttons[i, j].Tag = i.ToString() + "," + j.ToString();
                    this.Controls.Add(buttons[i, j]);
                    Location1 += 52;
                    


                }
                Location1 = 50;
                Location2 += 52;
            }
        }

        private void Tombol_Click(object sender, EventArgs e)
        {
            
            int cek = 0;
            Button button = (Button)sender;

            if(button.BackColor == Color.Red)
            {
                button.BackColor = Color.Blue;
            }
            else
            {
              button.BackColor = Color.Red;
            }

            int kolom = Convert.ToInt32(button.Tag.ToString().Split(',')[0]);
            int baris = Convert.ToInt32(button.Tag.ToString().Split(',')[1]);


            
        }

        private void cekmenang()
        {
           
        }
        
    }
}
