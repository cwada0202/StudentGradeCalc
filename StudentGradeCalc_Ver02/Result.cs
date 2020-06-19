using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeCalc_Ver02
{
    public partial class Result : Form
    {
        Form1 form1;
        public Result(Form1 form_1)
        {
            InitializeComponent();
            form1 = form_1;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            double studentGrade = Convert.ToDouble(txtSudentGrade.Text);
            if (studentGrade > 100 || studentGrade < 0)
            {
                string message = "Please enter numbers from 0 to 100. Try again.";
                string caption = "Error Detected in Input.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            else if (studentGrade >= Form1.SetValueForTxtGradeA && studentGrade <= 100)
            {
                txtResult.Text = "A";
            }
            else if (studentGrade >= Form1.SetValueForTxtGradeB && studentGrade < Form1.SetValueForTxtGradeA)
            {
                txtResult.Text = "B";
            }
            else if (studentGrade >= Form1.SetValueForTxtGradeC && studentGrade < Form1.SetValueForTxtGradeB)
            {
                txtResult.Text = "C";
            }
            else if (studentGrade >= Form1.SetValueForTxtGradeD && studentGrade < Form1.SetValueForTxtGradeC)
            {
                txtResult.Text = "D";
            }
            else
            {
                txtResult.Text = "F";
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            btn_back.Enabled = false;
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();

        }
        private void Results_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_back.Enabled == false)
            {
                return;
            }
            else
            {
                // Display a MsgBox asking the user to Exit or not. Yes=> Close / No => Cancel closing
                if (MessageBox.Show("Are you sure you want to really exit ? ", "Exit",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // closing the form.
                    System.Windows.Forms.Application.ExitThread();
                }
                else
                    e.Cancel = true;
            }

        }
    }
}
