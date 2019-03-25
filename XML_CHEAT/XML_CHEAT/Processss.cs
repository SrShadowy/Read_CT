using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace XML_CHEAT
{
    public partial class Processss : Form
    {
        public Processss()
        {
            InitializeComponent();
        }
        string xl;
        private void button1_Click(object sender, EventArgs e)
        {
                Process[] runningProcs = Process.GetProcesses(".");
                 StringBuilder builder = new StringBuilder();
                foreach (Process p in runningProcs)
                {
                    string info = string.Format( p.ProcessName);

                    listBox1.Items.Add(info);

                }
                //textBox1.Text = builder.Append("\n" + runningProcs.Length.ToString()).ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            xl = label1.Text;
            form1.Nomes = xl;
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         label1.Text =  listBox1.Items[listBox1.SelectedIndex].ToString();
        }
    }
}
