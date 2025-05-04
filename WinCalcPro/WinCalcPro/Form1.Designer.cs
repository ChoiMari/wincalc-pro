namespace WinCalcPro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_preview = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel_stdcalc_button = new System.Windows.Forms.TableLayoutPanel();
            this.button_percent = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_recip = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_multip = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_subtrac = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_PM = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_decipoint = new System.Windows.Forms.Button();
            this.button_equals = new System.Windows.Forms.Button();
            this.label_calc = new System.Windows.Forms.Label();
            this.tableLayoutPanel_menu_button = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_menu_setting = new System.Windows.Forms.TableLayoutPanel();
            this.button_menu_setting = new System.Windows.Forms.Button();
            this.button_menu_std = new System.Windows.Forms.Button();
            this.button_menu_sci = new System.Windows.Forms.Button();
            this.button_menu_prog = new System.Windows.Forms.Button();
            this.button_menu_date = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.tableLayoutPanel_stdcalc_button.SuspendLayout();
            this.tableLayoutPanel_menu_button.SuspendLayout();
            this.tableLayoutPanel_menu_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel_menu.Controls.Add(this.tableLayoutPanel_menu_setting);
            this.panel_menu.Controls.Add(this.tableLayoutPanel_menu_button);
            this.panel_menu.Controls.Add(this.label_calc);
            this.panel_menu.Controls.Add(this.button_close);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(0, 501);
            this.panel_menu.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.Location = new System.Drawing.Point(55, 17);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(68, 27);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "표준";
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.textBox_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_result.Font = new System.Drawing.Font("굴림", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_result.Location = new System.Drawing.Point(12, 100);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(300, 52);
            this.textBox_result.TabIndex = 3;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_preview
            // 
            this.textBox_preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.textBox_preview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_preview.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_preview.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_preview.Location = new System.Drawing.Point(12, 69);
            this.textBox_preview.Name = "textBox_preview";
            this.textBox_preview.ReadOnly = true;
            this.textBox_preview.Size = new System.Drawing.Size(300, 25);
            this.textBox_preview.TabIndex = 4;
            this.textBox_preview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel_stdcalc_button
            // 
            this.tableLayoutPanel_stdcalc_button.ColumnCount = 4;
            this.tableLayoutPanel_stdcalc_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_stdcalc_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_stdcalc_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_stdcalc_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_percent, 0, 0);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_CE, 1, 0);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_C, 2, 0);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_back, 3, 0);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_recip, 0, 1);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_square, 1, 1);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_sqrt, 2, 1);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_division, 3, 1);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_7, 0, 2);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_8, 1, 2);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_9, 2, 2);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_multip, 3, 2);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_4, 0, 3);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_5, 1, 3);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_6, 2, 3);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_subtrac, 3, 3);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_1, 0, 4);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_2, 1, 4);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_3, 2, 4);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_add, 3, 4);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_PM, 0, 5);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_0, 1, 5);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_decipoint, 2, 5);
            this.tableLayoutPanel_stdcalc_button.Controls.Add(this.button_equals, 3, 5);
            this.tableLayoutPanel_stdcalc_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel_stdcalc_button.Location = new System.Drawing.Point(0, 189);
            this.tableLayoutPanel_stdcalc_button.Name = "tableLayoutPanel_stdcalc_button";
            this.tableLayoutPanel_stdcalc_button.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel_stdcalc_button.RowCount = 6;
            this.tableLayoutPanel_stdcalc_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_stdcalc_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_stdcalc_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_stdcalc_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_stdcalc_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_stdcalc_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel_stdcalc_button.Size = new System.Drawing.Size(324, 312);
            this.tableLayoutPanel_stdcalc_button.TabIndex = 5;
            // 
            // button_percent
            // 
            this.button_percent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_percent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_percent.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_percent.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_percent.Location = new System.Drawing.Point(6, 6);
            this.button_percent.Margin = new System.Windows.Forms.Padding(1);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(76, 48);
            this.button_percent.TabIndex = 0;
            this.button_percent.Text = "%";
            this.button_percent.UseVisualStyleBackColor = false;
            // 
            // button_CE
            // 
            this.button_CE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_CE.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CE.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_CE.Location = new System.Drawing.Point(84, 6);
            this.button_CE.Margin = new System.Windows.Forms.Padding(1);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(76, 48);
            this.button_CE.TabIndex = 1;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = false;
            // 
            // button_C
            // 
            this.button_C.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_C.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_C.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_C.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_C.Location = new System.Drawing.Point(162, 6);
            this.button_C.Margin = new System.Windows.Forms.Padding(1);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(76, 48);
            this.button_C.TabIndex = 2;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = false;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_back.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_back.Location = new System.Drawing.Point(240, 6);
            this.button_back.Margin = new System.Windows.Forms.Padding(1);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(78, 48);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "⌫";
            this.button_back.UseVisualStyleBackColor = false;
            // 
            // button_recip
            // 
            this.button_recip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_recip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_recip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_recip.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_recip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_recip.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_recip.Location = new System.Drawing.Point(6, 56);
            this.button_recip.Margin = new System.Windows.Forms.Padding(1);
            this.button_recip.Name = "button_recip";
            this.button_recip.Size = new System.Drawing.Size(76, 48);
            this.button_recip.TabIndex = 4;
            this.button_recip.Text = "1/x";
            this.button_recip.UseVisualStyleBackColor = false;
            // 
            // button_square
            // 
            this.button_square.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_square.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_square.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_square.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_square.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_square.Location = new System.Drawing.Point(84, 56);
            this.button_square.Margin = new System.Windows.Forms.Padding(1);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(76, 48);
            this.button_square.TabIndex = 5;
            this.button_square.Text = "x²";
            this.button_square.UseVisualStyleBackColor = false;
            // 
            // button_sqrt
            // 
            this.button_sqrt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_sqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_sqrt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_sqrt.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sqrt.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_sqrt.Location = new System.Drawing.Point(162, 56);
            this.button_sqrt.Margin = new System.Windows.Forms.Padding(1);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(76, 48);
            this.button_sqrt.TabIndex = 6;
            this.button_sqrt.Text = "²√x";
            this.button_sqrt.UseVisualStyleBackColor = false;
            // 
            // button_division
            // 
            this.button_division.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_division.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_division.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_division.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_division.Location = new System.Drawing.Point(240, 56);
            this.button_division.Margin = new System.Windows.Forms.Padding(1);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(78, 48);
            this.button_division.TabIndex = 7;
            this.button_division.Text = "÷";
            this.button_division.UseVisualStyleBackColor = false;
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_7.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_7.Location = new System.Drawing.Point(6, 106);
            this.button_7.Margin = new System.Windows.Forms.Padding(1);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(76, 48);
            this.button_7.TabIndex = 8;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_8.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_8.Location = new System.Drawing.Point(84, 106);
            this.button_8.Margin = new System.Windows.Forms.Padding(1);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(76, 48);
            this.button_8.TabIndex = 9;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_9.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_9.Location = new System.Drawing.Point(162, 106);
            this.button_9.Margin = new System.Windows.Forms.Padding(1);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(76, 48);
            this.button_9.TabIndex = 10;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            // 
            // button_multip
            // 
            this.button_multip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_multip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_multip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_multip.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_multip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multip.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_multip.Location = new System.Drawing.Point(240, 106);
            this.button_multip.Margin = new System.Windows.Forms.Padding(1);
            this.button_multip.Name = "button_multip";
            this.button_multip.Size = new System.Drawing.Size(78, 48);
            this.button_multip.TabIndex = 11;
            this.button_multip.Text = "×";
            this.button_multip.UseVisualStyleBackColor = false;
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_4.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_4.Location = new System.Drawing.Point(6, 156);
            this.button_4.Margin = new System.Windows.Forms.Padding(1);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(76, 48);
            this.button_4.TabIndex = 12;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_5.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_5.Location = new System.Drawing.Point(84, 156);
            this.button_5.Margin = new System.Windows.Forms.Padding(1);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(76, 48);
            this.button_5.TabIndex = 13;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_6.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_6.Location = new System.Drawing.Point(162, 156);
            this.button_6.Margin = new System.Windows.Forms.Padding(1);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(76, 48);
            this.button_6.TabIndex = 14;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            // 
            // button_subtrac
            // 
            this.button_subtrac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_subtrac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_subtrac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_subtrac.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_subtrac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_subtrac.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_subtrac.Location = new System.Drawing.Point(240, 156);
            this.button_subtrac.Margin = new System.Windows.Forms.Padding(1);
            this.button_subtrac.Name = "button_subtrac";
            this.button_subtrac.Size = new System.Drawing.Size(78, 48);
            this.button_subtrac.TabIndex = 15;
            this.button_subtrac.Text = "－";
            this.button_subtrac.UseVisualStyleBackColor = false;
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_1.Location = new System.Drawing.Point(6, 206);
            this.button_1.Margin = new System.Windows.Forms.Padding(1);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(76, 48);
            this.button_1.TabIndex = 16;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_2.Location = new System.Drawing.Point(84, 206);
            this.button_2.Margin = new System.Windows.Forms.Padding(1);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(76, 48);
            this.button_2.TabIndex = 17;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_3.Location = new System.Drawing.Point(162, 206);
            this.button_3.Margin = new System.Windows.Forms.Padding(1);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(76, 48);
            this.button_3.TabIndex = 18;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_add.Location = new System.Drawing.Point(240, 206);
            this.button_add.Margin = new System.Windows.Forms.Padding(1);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(78, 48);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "＋";
            this.button_add.UseVisualStyleBackColor = false;
            // 
            // button_PM
            // 
            this.button_PM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_PM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_PM.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_PM.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_PM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PM.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_PM.Location = new System.Drawing.Point(6, 256);
            this.button_PM.Margin = new System.Windows.Forms.Padding(1);
            this.button_PM.Name = "button_PM";
            this.button_PM.Size = new System.Drawing.Size(76, 50);
            this.button_PM.TabIndex = 20;
            this.button_PM.Text = "+/-";
            this.button_PM.UseVisualStyleBackColor = false;
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_0.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_0.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_0.Location = new System.Drawing.Point(84, 256);
            this.button_0.Margin = new System.Windows.Forms.Padding(1);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(76, 50);
            this.button_0.TabIndex = 21;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            // 
            // button_decipoint
            // 
            this.button_decipoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button_decipoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_decipoint.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_decipoint.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button_decipoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_decipoint.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_decipoint.Location = new System.Drawing.Point(162, 256);
            this.button_decipoint.Margin = new System.Windows.Forms.Padding(1);
            this.button_decipoint.Name = "button_decipoint";
            this.button_decipoint.Size = new System.Drawing.Size(76, 50);
            this.button_decipoint.TabIndex = 22;
            this.button_decipoint.Text = ".";
            this.button_decipoint.UseVisualStyleBackColor = false;
            // 
            // button_equals
            // 
            this.button_equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.button_equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_equals.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_equals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(196)))));
            this.button_equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_equals.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_equals.ForeColor = System.Drawing.Color.White;
            this.button_equals.Location = new System.Drawing.Point(240, 256);
            this.button_equals.Margin = new System.Windows.Forms.Padding(1);
            this.button_equals.Name = "button_equals";
            this.button_equals.Size = new System.Drawing.Size(78, 50);
            this.button_equals.TabIndex = 23;
            this.button_equals.Text = "=";
            this.button_equals.UseVisualStyleBackColor = false;
            // 
            // label_calc
            // 
            this.label_calc.AutoSize = true;
            this.label_calc.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_calc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_calc.Location = new System.Drawing.Point(17, 60);
            this.label_calc.Name = "label_calc";
            this.label_calc.Size = new System.Drawing.Size(54, 19);
            this.label_calc.TabIndex = 6;
            this.label_calc.Text = "계산기";
            this.label_calc.Click += new System.EventHandler(this.label_calc_Click);
            // 
            // tableLayoutPanel_menu_button
            // 
            this.tableLayoutPanel_menu_button.ColumnCount = 1;
            this.tableLayoutPanel_menu_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_menu_button.Controls.Add(this.button_menu_std, 0, 0);
            this.tableLayoutPanel_menu_button.Controls.Add(this.button_menu_sci, 0, 1);
            this.tableLayoutPanel_menu_button.Controls.Add(this.button_menu_prog, 0, 2);
            this.tableLayoutPanel_menu_button.Controls.Add(this.button_menu_date, 0, 3);
            this.tableLayoutPanel_menu_button.Location = new System.Drawing.Point(0, 86);
            this.tableLayoutPanel_menu_button.Name = "tableLayoutPanel_menu_button";
            this.tableLayoutPanel_menu_button.RowCount = 4;
            this.tableLayoutPanel_menu_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_menu_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_menu_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_menu_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel_menu_button.Size = new System.Drawing.Size(220, 160);
            this.tableLayoutPanel_menu_button.TabIndex = 7;
            // 
            // tableLayoutPanel_menu_setting
            // 
            this.tableLayoutPanel_menu_setting.ColumnCount = 1;
            this.tableLayoutPanel_menu_setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_menu_setting.Controls.Add(this.button_menu_setting, 0, 0);
            this.tableLayoutPanel_menu_setting.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel_menu_setting.Location = new System.Drawing.Point(0, 437);
            this.tableLayoutPanel_menu_setting.Name = "tableLayoutPanel_menu_setting";
            this.tableLayoutPanel_menu_setting.RowCount = 1;
            this.tableLayoutPanel_menu_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_menu_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel_menu_setting.Size = new System.Drawing.Size(220, 49);
            this.tableLayoutPanel_menu_setting.TabIndex = 8;
            // 
            // button_menu_setting
            // 
            this.button_menu_setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_menu_setting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.button_menu_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_setting.Image = global::WinCalcPro.Properties.Resources.setting;
            this.button_menu_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_setting.Location = new System.Drawing.Point(3, 3);
            this.button_menu_setting.Name = "button_menu_setting";
            this.button_menu_setting.Padding = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.button_menu_setting.Size = new System.Drawing.Size(214, 43);
            this.button_menu_setting.TabIndex = 0;
            this.button_menu_setting.Text = "    설정";
            this.button_menu_setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menu_setting.UseVisualStyleBackColor = true;
            // 
            // button_menu_std
            // 
            this.button_menu_std.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_menu_std.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.button_menu_std.FlatAppearance.BorderSize = 0;
            this.button_menu_std.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_std.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_menu_std.Image = global::WinCalcPro.Properties.Resources.stdImg;
            this.button_menu_std.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_std.Location = new System.Drawing.Point(3, 3);
            this.button_menu_std.Name = "button_menu_std";
            this.button_menu_std.Padding = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.button_menu_std.Size = new System.Drawing.Size(214, 34);
            this.button_menu_std.TabIndex = 0;
            this.button_menu_std.Text = "    표준";
            this.button_menu_std.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_menu_std.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menu_std.UseVisualStyleBackColor = true;
            // 
            // button_menu_sci
            // 
            this.button_menu_sci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_menu_sci.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.button_menu_sci.FlatAppearance.BorderSize = 0;
            this.button_menu_sci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_sci.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_menu_sci.Image = global::WinCalcPro.Properties.Resources.sci;
            this.button_menu_sci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_sci.Location = new System.Drawing.Point(3, 43);
            this.button_menu_sci.Name = "button_menu_sci";
            this.button_menu_sci.Padding = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.button_menu_sci.Size = new System.Drawing.Size(214, 34);
            this.button_menu_sci.TabIndex = 1;
            this.button_menu_sci.Text = "    공학용";
            this.button_menu_sci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_sci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menu_sci.UseVisualStyleBackColor = true;
            // 
            // button_menu_prog
            // 
            this.button_menu_prog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_menu_prog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.button_menu_prog.FlatAppearance.BorderSize = 0;
            this.button_menu_prog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_prog.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_menu_prog.Image = global::WinCalcPro.Properties.Resources.prog;
            this.button_menu_prog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_prog.Location = new System.Drawing.Point(3, 83);
            this.button_menu_prog.Name = "button_menu_prog";
            this.button_menu_prog.Padding = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.button_menu_prog.Size = new System.Drawing.Size(214, 34);
            this.button_menu_prog.TabIndex = 2;
            this.button_menu_prog.Text = "    프로그래머";
            this.button_menu_prog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_prog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menu_prog.UseVisualStyleBackColor = true;
            // 
            // button_menu_date
            // 
            this.button_menu_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_menu_date.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.button_menu_date.FlatAppearance.BorderSize = 0;
            this.button_menu_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_date.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_menu_date.Image = global::WinCalcPro.Properties.Resources.dateImg;
            this.button_menu_date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_date.Location = new System.Drawing.Point(3, 123);
            this.button_menu_date.Name = "button_menu_date";
            this.button_menu_date.Padding = new System.Windows.Forms.Padding(15, 2, 2, 2);
            this.button_menu_date.Size = new System.Drawing.Size(214, 34);
            this.button_menu_date.TabIndex = 3;
            this.button_menu_date.Text = "    날짜 계산";
            this.button_menu_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_menu_date.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_menu_date.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Image = global::WinCalcPro.Properties.Resources.menuImg;
            this.button_close.Location = new System.Drawing.Point(13, 13);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(35, 35);
            this.button_close.TabIndex = 0;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Visible = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_menu.Image = global::WinCalcPro.Properties.Resources.menuImg;
            this.button_menu.Location = new System.Drawing.Point(13, 13);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(35, 35);
            this.button_menu.TabIndex = 0;
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(324, 501);
            this.Controls.Add(this.tableLayoutPanel_stdcalc_button);
            this.Controls.Add(this.textBox_preview);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.button_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "계산기";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.tableLayoutPanel_stdcalc_button.ResumeLayout(false);
            this.tableLayoutPanel_menu_button.ResumeLayout(false);
            this.tableLayoutPanel_menu_setting.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_preview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_stdcalc_button;
        private System.Windows.Forms.Button button_percent;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_recip;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_multip;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_subtrac;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_PM;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_decipoint;
        private System.Windows.Forms.Button button_equals;
        private System.Windows.Forms.Label label_calc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_menu_button;
        private System.Windows.Forms.Button button_menu_std;
        private System.Windows.Forms.Button button_menu_sci;
        private System.Windows.Forms.Button button_menu_prog;
        private System.Windows.Forms.Button button_menu_date;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_menu_setting;
        private System.Windows.Forms.Button button_menu_setting;
    }
}