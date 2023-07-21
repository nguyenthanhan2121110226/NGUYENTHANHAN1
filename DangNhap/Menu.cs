using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai01 b01 = new bai01();
            b01.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Article02 a2 = new Article02();
            a2.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Article01 a1 = new Article01();
            a1.ShowDialog();

        }
      
       
       
        private void button4_Click_1(object sender, EventArgs e)
        {
            Article03 a3 = new Article03();
            a3.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Article04 a2 = new Article04();
            a2.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Article06 a2 = new Article06();
            a2.ShowDialog();
        }
    }
}
