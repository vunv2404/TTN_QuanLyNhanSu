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
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.GUI.KyLuat
{
    public partial class ChiTietQuyetDinhKyLuat : Form
    {

        /// <summary>
        /// 
        /// - Xử lý ngày (regex)
        /// 
        /// - trạng thái có 3 trang thái có sẵn.
        /// 
        /// - trước khi lưu thông báo có muốn lưu thay đổi.
        /// 
        /// - Lưu khi có sự thay đổi dữ liệu.
        /// 
        /// </summary>

        public ChiTietQuyetDinhKyLuat()
        {
            InitializeComponent();
        }

        public ChiTietQuyetDinhKyLuat(DTO.KyLuat kyLuat)
        {
            InitializeComponent();
            textBoxSoQuyetDinh.Text = kyLuat.SoQuyetDinh;
            textBoxNgayHieuLuc.Text = kyLuat.NgayHieuLuc.ToString("MM/dd/yyyy");
            textBoxNgayHetHan.Text = kyLuat.NgayHetHan.ToString("MM/dd/yyyy");
            textBoxNoiDung.Text = kyLuat.NoiDung;
            textBoxLiDo.Text = kyLuat.LiDo;
            textBoxHinhThuc.Text = kyLuat.HinhThuc;
            comboBoxTrangThai.Text = kyLuat.TrangThai;
            buttonLuu.Enabled = false;
        }


        private void buttonLuu_Click(object sender, EventArgs e)
        {
            // lưu dữ liệu lại chỗ này này
            switch (MessageBox.Show(this, "Bạn có muốn lưu?", "Lưu dữ liệu", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    buttonLuu.Enabled = false;
                    if (LuuDuLieu())
                    {
                        this.Close();
                    }
                    break;
                default:
                    break;
            }            
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void textBoxDateTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            buttonLuu.Enabled = true;
            DateTimeFiller_KeyPressed(sender as TextBox, e);
        }

        private void textBoxDateTime_TextChanged(object sender, EventArgs e)
        {
            buttonLuu.Enabled = true;
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

        private void textBoxLiDo_TextChanged(object sender, EventArgs e)
        {
            buttonLuu.Enabled = true;
        }

        private void textBoxNoiDung_TextChanged(object sender, EventArgs e)
        {
            buttonLuu.Enabled = true;
        }

        private void textBoxHinhThuc_TextChanged(object sender, EventArgs e)
        {
            buttonLuu.Enabled = true;
        }

        private void comboBoxTrangThai_TextChanged(object sender, EventArgs e)
        {
            buttonLuu.Enabled = true;
        }



        public bool LuuDuLieu()
        {
            if (ValidDateTime(textBoxNgayHieuLuc.Text) && ValidDateTime(textBoxNgayHetHan.Text))
            {
                KyLuatBUS kyLuatBUS = new KyLuatBUS();
                kyLuatBUS.SuaKyLuat(new DTO.KyLuat(textBoxSoQuyetDinh.Text, DateTime.ParseExact(textBoxNgayHieuLuc.Text, "MM/dd/yyyy", null), DateTime.ParseExact(textBoxNgayHetHan.Text, "MM/dd/yyyy", null), textBoxLiDo.Text, textBoxNoiDung.Text, textBoxHinhThuc.Text, comboBoxTrangThai.Text));
                return true;
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ, vui lòng nhập lại ngày theo format Tháng/Ngày/Năm");
                return false;
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
    }
}