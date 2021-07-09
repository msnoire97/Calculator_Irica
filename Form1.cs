using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Irica
{
    public partial class Calculator_Main : Form
    {
        public Calculator_Main()
        {
            InitializeComponent();
        }

        private void nbr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            box_sol.Text = box_sol.Text + button.Text;

        }

        private void optr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            box_sol.Text = box_sol.Text + button.Text;
        }
    }
}
