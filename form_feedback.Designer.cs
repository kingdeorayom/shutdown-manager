
namespace Shutdown_Timer
{
    partial class form_feedback
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.button_copyToClipBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "For feedback and suggestions, send me an e-mail at:";
            // 
            // label_Email
            // 
            this.label_Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.Color.Black;
            this.label_Email.Location = new System.Drawing.Point(12, 56);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(158, 18);
            this.label_Email.TabIndex = 3;
            this.label_Email.Text = "kingdeorayom@gmail.com";
            // 
            // button_copyToClipBoard
            // 
            this.button_copyToClipBoard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_copyToClipBoard.Location = new System.Drawing.Point(15, 90);
            this.button_copyToClipBoard.Name = "button_copyToClipBoard";
            this.button_copyToClipBoard.Size = new System.Drawing.Size(233, 31);
            this.button_copyToClipBoard.TabIndex = 4;
            this.button_copyToClipBoard.Text = "Copy to clipboard";
            this.button_copyToClipBoard.UseVisualStyleBackColor = true;
            this.button_copyToClipBoard.Click += new System.EventHandler(this.button_copyToClipBoard_Click);
            // 
            // form_feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 133);
            this.Controls.Add(this.button_copyToClipBoard);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send Feedback";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Button button_copyToClipBoard;
    }
}