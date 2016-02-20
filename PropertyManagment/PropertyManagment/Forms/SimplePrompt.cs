using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyManagment
{
    public partial class SimplePrompt : Form
    {
        public SimplePrompt(string text,string title,string button1Text="",string button2Text="")
        {
            InitializeComponent();
            label1.Text = text;
            Text = title;
            button1.Text = button1Text;
            button2.Text = button2Text;
            if (button1Text == "")
            { button1.Visible = false; }
            if (button2Text == "")
            { button2.Visible = false; }
        }

        private void SimplePrompt_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            { DialogResult = DialogResult.Cancel; }
        }
    }
}
