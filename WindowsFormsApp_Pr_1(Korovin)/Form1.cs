using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Pr_1_Korovin_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {

        }



        private void FileMenuTools_Click(object sender, EventArgs e)
        {

        }

        private void AboutProgrammMenuTools_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitMenuTools_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Razdelenie_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMenuTools_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
