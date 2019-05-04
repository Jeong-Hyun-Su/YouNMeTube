namespace You_N_Me_Tube
{
    partial class Form1
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
            this.tb_link = new System.Windows.Forms.TextBox();
            this.bt_linkOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(52, 60);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(347, 28);
            this.tb_link.TabIndex = 0;
            // 
            // bt_linkOk
            // 
            this.bt_linkOk.Location = new System.Drawing.Point(417, 56);
            this.bt_linkOk.Name = "bt_linkOk";
            this.bt_linkOk.Size = new System.Drawing.Size(84, 33);
            this.bt_linkOk.TabIndex = 1;
            this.bt_linkOk.Text = "OK";
            this.bt_linkOk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.bt_linkOk);
            this.Controls.Add(this.tb_link);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.Button bt_linkOk;
    }
}

