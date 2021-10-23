
namespace Windows11Upgrade
{
    partial class win11_downloadSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win11_downloadSelection));
            this.curver = new System.Windows.Forms.Label();
            this.curver_build = new System.Windows.Forms.Label();
            this.newver = new System.Windows.Forms.Label();
            this.updatestat = new System.Windows.Forms.Label();
            this.newver_build = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.beginlabel = new System.Windows.Forms.Label();
            this.beginsublabel = new System.Windows.Forms.Label();
            this.checkupbutton = new System.Windows.Forms.Button();
            this.footlabel = new System.Windows.Forms.Label();
            this.loadingbar1 = new System.Windows.Forms.PictureBox();
            this.parseHTML = new System.ComponentModel.BackgroundWorker();
            this.newver_kb = new System.Windows.Forms.Label();
            this.downbutton = new System.Windows.Forms.Button();
            this.shellbuttonkb = new System.Windows.Forms.Button();
            this.shellKBrunner = new System.ComponentModel.BackgroundWorker();
            this.loadingbar2 = new System.Windows.Forms.PictureBox();
            this.wusabutton = new System.Windows.Forms.Button();
            this.powershelloutput = new System.Windows.Forms.Label();
            this.wusacallshell = new System.ComponentModel.BackgroundWorker();
            this.errorlabel = new System.Windows.Forms.Label();
            this.errordetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingbar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingbar2)).BeginInit();
            this.SuspendLayout();
            // 
            // curver
            // 
            this.curver.AutoSize = true;
            this.curver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.curver.Location = new System.Drawing.Point(70, 66);
            this.curver.Name = "curver";
            this.curver.Size = new System.Drawing.Size(303, 21);
            this.curver.TabIndex = 5;
            this.curver.Text = "Phiên bản Windows đang được cài đặt";
            this.curver.Visible = false;
            // 
            // curver_build
            // 
            this.curver_build.AutoSize = true;
            this.curver_build.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curver_build.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.curver_build.Location = new System.Drawing.Point(70, 101);
            this.curver_build.Name = "curver_build";
            this.curver_build.Size = new System.Drawing.Size(43, 20);
            this.curver_build.TabIndex = 7;
            this.curver_build.Text = "Build";
            this.curver_build.Visible = false;
            // 
            // newver
            // 
            this.newver.AutoSize = true;
            this.newver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.newver.Location = new System.Drawing.Point(70, 161);
            this.newver.Name = "newver";
            this.newver.Size = new System.Drawing.Size(311, 21);
            this.newver.TabIndex = 8;
            this.newver.Text = "Bản cập nhật mới nhất cho Windows 11";
            this.newver.Visible = false;
            // 
            // updatestat
            // 
            this.updatestat.AutoSize = true;
            this.updatestat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updatestat.Location = new System.Drawing.Point(70, 304);
            this.updatestat.Name = "updatestat";
            this.updatestat.Size = new System.Drawing.Size(232, 21);
            this.updatestat.TabIndex = 11;
            this.updatestat.Text = "Bạn đang dùng bản mới nhất";
            this.updatestat.Visible = false;
            // 
            // newver_build
            // 
            this.newver_build.AutoSize = true;
            this.newver_build.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newver_build.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.newver_build.Location = new System.Drawing.Point(70, 196);
            this.newver_build.Name = "newver_build";
            this.newver_build.Size = new System.Drawing.Size(43, 20);
            this.newver_build.TabIndex = 17;
            this.newver_build.Text = "Build";
            this.newver_build.Visible = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(404, 217);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(163, 157);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 18;
            this.logo.TabStop = false;
            // 
            // beginlabel
            // 
            this.beginlabel.AutoSize = true;
            this.beginlabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.beginlabel.Location = new System.Drawing.Point(69, 64);
            this.beginlabel.Name = "beginlabel";
            this.beginlabel.Size = new System.Drawing.Size(459, 25);
            this.beginlabel.TabIndex = 19;
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
            this.beginsublabel.TabIndex = 20;
            this.beginsublabel.Text = "Tải và cài đặt các bản cập nhật tích lũy cho Windows 11 thông qua file .msu \r\ntừ " +
    "Microsoft Update Catalog";
            // 
            // checkupbutton
            // 
            this.checkupbutton.BackColor = System.Drawing.Color.Transparent;
            this.checkupbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkupbutton.BackgroundImage")));
            this.checkupbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkupbutton.FlatAppearance.BorderSize = 0;
            this.checkupbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkupbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkupbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkupbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkupbutton.Location = new System.Drawing.Point(74, 282);
            this.checkupbutton.Name = "checkupbutton";
            this.checkupbutton.Size = new System.Drawing.Size(240, 42);
            this.checkupbutton.TabIndex = 21;
            this.checkupbutton.Text = "Kiểm tra cập nhật";
            this.checkupbutton.UseVisualStyleBackColor = false;
            this.checkupbutton.Click += new System.EventHandler(this.checkupbutton_Click);
            // 
            // footlabel
            // 
            this.footlabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.footlabel.Location = new System.Drawing.Point(0, 361);
            this.footlabel.Name = "footlabel";
            this.footlabel.Size = new System.Drawing.Size(634, 80);
            this.footlabel.TabIndex = 22;
            this.footlabel.Text = "\"Không ai có quyền ép người khác phải tuân theo thứ mà mình cho là đúng\"";
            this.footlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingbar1
            // 
            this.loadingbar1.Image = ((System.Drawing.Image)(resources.GetObject("loadingbar1.Image")));
            this.loadingbar1.Location = new System.Drawing.Point(73, 243);
            this.loadingbar1.Name = "loadingbar1";
            this.loadingbar1.Size = new System.Drawing.Size(241, 10);
            this.loadingbar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingbar1.TabIndex = 23;
            this.loadingbar1.TabStop = false;
            this.loadingbar1.Visible = false;
            // 
            // parseHTML
            // 
            this.parseHTML.DoWork += new System.ComponentModel.DoWorkEventHandler(this.parseHTML_DoWork);
            this.parseHTML.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.parseHTML_RunWorkerCompleted);
            // 
            // newver_kb
            // 
            this.newver_kb.AutoSize = true;
            this.newver_kb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newver_kb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.newver_kb.Location = new System.Drawing.Point(70, 222);
            this.newver_kb.Name = "newver_kb";
            this.newver_kb.Size = new System.Drawing.Size(27, 20);
            this.newver_kb.TabIndex = 25;
            this.newver_kb.Text = "KB";
            this.newver_kb.Visible = false;
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
            this.downbutton.TabIndex = 26;
            this.downbutton.Text = "Tải bản cập nhật";
            this.downbutton.UseVisualStyleBackColor = false;
            this.downbutton.Visible = false;
            this.downbutton.Click += new System.EventHandler(this.downbutton_Click);
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
            this.shellbuttonkb.TabIndex = 28;
            this.shellbuttonkb.Text = "Xác nhận tải xuống";
            this.shellbuttonkb.UseVisualStyleBackColor = false;
            this.shellbuttonkb.Visible = false;
            this.shellbuttonkb.Click += new System.EventHandler(this.shellbuttonkb_Click);
            // 
            // shellKBrunner
            // 
            this.shellKBrunner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.shellKBrunner_DoWork);
            this.shellKBrunner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.shellKBrunner_RunWorkerCompleted);
            // 
            // loadingbar2
            // 
            this.loadingbar2.Image = ((System.Drawing.Image)(resources.GetObject("loadingbar2.Image")));
            this.loadingbar2.Location = new System.Drawing.Point(196, 298);
            this.loadingbar2.Name = "loadingbar2";
            this.loadingbar2.Size = new System.Drawing.Size(241, 10);
            this.loadingbar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingbar2.TabIndex = 29;
            this.loadingbar2.TabStop = false;
            this.loadingbar2.Visible = false;
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
            this.wusabutton.Location = new System.Drawing.Point(196, 282);
            this.wusabutton.Name = "wusabutton";
            this.wusabutton.Size = new System.Drawing.Size(240, 42);
            this.wusabutton.TabIndex = 30;
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
            this.powershelloutput.TabIndex = 31;
            this.powershelloutput.Visible = false;
            // 
            // wusacallshell
            // 
            this.wusacallshell.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wusacallshell_DoWork);
            this.wusacallshell.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.wusacallshell_RunWorkerCompleted);
            // 
            // errorlabel
            // 
            this.errorlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.errorlabel.Location = new System.Drawing.Point(74, 198);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(493, 21);
            this.errorlabel.TabIndex = 32;
            this.errorlabel.Text = "Đã có lỗi xảy ra";
            this.errorlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorlabel.Visible = false;
            // 
            // errordetail
            // 
            this.errordetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errordetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.errordetail.Location = new System.Drawing.Point(74, 226);
            this.errordetail.Name = "errordetail";
            this.errordetail.Size = new System.Drawing.Size(493, 53);
            this.errordetail.TabIndex = 33;
            this.errordetail.Text = "Bạn đang dùng bản mới nhất";
            this.errordetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errordetail.Visible = false;
            // 
            // win11_downloadSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.errordetail);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.loadingbar2);
            this.Controls.Add(this.newver_kb);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.newver_build);
            this.Controls.Add(this.updatestat);
            this.Controls.Add(this.curver_build);
            this.Controls.Add(this.curver);
            this.Controls.Add(this.loadingbar1);
            this.Controls.Add(this.newver);
            this.Controls.Add(this.beginlabel);
            this.Controls.Add(this.footlabel);
            this.Controls.Add(this.beginsublabel);
            this.Controls.Add(this.powershelloutput);
            this.Controls.Add(this.downbutton);
            this.Controls.Add(this.checkupbutton);
            this.Controls.Add(this.shellbuttonkb);
            this.Controls.Add(this.wusabutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "win11_downloadSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 11 Unsupported Upgrade";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingbar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingbar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label curver;
        private System.Windows.Forms.Label curver_build;
        private System.Windows.Forms.Label newver;
        private System.Windows.Forms.Label updatestat;
        private System.Windows.Forms.Label newver_build;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label beginlabel;
        private System.Windows.Forms.Label beginsublabel;
        private System.Windows.Forms.Button checkupbutton;
        private System.Windows.Forms.Label footlabel;
        private System.Windows.Forms.PictureBox loadingbar1;
        private System.ComponentModel.BackgroundWorker parseHTML;
        private System.Windows.Forms.Label newver_kb;
        private System.Windows.Forms.Button downbutton;
        private System.Windows.Forms.Button shellbuttonkb;
        private System.ComponentModel.BackgroundWorker shellKBrunner;
        private System.Windows.Forms.PictureBox loadingbar2;
        private System.Windows.Forms.Button wusabutton;
        private System.Windows.Forms.Label powershelloutput;
        private System.ComponentModel.BackgroundWorker wusacallshell;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Label errordetail;
    }
}