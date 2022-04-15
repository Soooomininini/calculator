
namespace Calculator_winform
{
    partial class DivideAlertMessage
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
            this.button1 = new System.Windows.Forms.Button();
            this.AlertMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlertMessage
            // 
            this.AlertMessage.AutoSize = true;
            this.AlertMessage.Location = new System.Drawing.Point(113, 63);
            this.AlertMessage.Name = "AlertMessage";
            this.AlertMessage.Size = new System.Drawing.Size(256, 30);
            this.AlertMessage.TabIndex = 1;
            this.AlertMessage.Text = "0이 아닌 수로 나눠주세요";
            // 
            // DivideAlertMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 293);
            this.Controls.Add(this.AlertMessage);
            this.Controls.Add(this.button1);
            this.Name = "DivideAlertMessage";
            this.Text = "DivideAlertMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AlertMessage;
    }
}