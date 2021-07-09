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
        String operation = "";
        Decimal resultVal = 0;
        bool OptrPerf = false;

        public Calculator_Main()
        {
            InitializeComponent();
        }

        private void nbr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((box_sol.Text == "0") || OptrPerf)
                box_sol.Clear();
            OptrPerf = false;
            box_sol.Text += button.Text;
         }

        private void deci_click(object sender, EventArgs e)
        {
            if (!box_sol.Text.Contains("."))
            {
                box_sol.Text += ".";
            }

        }

        private void optr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultVal != 0)
            {
                optr_ans.PerformClick();
                operation = button.Text;
                OptrPerf = true;
            }
            else
            {
                operation = button.Text;
                resultVal = Decimal.Parse(box_sol.Text);
                box_ans.Text = resultVal + " " + operation;
                OptrPerf = true;
            }
        }



    }
}
