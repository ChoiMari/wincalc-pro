namespace WinCalcPro
{
    partial class DateCalcControl
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
            this.toolStrip_date = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox_date = new System.Windows.Forms.ToolStripComboBox();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label_start = new System.Windows.Forms.Label();
            this.label_end = new System.Windows.Forms.Label();
            this.label_diff = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.panel_date0 = new System.Windows.Forms.Panel();
            this.panel_date1 = new System.Windows.Forms.Panel();
            this.label_panel1_start = new System.Windows.Forms.Label();
            this.dateTimePicker_panel1_start = new System.Windows.Forms.DateTimePicker();
            this.radioBtn_panel1_add = new System.Windows.Forms.RadioButton();
            this.radioBtn_panel1_minus = new System.Windows.Forms.RadioButton();
            this.comboBox_panel1_year = new System.Windows.Forms.ComboBox();
            this.comboBox_panel1_month = new System.Windows.Forms.ComboBox();
            this.comboBox_panel1_day = new System.Windows.Forms.ComboBox();
            this.label_panel1_year = new System.Windows.Forms.Label();
            this.label_panel1_date = new System.Windows.Forms.Label();
            this.label_panel1_result = new System.Windows.Forms.Label();
            this.label_panel1_month = new System.Windows.Forms.Label();
            this.label_panel1_day = new System.Windows.Forms.Label();
            this.toolStrip_date.SuspendLayout();
            this.panel_date0.SuspendLayout();
            this.panel_date1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_date
            // 
            this.toolStrip_date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip_date.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_date.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip_date.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_date});
            this.toolStrip_date.Location = new System.Drawing.Point(27, 34);
            this.toolStrip_date.Name = "toolStrip_date";
            this.toolStrip_date.Size = new System.Drawing.Size(197, 33);
            this.toolStrip_date.TabIndex = 0;
            this.toolStrip_date.TabStop = true;
            // 
            // toolStripComboBox_date
            // 
            this.toolStripComboBox_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.toolStripComboBox_date.DropDownWidth = 200;
            this.toolStripComboBox_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBox_date.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripComboBox_date.Items.AddRange(new object[] {
            "날짜 간 차이",
            "일 합산 또는 빼기"});
            this.toolStripComboBox_date.Name = "toolStripComboBox_date";
            this.toolStripComboBox_date.Padding = new System.Windows.Forms.Padding(2);
            this.toolStripComboBox_date.Size = new System.Drawing.Size(192, 33);
            this.toolStripComboBox_date.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_date_SelectedIndexChanged);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.dateTimePicker_start.Font = new System.Drawing.Font("함초롬돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_start.Location = new System.Drawing.Point(24, 48);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker_start.TabIndex = 1;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.dateTimePicker_end.Font = new System.Drawing.Font("함초롬돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_end.Location = new System.Drawing.Point(24, 146);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker_end.TabIndex = 2;
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("한컴 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_start.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_start.Location = new System.Drawing.Point(21, 14);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(44, 17);
            this.label_start.TabIndex = 3;
            this.label_start.Text = "시작일";
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Font = new System.Drawing.Font("한컴 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_end.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_end.Location = new System.Drawing.Point(21, 113);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(44, 17);
            this.label_end.TabIndex = 4;
            this.label_end.Text = "종료일";
            // 
            // label_diff
            // 
            this.label_diff.AutoSize = true;
            this.label_diff.Font = new System.Drawing.Font("한컴 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_diff.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_diff.Location = new System.Drawing.Point(21, 216);
            this.label_diff.Name = "label_diff";
            this.label_diff.Size = new System.Drawing.Size(32, 17);
            this.label_diff.TabIndex = 5;
            this.label_diff.Text = "차이";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_result.Location = new System.Drawing.Point(20, 246);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 21);
            this.label_result.TabIndex = 6;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_date0
            // 
            this.panel_date0.Controls.Add(this.label_result);
            this.panel_date0.Controls.Add(this.label_diff);
            this.panel_date0.Controls.Add(this.label_start);
            this.panel_date0.Controls.Add(this.label_end);
            this.panel_date0.Controls.Add(this.dateTimePicker_end);
            this.panel_date0.Controls.Add(this.dateTimePicker_start);
            this.panel_date0.Location = new System.Drawing.Point(3, 81);
            this.panel_date0.Name = "panel_date0";
            this.panel_date0.Size = new System.Drawing.Size(318, 371);
            this.panel_date0.TabIndex = 7;
            // 
            // panel_date1
            // 
            this.panel_date1.Controls.Add(this.comboBox_panel1_day);
            this.panel_date1.Controls.Add(this.comboBox_panel1_month);
            this.panel_date1.Controls.Add(this.comboBox_panel1_year);
            this.panel_date1.Controls.Add(this.radioBtn_panel1_minus);
            this.panel_date1.Controls.Add(this.radioBtn_panel1_add);
            this.panel_date1.Controls.Add(this.dateTimePicker_panel1_start);
            this.panel_date1.Controls.Add(this.label_panel1_result);
            this.panel_date1.Controls.Add(this.label_panel1_date);
            this.panel_date1.Controls.Add(this.label_panel1_day);
            this.panel_date1.Controls.Add(this.label_panel1_month);
            this.panel_date1.Controls.Add(this.label_panel1_year);
            this.panel_date1.Controls.Add(this.label_panel1_start);
            this.panel_date1.Location = new System.Drawing.Point(3, 81);
            this.panel_date1.Name = "panel_date1";
            this.panel_date1.Size = new System.Drawing.Size(318, 371);
            this.panel_date1.TabIndex = 8;
            this.panel_date1.Visible = false;
            // 
            // label_panel1_start
            // 
            this.label_panel1_start.AutoSize = true;
            this.label_panel1_start.Font = new System.Drawing.Font("한컴 고딕", 9.75F);
            this.label_panel1_start.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_panel1_start.Location = new System.Drawing.Point(21, 14);
            this.label_panel1_start.Name = "label_panel1_start";
            this.label_panel1_start.Size = new System.Drawing.Size(44, 17);
            this.label_panel1_start.TabIndex = 0;
            this.label_panel1_start.Text = "시작일";
            // 
            // dateTimePicker_panel1_start
            // 
            this.dateTimePicker_panel1_start.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.dateTimePicker_panel1_start.Font = new System.Drawing.Font("함초롬돋움", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_panel1_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_panel1_start.Location = new System.Drawing.Point(24, 47);
            this.dateTimePicker_panel1_start.Name = "dateTimePicker_panel1_start";
            this.dateTimePicker_panel1_start.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker_panel1_start.TabIndex = 2;
            // 
            // radioBtn_panel1_add
            // 
            this.radioBtn_panel1_add.AutoSize = true;
            this.radioBtn_panel1_add.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioBtn_panel1_add.Location = new System.Drawing.Point(24, 105);
            this.radioBtn_panel1_add.Name = "radioBtn_panel1_add";
            this.radioBtn_panel1_add.Size = new System.Drawing.Size(60, 25);
            this.radioBtn_panel1_add.TabIndex = 3;
            this.radioBtn_panel1_add.TabStop = true;
            this.radioBtn_panel1_add.Text = "추가";
            this.radioBtn_panel1_add.UseVisualStyleBackColor = true;
            // 
            // radioBtn_panel1_minus
            // 
            this.radioBtn_panel1_minus.AutoSize = true;
            this.radioBtn_panel1_minus.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioBtn_panel1_minus.Location = new System.Drawing.Point(148, 105);
            this.radioBtn_panel1_minus.Name = "radioBtn_panel1_minus";
            this.radioBtn_panel1_minus.Size = new System.Drawing.Size(60, 25);
            this.radioBtn_panel1_minus.TabIndex = 4;
            this.radioBtn_panel1_minus.TabStop = true;
            this.radioBtn_panel1_minus.Text = "빼기";
            this.radioBtn_panel1_minus.UseVisualStyleBackColor = true;
            // 
            // comboBox_panel1_year
            // 
            this.comboBox_panel1_year.FormattingEnabled = true;
            this.comboBox_panel1_year.Location = new System.Drawing.Point(24, 182);
            this.comboBox_panel1_year.Name = "comboBox_panel1_year";
            this.comboBox_panel1_year.Size = new System.Drawing.Size(60, 20);
            this.comboBox_panel1_year.TabIndex = 6;
            // 
            // comboBox_panel1_month
            // 
            this.comboBox_panel1_month.FormattingEnabled = true;
            this.comboBox_panel1_month.Location = new System.Drawing.Point(107, 182);
            this.comboBox_panel1_month.Name = "comboBox_panel1_month";
            this.comboBox_panel1_month.Size = new System.Drawing.Size(60, 20);
            this.comboBox_panel1_month.TabIndex = 6;
            // 
            // comboBox_panel1_day
            // 
            this.comboBox_panel1_day.FormattingEnabled = true;
            this.comboBox_panel1_day.Location = new System.Drawing.Point(191, 182);
            this.comboBox_panel1_day.Name = "comboBox_panel1_day";
            this.comboBox_panel1_day.Size = new System.Drawing.Size(60, 20);
            this.comboBox_panel1_day.TabIndex = 6;
            // 
            // label_panel1_year
            // 
            this.label_panel1_year.AutoSize = true;
            this.label_panel1_year.Font = new System.Drawing.Font("한컴 고딕", 9.75F);
            this.label_panel1_year.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_panel1_year.Location = new System.Drawing.Point(21, 157);
            this.label_panel1_year.Name = "label_panel1_year";
            this.label_panel1_year.Size = new System.Drawing.Size(20, 17);
            this.label_panel1_year.TabIndex = 0;
            this.label_panel1_year.Text = "년";
            // 
            // label_panel1_date
            // 
            this.label_panel1_date.AutoSize = true;
            this.label_panel1_date.Font = new System.Drawing.Font("한컴 고딕", 9.75F);
            this.label_panel1_date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_panel1_date.Location = new System.Drawing.Point(21, 233);
            this.label_panel1_date.Name = "label_panel1_date";
            this.label_panel1_date.Size = new System.Drawing.Size(32, 17);
            this.label_panel1_date.TabIndex = 0;
            this.label_panel1_date.Text = "날짜";
            // 
            // label_panel1_result
            // 
            this.label_panel1_result.AutoSize = true;
            this.label_panel1_result.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_panel1_result.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_panel1_result.Location = new System.Drawing.Point(21, 264);
            this.label_panel1_result.Name = "label_panel1_result";
            this.label_panel1_result.Size = new System.Drawing.Size(0, 21);
            this.label_panel1_result.TabIndex = 0;
            // 
            // label_panel1_month
            // 
            this.label_panel1_month.AutoSize = true;
            this.label_panel1_month.Font = new System.Drawing.Font("한컴 고딕", 9.75F);
            this.label_panel1_month.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_panel1_month.Location = new System.Drawing.Point(104, 157);
            this.label_panel1_month.Name = "label_panel1_month";
            this.label_panel1_month.Size = new System.Drawing.Size(20, 17);
            this.label_panel1_month.TabIndex = 0;
            this.label_panel1_month.Text = "월";
            // 
            // label_panel1_day
            // 
            this.label_panel1_day.AutoSize = true;
            this.label_panel1_day.Font = new System.Drawing.Font("한컴 고딕", 9.75F);
            this.label_panel1_day.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_panel1_day.Location = new System.Drawing.Point(188, 157);
            this.label_panel1_day.Name = "label_panel1_day";
            this.label_panel1_day.Size = new System.Drawing.Size(20, 17);
            this.label_panel1_day.TabIndex = 0;
            this.label_panel1_day.Text = "일";
            // 
            // DateCalcControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel_date1);
            this.Controls.Add(this.toolStrip_date);
            this.Controls.Add(this.panel_date0);
            this.Name = "DateCalcControl";
            this.Size = new System.Drawing.Size(324, 455);
            this.Load += new System.EventHandler(this.DateCalcControl_Load);
            this.toolStrip_date.ResumeLayout(false);
            this.toolStrip_date.PerformLayout();
            this.panel_date0.ResumeLayout(false);
            this.panel_date0.PerformLayout();
            this.panel_date1.ResumeLayout(false);
            this.panel_date1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_date;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.Label label_diff;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Panel panel_date0;
        private System.Windows.Forms.Panel panel_date1;
        private System.Windows.Forms.Label label_panel1_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_panel1_start;
        private System.Windows.Forms.RadioButton radioBtn_panel1_minus;
        private System.Windows.Forms.RadioButton radioBtn_panel1_add;
        private System.Windows.Forms.ComboBox comboBox_panel1_year;
        private System.Windows.Forms.ComboBox comboBox_panel1_day;
        private System.Windows.Forms.ComboBox comboBox_panel1_month;
        private System.Windows.Forms.Label label_panel1_result;
        private System.Windows.Forms.Label label_panel1_date;
        private System.Windows.Forms.Label label_panel1_day;
        private System.Windows.Forms.Label label_panel1_month;
        private System.Windows.Forms.Label label_panel1_year;
    }
}
