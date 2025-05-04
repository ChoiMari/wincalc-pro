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
            this.panel_header = new System.Windows.Forms.Panel();
            this.button_menu = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_menu_close = new System.Windows.Forms.Button();
            this.panel_hr = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_menu_setting = new System.Windows.Forms.TableLayoutPanel();
            this.button_menu_setting = new System.Windows.Forms.Button();
            this.tableLayoutPanel_menu_button = new System.Windows.Forms.TableLayoutPanel();
            this.button_menu_std = new System.Windows.Forms.Button();
            this.button_menu_sci = new System.Windows.Forms.Button();
            this.button_menu_prog = new System.Windows.Forms.Button();
            this.button_menu_date = new System.Windows.Forms.Button();
            this.label_calc = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.tableLayoutPanel_menu_setting.SuspendLayout();
            this.tableLayoutPanel_menu_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(324, 45);
            this.panel_header.TabIndex = 0;
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_menu.Image = global::WinCalcPro.Properties.Resources.menuImg;
            this.button_menu.Location = new System.Drawing.Point(13, 6);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(35, 35);
            this.button_menu.TabIndex = 7;
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_title.Location = new System.Drawing.Point(55, 10);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(68, 27);
            this.label_title.TabIndex = 8;
            this.label_title.Text = "표준";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel_menu.Controls.Add(this.button_menu_close);
            this.panel_menu.Controls.Add(this.panel_hr);
            this.panel_menu.Controls.Add(this.tableLayoutPanel_menu_setting);
            this.panel_menu.Controls.Add(this.tableLayoutPanel_menu_button);
            this.panel_menu.Controls.Add(this.label_calc);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(0, 501);
            this.panel_menu.TabIndex = 12;
            // 
            // button_menu_close
            // 
            this.button_menu_close.FlatAppearance.BorderSize = 0;
            this.button_menu_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_close.Image = global::WinCalcPro.Properties.Resources.menuImg;
            this.button_menu_close.Location = new System.Drawing.Point(13, 6);
            this.button_menu_close.Name = "button_menu_close";
            this.button_menu_close.Size = new System.Drawing.Size(35, 35);
            this.button_menu_close.TabIndex = 0;
            this.button_menu_close.UseVisualStyleBackColor = true;
            this.button_menu_close.Visible = false;
            this.button_menu_close.Click += new System.EventHandler(this.button_menu_close_Click);
            // 
            // panel_hr
            // 
            this.panel_hr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_hr.Location = new System.Drawing.Point(0, 444);
            this.panel_hr.Name = "panel_hr";
            this.panel_hr.Size = new System.Drawing.Size(220, 1);
            this.panel_hr.TabIndex = 9;
            // 
            // tableLayoutPanel_menu_setting
            // 
            this.tableLayoutPanel_menu_setting.ColumnCount = 1;
            this.tableLayoutPanel_menu_setting.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_menu_setting.Controls.Add(this.button_menu_setting, 0, 0);
            this.tableLayoutPanel_menu_setting.Font = new System.Drawing.Font("함초롬돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLayoutPanel_menu_setting.Location = new System.Drawing.Point(0, 447);
            this.tableLayoutPanel_menu_setting.Name = "tableLayoutPanel_menu_setting";
            this.tableLayoutPanel_menu_setting.RowCount = 1;
            this.tableLayoutPanel_menu_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_menu_setting.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
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
            this.button_menu_std.Click += new System.EventHandler(this.button_menu_std_Click);
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
            this.button_menu_sci.Click += new System.EventHandler(this.button_menu_sci_Click);
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
            // 
            // panel_main
            // 
            this.panel_main.Location = new System.Drawing.Point(0, 46);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(324, 455);
            this.panel_main.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(324, 501);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.tableLayoutPanel_menu_setting.ResumeLayout(false);
            this.tableLayoutPanel_menu_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_menu_close;
        private System.Windows.Forms.Panel panel_hr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_menu_setting;
        private System.Windows.Forms.Button button_menu_setting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_menu_button;
        private System.Windows.Forms.Button button_menu_std;
        private System.Windows.Forms.Button button_menu_sci;
        private System.Windows.Forms.Button button_menu_prog;
        private System.Windows.Forms.Button button_menu_date;
        private System.Windows.Forms.Label label_calc;
        private System.Windows.Forms.Panel panel_main;
    }
}