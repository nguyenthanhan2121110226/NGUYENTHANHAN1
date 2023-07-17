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
using System.Xml.Serialization;

namespace Article01
{
    public partial class Form1 : Form
    {
        string path = @"D:\form.xml";
        public Form1()
        {
            InitializeComponent();
        }
        public void Write(InforWindowns iw)
        {
            XmlSerializer write = new XmlSerializer(typeof(InforWindowns));
            StreamWriter file = new StreamWriter(path);
            write.Serialize(file, iw);
            file.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InforWindowns iw = new InforWindowns();
            iw.With = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            InforWindowns iw = new InforWindowns();
            iw.With = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }
    }
}
