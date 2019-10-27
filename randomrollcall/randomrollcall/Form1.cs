using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace randomrollcall
{

    public partial class Form1 : Form
    {
        List<string> pathlist = new List<string>();
        string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string strr = "天选之子：" + name;
            this.textBox1.Text = strr;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string img1 = "D:/workspace/randomrollcall/face/john.png";
            string img2 = "D:/workspace/randomrollcall/face/zmy.png";
            string[] files;
            files = Directory.GetFiles("D:/workspace/randomrollcall/face");
            pathlist = files.ToList();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int a = rd.Next(0, pathlist.Count());
            this.pictureBox1.Image = Image.FromFile(pathlist[a]);
            name = pathlist[a].Split('\\')[1].Split('.')[0];
        }

    }
}
