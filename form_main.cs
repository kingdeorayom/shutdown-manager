using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Shutdown_Timer
{
    public partial class form_main : Form
    {

        int timeValue = 0;

        string processName = "shutdown"; //name of process found in C:\Windows\System32
        string parameterContent = "/s /t"; //the parameters for executing the shutdown process. "/s" argument to shutdown and "/t" to wait for x seconds before shutting down

        public form_main()
        {
            InitializeComponent();
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            comboBox_quickAccess.SelectedIndex = 0; //sets first item in dropdown collection selected as default when the form loads
            this.ActiveControl = textBox_toTime;
        }

        private void button_initiate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_toTime.Text)) //checks if textbox is empty
            {
                MessageBox.Show("Time input not found", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error); //shows error when start button is pressed while textbox is empty
            }

            else
            {
                if(checkBox_restartOrNot.Checked == true)
                {
                    parameterContent = "/r /t " + textBox_toTime.Text; //adds the content of textbox to the string content
                    System.Diagnostics.Process.Start(processName, parameterContent); //executes the process together with its parameters

                    Application.Exit(); //stops the application process
                }

                else
                {
                    parameterContent = "/s /t " + textBox_toTime.Text; //adds the content of textbox
                    System.Diagnostics.Process.Start(processName, parameterContent); //executes the process together with its parameters

                    Application.Exit(); //stops the application process
                }
            }
        }

        //KeyPress is an event that occurs when the control has focus and the user presses and releases a key
        private void textBox_toTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //this condition allows only numerical values to be entered in textbox
            {
                e.Handled = true;
            }
        }

        private void comboBox_quickAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_quickAccess.SelectedIndex == 0)
            {
                textBox_toTime.Text = "60"; //1 minute to seconds
            }

            else if(comboBox_quickAccess.SelectedIndex == 1)
            {
                textBox_toTime.Text = "120"; //2 minutes to seconds
            }

            else if (comboBox_quickAccess.SelectedIndex == 2)
            {
                textBox_toTime.Text = "300"; //5 minutes to seconds
            }

            else if (comboBox_quickAccess.SelectedIndex == 3)
            {
                textBox_toTime.Text = "600"; //10 minutes to seconds
            }

            else if (comboBox_quickAccess.SelectedIndex == 4)
            {
                textBox_toTime.Text = "900"; //15 minutes to seconds
            }

            else if (comboBox_quickAccess.SelectedIndex == 5)
            {
                textBox_toTime.Text = "1800"; //30 minutes to seconds
            }

            else if (comboBox_quickAccess.SelectedIndex == 6)
            {
                textBox_toTime.Text = "3600"; //1 hour to seconds
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart(); //restarts the application process
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //stops the application process
        }

        private void textBox_toEnteredTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //this condition allows only numerical values to be entered in textbox
            {
                e.Handled = true;
            }
        }

        private void button_convert_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox_EnteredTime.Text))
            {
                MessageBox.Show("Time input not found", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows error when convert button is pressed while textbox is empty
            }

            else
            {
                try
                {
                    if (radioButton_minute.Checked == true)
                    {
                        timeValue = Int32.Parse(textBox_EnteredTime.Text);
                        timeValue = timeValue * 60; //convert minute to second
                        textBox_toSecond.Text = timeValue.ToString(); //pass the value to the textbox containing converted time
                    }

                    else if (radioButton_hour.Checked == true)
                    {
                        timeValue = Int32.Parse(textBox_EnteredTime.Text);
                        timeValue = timeValue * 3600; //convert hour to second
                        textBox_toSecond.Text = timeValue.ToString(); //pass the value to the textbox containing converted time
                    }

                    else if (radioButton_day.Checked == true)
                    {
                        timeValue = Int32.Parse(textBox_EnteredTime.Text);
                        timeValue = timeValue * 86400; //convert day to second
                        textBox_toSecond.Text = timeValue.ToString(); //pass the value to the textbox containing converted time
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Time input not found", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows error when convert button is pressed while textbox is empty
                }
            }
        }

        private void aboutShutdownTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_about about_form = new form_about();
            about_form.ShowDialog(); //opens about form
        }

        private void textBox_toSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //prevents any character input to the textbox
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_feedback feedback_form = new form_feedback();
            feedback_form.ShowDialog(); //opens feedback form
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_help help_form = new form_help();
            help_form.ShowDialog(); //opens help form
        }
    }
}
