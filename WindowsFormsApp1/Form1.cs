using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        object a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x aaa = new x();
            aaa.con = textBox1;

            aaa.d = func1;
            aaa.d();
        }

        public void func1()
        {
            MessageBox.Show("func1");
        }
    }
    public delegate void dele();
    class x
    {
        public Control con;
        public dele d;
    }
}
