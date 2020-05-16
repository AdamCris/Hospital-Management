namespace Hospitalagain5.Winform
{
    partial class Patient
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
            this.panelpatient = new System.Windows.Forms.Panel();
            this.paneladdpatientright = new System.Windows.Forms.Panel();
            this.listViewpatient = new System.Windows.Forms.ListView();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.panelpatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelpatient
            // 
            this.panelpatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpatient.Controls.Add(this.paneladdpatientright);
            this.panelpatient.Controls.Add(this.listViewpatient);
            this.panelpatient.Controls.Add(this.buttondelete);
            this.panelpatient.Controls.Add(this.buttonupdate);
            this.panelpatient.Controls.Add(this.buttonadd);
            this.panelpatient.Controls.Add(this.buttonclose);
            this.panelpatient.Location = new System.Drawing.Point(12, 12);
            this.panelpatient.Name = "panelpatient";
            this.panelpatient.Size = new System.Drawing.Size(776, 426);
            this.panelpatient.TabIndex = 0;
            this.panelpatient.Paint += new System.Windows.Forms.PaintEventHandler(this.panelpatient_Paint);
            // 
            // paneladdpatientright
            // 
            this.paneladdpatientright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneladdpatientright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paneladdpatientright.Location = new System.Drawing.Point(182, 63);
            this.paneladdpatientright.Name = "paneladdpatientright";
            this.paneladdpatientright.Size = new System.Drawing.Size(581, 359);
            this.paneladdpatientright.TabIndex = 5;
            this.paneladdpatientright.Paint += new System.Windows.Forms.PaintEventHandler(this.paneladdpatientright_Paint);
            // 
            // listViewpatient
            // 
            this.listViewpatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewpatient.HideSelection = false;
            this.listViewpatient.Location = new System.Drawing.Point(12, 63);
            this.listViewpatient.Name = "listViewpatient";
            this.listViewpatient.Size = new System.Drawing.Size(164, 360);
            this.listViewpatient.TabIndex = 4;
            this.listViewpatient.UseCompatibleStateImageBehavior = false;
            this.listViewpatient.SelectedIndexChanged += new System.EventHandler(this.listViewpatient_SelectedIndexChanged);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(182, 12);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(79, 27);
            this.buttondelete.TabIndex = 3;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(97, 12);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(79, 27);
            this.buttonupdate.TabIndex = 2;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(12, 12);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(79, 27);
            this.buttonadd.TabIndex = 1;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonclose.Location = new System.Drawing.Point(689, 12);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(75, 23);
            this.buttonclose.TabIndex = 0;
            this.buttonclose.Text = "X";
            this.buttonclose.UseVisualStyleBackColor = true;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelpatient);
            this.Name = "Patient";
            this.Text = "Patient";
            this.panelpatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelpatient;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Panel paneladdpatientright;
        private System.Windows.Forms.ListView listViewpatient;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonadd;
    }
}