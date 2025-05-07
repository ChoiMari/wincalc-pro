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
            this.panel_theme = new System.Windows.Forms.Panel();
            this.radioButton_dark = new System.Windows.Forms.RadioButton();
            this.radioButton_light = new System.Windows.Forms.RadioButton();
            this.panel_theme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_shape
            // 
            this.label_shape.AutoSize = true;
            this.label_shape.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_shape.Location = new System.Drawing.Point(29, 40);
            this.label_shape.Name = "label_shape";
            this.label_shape.Size = new System.Drawing.Size(37, 19);
            this.label_shape.TabIndex = 0;
            this.label_shape.Text = "모양";
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_information.Location = new System.Drawing.Point(29, 193);
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
            // panel_theme
            // 
            this.panel_theme.BackColor = System.Drawing.Color.White;
            this.panel_theme.Controls.Add(this.radioButton_dark);
            this.panel_theme.Controls.Add(this.radioButton_light);
            this.panel_theme.Location = new System.Drawing.Point(33, 74);
            this.panel_theme.Name = "panel_theme";
            this.panel_theme.Size = new System.Drawing.Size(248, 100);
            this.panel_theme.TabIndex = 5;
            // 
            // radioButton_dark
            // 
            this.radioButton_dark.AutoSize = true;
            this.radioButton_dark.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_dark.Location = new System.Drawing.Point(17, 61);
            this.radioButton_dark.Name = "radioButton_dark";
            this.radioButton_dark.Size = new System.Drawing.Size(60, 23);
            this.radioButton_dark.TabIndex = 0;
            this.radioButton_dark.TabStop = true;
            this.radioButton_dark.Text = "Dark";
            this.radioButton_dark.UseVisualStyleBackColor = true;
            // 
            // radioButton_light
            // 
            this.radioButton_light.AutoSize = true;
            this.radioButton_light.Checked = true;
            this.radioButton_light.Font = new System.Drawing.Font("한컴 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton_light.Location = new System.Drawing.Point(17, 22);
            this.radioButton_light.Name = "radioButton_light";
            this.radioButton_light.Size = new System.Drawing.Size(62, 23);
            this.radioButton_light.TabIndex = 0;
            this.radioButton_light.TabStop = true;
            this.radioButton_light.Text = "Light";
            this.radioButton_light.UseVisualStyleBackColor = true;
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel_theme);
            this.Controls.Add(this.label_icon_copyright);
            this.Controls.Add(this.linkLabel_icon_copyright);
            this.Controls.Add(this.label_copyright);
            this.Controls.Add(this.label_info_content);
            this.Controls.Add(this.label_information);
            this.Controls.Add(this.label_shape);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(324, 455);
            this.Load += new System.EventHandler(this.SettingControl_Load);
            this.panel_theme.ResumeLayout(false);
            this.panel_theme.PerformLayout();
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
        private System.Windows.Forms.Panel panel_theme;
        private System.Windows.Forms.RadioButton radioButton_light;
        private System.Windows.Forms.RadioButton radioButton_dark;
    }
}
