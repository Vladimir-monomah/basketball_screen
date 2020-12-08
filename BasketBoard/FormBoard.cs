using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketBoard
{
    public partial class FormBoard : Form
    {
        public FormBoard()
        {
            InitializeComponent();
            tableLayoutPanel_Resize(null,null);
        }

        public void set_a_points(int points)
        {
            label_a_points.Text = points.ToString();
        }

        public void set_b_points(int points)
        {
            label_b_points.Text = points.ToString();
        }

        public void set_a_name(string name)
        {
            label_a_name.Text = name;
        }

        public void set_b_name(string name)
        {
            label_b_name.Text = name;
        }

        private void FormBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            e.Cancel = true;
        }

        private void tableLayoutPanel_Resize(object sender, EventArgs e)
        {
            label_a_name.Font = new Font(label_a_name.Font.FontFamily, label_a_name.Height/2, label_a_name.Font.Style);
            label_b_name.Font = new Font(label_b_name.Font.FontFamily, label_b_name.Height / 2, label_b_name.Font.Style);
            label_a_points.Font = new Font(label_a_points.Font.FontFamily, label_a_points.Height * 4 / 10, label_a_points.Font.Style);
            label_b_points.Font = new Font(label_b_points.Font.FontFamily, label_b_points.Height * 4 / 10, label_b_points.Font.Style);
        }
    }
}
