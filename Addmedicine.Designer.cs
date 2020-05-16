namespace Hospitalagain5.Winform
{
    partial class Addmedicine
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
            this.txtout = new System.Windows.Forms.TextBox();
            this.labelkind = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            this.txtimport = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.labelunit = new System.Windows.Forms.Label();
            this.labelquantity = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtout);
            this.panel1.Controls.Add(this.labelkind);
            this.panel1.Controls.Add(this.buttonadd);
            this.panel1.Controls.Add(this.buttonback);
            this.panel1.Controls.Add(this.txtimport);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.labelunit);
            this.panel1.Controls.Add(this.labelquantity);
            this.panel1.Controls.Add(this.labelname);
            this.panel1.Controls.Add(this.labelid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 589);
            this.panel1.TabIndex = 0;
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(245, 319);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(279, 20);
            this.txtout.TabIndex = 25;
            // 
            // labelkind
            // 
            this.labelkind.AutoSize = true;
            this.labelkind.Location = new System.Drawing.Point(177, 326);
            this.labelkind.Name = "labelkind";
            this.labelkind.Size = new System.Drawing.Size(28, 13);
            this.labelkind.TabIndex = 24;
            this.labelkind.Text = "Kind";
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(469, 365);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(55, 23);
            this.buttonadd.TabIndex = 23;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(469, 22);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(55, 23);
            this.buttonback.TabIndex = 22;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // txtimport
            // 
            this.txtimport.Location = new System.Drawing.Point(244, 275);
            this.txtimport.Name = "txtimport";
            this.txtimport.Size = new System.Drawing.Size(280, 20);
            this.txtimport.TabIndex = 21;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(244, 224);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(280, 20);
            this.txtquantity.TabIndex = 20;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(244, 172);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(280, 20);
            this.txtname.TabIndex = 19;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(244, 117);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(280, 20);
            this.txtid.TabIndex = 18;
            // 
            // labelunit
            // 
            this.labelunit.AutoSize = true;
            this.labelunit.Location = new System.Drawing.Point(177, 278);
            this.labelunit.Name = "labelunit";
            this.labelunit.Size = new System.Drawing.Size(26, 13);
            this.labelunit.TabIndex = 17;
            this.labelunit.Text = "Unit";
            // 
            // labelquantity
            // 
            this.labelquantity.AutoSize = true;
            this.labelquantity.Location = new System.Drawing.Point(177, 227);
            this.labelquantity.Name = "labelquantity";
            this.labelquantity.Size = new System.Drawing.Size(46, 13);
            this.labelquantity.TabIndex = 16;
            this.labelquantity.Text = "Quantity";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(177, 175);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(35, 13);
            this.labelname.TabIndex = 15;
            this.labelname.Text = "Name";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(177, 120);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(18, 13);
            this.labelid.TabIndex = 14;
            this.labelid.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Information medicine";
            // 
            // Addmedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.panel1);
            this.Name = "Addmedicine";
            this.Text = "Addmedicine";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtout;
        private System.Windows.Forms.Label labelkind;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.TextBox txtimport;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label labelunit;
        private System.Windows.Forms.Label labelquantity;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label1;
    }
}