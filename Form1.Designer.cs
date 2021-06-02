
namespace Calculator_Irica
{
    partial class Calculator_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nbr_1 = new System.Windows.Forms.Button();
            this.Nbr_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nbr_1
            // 
            this.Nbr_1.BackColor = System.Drawing.Color.FloralWhite;
            this.Nbr_1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nbr_1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Nbr_1.Location = new System.Drawing.Point(12, 206);
            this.Nbr_1.Name = "Nbr_1";
            this.Nbr_1.Size = new System.Drawing.Size(80, 80);
            this.Nbr_1.TabIndex = 0;
            this.Nbr_1.Text = "1";
            this.Nbr_1.UseVisualStyleBackColor = false;
            // 
            // Nbr_2
            // 
            this.Nbr_2.BackColor = System.Drawing.Color.FloralWhite;
            this.Nbr_2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nbr_2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Nbr_2.Location = new System.Drawing.Point(98, 206);
            this.Nbr_2.Name = "Nbr_2";
            this.Nbr_2.Size = new System.Drawing.Size(80, 80);
            this.Nbr_2.TabIndex = 1;
            this.Nbr_2.Text = "2";
            this.Nbr_2.UseVisualStyleBackColor = false;
            this.Nbr_2.Visible = false;
            this.Nbr_2.Click += new System.EventHandler(this.Nbr_2_Click);
            // 
            // Calculator_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(447, 539);
            this.Controls.Add(this.Nbr_2);
            this.Controls.Add(this.Nbr_1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Nbr_1;
        private System.Windows.Forms.Button Nbr_2;
    }
}

