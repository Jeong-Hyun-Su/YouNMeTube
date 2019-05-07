namespace You_N_Me_Tube
{
    partial class VideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Rewind = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_FastFoward = new System.Windows.Forms.Button();
            this.btn_mute = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_ChangeToMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(940, 29);
            this.panel1.TabIndex = 0;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(885, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(23, 23);
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.Text = "-";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            // 
            // btn_Close
            // 
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(914, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(23, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(253, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 304);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search.BackgroundImage")));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(194, 38);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(53, 39);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Rewind
            // 
            this.btn_Rewind.BackColor = System.Drawing.Color.White;
            this.btn_Rewind.FlatAppearance.BorderSize = 4;
            this.btn_Rewind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rewind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Rewind.ImageIndex = 8;
            this.btn_Rewind.ImageList = this.imageList1;
            this.btn_Rewind.Location = new System.Drawing.Point(450, 418);
            this.btn_Rewind.Name = "btn_Rewind";
            this.btn_Rewind.Size = new System.Drawing.Size(48, 48);
            this.btn_Rewind.TabIndex = 4;
            this.btn_Rewind.UseVisualStyleBackColor = false;
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
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.White;
            this.btn_Play.FlatAppearance.BorderSize = 4;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.ImageIndex = 5;
            this.btn_Play.ImageList = this.imageList1;
            this.btn_Play.Location = new System.Drawing.Point(520, 418);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(48, 48);
            this.btn_Play.TabIndex = 4;
            this.btn_Play.UseVisualStyleBackColor = false;
            // 
            // btn_FastFoward
            // 
            this.btn_FastFoward.FlatAppearance.BorderSize = 4;
            this.btn_FastFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FastFoward.ImageIndex = 7;
            this.btn_FastFoward.ImageList = this.imageList1;
            this.btn_FastFoward.Location = new System.Drawing.Point(591, 418);
            this.btn_FastFoward.Name = "btn_FastFoward";
            this.btn_FastFoward.Size = new System.Drawing.Size(48, 48);
            this.btn_FastFoward.TabIndex = 4;
            this.btn_FastFoward.UseVisualStyleBackColor = true;
            // 
            // btn_mute
            // 
            this.btn_mute.FlatAppearance.BorderSize = 0;
            this.btn_mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mute.ImageIndex = 0;
            this.btn_mute.ImageList = this.imageList1;
            this.btn_mute.Location = new System.Drawing.Point(678, 418);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(48, 48);
            this.btn_mute.TabIndex = 4;
            this.btn_mute.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(732, 418);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(175, 56);
            this.trackBar1.TabIndex = 5;
            // 
            // btn_ChangeToMusic
            // 
            this.btn_ChangeToMusic.BackColor = System.Drawing.Color.White;
            this.btn_ChangeToMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ChangeToMusic.BackgroundImage")));
            this.btn_ChangeToMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ChangeToMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeToMusic.Location = new System.Drawing.Point(12, 38);
            this.btn_ChangeToMusic.Name = "btn_ChangeToMusic";
            this.btn_ChangeToMusic.Size = new System.Drawing.Size(53, 39);
            this.btn_ChangeToMusic.TabIndex = 3;
            this.btn_ChangeToMusic.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Video Player";
            // 
            // VideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btn_mute);
            this.Controls.Add(this.btn_FastFoward);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Rewind);
            this.Controls.Add(this.btn_ChangeToMusic);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoPlayer";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_ChangeToMusic;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Rewind;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_FastFoward;
        private System.Windows.Forms.Button btn_mute;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}