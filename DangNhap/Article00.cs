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
    public partial class Article00 : Form
    {
        public Article00()
        {
            InitializeComponent();
            this.Load += Article00_Load;
            this.ResizeEnd += Article00_ResizeEnd;
        }
        private void Article00_ResizeEnd(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();
        }

        private void Article00_Load(object sender, System.EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + " - " + height.ToString();

        }


    }
}