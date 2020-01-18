using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushCounter
{
    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            counter += 1;
            counterLabel.Text = string.Format("{0} times", counter);

            if (counter > 0)
            {
                resetButton.Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        { 

            counter = 0;
            counterLabel.Text = string.Format("{0} times", counter);
            resetButton.Enabled = false;
        }
    }
}
