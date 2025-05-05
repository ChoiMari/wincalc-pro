namespace WinCalcPro
{
    partial class SettingControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_shape = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.label_info_content = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.linkLabel_icon_copyright = new System.Windows.Forms.LinkLabel();
            this.label_icon_copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_shape
            // 
            this.label_shape.AutoSize = true;
            this.label_shape.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_shape.Location = new System.Drawing.Point(29, 38);
            this.label_shape.Name = "label_shape";
            this.label_shape.Size = new System.Drawing.Size(37, 19);
            this.label_shape.TabIndex = 0;
            this.label_shape.Text = "모양";
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_information.Location = new System.Drawing.Point(29, 191);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(37, 19);
            this.label_information.TabIndex = 0;
            this.label_information.Text = "정보";
            // 
            // label_info_content
            // 
            this.label_info_content.AutoSize = true;
            this.label_info_content.BackColor = System.Drawing.Color.White;
            this.label_info_content.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_info_content.Location = new System.Drawing.Point(34, 227);
            this.label_info_content.Name = "label_info_content";
            this.label_info_content.Size = new System.Drawing.Size(0, 19);
            this.label_info_content.TabIndex = 1;
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Font = new System.Drawing.Font("한컴산뜻돋움", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_copyright.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_copyright.Location = new System.Drawing.Point(33, 320);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(0, 14);
            this.label_copyright.TabIndex = 2;
            // 
            // linkLabel_icon_copyright
            // 
            this.linkLabel_icon_copyright.AutoSize = true;
            this.linkLabel_icon_copyright.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel_icon_copyright.Location = new System.Drawing.Point(102, 380);
            this.linkLabel_icon_copyright.Name = "linkLabel_icon_copyright";
            this.linkLabel_icon_copyright.Size = new System.Drawing.Size(74, 12);
            this.linkLabel_icon_copyright.TabIndex = 3;
            this.linkLabel_icon_copyright.TabStop = true;
            this.linkLabel_icon_copyright.Text = "flaticon.com";
            this.linkLabel_icon_copyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_icon_copyright_LinkClicked);
            // 
            // label_icon_copyright
            // 
            this.label_icon_copyright.AutoSize = true;
            this.label_icon_copyright.Font = new System.Drawing.Font("한컴산뜻돋움", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_icon_copyright.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_icon_copyright.Location = new System.Drawing.Point(35, 379);
            this.label_icon_copyright.Name = "label_icon_copyright";
            this.label_icon_copyright.Size = new System.Drawing.Size(66, 14);
            this.label_icon_copyright.TabIndex = 4;
            this.label_icon_copyright.Text = "아이콘 출처 :";
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.label_icon_copyright);
            this.Controls.Add(this.linkLabel_icon_copyright);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_info_content);
            this.Controls.Add(this.label_information);
            this.Controls.Add(this.label_shape);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(324, 455);
            this.Load += new System.EventHandler(this.SettingControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_shape;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label_info_content;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.LinkLabel linkLabel_icon_copyright;
        private System.Windows.Forms.Label label_icon_copyright;
    }
}
