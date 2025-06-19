using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS.Views
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void Course_label_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("BSc Computer Science");
            comboBox1.Items.Add("BSc Mathematics");
            comboBox1.Items.Add("BA English");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
