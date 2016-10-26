namespace WindowsFormsApplication9
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
            this.lblGrade1 = new System.Windows.Forms.Label();
            this.lblGrade2 = new System.Windows.Forms.Label();
            this.lblGrade3 = new System.Windows.Forms.Label();
            this.lblGrade4 = new System.Windows.Forms.Label();
            this.lblGrade5 = new System.Windows.Forms.Label();
            this.txbGrade1 = new System.Windows.Forms.TextBox();
            this.txbGrade2 = new System.Windows.Forms.TextBox();
            this.txbGrade3 = new System.Windows.Forms.TextBox();
            this.txbGrade4 = new System.Windows.Forms.TextBox();
            this.txbGrade5 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGrade1
            // 
            this.lblGrade1.AutoSize = true;
            this.lblGrade1.Location = new System.Drawing.Point(13, 15);
            this.lblGrade1.Name = "lblGrade1";
            this.lblGrade1.Size = new System.Drawing.Size(45, 13);
            this.lblGrade1.TabIndex = 0;
            this.lblGrade1.Text = "Grade 1";
            // 
            // lblGrade2
            // 
            this.lblGrade2.AutoSize = true;
            this.lblGrade2.Location = new System.Drawing.Point(13, 45);
            this.lblGrade2.Name = "lblGrade2";
            this.lblGrade2.Size = new System.Drawing.Size(45, 13);
            this.lblGrade2.TabIndex = 1;
            this.lblGrade2.Text = "Grade 2";
            // 
            // lblGrade3
            // 
            this.lblGrade3.AutoSize = true;
            this.lblGrade3.Location = new System.Drawing.Point(13, 75);
            this.lblGrade3.Name = "lblGrade3";
            this.lblGrade3.Size = new System.Drawing.Size(45, 13);
            this.lblGrade3.TabIndex = 2;
            this.lblGrade3.Text = "Grade 3";
            // 
            // lblGrade4
            // 
            this.lblGrade4.AutoSize = true;
            this.lblGrade4.Location = new System.Drawing.Point(13, 105);
            this.lblGrade4.Name = "lblGrade4";
            this.lblGrade4.Size = new System.Drawing.Size(45, 13);
            this.lblGrade4.TabIndex = 3;
            this.lblGrade4.Text = "Grade 4";
            // 
            // lblGrade5
            // 
            this.lblGrade5.AutoSize = true;
            this.lblGrade5.Location = new System.Drawing.Point(12, 135);
            this.lblGrade5.Name = "lblGrade5";
            this.lblGrade5.Size = new System.Drawing.Size(45, 13);
            this.lblGrade5.TabIndex = 4;
            this.lblGrade5.Text = "Grade 5";
            // 
            // txbGrade1
            // 
            this.txbGrade1.Location = new System.Drawing.Point(89, 15);
            this.txbGrade1.Name = "txbGrade1";
            this.txbGrade1.Size = new System.Drawing.Size(100, 20);
            this.txbGrade1.TabIndex = 5;
            this.txbGrade1.TextChanged += new System.EventHandler(this.txbGrade1_TextChanged);
            // 
            // txbGrade2
            // 
            this.txbGrade2.Location = new System.Drawing.Point(89, 45);
            this.txbGrade2.Name = "txbGrade2";
            this.txbGrade2.Size = new System.Drawing.Size(100, 20);
            this.txbGrade2.TabIndex = 6;
            this.txbGrade2.TextChanged += new System.EventHandler(this.txbGrade2_TextChanged);
            // 
            // txbGrade3
            // 
            this.txbGrade3.Location = new System.Drawing.Point(89, 75);
            this.txbGrade3.Name = "txbGrade3";
            this.txbGrade3.Size = new System.Drawing.Size(100, 20);
            this.txbGrade3.TabIndex = 7;
            this.txbGrade3.TextChanged += new System.EventHandler(this.txbGrade3_TextChanged);
            // 
            // txbGrade4
            // 
            this.txbGrade4.Location = new System.Drawing.Point(89, 105);
            this.txbGrade4.Name = "txbGrade4";
            this.txbGrade4.Size = new System.Drawing.Size(100, 20);
            this.txbGrade4.TabIndex = 8;
            this.txbGrade4.TextChanged += new System.EventHandler(this.txbGrade4_TextChanged);
            // 
            // txbGrade5
            // 
            this.txbGrade5.Location = new System.Drawing.Point(89, 135);
            this.txbGrade5.Name = "txbGrade5";
            this.txbGrade5.Size = new System.Drawing.Size(100, 20);
            this.txbGrade5.TabIndex = 9;
            this.txbGrade5.TextChanged += new System.EventHandler(this.txbGrade5_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(89, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(65, 218);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(368, 157);
            this.lblResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 351);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbGrade5);
            this.Controls.Add(this.txbGrade4);
            this.Controls.Add(this.txbGrade3);
            this.Controls.Add(this.txbGrade2);
            this.Controls.Add(this.txbGrade1);
            this.Controls.Add(this.lblGrade5);
            this.Controls.Add(this.lblGrade4);
            this.Controls.Add(this.lblGrade3);
            this.Controls.Add(this.lblGrade2);
            this.Controls.Add(this.lblGrade1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrade1;
        private System.Windows.Forms.Label lblGrade2;
        private System.Windows.Forms.Label lblGrade3;
        private System.Windows.Forms.Label lblGrade4;
        private System.Windows.Forms.Label lblGrade5;
        private System.Windows.Forms.TextBox txbGrade1;
        private System.Windows.Forms.TextBox txbGrade2;
        private System.Windows.Forms.TextBox txbGrade3;
        private System.Windows.Forms.TextBox txbGrade4;
        private System.Windows.Forms.TextBox txbGrade5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

