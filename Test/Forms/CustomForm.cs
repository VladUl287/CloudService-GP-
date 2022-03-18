using System;
using System.Windows.Forms;
using Test.Validation;

namespace Test.Forms
{
    public partial class CustomForm : Form
    {
        public CustomForm()
        {
            InitializeComponent();

            timer.Tick += Timer_Elapsed;
            timer.Start();
        }

        private void CustomForm_Load(object sender, EventArgs e)
        {
            Timer_Elapsed(null, null);
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            if (!InternetConnetion.Check())
            {
                pbConnectionCheck.BackgroundImage = Properties.Resources.iconsNotconnect;
            }
            else
            {
                pbConnectionCheck.BackgroundImage = Properties.Resources.iconConnect;
            }
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            panelTop.Capture = false;
            lbAppTitle.Capture = false;
            pictureBoxLogo.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        protected virtual void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}