namespace Hospitalagain5.Winform
{
    partial class Addfooddrink
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelquantity = new System.Windows.Forms.Label();
            this.labelimport = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtimport = new System.Windows.Forms.TextBox();
            this.buttonback = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtout = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtout);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonadd);
            this.panel1.Controls.Add(this.buttonback);
            this.panel1.Controls.Add(this.txtimport);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.labelimport);
            this.panel1.Controls.Add(this.labelquantity);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Controls.Add(this.labelid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information F and D";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(10, 118);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(18, 13);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "ID";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(10, 173);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(35, 13);
            this.labelname.TabIndex = 2;
            this.labelname.Text = "Name";
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Location = new System.Drawing.Point(10, 225);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(46, 13);
            this.labelquantity.TabIndex = 3;
            this.labelquantity.Text = "Quantity";
            // 
            // labelimport
            // 
            this.labelimport.AutoSize = true;
            this.labelimport.Location = new System.Drawing.Point(10, 276);
            this.labelimport.Name = "labelimport";
            this.labelimport.Size = new System.Drawing.Size(61, 13);
            this.labelimport.TabIndex = 4;
            this.labelimport.Text = "Day_Import";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(77, 115);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(280, 20);
            this.txtid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(77, 170);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(280, 20);
            this.txtname.TabIndex = 6;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(77, 222);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(280, 20);
            this.txtquantity.TabIndex = 7;
            // 
            // txtimport
            // 
            this.txtimport.Location = new System.Drawing.Point(77, 273);
            this.txtimport.Name = "txtimport";
            this.txtimport.Size = new System.Drawing.Size(280, 20);
            this.txtimport.TabIndex = 8;
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(302, 20);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(55, 23);
            this.buttonback.TabIndex = 9;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(302, 363);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(55, 23);
            this.buttonadd.TabIndex = 10;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Day_Out";
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(78, 317);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(279, 20);
            this.txtout.TabIndex = 12;
            // 
            // Addfooddrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Addfooddrink";
            this.Text = "Addfooddrink";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.TextBox txtimport;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label labelimport;
        private System.Windows.Forms.Label labelquantity;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label1;
    }
}