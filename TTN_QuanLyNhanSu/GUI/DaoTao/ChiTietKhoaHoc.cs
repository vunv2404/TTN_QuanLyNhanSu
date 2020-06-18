using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTN_QuanLyNhanSu.BUS;
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.GUI.DaoTao
{
    public partial class ChiTietKhoaHoc : Form
    {

        /// <summary>
        /// - Đưa dữ liệu từ bảng danh sách khóa học đào tạo sang ném lên các ô textbox
        /// 
        /// - Khi Có sự thay đổi dữ liệu thì nút cập nhật mưới hiện lên
        /// 
        /// - trước khi cập nhật kiểm tra xử lí dữ liệu.
        /// 
        /// - xử lí ngày nhập nếu có cập nhật dữ liệu
        /// 
        /// - TRước khi cập nhật tạo thông báo có muốn cập nhật
        /// 
        /// </summary>
        Utility utility;
        public ChiTietKhoaHoc()
        {
            InitializeComponent();
            utility = new Utility();
            textBoxNgayLap.TextChanged += TextBoxNgayLap_TextChanged;
            textBoxNgayLap.KeyPress += TextBoxNgayLap_KeyPress;
        }

        public ChiTietKhoaHoc(DTO.DaoTao daoTao)
        {
            InitializeComponent();
            utility = new Utility();
            textBoxNgayLap.TextChanged += TextBoxNgayLap_TextChanged;
            textBoxNgayLap.KeyPress += TextBoxNgayLap_KeyPress;
            textBoxMaKhoaHoc.Text = daoTao.MaDaoTao;
            textBoxNgayLap.Text = daoTao.NgayLap.ToString("MM/dd/yyyy");
            textBoxMucDich.Text = daoTao.MucDich;
            textBoxSoLuong.Text = daoTao.SoLuong.ToString();
            textBoxNguoiPhuTrach.Text = daoTao.NguoiPhuTrach;
            textBoxChiPhi.Text = daoTao.ChiPhi.ToString();
            comboBoxTinhTrang.Text = daoTao.TrangThai;
            buttonCapNhat.Enabled = false;
        }


        private void TextBoxNgayLap_KeyPress(object sender, KeyPressEventArgs e)
        {
            utility.DateTimeFiller_KeyPressed(sender as TextBox, e);
        }

        private void TextBoxNgayLap_TextChanged(object sender, EventArgs e)
        {
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (LuuDuLieu())
            {
                buttonCapNhat.Enabled = false;
                this.Close();
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonCapNhapEnable(object sender, EventArgs e)
        {
            buttonCapNhat.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            if (buttonCapNhat.Enabled)
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
            if (textBoxMaKhoaHoc.Text.Length == 0)
            {
                MessageBox.Show("Số quyết định không hợp lệ");
                return false;
            }
            if (ValidDateTime(textBoxNgayLap.Text))
            {
                DaoTaoBUS daoTaoBUS = new DaoTaoBUS();
                if (daoTaoBUS.SuaDaoTao(new DTO.DaoTao(textBoxMaKhoaHoc.Text, DateTime.Parse(textBoxNgayLap.Text), textBoxMucDich.Text, Int32.Parse(textBoxSoLuong.Text), textBoxNguoiPhuTrach.Text, decimal.Parse(textBoxChiPhi.Text), comboBoxTinhTrang.Text)))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Không thể thêm mới khoá học");
                    return false;
                }
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
    }
}
