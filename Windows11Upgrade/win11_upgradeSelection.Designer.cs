
namespace Windows11Upgrade
{
    partial class win11_upgradeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win11_upgradeSelection));
            this.lbl_choice = new System.Windows.Forms.Label();
            this.btn_downloadIso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choice
            // 
            this.lbl_choice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_choice.Location = new System.Drawing.Point(261, 44);
            this.lbl_choice.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(302, 112);
            this.lbl_choice.TabIndex = 0;
            this.lbl_choice.Text = "Tool update Windows 11\r\ncho máy không được hỗ trợ";
            this.lbl_choice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_downloadIso
            // 
            this.btn_downloadIso.BackColor = System.Drawing.Color.Transparent;
            this.btn_downloadIso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_downloadIso.BackgroundImage")));
            this.btn_downloadIso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_downloadIso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_downloadIso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_downloadIso.FlatAppearance.BorderSize = 0;
            this.btn_downloadIso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_downloadIso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_downloadIso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_downloadIso.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadIso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_downloadIso.Location = new System.Drawing.Point(321, 327);
            this.btn_downloadIso.Name = "btn_downloadIso";
            this.btn_downloadIso.Size = new System.Drawing.Size(240, 42);
            this.btn_downloadIso.TabIndex = 3;
            this.btn_downloadIso.Text = "Bắt đầu cập nhật";
            this.btn_downloadIso.UseVisualStyleBackColor = false;
            this.btn_downloadIso.Click += new System.EventHandler(this.btn_downloadIso_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 441);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(303, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Based on kbupdate script of Chrissy LeMaire";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabel1
            // 
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(340, 147);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(221, 23);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://npethuduc.net";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            // 
            // win11_upgradeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_choice);
            this.Controls.Add(this.btn_downloadIso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "win11_upgradeSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 11 Unsupported Upgrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_choice;
        private System.Windows.Forms.Button btn_downloadIso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

