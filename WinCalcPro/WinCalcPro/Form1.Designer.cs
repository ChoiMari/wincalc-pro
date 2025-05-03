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
            this.button_close = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel_menu.Controls.Add(this.button_close);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(0, 501);
            this.panel_menu.TabIndex = 1;
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
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.button_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "계산기";
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_close;
    }
}