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
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_EnterGame_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(TB_GridSize.Text) || Convert.ToInt32(TB_GridSize.Text) < 5)
            {
                MessageBox.Show("Please Input Integer 5 or above");
                return;
            }
            else
            {
                Form2 form2 = new Form2(Convert.ToInt32(TB_GridSize.Text));
                form2.Show();
                
            }
        }
    }
}
