namespace StudentGradeCalc_Ver02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtGradeA = new System.Windows.Forms.TextBox();
            this.txtGradeB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGradeC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGradeD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter minimum grade to recieve A:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGradeA
            // 
            this.txtGradeA.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeA.Location = new System.Drawing.Point(312, 50);
            this.txtGradeA.Name = "txtGradeA";
            this.txtGradeA.Size = new System.Drawing.Size(101, 31);
            this.txtGradeA.TabIndex = 1;
            this.txtGradeA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGradeB
            // 
            this.txtGradeB.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeB.Location = new System.Drawing.Point(312, 144);
            this.txtGradeB.Name = "txtGradeB";
            this.txtGradeB.Size = new System.Drawing.Size(101, 31);
            this.txtGradeB.TabIndex = 3;
            this.txtGradeB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter minimum grade to recieve B:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGradeC
            // 
            this.txtGradeC.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeC.Location = new System.Drawing.Point(312, 246);
            this.txtGradeC.Name = "txtGradeC";
            this.txtGradeC.Size = new System.Drawing.Size(101, 31);
            this.txtGradeC.TabIndex = 5;
            this.txtGradeC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter minimum grade to recieve C:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGradeD
            // 
            this.txtGradeD.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeD.Location = new System.Drawing.Point(312, 351);
            this.txtGradeD.Name = "txtGradeD";
            this.txtGradeD.Size = new System.Drawing.Size(101, 31);
            this.txtGradeD.TabIndex = 7;
            this.txtGradeD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter minimum grade to recieve D:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Submit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(27, 399);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(403, 39);
            this.btn_Submit.TabIndex = 8;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtGradeD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGradeC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGradeB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGradeA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Grade Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGradeA;
        private System.Windows.Forms.TextBox txtGradeB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGradeC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGradeD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Submit;
    }
}

