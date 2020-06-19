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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtGradeA.Text = Properties.Settings.Default.GradeA;
            txtGradeB.Text = Properties.Settings.Default.GradeB;
            txtGradeC.Text = Properties.Settings.Default.GradeC;
            txtGradeD.Text = Properties.Settings.Default.GradeD;
        }
        public static double SetValueForTxtGradeA = 0;
        public static double SetValueForTxtGradeB = 0;
        public static double SetValueForTxtGradeC = 0;
        public static double SetValueForTxtGradeD = 0;


        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SetValueForTxtGradeA = Convert.ToDouble(txtGradeA.Text);
            SetValueForTxtGradeB = Convert.ToDouble(txtGradeB.Text);
            SetValueForTxtGradeC = Convert.ToDouble(txtGradeC.Text);
            SetValueForTxtGradeD = Convert.ToDouble(txtGradeD.Text);


            if (SetValueForTxtGradeA > 100 || SetValueForTxtGradeA < 0 ||
                SetValueForTxtGradeA < SetValueForTxtGradeB)
            {
                string gradeA = "A";
                Error_Message(gradeA);
                txtGradeA.Clear();
            }
            else if (SetValueForTxtGradeB > 100 || SetValueForTxtGradeB < 0 ||
            SetValueForTxtGradeB < SetValueForTxtGradeC)
            {
                string gradeB = "B";
                Error_Message(gradeB);
                txtGradeB.Clear();
            }
            else if (SetValueForTxtGradeC > 100 || SetValueForTxtGradeC < 0 ||
              SetValueForTxtGradeC < SetValueForTxtGradeD)
            {
                string gradeC = "C";
                Error_Message(gradeC);
                txtGradeC.Clear();
            }
            else if (SetValueForTxtGradeD > 100 || SetValueForTxtGradeD < 0)
            {
                string gradeD = "D";
                Error_Message(gradeD);
                txtGradeD.Clear();
            }
            else if (SetValueForTxtGradeA == 0 || SetValueForTxtGradeB == 0 || SetValueForTxtGradeC == 0 || SetValueForTxtGradeA == 0)
            {
                string message = "The box cannot be zero.";
                string caption = "Error Detected in Input.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();

                }
            }
            else
            {
                Properties.Settings.Default.GradeA = txtGradeA.Text;
                Properties.Settings.Default.GradeB = txtGradeB.Text;
                Properties.Settings.Default.GradeC = txtGradeC.Text;
                Properties.Settings.Default.GradeD = txtGradeD.Text;
                Properties.Settings.Default.Save();

                this.Hide();
                Result f2 = new Result(this);
                f2.ShowDialog();
            }

            void Error_Message(string grade)
            {
                string message = "Grade " + grade + ": Input number is not appropriate. Try again.";
                string caption = "Error Detected in Input.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                    txtGradeA.Text = Properties.Settings.Default.GradeA;
                    txtGradeB.Text = Properties.Settings.Default.GradeB;
                    txtGradeC.Text = Properties.Settings.Default.GradeC;
                    txtGradeD.Text = Properties.Settings.Default.GradeD;

                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a MsgBox asking the user to Exit or not. Yes=> Close / No => Cancel closing
            if (MessageBox.Show("Are you sure you want to really exit ? ", "Exit",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //closing the form.
                System.Windows.Forms.Application.ExitThread();

            }
            else
                e.Cancel = true;

        }
            
    }

}



