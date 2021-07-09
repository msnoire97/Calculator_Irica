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
        String OperationUsed = "";
        Double ResultValue = 0;
        bool OperationPerformed = false;
        bool OperationCompleted = false;

        public Calculator_Main()
        {
            InitializeComponent();
        }

        private void nbr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((box_display.Text == "0") || (OperationPerformed))
            {
                box_display.Clear();
            }
            if (OperationCompleted)
            {
                box_display.Clear();
                ResultValue = 0;
            }
                
            OperationPerformed = false;
            OperationCompleted = false;
            box_display.Text += button.Text;
         }

        private void deci_click(object sender, EventArgs e)
        {
            if (!box_display.Text.Contains("."))
            {
                box_display.Text += ".";
            }

        }

        private void optr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (ResultValue != 0)
            {
                optr_ans.PerformClick();
                OperationUsed = button.Text;
                box_display.Text = "0";
                label_CurrentStatus.Text = ResultValue + " " + OperationUsed;
                OperationPerformed = true;
            }
            else
            {
                OperationUsed = button.Text;
                ResultValue = Double.Parse(box_display.Text);
                box_display.Text = "0";
                label_CurrentStatus.Text = ResultValue + " " + OperationUsed;
                OperationPerformed = true;
            }
        }

        private void ftn_clear(object sender, EventArgs e)
        {
            box_display.Text = "0";
        }

        private void ftn_clrall(object sender, EventArgs e)
        {
            box_display.Text = "0";
            ResultValue = 0;
            label_CurrentStatus.Text = "";
        }

        private void ftn_equals(object sender, EventArgs e)
        {
            if (OperationCompleted == true)
            {
                ResultValue = Double.Parse(box_display.Text);
                label_CurrentStatus.Text = (ResultValue).ToString();
                OperationCompleted = false;
                return;
            }   

            switch (OperationUsed)
            {
                case "+":
                    box_display.Text = (ResultValue + Double.Parse(box_display.Text)).ToString();
                    break;

                case "-":
                    box_display.Text = (ResultValue - Double.Parse(box_display.Text)).ToString();
                    break;

                case "*":
                    box_display.Text = (ResultValue * Double.Parse(box_display.Text)).ToString();
                    break;

                case "/":
                    box_display.Text = (ResultValue / Double.Parse(box_display.Text)).ToString();
                    break;
                    
                default:
                    break;
            }
            ResultValue = Double.Parse(box_display.Text);
            label_CurrentStatus.Text = (ResultValue).ToString();
            OperationCompleted = true;
        }
    }
}
