namespace You_N_Me_Tube
{
    partial class Tube
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tube));
            this.bt_SearchOk = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.ShockWave = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ShockWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_SearchOk
            // 
            this.bt_SearchOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_SearchOk.Location = new System.Drawing.Point(489, 21);
            this.bt_SearchOk.Name = "bt_SearchOk";
            this.bt_SearchOk.Size = new System.Drawing.Size(84, 33);
            this.bt_SearchOk.TabIndex = 1;
            this.bt_SearchOk.Text = "OK";
            this.bt_SearchOk.UseVisualStyleBackColor = true;
            this.bt_SearchOk.Click += new System.EventHandler(this.bt_SearchOk_Click);
            // 
            // lstBox
            // 
            this.lstBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 18;
            this.lstBox.Location = new System.Drawing.Point(12, 69);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(561, 202);
            this.lstBox.TabIndex = 2;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Search.Location = new System.Drawing.Point(12, 21);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(471, 28);
            this.tb_Search.TabIndex = 3;
            // 
            // ShockWave
            // 
            this.ShockWave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShockWave.Enabled = true;
            this.ShockWave.Location = new System.Drawing.Point(12, 277);
            this.ShockWave.Name = "ShockWave";
            this.ShockWave.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ShockWave.OcxState")));
            this.ShockWave.Size = new System.Drawing.Size(564, 355);
            this.ShockWave.TabIndex = 4;
            // 
            // videoBindingSource
            // 
            this.videoBindingSource.DataSource = typeof(You_N_Me_Tube.Video);
            // 
            // Tube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 644);
            this.Controls.Add(this.ShockWave);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.bt_SearchOk);
            this.Name = "Tube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShockWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_SearchOk;
        private System.Windows.Forms.BindingSource videoBindingSource;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.TextBox tb_Search;
        private AxShockwaveFlashObjects.AxShockwaveFlash ShockWave;
    }
}

