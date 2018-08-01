namespace Client_Card
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcardno = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtcvv = new System.Windows.Forms.TextBox();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Expiry Date (01/MM/YYYY):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CVV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transaction Amount:";
            // 
            // txtcardno
            // 
            this.txtcardno.Location = new System.Drawing.Point(210, 57);
            this.txtcardno.Name = "txtcardno";
            this.txtcardno.Size = new System.Drawing.Size(100, 20);
            this.txtcardno.TabIndex = 4;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(210, 125);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 5;
            // 
            // txtcvv
            // 
            this.txtcvv.Location = new System.Drawing.Point(210, 200);
            this.txtcvv.Name = "txtcvv";
            this.txtcvv.Size = new System.Drawing.Size(100, 20);
            this.txtcvv.TabIndex = 6;
            // 
            // txtamt
            // 
            this.txtamt.Location = new System.Drawing.Point(210, 255);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(100, 20);
            this.txtamt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtamt);
            this.Controls.Add(this.txtcvv);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtcardno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcardno;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtcvv;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.Button button1;
    }
}

