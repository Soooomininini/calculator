
namespace Calculator_winform
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.intLabel_1 = new System.Windows.Forms.Label();
            this.intLabel_2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.multipleBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intLabel_1
            // 
            this.intLabel_1.AutoSize = true;
            this.intLabel_1.Location = new System.Drawing.Point(83, 126);
            this.intLabel_1.Name = "intLabel_1";
            this.intLabel_1.Size = new System.Drawing.Size(135, 30);
            this.intLabel_1.TabIndex = 0;
            this.intLabel_1.Text = "First Number";
            // 
            // intLabel_2
            // 
            this.intLabel_2.AutoSize = true;
            this.intLabel_2.Location = new System.Drawing.Point(51, 197);
            this.intLabel_2.Name = "intLabel_2";
            this.intLabel_2.Size = new System.Drawing.Size(167, 30);
            this.intLabel_2.TabIndex = 1;
            this.intLabel_2.Text = "Second Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 35);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 35);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 360);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 35);
            this.textBox3.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(111, 365);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(70, 30);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(522, 121);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(181, 119);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateBtn_click);
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusBtn.Location = new System.Drawing.Point(51, 263);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(64, 77);
            this.plusBtn.TabIndex = 7;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusBtn.Location = new System.Drawing.Point(167, 263);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(64, 77);
            this.minusBtn.TabIndex = 8;
            this.minusBtn.Text = "-";
            this.minusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // multipleBtn
            // 
            this.multipleBtn.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multipleBtn.Location = new System.Drawing.Point(291, 263);
            this.multipleBtn.Name = "multipleBtn";
            this.multipleBtn.Size = new System.Drawing.Size(64, 77);
            this.multipleBtn.TabIndex = 9;
            this.multipleBtn.Text = "x";
            this.multipleBtn.UseVisualStyleBackColor = true;
            this.multipleBtn.Click += new System.EventHandler(this.multipleBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divideBtn.Location = new System.Drawing.Point(415, 263);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(64, 77);
            this.divideBtn.TabIndex = 10;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(522, 276);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(181, 50);
            this.resetBtn.TabIndex = 11;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.divideBtn);
            this.Controls.Add(this.multipleBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.intLabel_2);
            this.Controls.Add(this.intLabel_1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intLabel_1;
        private System.Windows.Forms.Label intLabel_2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button multipleBtn;
        private System.Windows.Forms.Button divideBtn;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button resetBtn;
    }
}

