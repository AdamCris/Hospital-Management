namespace Hospitalagain5.Winform
{
    partial class Doctor
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
            this.paneldoctor = new System.Windows.Forms.Panel();
            this.paneladddoctorright = new System.Windows.Forms.Panel();
            this.listViewdoctor = new System.Windows.Forms.ListView();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.paneldoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldoctor
            // 
            this.paneldoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldoctor.Controls.Add(this.paneladddoctorright);
            this.paneldoctor.Controls.Add(this.listViewdoctor);
            this.paneldoctor.Controls.Add(this.buttonclose);
            this.paneldoctor.Controls.Add(this.buttondelete);
            this.paneldoctor.Controls.Add(this.buttonupdate);
            this.paneldoctor.Controls.Add(this.buttonadd);
            this.paneldoctor.Location = new System.Drawing.Point(3, 7);
            this.paneldoctor.Name = "paneldoctor";
            this.paneldoctor.Size = new System.Drawing.Size(790, 431);
            this.paneldoctor.TabIndex = 0;
            // 
            // paneladddoctorright
            // 
            this.paneladddoctorright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneladddoctorright.BackColor = System.Drawing.Color.White;
            this.paneladddoctorright.Location = new System.Drawing.Point(356, 71);
            this.paneladddoctorright.Name = "paneladddoctorright";
            this.paneladddoctorright.Size = new System.Drawing.Size(418, 358);
            this.paneladddoctorright.TabIndex = 6;
            // 
            // listViewdoctor
            // 
            this.listViewdoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewdoctor.HideSelection = false;
            this.listViewdoctor.Location = new System.Drawing.Point(17, 71);
            this.listViewdoctor.Name = "listViewdoctor";
            this.listViewdoctor.Size = new System.Drawing.Size(333, 359);
            this.listViewdoctor.TabIndex = 5;
            this.listViewdoctor.UseCompatibleStateImageBehavior = false;
            this.listViewdoctor.SelectedIndexChanged += new System.EventHandler(this.listViewdoctor_SelectedIndexChanged);
            // 
            // buttonclose
            // 
            this.buttonclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonclose.Location = new System.Drawing.Point(670, 20);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(104, 34);
            this.buttonclose.TabIndex = 4;
            this.buttonclose.Text = "X";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(176, 20);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(74, 34);
            this.buttondelete.TabIndex = 3;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(96, 20);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(74, 34);
            this.buttonupdate.TabIndex = 2;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(17, 20);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(74, 34);
            this.buttonadd.TabIndex = 0;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.paneldoctor);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.paneldoctor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldoctor;
        private System.Windows.Forms.ListView listViewdoctor;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Panel paneladddoctorright;
    }
}