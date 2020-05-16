namespace Hospitalagain5.Winform
{
    partial class Medicine
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
            this.panelmedicine = new System.Windows.Forms.Panel();
            this.listViewmedicine = new System.Windows.Forms.ListView();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.paneladdmedicineright = new System.Windows.Forms.Panel();
            this.panelmedicine.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmedicine
            // 
            this.panelmedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelmedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelmedicine.Controls.Add(this.paneladdmedicineright);
            this.panelmedicine.Controls.Add(this.listViewmedicine);
            this.panelmedicine.Controls.Add(this.buttonclose);
            this.panelmedicine.Controls.Add(this.buttondelete);
            this.panelmedicine.Controls.Add(this.buttonupdate);
            this.panelmedicine.Controls.Add(this.buttonadd);
            this.panelmedicine.Location = new System.Drawing.Point(15, 15);
            this.panelmedicine.Name = "panelmedicine";
            this.panelmedicine.Size = new System.Drawing.Size(773, 427);
            this.panelmedicine.TabIndex = 0;
            // 
            // listViewmedicine
            // 
            this.listViewmedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewmedicine.HideSelection = false;
            this.listViewmedicine.Location = new System.Drawing.Point(20, 71);
            this.listViewmedicine.Name = "listViewmedicine";
            this.listViewmedicine.Size = new System.Drawing.Size(486, 352);
            this.listViewmedicine.TabIndex = 8;
            this.listViewmedicine.UseCompatibleStateImageBehavior = false;
            this.listViewmedicine.SelectedIndexChanged += new System.EventHandler(this.listViewmedicine_SelectedIndexChanged);
            // 
            // buttonclose
            // 
            this.buttonclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonclose.Location = new System.Drawing.Point(686, 16);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(75, 23);
            this.buttonclose.TabIndex = 7;
            this.buttonclose.Text = "X";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(190, 12);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(79, 27);
            this.buttondelete.TabIndex = 6;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(105, 12);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(79, 27);
            this.buttonupdate.TabIndex = 5;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(20, 12);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(79, 27);
            this.buttonadd.TabIndex = 4;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // paneladdmedicineright
            // 
            this.paneladdmedicineright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneladdmedicineright.Location = new System.Drawing.Point(515, 70);
            this.paneladdmedicineright.Name = "paneladdmedicineright";
            this.paneladdmedicineright.Size = new System.Drawing.Size(245, 352);
            this.paneladdmedicineright.TabIndex = 9;
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelmedicine);
            this.Name = "Medicine";
            this.Text = "Medicine";
            this.panelmedicine.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmedicine;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.ListView listViewmedicine;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Panel paneladdmedicineright;
    }
}