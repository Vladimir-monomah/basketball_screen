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
    public partial class FormConrol : Form
    {
        FormBoard board;

        int a_points = 0;
        int b_points = 0;


        public FormConrol()
        {
            InitializeComponent();
            board = new FormBoard();
            button_reset_Click(null,null);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            a_points = 0;
            b_points = 0;
            board.set_a_points(a_points);
            board.set_b_points(b_points);
            label_a.Text = a_points.ToString();
            label_b.Text = b_points.ToString();
        }

        private void button_a_plus1_Click(object sender, EventArgs e)
        {
            a_points = a_points + Convert.ToInt16(((Button)sender).Tag);
            label_a.Text = a_points.ToString();
            board.set_a_points(a_points);
        }

        private void button_b_plus1_Click(object sender, EventArgs e)
        {
            b_points = b_points + Convert.ToInt16(((Button)sender).Tag);
            label_b.Text = b_points.ToString();
            board.set_b_points(b_points);
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            board.Visible = true;
        }

        private void text_a_TextChanged(object sender, EventArgs e)
        {
            board.set_a_name(text_a.Text);
        }

        private void text_b_TextChanged(object sender, EventArgs e)
        {
            board.set_b_name(text_b.Text);
        }
    }
}
