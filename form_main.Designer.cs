
namespace Shutdown_Timer
{
    partial class form_main
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
            this.button_initiate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_toTime = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutShutdownTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_quickAccess = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_restartOrNot = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_toSecond = new System.Windows.Forms.TextBox();
            this.radioButton_day = new System.Windows.Forms.RadioButton();
            this.radioButton_hour = new System.Windows.Forms.RadioButton();
            this.radioButton_minute = new System.Windows.Forms.RadioButton();
            this.button_convert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_EnteredTime = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_initiate
            // 
            this.button_initiate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_initiate.Location = new System.Drawing.Point(190, 87);
            this.button_initiate.Name = "button_initiate";
            this.button_initiate.Size = new System.Drawing.Size(84, 31);
            this.button_initiate.TabIndex = 0;
            this.button_initiate.Text = "Initiate";
            this.button_initiate.UseVisualStyleBackColor = true;
            this.button_initiate.Click += new System.EventHandler(this.button_initiate_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the time in seconds:";
            // 
            // textBox_toTime
            // 
            this.textBox_toTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_toTime.Location = new System.Drawing.Point(11, 56);
            this.textBox_toTime.Name = "textBox_toTime";
            this.textBox_toTime.Size = new System.Drawing.Size(172, 23);
            this.textBox_toTime.TabIndex = 2;
            this.textBox_toTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_toTime_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(287, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendFeedbackToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutShutdownTimerToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            this.sendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.sendFeedbackToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // aboutShutdownTimerToolStripMenuItem
            // 
            this.aboutShutdownTimerToolStripMenuItem.Name = "aboutShutdownTimerToolStripMenuItem";
            this.aboutShutdownTimerToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.aboutShutdownTimerToolStripMenuItem.Text = "About Shutdown Timer...";
            this.aboutShutdownTimerToolStripMenuItem.Click += new System.EventHandler(this.aboutShutdownTimerToolStripMenuItem_Click);
            // 
            // comboBox_quickAccess
            // 
            this.comboBox_quickAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_quickAccess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_quickAccess.FormattingEnabled = true;
            this.comboBox_quickAccess.Items.AddRange(new object[] {
            "1 Minute",
            "2 Minutes",
            "5 Minutes",
            "10 Minutes",
            "15 Minutes",
            "30 Minutes",
            "1 Hour"});
            this.comboBox_quickAccess.Location = new System.Drawing.Point(190, 56);
            this.comboBox_quickAccess.Name = "comboBox_quickAccess";
            this.comboBox_quickAccess.Size = new System.Drawing.Size(84, 23);
            this.comboBox_quickAccess.TabIndex = 5;
            this.comboBox_quickAccess.SelectedIndexChanged += new System.EventHandler(this.comboBox_quickAccess_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quick access";
            // 
            // checkBox_restartOrNot
            // 
            this.checkBox_restartOrNot.AutoSize = true;
            this.checkBox_restartOrNot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkBox_restartOrNot.Location = new System.Drawing.Point(14, 94);
            this.checkBox_restartOrNot.Name = "checkBox_restartOrNot";
            this.checkBox_restartOrNot.Size = new System.Drawing.Size(173, 19);
            this.checkBox_restartOrNot.TabIndex = 7;
            this.checkBox_restartOrNot.Text = "Restart instead of shutdown";
            this.checkBox_restartOrNot.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_toSecond);
            this.groupBox1.Controls.Add(this.radioButton_day);
            this.groupBox1.Controls.Add(this.radioButton_hour);
            this.groupBox1.Controls.Add(this.radioButton_minute);
            this.groupBox1.Controls.Add(this.button_convert);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_EnteredTime);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.Location = new System.Drawing.Point(9, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 113);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert to seconds";
            // 
            // textBox_toSecond
            // 
            this.textBox_toSecond.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_toSecond.Location = new System.Drawing.Point(144, 31);
            this.textBox_toSecond.MaxLength = 10;
            this.textBox_toSecond.Name = "textBox_toSecond";
            this.textBox_toSecond.Size = new System.Drawing.Size(120, 23);
            this.textBox_toSecond.TabIndex = 26;
            this.textBox_toSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_toSecond_KeyPress);
            // 
            // radioButton_day
            // 
            this.radioButton_day.AutoSize = true;
            this.radioButton_day.Location = new System.Drawing.Point(127, 74);
            this.radioButton_day.Name = "radioButton_day";
            this.radioButton_day.Size = new System.Drawing.Size(45, 19);
            this.radioButton_day.TabIndex = 25;
            this.radioButton_day.TabStop = true;
            this.radioButton_day.Text = "Day";
            this.radioButton_day.UseVisualStyleBackColor = true;
            // 
            // radioButton_hour
            // 
            this.radioButton_hour.AutoSize = true;
            this.radioButton_hour.Location = new System.Drawing.Point(71, 74);
            this.radioButton_hour.Name = "radioButton_hour";
            this.radioButton_hour.Size = new System.Drawing.Size(52, 19);
            this.radioButton_hour.TabIndex = 24;
            this.radioButton_hour.TabStop = true;
            this.radioButton_hour.Text = "Hour";
            this.radioButton_hour.UseVisualStyleBackColor = true;
            // 
            // radioButton_minute
            // 
            this.radioButton_minute.AutoSize = true;
            this.radioButton_minute.Location = new System.Drawing.Point(6, 74);
            this.radioButton_minute.Name = "radioButton_minute";
            this.radioButton_minute.Size = new System.Drawing.Size(63, 19);
            this.radioButton_minute.TabIndex = 23;
            this.radioButton_minute.TabStop = true;
            this.radioButton_minute.Text = "Minute";
            this.radioButton_minute.UseVisualStyleBackColor = true;
            // 
            // button_convert
            // 
            this.button_convert.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_convert.Location = new System.Drawing.Point(181, 68);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(83, 31);
            this.button_convert.TabIndex = 22;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "=";
            // 
            // textBox_EnteredTime
            // 
            this.textBox_EnteredTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_EnteredTime.Location = new System.Drawing.Point(7, 31);
            this.textBox_EnteredTime.MaxLength = 10;
            this.textBox_EnteredTime.Name = "textBox_EnteredTime";
            this.textBox_EnteredTime.Size = new System.Drawing.Size(107, 23);
            this.textBox_EnteredTime.TabIndex = 18;
            this.textBox_EnteredTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_toEnteredTime_KeyPress);
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_restartOrNot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_quickAccess);
            this.Controls.Add(this.textBox_toTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_initiate);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Timer";
            this.Load += new System.EventHandler(this.form_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_initiate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_toTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutShutdownTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox comboBox_quickAccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_restartOrNot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_day;
        private System.Windows.Forms.RadioButton radioButton_hour;
        private System.Windows.Forms.RadioButton radioButton_minute;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_EnteredTime;
        private System.Windows.Forms.TextBox textBox_toSecond;
    }
}

