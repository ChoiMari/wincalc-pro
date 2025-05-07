namespace WinCalcPro
{
    partial class ProgCalcControl
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
            this.textBox_preview = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_BIN = new System.Windows.Forms.TextBox();
            this.textBox_OCT = new System.Windows.Forms.TextBox();
            this.textBox_DEC = new System.Windows.Forms.TextBox();
            this.textBox_HEX = new System.Windows.Forms.TextBox();
            this.btn_BIN = new System.Windows.Forms.Button();
            this.btn_OCT = new System.Windows.Forms.Button();
            this.btn_DEC = new System.Windows.Forms.Button();
            this.btn_BEX = new System.Windows.Forms.Button();
            this.tableLayoutPanel_progcalc = new System.Windows.Forms.TableLayoutPanel();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_leftShift = new System.Windows.Forms.Button();
            this.btn_rightShift = new System.Windows.Forms.Button();
            this.btn_clearAll = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_openParentheses = new System.Windows.Forms.Button();
            this.btn_parenthesesEnd = new System.Windows.Forms.Button();
            this.btn_percent = new System.Windows.Forms.Button();
            this.btn_sharing = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_E = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_F = new System.Windows.Forms.Button();
            this.btn_conversion = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_decimalPoint = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.panel_hr = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_progcalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_preview
            // 
            this.textBox_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.textBox_preview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_preview.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_preview.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_preview.Location = new System.Drawing.Point(11, 26);
            this.textBox_preview.Name = "textBox_preview";
            this.textBox_preview.ReadOnly = true;
            this.textBox_preview.Size = new System.Drawing.Size(300, 19);
            this.textBox_preview.TabIndex = 4;
            this.textBox_preview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_input
            // 
            this.textBox_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.textBox_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_input.Location = new System.Drawing.Point(11, 52);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.ReadOnly = true;
            this.textBox_input.Size = new System.Drawing.Size(300, 34);
            this.textBox_input.TabIndex = 3;
            this.textBox_input.Text = "0";
            this.textBox_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_BIN
            // 
            this.textBox_BIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.textBox_BIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_BIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_BIN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_BIN.Location = new System.Drawing.Point(69, 179);
            this.textBox_BIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_BIN.Name = "textBox_BIN";
            this.textBox_BIN.ReadOnly = true;
            this.textBox_BIN.Size = new System.Drawing.Size(240, 14);
            this.textBox_BIN.TabIndex = 16;
            this.textBox_BIN.Text = "0";
            // 
            // textBox_OCT
            // 
            this.textBox_OCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.textBox_OCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_OCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_OCT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_OCT.Location = new System.Drawing.Point(69, 155);
            this.textBox_OCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_OCT.Name = "textBox_OCT";
            this.textBox_OCT.ReadOnly = true;
            this.textBox_OCT.Size = new System.Drawing.Size(240, 14);
            this.textBox_OCT.TabIndex = 15;
            this.textBox_OCT.Text = "0";
            // 
            // textBox_DEC
            // 
            this.textBox_DEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.textBox_DEC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_DEC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_DEC.Location = new System.Drawing.Point(69, 130);
            this.textBox_DEC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DEC.Name = "textBox_DEC";
            this.textBox_DEC.ReadOnly = true;
            this.textBox_DEC.Size = new System.Drawing.Size(240, 14);
            this.textBox_DEC.TabIndex = 14;
            this.textBox_DEC.Text = "0";
            // 
            // textBox_HEX
            // 
            this.textBox_HEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.textBox_HEX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_HEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_HEX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_HEX.Location = new System.Drawing.Point(69, 105);
            this.textBox_HEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_HEX.Name = "textBox_HEX";
            this.textBox_HEX.ReadOnly = true;
            this.textBox_HEX.Size = new System.Drawing.Size(240, 14);
            this.textBox_HEX.TabIndex = 13;
            this.textBox_HEX.Text = "0";
            // 
            // btn_BIN
            // 
            this.btn_BIN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.btn_BIN.FlatAppearance.BorderSize = 0;
            this.btn_BIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_BIN.Location = new System.Drawing.Point(16, 176);
            this.btn_BIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BIN.Name = "btn_BIN";
            this.btn_BIN.Size = new System.Drawing.Size(40, 20);
            this.btn_BIN.TabIndex = 12;
            this.btn_BIN.Text = "BIN";
            this.btn_BIN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BIN.UseVisualStyleBackColor = true;
            this.btn_BIN.Click += new System.EventHandler(this.btn_BIN_Click);
            // 
            // btn_OCT
            // 
            this.btn_OCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.btn_OCT.FlatAppearance.BorderSize = 0;
            this.btn_OCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OCT.Location = new System.Drawing.Point(15, 152);
            this.btn_OCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OCT.Name = "btn_OCT";
            this.btn_OCT.Size = new System.Drawing.Size(40, 20);
            this.btn_OCT.TabIndex = 11;
            this.btn_OCT.Text = "OCT";
            this.btn_OCT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OCT.UseVisualStyleBackColor = true;
            this.btn_OCT.Click += new System.EventHandler(this.btn_OCT_Click);
            // 
            // btn_DEC
            // 
            this.btn_DEC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.btn_DEC.FlatAppearance.BorderSize = 0;
            this.btn_DEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DEC.Location = new System.Drawing.Point(15, 126);
            this.btn_DEC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DEC.Name = "btn_DEC";
            this.btn_DEC.Size = new System.Drawing.Size(40, 20);
            this.btn_DEC.TabIndex = 10;
            this.btn_DEC.Text = "DEC";
            this.btn_DEC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DEC.UseVisualStyleBackColor = true;
            this.btn_DEC.Click += new System.EventHandler(this.btn_DEC_Click);
            // 
            // btn_BEX
            // 
            this.btn_BEX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.btn_BEX.FlatAppearance.BorderSize = 0;
            this.btn_BEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_BEX.Location = new System.Drawing.Point(15, 101);
            this.btn_BEX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BEX.Name = "btn_BEX";
            this.btn_BEX.Size = new System.Drawing.Size(40, 20);
            this.btn_BEX.TabIndex = 9;
            this.btn_BEX.Text = "HEX";
            this.btn_BEX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BEX.UseVisualStyleBackColor = true;
            this.btn_BEX.Click += new System.EventHandler(this.btn_BEX_Click);
            // 
            // tableLayoutPanel_progcalc
            // 
            this.tableLayoutPanel_progcalc.ColumnCount = 5;
            this.tableLayoutPanel_progcalc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_progcalc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_progcalc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_progcalc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_progcalc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_A, 0, 0);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_leftShift, 1, 0);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_rightShift, 2, 0);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_clearAll, 3, 0);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_back, 4, 0);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_B, 0, 1);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_openParentheses, 1, 1);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_parenthesesEnd, 2, 1);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_percent, 3, 1);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_sharing, 4, 1);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_C, 0, 2);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_7, 1, 2);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_8, 2, 2);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_9, 3, 2);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_multiplication, 4, 2);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_D, 0, 3);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_4, 1, 3);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_5, 2, 3);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_6, 3, 3);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_minus, 4, 3);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_E, 0, 4);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_1, 1, 4);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_2, 2, 4);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_3, 3, 4);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_plus, 4, 4);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_F, 0, 5);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_conversion, 1, 5);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_0, 2, 5);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_decimalPoint, 3, 5);
            this.tableLayoutPanel_progcalc.Controls.Add(this.btn_equal, 4, 5);
            this.tableLayoutPanel_progcalc.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel_progcalc.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel_progcalc.Name = "tableLayoutPanel_progcalc";
            this.tableLayoutPanel_progcalc.RowCount = 6;
            this.tableLayoutPanel_progcalc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_progcalc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_progcalc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_progcalc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_progcalc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.43119F));
            this.tableLayoutPanel_progcalc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.51376F));
            this.tableLayoutPanel_progcalc.Size = new System.Drawing.Size(318, 218);
            this.tableLayoutPanel_progcalc.TabIndex = 17;
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_A.Enabled = false;
            this.btn_A.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_A.FlatAppearance.BorderSize = 0;
            this.btn_A.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_A.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_A.Location = new System.Drawing.Point(1, 1);
            this.btn_A.Margin = new System.Windows.Forms.Padding(1);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(61, 34);
            this.btn_A.TabIndex = 0;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_leftShift
            // 
            this.btn_leftShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_leftShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_leftShift.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_leftShift.FlatAppearance.BorderSize = 0;
            this.btn_leftShift.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_leftShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leftShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_leftShift.Location = new System.Drawing.Point(64, 1);
            this.btn_leftShift.Margin = new System.Windows.Forms.Padding(1);
            this.btn_leftShift.Name = "btn_leftShift";
            this.btn_leftShift.Size = new System.Drawing.Size(61, 34);
            this.btn_leftShift.TabIndex = 1;
            this.btn_leftShift.Text = "<<";
            this.btn_leftShift.UseVisualStyleBackColor = false;
            this.btn_leftShift.Click += new System.EventHandler(this.btn_leftShift_Click);
            // 
            // btn_rightShift
            // 
            this.btn_rightShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_rightShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rightShift.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_rightShift.FlatAppearance.BorderSize = 0;
            this.btn_rightShift.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_rightShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rightShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_rightShift.Location = new System.Drawing.Point(127, 1);
            this.btn_rightShift.Margin = new System.Windows.Forms.Padding(1);
            this.btn_rightShift.Name = "btn_rightShift";
            this.btn_rightShift.Size = new System.Drawing.Size(61, 34);
            this.btn_rightShift.TabIndex = 2;
            this.btn_rightShift.Text = ">>";
            this.btn_rightShift.UseVisualStyleBackColor = false;
            this.btn_rightShift.Click += new System.EventHandler(this.btn_rightShift_Click);
            // 
            // btn_clearAll
            // 
            this.btn_clearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_clearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clearAll.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_clearAll.FlatAppearance.BorderSize = 0;
            this.btn_clearAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_clearAll.Location = new System.Drawing.Point(190, 1);
            this.btn_clearAll.Margin = new System.Windows.Forms.Padding(1);
            this.btn_clearAll.Name = "btn_clearAll";
            this.btn_clearAll.Size = new System.Drawing.Size(61, 34);
            this.btn_clearAll.TabIndex = 3;
            this.btn_clearAll.Text = "C";
            this.btn_clearAll.UseVisualStyleBackColor = false;
            this.btn_clearAll.Click += new System.EventHandler(this.btn_clearAll_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_back.Location = new System.Drawing.Point(253, 1);
            this.btn_back.Margin = new System.Windows.Forms.Padding(1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(64, 34);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "⌫";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_B.Enabled = false;
            this.btn_B.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_B.FlatAppearance.BorderSize = 0;
            this.btn_B.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_B.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_B.Location = new System.Drawing.Point(1, 37);
            this.btn_B.Margin = new System.Windows.Forms.Padding(1);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(61, 34);
            this.btn_B.TabIndex = 5;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_openParentheses
            // 
            this.btn_openParentheses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_openParentheses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_openParentheses.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_openParentheses.FlatAppearance.BorderSize = 0;
            this.btn_openParentheses.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_openParentheses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openParentheses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_openParentheses.Location = new System.Drawing.Point(64, 37);
            this.btn_openParentheses.Margin = new System.Windows.Forms.Padding(1);
            this.btn_openParentheses.Name = "btn_openParentheses";
            this.btn_openParentheses.Size = new System.Drawing.Size(61, 34);
            this.btn_openParentheses.TabIndex = 6;
            this.btn_openParentheses.Text = "(";
            this.btn_openParentheses.UseVisualStyleBackColor = false;
            this.btn_openParentheses.Click += new System.EventHandler(this.btn_openParentheses_Click);
            // 
            // btn_parenthesesEnd
            // 
            this.btn_parenthesesEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_parenthesesEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_parenthesesEnd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_parenthesesEnd.FlatAppearance.BorderSize = 0;
            this.btn_parenthesesEnd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_parenthesesEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parenthesesEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_parenthesesEnd.Location = new System.Drawing.Point(127, 37);
            this.btn_parenthesesEnd.Margin = new System.Windows.Forms.Padding(1);
            this.btn_parenthesesEnd.Name = "btn_parenthesesEnd";
            this.btn_parenthesesEnd.Size = new System.Drawing.Size(61, 34);
            this.btn_parenthesesEnd.TabIndex = 7;
            this.btn_parenthesesEnd.Text = ")";
            this.btn_parenthesesEnd.UseVisualStyleBackColor = false;
            this.btn_parenthesesEnd.Click += new System.EventHandler(this.btn_parenthesesEnd_Click);
            // 
            // btn_percent
            // 
            this.btn_percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_percent.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_percent.FlatAppearance.BorderSize = 0;
            this.btn_percent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_percent.Location = new System.Drawing.Point(190, 37);
            this.btn_percent.Margin = new System.Windows.Forms.Padding(1);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(61, 34);
            this.btn_percent.TabIndex = 8;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = false;
            this.btn_percent.Click += new System.EventHandler(this.btn_percent_Click);
            // 
            // btn_sharing
            // 
            this.btn_sharing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_sharing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sharing.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_sharing.FlatAppearance.BorderSize = 0;
            this.btn_sharing.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sharing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sharing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sharing.Location = new System.Drawing.Point(253, 37);
            this.btn_sharing.Margin = new System.Windows.Forms.Padding(1);
            this.btn_sharing.Name = "btn_sharing";
            this.btn_sharing.Size = new System.Drawing.Size(64, 34);
            this.btn_sharing.TabIndex = 9;
            this.btn_sharing.Text = "÷";
            this.btn_sharing.UseVisualStyleBackColor = false;
            this.btn_sharing.Click += new System.EventHandler(this.btn_sharing_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_C.Enabled = false;
            this.btn_C.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_C.FlatAppearance.BorderSize = 0;
            this.btn_C.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_C.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_C.Location = new System.Drawing.Point(1, 73);
            this.btn_C.Margin = new System.Windows.Forms.Padding(1);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(61, 34);
            this.btn_C.TabIndex = 10;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_7.Location = new System.Drawing.Point(64, 73);
            this.btn_7.Margin = new System.Windows.Forms.Padding(1);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(61, 34);
            this.btn_7.TabIndex = 11;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_8.Location = new System.Drawing.Point(127, 73);
            this.btn_8.Margin = new System.Windows.Forms.Padding(1);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(61, 34);
            this.btn_8.TabIndex = 12;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_9.Location = new System.Drawing.Point(190, 73);
            this.btn_9.Margin = new System.Windows.Forms.Padding(1);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(61, 34);
            this.btn_9.TabIndex = 13;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_multiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_multiplication.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_multiplication.FlatAppearance.BorderSize = 0;
            this.btn_multiplication.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_multiplication.Location = new System.Drawing.Point(253, 73);
            this.btn_multiplication.Margin = new System.Windows.Forms.Padding(1);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(64, 34);
            this.btn_multiplication.TabIndex = 14;
            this.btn_multiplication.Text = "×";
            this.btn_multiplication.UseVisualStyleBackColor = false;
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_D.Enabled = false;
            this.btn_D.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_D.FlatAppearance.BorderSize = 0;
            this.btn_D.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_D.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_D.Location = new System.Drawing.Point(1, 109);
            this.btn_D.Margin = new System.Windows.Forms.Padding(1);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(61, 34);
            this.btn_D.TabIndex = 15;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_4.Location = new System.Drawing.Point(64, 109);
            this.btn_4.Margin = new System.Windows.Forms.Padding(1);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(61, 34);
            this.btn_4.TabIndex = 16;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_5.Location = new System.Drawing.Point(127, 109);
            this.btn_5.Margin = new System.Windows.Forms.Padding(1);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(61, 34);
            this.btn_5.TabIndex = 17;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_6.Location = new System.Drawing.Point(190, 109);
            this.btn_6.Margin = new System.Windows.Forms.Padding(1);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(61, 34);
            this.btn_6.TabIndex = 18;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_minus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minus.FlatAppearance.BorderSize = 0;
            this.btn_minus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_minus.Location = new System.Drawing.Point(253, 109);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(1);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(64, 34);
            this.btn_minus.TabIndex = 19;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_E
            // 
            this.btn_E.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_E.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_E.Enabled = false;
            this.btn_E.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_E.FlatAppearance.BorderSize = 0;
            this.btn_E.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_E.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_E.Location = new System.Drawing.Point(1, 145);
            this.btn_E.Margin = new System.Windows.Forms.Padding(1);
            this.btn_E.Name = "btn_E";
            this.btn_E.Size = new System.Drawing.Size(61, 35);
            this.btn_E.TabIndex = 20;
            this.btn_E.Text = "E";
            this.btn_E.UseVisualStyleBackColor = false;
            this.btn_E.Click += new System.EventHandler(this.btn_E_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_1.Location = new System.Drawing.Point(64, 145);
            this.btn_1.Margin = new System.Windows.Forms.Padding(1);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(61, 35);
            this.btn_1.TabIndex = 21;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_2.Location = new System.Drawing.Point(127, 145);
            this.btn_2.Margin = new System.Windows.Forms.Padding(1);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(61, 35);
            this.btn_2.TabIndex = 22;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_3.Location = new System.Drawing.Point(190, 145);
            this.btn_3.Margin = new System.Windows.Forms.Padding(1);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(61, 35);
            this.btn_3.TabIndex = 23;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_plus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_plus.FlatAppearance.BorderSize = 0;
            this.btn_plus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_plus.Location = new System.Drawing.Point(253, 145);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(1);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(64, 35);
            this.btn_plus.TabIndex = 24;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_F
            // 
            this.btn_F.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_F.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_F.Enabled = false;
            this.btn_F.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_F.FlatAppearance.BorderSize = 0;
            this.btn_F.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_F.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_F.Location = new System.Drawing.Point(1, 182);
            this.btn_F.Margin = new System.Windows.Forms.Padding(1);
            this.btn_F.Name = "btn_F";
            this.btn_F.Size = new System.Drawing.Size(61, 35);
            this.btn_F.TabIndex = 25;
            this.btn_F.Text = "F";
            this.btn_F.UseVisualStyleBackColor = false;
            this.btn_F.Click += new System.EventHandler(this.btn_F_Click);
            // 
            // btn_conversion
            // 
            this.btn_conversion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_conversion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_conversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_conversion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_conversion.FlatAppearance.BorderSize = 0;
            this.btn_conversion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_conversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_conversion.Location = new System.Drawing.Point(64, 182);
            this.btn_conversion.Margin = new System.Windows.Forms.Padding(1);
            this.btn_conversion.Name = "btn_conversion";
            this.btn_conversion.Size = new System.Drawing.Size(61, 35);
            this.btn_conversion.TabIndex = 26;
            this.btn_conversion.Text = "+/-";
            this.btn_conversion.UseVisualStyleBackColor = false;
            this.btn_conversion.Click += new System.EventHandler(this.btn_conversion_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_0.Location = new System.Drawing.Point(127, 182);
            this.btn_0.Margin = new System.Windows.Forms.Padding(1);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(61, 35);
            this.btn_0.TabIndex = 27;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_decimalPoint
            // 
            this.btn_decimalPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_decimalPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_decimalPoint.Enabled = false;
            this.btn_decimalPoint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_decimalPoint.FlatAppearance.BorderSize = 0;
            this.btn_decimalPoint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_decimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_decimalPoint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_decimalPoint.Location = new System.Drawing.Point(190, 182);
            this.btn_decimalPoint.Margin = new System.Windows.Forms.Padding(1);
            this.btn_decimalPoint.Name = "btn_decimalPoint";
            this.btn_decimalPoint.Size = new System.Drawing.Size(61, 35);
            this.btn_decimalPoint.TabIndex = 28;
            this.btn_decimalPoint.Text = ".";
            this.btn_decimalPoint.UseVisualStyleBackColor = false;
            this.btn_decimalPoint.Click += new System.EventHandler(this.btn_decimalPoint_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btn_equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_equal.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_equal.FlatAppearance.BorderSize = 0;
            this.btn_equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(196)))));
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_equal.ForeColor = System.Drawing.Color.White;
            this.btn_equal.Location = new System.Drawing.Point(253, 182);
            this.btn_equal.Margin = new System.Windows.Forms.Padding(1);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(64, 35);
            this.btn_equal.TabIndex = 29;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // panel_hr
            // 
            this.panel_hr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_hr.Location = new System.Drawing.Point(0, 205);
            this.panel_hr.Name = "panel_hr";
            this.panel_hr.Size = new System.Drawing.Size(320, 1);
            this.panel_hr.TabIndex = 18;
            // 
            // ProgCalcControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panel_hr);
            this.Controls.Add(this.tableLayoutPanel_progcalc);
            this.Controls.Add(this.textBox_BIN);
            this.Controls.Add(this.textBox_OCT);
            this.Controls.Add(this.textBox_DEC);
            this.Controls.Add(this.textBox_HEX);
            this.Controls.Add(this.btn_BIN);
            this.Controls.Add(this.btn_OCT);
            this.Controls.Add(this.btn_DEC);
            this.Controls.Add(this.btn_BEX);
            this.Controls.Add(this.textBox_preview);
            this.Controls.Add(this.textBox_input);
            this.Name = "ProgCalcControl";
            this.Size = new System.Drawing.Size(324, 455);
            this.tableLayoutPanel_progcalc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_preview;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_BIN;
        private System.Windows.Forms.TextBox textBox_OCT;
        private System.Windows.Forms.TextBox textBox_DEC;
        private System.Windows.Forms.TextBox textBox_HEX;
        private System.Windows.Forms.Button btn_BIN;
        private System.Windows.Forms.Button btn_OCT;
        private System.Windows.Forms.Button btn_DEC;
        private System.Windows.Forms.Button btn_BEX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_progcalc;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_leftShift;
        private System.Windows.Forms.Button btn_rightShift;
        private System.Windows.Forms.Button btn_clearAll;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_openParentheses;
        private System.Windows.Forms.Button btn_parenthesesEnd;
        private System.Windows.Forms.Button btn_percent;
        private System.Windows.Forms.Button btn_sharing;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_E;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.Button btn_conversion;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_decimalPoint;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Panel panel_hr;
    }
}
