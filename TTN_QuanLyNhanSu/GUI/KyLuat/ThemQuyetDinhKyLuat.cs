using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.BUS;

namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    public partial class ThemQuyetDinhKyLuat : Form
    {

        /// <summary>
        /// 
        /// - xử Lý ngày (regex)
        /// 
        /// - Trạng thái có 3 trạng thái đã được thêm sẵn.
        /// 
        /// - thông báo có muốn thêm trước khi lưu thay đổi
        /// 
        /// </summary>

        public ThemQuyetDinhKyLuat()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (LuuDuLieu())
            {
                this.Close();
            }
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Cách hàm xử lý datetime
        private void textBoxDateTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            DateTimeFiller_KeyPressed(sender as TextBox, e);
        }

        private void textBoxDateTime_TextChanged(object sender, EventArgs e)
        {
            DateTimeFiller_TextChanged(sender as TextBox);
        }

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

        public bool ValidDateTime(string x)
        {
            DateTime temp;
            if (DateTime.TryParse(x, out temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //
        private void textBoxSoQuyetDinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBoxSoQuyetDinh.Text.Length == 10 && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            if (buttonLuu.Enabled)
            {
                switch (MessageBox.Show(this, "Thông tin đã bị thay đổi, bạn có muốn lưu lại ?", "Đóng cửa sổ", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        if (!LuuDuLieu())
                        {
                            e.Cancel = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public bool LuuDuLieu()
        {
            if(textBoxSoQuyetDinh.Text.Length == 0)
            {
                MessageBox.Show("Số quyết định không hợp lệ");
                return false;
            }    
            if (ValidDateTime(textBoxNgayHieuLuc.Text) && ValidDateTime(textBoxNgayHetHan.Text))
            {
                KyLuatBUS kyLuatBUS = new KyLuatBUS();
                kyLuatBUS.ThemKyLuat(new DTO.KyLuat(textBoxSoQuyetDinh.Text, DateTime.ParseExact(textBoxNgayHieuLuc.Text, "MM/dd/yyyy", null), DateTime.ParseExact(textBoxNgayHetHan.Text, "MM/dd/yyyy", null), textBoxLiDo.Text, textBoxNoiDung.Text, textBoxHinhThuc.Text, comboBoxTrangThai.Text));
                return true;
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ, vui lòng nhập lại ngày theo format Tháng/Ngày/Năm");
                return false;
            }
        }

    }
}
