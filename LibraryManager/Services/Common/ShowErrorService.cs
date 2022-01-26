namespace LibraryManager.Services.Common
{
    using System;

    using System.Windows.Forms;

    public class ShowErrorService : IShowErrorService
    {
        private readonly TextBox textBox;
        private readonly Timer timer;

        public ShowErrorService(TextBox textBox, Timer timer)
        {
            this.textBox = textBox;
            this.timer = timer;
        }

        public void Show(int milisecods, string message)
        {
            SetTimer(milisecods);
            ShowTextBox(message);
        }

        private void SetTimer(int miliseconds)
        {
            this.timer.Stop();
            this.timer.Interval = (miliseconds);
            this.timer.Tick += new EventHandler(ClearTextBox);
            this.timer.Start();
        }

        private void ShowTextBox(string message)
        {
            this.textBox.Visible = true;
            this.textBox.ForeColor = System.Drawing.Color.Red;
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Text = message;
        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            this.textBox.Text = String.Empty;
            this.textBox.Visible = false;
        }
    }
}
