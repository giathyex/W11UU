namespace Windows11Upgrade
{
    partial class w11uu_manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w11uu_manual));
            this.inputb = new System.Windows.Forms.TextBox();
            this.beginlabel = new System.Windows.Forms.Label();
            this.beginsublabel = new System.Windows.Forms.Label();
            this.downbutton = new System.Windows.Forms.Button();
            this.footlabel = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.shellKBrunner = new System.ComponentModel.BackgroundWorker();
            this.wusacallshell = new System.ComponentModel.BackgroundWorker();
            this.loadingbar2 = new System.Windows.Forms.PictureBox();
            this.shellbuttonkb = new System.Windows.Forms.Button();
            this.wusabutton = new System.Windows.Forms.Button();
            this.powershelloutput = new System.Windows.Forms.Label();
            this.exam = new System.Windows.Forms.Label();
            this.inputbg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputbg)).BeginInit();
            this.SuspendLayout();
            // 
            // inputb
            // 
            this.inputb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(161)))), ((int)(((byte)(183)))));
            this.inputb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.inputb.Location = new System.Drawing.Point(76, 231);
            this.inputb.Name = "inputb";
            this.inputb.Size = new System.Drawing.Size(235, 18);
            this.inputb.TabIndex = 0;
            this.inputb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // beginlabel
            // 
            this.beginlabel.AutoSize = true;
            this.beginlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.beginlabel.Location = new System.Drawing.Point(68, 64);
            this.beginlabel.Name = "beginlabel";
            this.beginlabel.Size = new System.Drawing.Size(459, 25);
            this.beginlabel.TabIndex = 21;
            this.beginlabel.Text = "Cập nhật Windows 11 cho máy không được hỗ trợ";
            // 
            // beginsublabel
            // 
            this.beginsublabel.AutoSize = true;
            this.beginsublabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginsublabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.beginsublabel.Location = new System.Drawing.Point(71, 103);
            this.beginsublabel.Name = "beginsublabel";
            this.beginsublabel.Size = new System.Drawing.Size(452, 34);
            this.beginsublabel.TabIndex = 22;
            this.beginsublabel.Text = "Nhập tên bản cập nhật tích lũy cho Windows 11 mà bạn muốn để tải xuống \r\ntừ Micro" +
    "soft Update Catalog và cài đặt bằng wusa.exe";
            // 
            // downbutton
            // 
            this.downbutton.BackColor = System.Drawing.Color.Transparent;
            this.downbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downbutton.BackgroundImage")));
            this.downbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.downbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downbutton.FlatAppearance.BorderSize = 0;
            this.downbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.downbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.downbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.downbutton.Location = new System.Drawing.Point(73, 282);
            this.downbutton.Name = "downbutton";
            this.downbutton.Size = new System.Drawing.Size(240, 42);
            this.downbutton.TabIndex = 27;
            this.downbutton.Text = "Tải bản cập nhật";
            this.downbutton.UseVisualStyleBackColor = false;
            this.downbutton.Click += new System.EventHandler(this.downbutton_Click);
            // 
            // footlabel
            // 
            this.footlabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.footlabel.Location = new System.Drawing.Point(0, 361);
            this.footlabel.Name = "footlabel";
            this.footlabel.Size = new System.Drawing.Size(634, 80);
            this.footlabel.TabIndex = 28;
            this.footlabel.Text = "\"Không ai có quyền ép người khác phải tuân theo thứ mà mình cho là đúng\"";
            this.footlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(404, 217);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(163, 157);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 29;
            this.logo.TabStop = false;
            // 
            // shellKBrunner
            // 
            this.shellKBrunner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.shellKBrunner_DoWork);
            this.shellKBrunner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.shellKBrunner_RunWorkerCompleted);
            // 
            // wusacallshell
            // 
            this.wusacallshell.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wusacallshell_DoWork);
            this.wusacallshell.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wusacallshell_RunWorkerCompleted);
            // 
            // loadingbar2
            // 
            this.loadingbar2.Image = ((System.Drawing.Image)(resources.GetObject("loadingbar2.Image")));
            this.loadingbar2.Location = new System.Drawing.Point(196, 298);
            this.loadingbar2.Name = "loadingbar2";
            this.loadingbar2.Size = new System.Drawing.Size(241, 10);
            this.loadingbar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingbar2.TabIndex = 31;
            this.loadingbar2.TabStop = false;
            this.loadingbar2.Visible = false;
            // 
            // shellbuttonkb
            // 
            this.shellbuttonkb.BackColor = System.Drawing.Color.Transparent;
            this.shellbuttonkb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shellbuttonkb.BackgroundImage")));
            this.shellbuttonkb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shellbuttonkb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shellbuttonkb.FlatAppearance.BorderSize = 0;
            this.shellbuttonkb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shellbuttonkb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shellbuttonkb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shellbuttonkb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellbuttonkb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.shellbuttonkb.Location = new System.Drawing.Point(197, 282);
            this.shellbuttonkb.Name = "shellbuttonkb";
            this.shellbuttonkb.Size = new System.Drawing.Size(240, 42);
            this.shellbuttonkb.TabIndex = 30;
            this.shellbuttonkb.Text = "Xác nhận tải xuống";
            this.shellbuttonkb.UseVisualStyleBackColor = false;
            this.shellbuttonkb.Visible = false;
            this.shellbuttonkb.Click += new System.EventHandler(this.shellbuttonkb_Click);
            // 
            // wusabutton
            // 
            this.wusabutton.BackColor = System.Drawing.Color.Transparent;
            this.wusabutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wusabutton.BackgroundImage")));
            this.wusabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wusabutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wusabutton.FlatAppearance.BorderSize = 0;
            this.wusabutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wusabutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wusabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wusabutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wusabutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.wusabutton.Location = new System.Drawing.Point(197, 282);
            this.wusabutton.Name = "wusabutton";
            this.wusabutton.Size = new System.Drawing.Size(240, 42);
            this.wusabutton.TabIndex = 32;
            this.wusabutton.Text = "Cài đặt cập nhật";
            this.wusabutton.UseVisualStyleBackColor = false;
            this.wusabutton.Visible = false;
            this.wusabutton.Click += new System.EventHandler(this.wusabutton_Click);
            // 
            // powershelloutput
            // 
            this.powershelloutput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powershelloutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.powershelloutput.Location = new System.Drawing.Point(72, 66);
            this.powershelloutput.Name = "powershelloutput";
            this.powershelloutput.Size = new System.Drawing.Size(495, 213);
            this.powershelloutput.TabIndex = 33;
            this.powershelloutput.Visible = false;
            // 
            // exam
            // 
            this.exam.AutoSize = true;
            this.exam.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.exam.Location = new System.Drawing.Point(70, 186);
            this.exam.Name = "exam";
            this.exam.Size = new System.Drawing.Size(109, 17);
            this.exam.TabIndex = 34;
            this.exam.Text = "Ví dụ: KB5006674";
            // 
            // inputbg
            // 
            this.inputbg.Image = ((System.Drawing.Image)(resources.GetObject("inputbg.Image")));
            this.inputbg.Location = new System.Drawing.Point(74, 218);
            this.inputbg.Name = "inputbg";
            this.inputbg.Size = new System.Drawing.Size(239, 43);
            this.inputbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inputbg.TabIndex = 35;
            this.inputbg.TabStop = false;
            // 
            // w11uu_manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.exam);
            this.Controls.Add(this.loadingbar2);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.footlabel);
            this.Controls.Add(this.downbutton);
            this.Controls.Add(this.beginlabel);
            this.Controls.Add(this.beginsublabel);
            this.Controls.Add(this.inputb);
            this.Controls.Add(this.shellbuttonkb);
            this.Controls.Add(this.wusabutton);
            this.Controls.Add(this.inputbg);
            this.Controls.Add(this.powershelloutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w11uu_manual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 11 Unsupported Upgrade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.exit);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputbg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputb;
        private System.Windows.Forms.Label beginlabel;
        private System.Windows.Forms.Label beginsublabel;
        private System.Windows.Forms.Button downbutton;
        private System.Windows.Forms.Label footlabel;
        private System.Windows.Forms.PictureBox logo;
        private System.ComponentModel.BackgroundWorker shellKBrunner;
        private System.ComponentModel.BackgroundWorker wusacallshell;
        private System.Windows.Forms.PictureBox loadingbar2;
        private System.Windows.Forms.Button shellbuttonkb;
        private System.Windows.Forms.Button wusabutton;
        private System.Windows.Forms.Label powershelloutput;
        private System.Windows.Forms.Label exam;
        private System.Windows.Forms.PictureBox inputbg;
    }
}