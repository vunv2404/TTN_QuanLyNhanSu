using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TTN_QuanLyNhanSu.DTO
{
    class Utility
    {
        //loại datetime
        public void DateTimeFiller_TextChanged(TextBox tb)
        {
            if (tb.Text.Length == 2 && Regex.IsMatch(tb.Text.Substring(0, 2), @"^[0-9]+$") && tb.Text.Length < 3)
            {

                tb.Text += "/";
                tb.SelectionStart = tb.Text.Length;
                tb.SelectionLength = 0;
            }
            if (tb.Text.Length == 5 && Regex.IsMatch(tb.Text.Substring(3, 2), @"^[0-9]+$"))
            {
                tb.Text += "/";
                tb.SelectionStart = tb.Text.Length;
                tb.SelectionLength = 0;
            }
        }

        private void DateTimeFiller_KeyPressed(TextBox tb, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (tb.Text.Length == 3 && e.KeyChar == '\b')
            {
                tb.Text = tb.Text.Remove(1, 1);
                tb.SelectionStart = tb.Text.Length;
                tb.SelectionLength = 0;
            }
            if (tb.Text.Length == 6 && e.KeyChar == '\b')
            {
                tb.Text = tb.Text.Remove(4, 1);
                tb.SelectionStart = tb.Text.Length;
                tb.SelectionLength = 0;
            }
            if (tb.Text.Length == 10 && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
