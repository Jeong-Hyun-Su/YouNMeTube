namespace You_N_Me_Tube
{
    partial class MusicPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_NameOfMusic = new System.Windows.Forms.Label();
            this.btn_Mute = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_FastFoward = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Rewind = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_ChangeToVideo = new System.Windows.Forms.Button();
            this.btn_Random = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 29);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Music Player";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(599, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(23, 23);
            this.btn_Minimize.TabIndex = 2;
            this.btn_Minimize.Text = "-";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(628, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(23, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 168);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_NameOfMusic
            // 
            this.label_NameOfMusic.AutoSize = true;
            this.label_NameOfMusic.Location = new System.Drawing.Point(141, 43);
            this.label_NameOfMusic.Name = "label_NameOfMusic";
            this.label_NameOfMusic.Size = new System.Drawing.Size(45, 15);
            this.label_NameOfMusic.TabIndex = 8;
            this.label_NameOfMusic.Text = "music";
            // 
            // btn_Mute
            // 
            this.btn_Mute.FlatAppearance.BorderSize = 0;
            this.btn_Mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mute.ImageIndex = 0;
            this.btn_Mute.ImageList = this.imageList1;
            this.btn_Mute.Location = new System.Drawing.Point(23, 274);
            this.btn_Mute.Name = "btn_Mute";
            this.btn_Mute.Size = new System.Drawing.Size(48, 48);
            this.btn_Mute.TabIndex = 9;
            this.btn_Mute.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "speaker (4).png");
            this.imageList1.Images.SetKeyName(1, "speaker (1).png");
            this.imageList1.Images.SetKeyName(2, "speaker (2).png");
            this.imageList1.Images.SetKeyName(3, "speaker (3).png");
            this.imageList1.Images.SetKeyName(4, "speaker.png");
            this.imageList1.Images.SetKeyName(5, "play-button.png");
            this.imageList1.Images.SetKeyName(6, "pause-button.png");
            this.imageList1.Images.SetKeyName(7, "fast-forward-button.png");
            this.imageList1.Images.SetKeyName(8, "fast-rewind-button.png");
            this.imageList1.Images.SetKeyName(9, "couple-of-arrows-changing-places.png");
            this.imageList1.Images.SetKeyName(10, "exchange-arrows.png");
            // 
            // btn_FastFoward
            // 
            this.btn_FastFoward.FlatAppearance.BorderSize = 4;
            this.btn_FastFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FastFoward.ImageIndex = 7;
            this.btn_FastFoward.ImageList = this.imageList1;
            this.btn_FastFoward.Location = new System.Drawing.Point(282, 274);
            this.btn_FastFoward.Name = "btn_FastFoward";
            this.btn_FastFoward.Size = new System.Drawing.Size(48, 48);
            this.btn_FastFoward.TabIndex = 10;
            this.btn_FastFoward.UseVisualStyleBackColor = true;
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.White;
            this.btn_Play.FlatAppearance.BorderSize = 4;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.ImageIndex = 5;
            this.btn_Play.ImageList = this.imageList1;
            this.btn_Play.Location = new System.Drawing.Point(211, 274);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(48, 48);
            this.btn_Play.TabIndex = 11;
            this.btn_Play.UseVisualStyleBackColor = false;
            // 
            // btn_Rewind
            // 
            this.btn_Rewind.BackColor = System.Drawing.Color.White;
            this.btn_Rewind.FlatAppearance.BorderSize = 4;
            this.btn_Rewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rewind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Rewind.ImageIndex = 8;
            this.btn_Rewind.ImageList = this.imageList1;
            this.btn_Rewind.Location = new System.Drawing.Point(141, 274);
            this.btn_Rewind.Name = "btn_Rewind";
            this.btn_Rewind.Size = new System.Drawing.Size(48, 48);
            this.btn_Rewind.TabIndex = 12;
            this.btn_Rewind.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(76, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(53, 39);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(33, 148);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 120);
            this.trackBar1.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(370, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 289);
            this.listBox1.TabIndex = 16;
            // 
            // btn_ChangeToVideo
            // 
            this.btn_ChangeToVideo.BackColor = System.Drawing.Color.White;
            this.btn_ChangeToVideo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChangeToVideo.BackgroundImage")));
            this.btn_ChangeToVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ChangeToVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeToVideo.Location = new System.Drawing.Point(12, 43);
            this.btn_ChangeToVideo.Name = "btn_ChangeToVideo";
            this.btn_ChangeToVideo.Size = new System.Drawing.Size(53, 39);
            this.btn_ChangeToVideo.TabIndex = 14;
            this.btn_ChangeToVideo.UseVisualStyleBackColor = false;
            this.btn_ChangeToVideo.Click += new System.EventHandler(this.btn_ChangeToVideo_Click);
            // 
            // btn_Random
            // 
            this.btn_Random.FlatAppearance.BorderSize = 0;
            this.btn_Random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Random.ImageIndex = 9;
            this.btn_Random.ImageList = this.imageList1;
            this.btn_Random.Location = new System.Drawing.Point(76, 274);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(48, 48);
            this.btn_Random.TabIndex = 9;
            this.btn_Random.UseVisualStyleBackColor = true;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 342);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_ChangeToVideo);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Random);
            this.Controls.Add(this.btn_Mute);
            this.Controls.Add(this.btn_FastFoward);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Rewind);
            this.Controls.Add(this.label_NameOfMusic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_NameOfMusic;
        private System.Windows.Forms.Button btn_Mute;
        private System.Windows.Forms.Button btn_FastFoward;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Rewind;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ChangeToVideo;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Random;
        private System.Windows.Forms.Label label1;
    }
}