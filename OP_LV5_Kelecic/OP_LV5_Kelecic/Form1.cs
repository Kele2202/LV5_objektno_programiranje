using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace OP_LV5_Kelecic
{
    public partial class Form1 : Form
    {
        ScriptEngine pyEngine = null;
        ScriptScope pyScope = null;

        double A = 0;
        double B = 0;
        public Form1()
        {
            InitializeComponent();

            pyEngine = Python.CreateEngine();
            pyScope = pyEngine.CreateScope();
        }

        private void loadExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.ShowDialog();

            ScriptSource script = pyEngine.CreateScriptSourceFromFile(OpenFileDialog.FileName);
            script.Execute(pyScope);
            Console.WriteLine(OpenFileDialog1.FileName);
            dynamic DodajFunk = pyScope.GetVariable("DodajFunkciju");
            DodajFunk(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(tbA.Text);
            B = Convert.ToDouble(tbB.Text);
            tbC.Text = Convert.ToString(A + B);
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(tbA.Text);
            B = Convert.ToDouble(tbB.Text);
            tbC.Text = Convert.ToString(A - B);
        }

        private void mulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(tbA.Text);
            B = Convert.ToDouble(tbB.Text);
            tbC.Text = Convert.ToString(A * B);
        }

        private void divToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(tbA.Text);
            B = Convert.ToDouble(tbB.Text);
            tbC.Text = Convert.ToString(A / B);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
