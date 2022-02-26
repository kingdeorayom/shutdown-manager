using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shutdown_Timer
{
    public partial class form_help : Form
    {
        public form_help()
        {
            InitializeComponent();
        }

        private void button_copyToClipBoard_Click(object sender, EventArgs e)
        {
            string mailAddress = "kingdeorayom@gmail.com";

            Clipboard.SetText(mailAddress);
        }
    }
}
