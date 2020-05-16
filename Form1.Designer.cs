namespace Hospitalagain5
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.panelleft = new System.Windows.Forms.Panel();
            this.buttontool = new System.Windows.Forms.Button();
            this.buttonmedicine = new System.Windows.Forms.Button();
            this.buttonfooddrink = new System.Windows.Forms.Button();
            this.buttonpatient = new System.Windows.Forms.Button();
            this.buttondoctor = new System.Windows.Forms.Button();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.panelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(800, 137);
            this.paneltop.TabIndex = 0;
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelleft.Controls.Add(this.buttontool);
            this.panelleft.Controls.Add(this.buttonmedicine);
            this.panelleft.Controls.Add(this.buttonfooddrink);
            this.panelleft.Controls.Add(this.buttonpatient);
            this.panelleft.Controls.Add(this.buttondoctor);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 137);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(215, 313);
            this.panelleft.TabIndex = 1;
            // 
            // buttontool
            // 
            this.buttontool.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttontool.Location = new System.Drawing.Point(0, 180);
            this.buttontool.Name = "buttontool";
            this.buttontool.Size = new System.Drawing.Size(215, 45);
            this.buttontool.TabIndex = 4;
            this.buttontool.Text = "Tool";
            this.buttontool.UseVisualStyleBackColor = true;
            this.buttontool.Click += new System.EventHandler(this.buttontool_Click);
            // 
            // buttonmedicine
            // 
            this.buttonmedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonmedicine.Location = new System.Drawing.Point(0, 135);
            this.buttonmedicine.Name = "buttonmedicine";
            this.buttonmedicine.Size = new System.Drawing.Size(215, 45);
            this.buttonmedicine.TabIndex = 3;
            this.buttonmedicine.Text = "Medicine";
            this.buttonmedicine.UseVisualStyleBackColor = true;
            this.buttonmedicine.Click += new System.EventHandler(this.buttonmedicine_Click);
            // 
            // buttonfooddrink
            // 
            this.buttonfooddrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonfooddrink.Location = new System.Drawing.Point(0, 90);
            this.buttonfooddrink.Name = "buttonfooddrink";
            this.buttonfooddrink.Size = new System.Drawing.Size(215, 45);
            this.buttonfooddrink.TabIndex = 2;
            this.buttonfooddrink.Text = "Food/drink";
            this.buttonfooddrink.UseVisualStyleBackColor = true;
            this.buttonfooddrink.Click += new System.EventHandler(this.buttonfooddrink_Click);
            // 
            // buttonpatient
            // 
            this.buttonpatient.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonpatient.Location = new System.Drawing.Point(0, 45);
            this.buttonpatient.Name = "buttonpatient";
            this.buttonpatient.Size = new System.Drawing.Size(215, 45);
            this.buttonpatient.TabIndex = 1;
            this.buttonpatient.Text = "Patient";
            this.buttonpatient.UseVisualStyleBackColor = true;
            this.buttonpatient.Click += new System.EventHandler(this.buttonpatient_Click);
            // 
            // buttondoctor
            // 
            this.buttondoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttondoctor.Location = new System.Drawing.Point(0, 0);
            this.buttondoctor.Name = "buttondoctor";
            this.buttondoctor.Size = new System.Drawing.Size(215, 45);
            this.buttondoctor.TabIndex = 0;
            this.buttondoctor.Text = "Doctor";
            this.buttondoctor.UseVisualStyleBackColor = true;
            this.buttondoctor.Click += new System.EventHandler(this.buttondoctor_Click);
            // 
            // panelcenter
            // 
            this.panelcenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcenter.BackColor = System.Drawing.Color.White;
            this.panelcenter.Location = new System.Drawing.Point(215, 137);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(585, 313);
            this.panelcenter.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelcenter);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.paneltop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.Button buttontool;
        private System.Windows.Forms.Button buttonmedicine;
        private System.Windows.Forms.Button buttonfooddrink;
        private System.Windows.Forms.Button buttonpatient;
        private System.Windows.Forms.Button buttondoctor;
    }
}

