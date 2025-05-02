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
            this.input_number = new System.Windows.Forms.TextBox();
            this.Pi = new System.Windows.Forms.Button();
            this.nd2 = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.sec = new System.Windows.Forms.Button();
            this.hyp = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.cot = new System.Windows.Forms.Button();
            this.csc = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_number
            // 
            this.input_number.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.input_number.Location = new System.Drawing.Point(12, 12);
            this.input_number.Name = "input_number";
            this.input_number.Size = new System.Drawing.Size(539, 42);
            this.input_number.TabIndex = 0;
            // 
            // Pi
            // 
            this.Pi.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Pi.Location = new System.Drawing.Point(12, 192);
            this.Pi.Name = "Pi";
            this.Pi.Size = new System.Drawing.Size(52, 55);
            this.Pi.TabIndex = 1;
            this.Pi.Text = "π ";
            this.Pi.UseVisualStyleBackColor = true;
            // 
            // nd2
            // 
            this.nd2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nd2.Location = new System.Drawing.Point(12, 60);
            this.nd2.Name = "nd2";
            this.nd2.Size = new System.Drawing.Size(52, 55);
            this.nd2.TabIndex = 2;
            this.nd2.Text = "2nd";
            this.nd2.UseVisualStyleBackColor = true;
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sin.Location = new System.Drawing.Point(70, 60);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(52, 55);
            this.sin.TabIndex = 3;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // sec
            // 
            this.sec.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sec.Location = new System.Drawing.Point(70, 121);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(52, 55);
            this.sec.TabIndex = 4;
            this.sec.Text = "sec";
            this.sec.UseVisualStyleBackColor = true;
            // 
            // hyp
            // 
            this.hyp.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hyp.Location = new System.Drawing.Point(12, 121);
            this.hyp.Name = "hyp";
            this.hyp.Size = new System.Drawing.Size(52, 55);
            this.hyp.TabIndex = 5;
            this.hyp.Text = "hyp";
            this.hyp.UseVisualStyleBackColor = true;
            // 
            // tan
            // 
            this.tan.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tan.Location = new System.Drawing.Point(186, 60);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(52, 55);
            this.tan.TabIndex = 6;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cos.Location = new System.Drawing.Point(128, 60);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(52, 55);
            this.cos.TabIndex = 7;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            // 
            // cot
            // 
            this.cot.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cot.Location = new System.Drawing.Point(186, 121);
            this.cot.Name = "cot";
            this.cot.Size = new System.Drawing.Size(52, 55);
            this.cot.TabIndex = 8;
            this.cot.Text = "cot";
            this.cot.UseVisualStyleBackColor = true;
            // 
            // csc
            // 
            this.csc.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.csc.Location = new System.Drawing.Point(128, 121);
            this.csc.Name = "csc";
            this.csc.Size = new System.Drawing.Size(52, 55);
            this.csc.TabIndex = 9;
            this.csc.Text = "csc";
            this.csc.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delete.Location = new System.Drawing.Point(244, 60);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(52, 55);
            this.delete.TabIndex = 10;
            this.delete.Text = "<-";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.csc);
            this.Controls.Add(this.cot);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.hyp);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.nd2);
            this.Controls.Add(this.Pi);
            this.Controls.Add(this.input_number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_number;
        private System.Windows.Forms.Button Pi;
        private System.Windows.Forms.Button nd2;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button sec;
        private System.Windows.Forms.Button hyp;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button cot;
        private System.Windows.Forms.Button csc;
        private System.Windows.Forms.Button delete;
    }
}

