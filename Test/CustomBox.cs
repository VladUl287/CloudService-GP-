using System;
using System.Windows.Forms;

namespace Test.Logic
{
    public static class CustomBox
    {
        public static void Show(string text, string head = "Уведомление", TypeButton typeButton = TypeButton.OK)
        {
            var form = new DialogForm(text, head, typeButton);
            form.ShowDialog();
        }

        public static DialogResult ShowDialog(string text, string head = "Уведомление", TypeButton typeBtn = TypeButton.OK)
        {
            return (DialogResult)Application.OpenForms[0].Invoke(new Func<DialogResult>(() =>
            {
                var form = new DialogForm(text, head, typeBtn);
                return form.ShowDialog();
            }));
        }

        public static DialogResult ShowDialog(Form parent, string text, string head = "Уведомление", TypeButton typeBtn = TypeButton.OK)
        {
            return (DialogResult)parent.Invoke(new Func<DialogResult>(() =>
            {
                var form = new DialogForm(text, head, typeBtn);
                return form.ShowDialog();
            }));
        }
    }
}