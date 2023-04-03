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
        public static int input = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_PindahForm_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox_N.Text) || Convert.ToInt32(textBox_N.Text) < 5)
            {
                MessageBox.Show("input dulu di atas 5");
            }
            else
            {
                input = Convert.ToInt32(textBox_N.Text);
                Form2 form = new Form2();
                form.Show();
            }
        }
    }
}
