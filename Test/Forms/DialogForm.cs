using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test
{
    public partial class DialogForm : Form
    {
        public DialogForm(string text, string head = "Уведомление", TypeButton typeButton = TypeButton.OK)
        {
            InitializeComponent();
            lbHead.Text = head;
            switch (typeButton)
            {
                case TypeButton.OK:
                    var btn = CreateBtn("ОК", BtnOk_Click);
                    tableLayoutPanelButtons.Controls.Add(btn, 3, 0);
                    break;

                case TypeButton.YesAllNoAll:
                    var yes = CreateBtn("Да", BtnYes_Click);
                    var no = CreateBtn("Нет", BtnNo_Click);
                    var yesAll = CreateBtn("Да для всех", BtnYesAll_Click);
                    var noAll = CreateBtn("Нет для всех", BtnNoAll_Click);
                    tableLayoutPanelButtons.Controls.Add(yesAll, 0, 0);
                    tableLayoutPanelButtons.Controls.Add(noAll, 1, 0);
                    tableLayoutPanelButtons.Controls.Add(yes, 2, 0);
                    tableLayoutPanelButtons.Controls.Add(no, 3, 0);
                    break;

                default:
                    var yesBtn = CreateBtn("Да", BtnYes_Click);
                    var noBtn = CreateBtn("Нет", BtnNo_Click);
                    tableLayoutPanelButtons.Controls.Add(yesBtn, 2, 0);
                    tableLayoutPanelButtons.Controls.Add(noBtn, 3, 0);
                    break;
            }
            lbText.Text = text;
        }

        private Button CreateBtn(string text, EventHandler eventHandler)
        {
            var button = new Button
            {
                Text = text,
                AutoSize = true,
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(242, 109, 228),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                TabIndex = 16,
                UseVisualStyleBackColor = false
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += eventHandler;
            return button;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void BtnYesAll_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void BtnNoAll_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            panelTop.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

    public enum TypeButton : byte
    {
        OK = 1,
        YesNo,
        YesAllNoAll
    }
}