namespace MusQ_Player
{
    partial class MusX
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MusX));
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.proceedbtn = new System.Windows.Forms.Button();
            this.nextbtn = new System.Windows.Forms.Button();
            this.prevbtn = new System.Windows.Forms.Button();
            this.lblnow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnaddconcr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mzk = new AxWMPLib.AxWindowsMediaPlayer();
            this.labeltimer = new System.Windows.Forms.Label();
            this.customProgressBar1 = new MusQ_Player.CustomProgressBar();
            this.pausebtn = new System.Windows.Forms.Button();
            this.checkAutoplay = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmix = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.checkMixed = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.mzk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.lbSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSongs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbSongs.ForeColor = System.Drawing.Color.Crimson;
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 16;
            this.lbSongs.Location = new System.Drawing.Point(16, 162);
            this.lbSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSongs.Size = new System.Drawing.Size(252, 210);
            this.lbSongs.TabIndex = 10;
            this.lbSongs.UseTabStops = false;
            this.lbSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSongs_MouseDoubleClick);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnadd.ForeColor = System.Drawing.Color.Crimson;
            this.btnadd.Location = new System.Drawing.Point(16, 389);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 55);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add Songs";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnclear.ForeColor = System.Drawing.Color.Crimson;
            this.btnclear.Location = new System.Drawing.Point(248, 389);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(88, 55);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // proceedbtn
            // 
            this.proceedbtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.proceedbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.proceedbtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.proceedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.proceedbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.proceedbtn.ForeColor = System.Drawing.Color.Crimson;
            this.proceedbtn.Location = new System.Drawing.Point(16, 61);
            this.proceedbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(88, 34);
            this.proceedbtn.TabIndex = 2;
            this.proceedbtn.Text = "Proceed";
            this.proceedbtn.UseVisualStyleBackColor = false;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.nextbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.nextbtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.nextbtn.FlatAppearance.BorderSize = 2;
            this.nextbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nextbtn.ForeColor = System.Drawing.Color.Crimson;
            this.nextbtn.Location = new System.Drawing.Point(201, 19);
            this.nextbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(59, 76);
            this.nextbtn.TabIndex = 4;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = false;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // prevbtn
            // 
            this.prevbtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.prevbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.prevbtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.prevbtn.FlatAppearance.BorderSize = 2;
            this.prevbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prevbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prevbtn.ForeColor = System.Drawing.Color.Crimson;
            this.prevbtn.Location = new System.Drawing.Point(133, 19);
            this.prevbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.Size = new System.Drawing.Size(59, 75);
            this.prevbtn.TabIndex = 3;
            this.prevbtn.Text = "Prev";
            this.prevbtn.UseVisualStyleBackColor = false;
            this.prevbtn.Click += new System.EventHandler(this.prevbtn_Click);
            // 
            // lblnow
            // 
            this.lblnow.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.lblnow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblnow.ForeColor = System.Drawing.Color.Crimson;
            this.lblnow.Location = new System.Drawing.Point(56, 100);
            this.lblnow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnow.Name = "lblnow";
            this.lblnow.Size = new System.Drawing.Size(251, 58);
            this.lblnow.TabIndex = 0;
            this.lblnow.Text = "Now Playing: ...";
            this.lblnow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnaddconcr
            // 
            this.btnaddconcr.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnaddconcr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddconcr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnaddconcr.ForeColor = System.Drawing.Color.Crimson;
            this.btnaddconcr.Location = new System.Drawing.Point(133, 389);
            this.btnaddconcr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaddconcr.Name = "btnaddconcr";
            this.btnaddconcr.Size = new System.Drawing.Size(88, 55);
            this.btnaddconcr.TabIndex = 7;
            this.btnaddconcr.Text = "Add Song";
            this.btnaddconcr.UseVisualStyleBackColor = false;
            this.btnaddconcr.Click += new System.EventHandler(this.btnaddconcr_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(248, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "v 0.2 by sev";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mzk
            // 
            this.mzk.Enabled = true;
            this.mzk.Location = new System.Drawing.Point(249, 12);
            this.mzk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mzk.Name = "mzk";
            this.mzk.OcxState = ((System.Windows.Forms.AxHost.State) (resources.GetObject("mzk.OcxState")));
            this.mzk.Size = new System.Drawing.Size(124, 78);
            this.mzk.TabIndex = 0;
            this.mzk.Visible = false;
            this.mzk.PlayStateChange +=
                new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mzk_PlayStateChange_1);
            // 
            // labeltimer
            // 
            this.labeltimer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labeltimer.ForeColor = System.Drawing.Color.Crimson;
            this.labeltimer.Location = new System.Drawing.Point(272, 16);
            this.labeltimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltimer.Name = "labeltimer";
            this.labeltimer.Size = new System.Drawing.Size(64, 78);
            this.labeltimer.TabIndex = 10;
            this.labeltimer.Text = "0:00";
            this.labeltimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.customProgressBar1.Location = new System.Drawing.Point(0, 451);
            this.customProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.Size = new System.Drawing.Size(358, 22);
            this.customProgressBar1.TabIndex = 11;
            // 
            // pausebtn
            // 
            this.pausebtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.pausebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.pausebtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.pausebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pausebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.pausebtn.ForeColor = System.Drawing.Color.Crimson;
            this.pausebtn.Location = new System.Drawing.Point(16, 16);
            this.pausebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(88, 34);
            this.pausebtn.TabIndex = 1;
            this.pausebtn.Text = "Pause";
            this.pausebtn.UseVisualStyleBackColor = false;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // checkAutoplay
            // 
            this.checkAutoplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkAutoplay.Location = new System.Drawing.Point(328, 158);
            this.checkAutoplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkAutoplay.Name = "checkAutoplay";
            this.checkAutoplay.Size = new System.Drawing.Size(18, 24);
            this.checkAutoplay.TabIndex = 5;
            this.checkAutoplay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 4.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(275, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Autoplay";
            // 
            // btnmix
            // 
            this.btnmix.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnmix.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnmix.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnmix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmix.Font = new System.Drawing.Font("Arial Rounded MT Bold", 4.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnmix.ForeColor = System.Drawing.Color.Crimson;
            this.btnmix.Location = new System.Drawing.Point(284, 222);
            this.btnmix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmix.Name = "btnmix";
            this.btnmix.Size = new System.Drawing.Size(52, 26);
            this.btnmix.TabIndex = 15;
            this.btnmix.Text = "Shuffle";
            this.btnmix.UseVisualStyleBackColor = false;
            this.btnmix.Click += new System.EventHandler(this.btnmix_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(294, 255);
            this.volumeBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.Size = new System.Drawing.Size(56, 128);
            this.volumeBar.TabIndex = 16;
            this.volumeBar.TabStop = false;
            this.volumeBar.Value = 100;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // checkMixed
            // 
            this.checkMixed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkMixed.Location = new System.Drawing.Point(328, 191);
            this.checkMixed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkMixed.Name = "checkMixed";
            this.checkMixed.Size = new System.Drawing.Size(18, 24);
            this.checkMixed.TabIndex = 17;
            this.checkMixed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 4.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(275, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mixed";
            // 
            // MusX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(352, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkMixed);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.btnmix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkAutoplay);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.labeltimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaddconcr);
            this.Controls.Add(this.lblnow);
            this.Controls.Add(this.prevbtn);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.proceedbtn);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.mzk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MusX";
            this.Text = "MusQ-RED";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MusQ_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.mzk)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer mzk;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button proceedbtn;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button prevbtn;
        private System.Windows.Forms.Label lblnow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnaddconcr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltimer;
        private MusQ_Player.CustomProgressBar customProgressBar1;
        private System.Windows.Forms.Button pausebtn;
        private System.Windows.Forms.CheckBox checkAutoplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmix;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkMixed;
    }
}

