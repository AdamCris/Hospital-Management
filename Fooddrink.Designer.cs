namespace Hospitalagain5.Winform
{
    partial class Fooddrink
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
            this.panelfooddrink = new System.Windows.Forms.Panel();
            this.paneladdfooddrinkright = new System.Windows.Forms.Panel();
            this.listViewfooddrink = new System.Windows.Forms.ListView();
            this.buttonclose = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.panelfooddrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfooddrink
            // 
            this.panelfooddrink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelfooddrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelfooddrink.Controls.Add(this.paneladdfooddrinkright);
            this.panelfooddrink.Controls.Add(this.listViewfooddrink);
            this.panelfooddrink.Controls.Add(this.buttonclose);
            this.panelfooddrink.Controls.Add(this.buttondelete);
            this.panelfooddrink.Controls.Add(this.buttonupdate);
            this.panelfooddrink.Controls.Add(this.buttonadd);
            this.panelfooddrink.Location = new System.Drawing.Point(5, 12);
            this.panelfooddrink.Name = "panelfooddrink";
            this.panelfooddrink.Size = new System.Drawing.Size(820, 426);
            this.panelfooddrink.TabIndex = 2;
            // 
            // paneladdfooddrinkright
            // 
            this.paneladdfooddrinkright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneladdfooddrinkright.Location = new System.Drawing.Point(439, 105);
            this.paneladdfooddrinkright.Name = "paneladdfooddrinkright";
            this.paneladdfooddrinkright.Size = new System.Drawing.Size(380, 317);
            this.paneladdfooddrinkright.TabIndex = 13;
            // 
            // listViewfooddrink
            // 
            this.listViewfooddrink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewfooddrink.HideSelection = false;
            this.listViewfooddrink.Location = new System.Drawing.Point(7, 106);
            this.listViewfooddrink.Name = "listViewfooddrink";
            this.listViewfooddrink.Size = new System.Drawing.Size(426, 317);
            this.listViewfooddrink.TabIndex = 12;
            this.listViewfooddrink.UseCompatibleStateImageBehavior = false;
            this.listViewfooddrink.SelectedIndexChanged += new System.EventHandler(this.listViewfooddrink_SelectedIndexChanged);
            // 
            // buttonclose
            // 
            this.buttonclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonclose.Location = new System.Drawing.Point(727, 19);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(87, 33);
            this.buttonclose.TabIndex = 11;
            this.buttonclose.Text = "X";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(201, 15);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(91, 37);
            this.buttondelete.TabIndex = 10;
            this.buttondelete.Text = "Delete";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(104, 15);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(91, 37);
            this.buttonupdate.TabIndex = 9;
            this.buttonupdate.Text = "Update";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(7, 15);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(91, 37);
            this.buttonadd.TabIndex = 8;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // Fooddrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panelfooddrink);
            this.Name = "Fooddrink";
            this.Text = "Fooddrink";
            this.panelfooddrink.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelfooddrink;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.ListView listViewfooddrink;
        private System.Windows.Forms.Panel paneladdfooddrinkright;
    }
}