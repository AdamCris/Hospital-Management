namespace Hospitalagain5.Winform
{
    partial class Adddoctor
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
            this.paneladddoctor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.buttonback = new System.Windows.Forms.Button();
            this.paneladddoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneladddoctor
            // 
            this.paneladddoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneladddoctor.Controls.Add(this.button1);
            this.paneladddoctor.Controls.Add(this.textBox4);
            this.paneladddoctor.Controls.Add(this.textBox3);
            this.paneladddoctor.Controls.Add(this.textBox2);
            this.paneladddoctor.Controls.Add(this.textBox1);
            this.paneladddoctor.Controls.Add(this.labeladdress);
            this.paneladddoctor.Controls.Add(this.labelphone);
            this.paneladddoctor.Controls.Add(this.labelname);
            this.paneladddoctor.Controls.Add(this.labelid);
            this.paneladddoctor.Controls.Add(this.buttonback);
            this.paneladddoctor.Location = new System.Drawing.Point(12, 26);
            this.paneladddoctor.Name = "paneladddoctor";
            this.paneladddoctor.Size = new System.Drawing.Size(358, 397);
            this.paneladddoctor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(71, 239);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 195);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Location = new System.Drawing.Point(13, 239);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(45, 13);
            this.labeladdress.TabIndex = 4;
            this.labeladdress.Text = "Address";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Location = new System.Drawing.Point(13, 195);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(38, 13);
            this.labelphone.TabIndex = 3;
            this.labelphone.Text = "Phone";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(13, 147);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(35, 13);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Name";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(14, 105);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(18, 13);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "ID";
            this.labelid.Click += new System.EventHandler(this.labelid_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(241, 13);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(104, 40);
            this.buttonback.TabIndex = 0;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // Adddoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.paneladddoctor);
            this.Location = new System.Drawing.Point(356, 71);
            this.Name = "Adddoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Adddoctor";
            this.paneladddoctor.ResumeLayout(false);
            this.paneladddoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladddoctor;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelid;
    }
}