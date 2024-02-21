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
using System;
using System.IO;
using System.Windows.Forms;

namespace _17._3_StudentGrades
{
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\khbil\\source\\repos\\17.3_StudentGrades\\bin\\Debug\\grades.txt";
            if (new FileInfo(filePath).Exists)
            {
                StreamReader stream = new StreamReader(filePath);
                txtGrades.AppendText(stream.ReadToEnd());
            }
            else
                MessageBox.Show("There was a problem loading the file.");
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
