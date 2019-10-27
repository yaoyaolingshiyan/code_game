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
        string imgpath;
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

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int a = rd.Next(0, pathlist.Count());
            this.pictureBox1.Image = Image.FromFile(pathlist[a]);
            int index = pathlist[a].LastIndexOf('\\');
            name = pathlist[a].Substring(index+1).Split('.')[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择存储点名人群照片的路径， 照片命名为用户名。";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgpath = dialog.SelectedPath;
                this.textBox2.Text = imgpath;
                string[] files;
                files = Directory.GetFiles(imgpath);
                pathlist = files.ToList();
            }
        }
    }
}
