
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
            this.Nbr_3 = new System.Windows.Forms.Button();
            this.Nbr_4 = new System.Windows.Forms.Button();
            this.Box_Ans = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Nbr_1
            // 
            this.Nbr_1.BackColor = System.Drawing.Color.FloralWhite;
            this.Nbr_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.Nbr_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            // Nbr_3
            // 
            this.Nbr_3.BackColor = System.Drawing.Color.FloralWhite;
            this.Nbr_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nbr_3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nbr_3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Nbr_3.Location = new System.Drawing.Point(184, 206);
            this.Nbr_3.Name = "Nbr_3";
            this.Nbr_3.Size = new System.Drawing.Size(80, 80);
            this.Nbr_3.TabIndex = 2;
            this.Nbr_3.Text = "3";
            this.Nbr_3.UseVisualStyleBackColor = false;
            // 
            // Nbr_4
            // 
            this.Nbr_4.BackColor = System.Drawing.Color.FloralWhite;
            this.Nbr_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Nbr_4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nbr_4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Nbr_4.Location = new System.Drawing.Point(270, 206);
            this.Nbr_4.Name = "Nbr_4";
            this.Nbr_4.Size = new System.Drawing.Size(80, 80);
            this.Nbr_4.TabIndex = 3;
            this.Nbr_4.Text = "4";
            this.Nbr_4.UseVisualStyleBackColor = false;
            // 
            // Box_Ans
            // 
            this.Box_Ans.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box_Ans.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Box_Ans.Location = new System.Drawing.Point(12, 12);
            this.Box_Ans.Name = "Box_Ans";
            this.Box_Ans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Box_Ans.Size = new System.Drawing.Size(423, 146);
            this.Box_Ans.TabIndex = 4;
            this.Box_Ans.Text = "";
            this.Box_Ans.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Calculator_Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(447, 539);
            this.Controls.Add(this.Box_Ans);
            this.Controls.Add(this.Nbr_4);
            this.Controls.Add(this.Nbr_3);
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
        private System.Windows.Forms.Button Nbr_3;
        private System.Windows.Forms.Button Nbr_4;
        private System.Windows.Forms.RichTextBox Box_Ans;
    }
}

