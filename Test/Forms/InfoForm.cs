using System;
using System.IO;
using System.Windows.Forms;

namespace Test.Forms
{
    public partial class InfoForm : Form
    {
        public InfoForm(string title, string path)
        {
            InitializeComponent();

            lbAppTitle.Text = title;

            if (File.Exists(path))
            {
                richTextBox.LoadFile(path);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            panelTop.Capture = false;
            lbAppTitle.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}