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
    public partial class ThemKhoaHoc : Form
    {
        /// <summary>
        /// 
        /// - xử lý ngày lập .
        /// - trước khi thêm tạo thông báo có chắc chắn thêm
        /// 
        /// </summary>
        Utility utility;
        public ThemKhoaHoc()
        {
            InitializeComponent();
            utility = new Utility();
            buttonLuu.Enabled = false;
            textBoxNgayLap.TextChanged += textBoxNgayLap_TextChanged;
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(LuuDuLieu())
            {
                buttonLuu.Enabled = false;
                this.Close();
            }    
        }

        private void textBoxNgayLap_TextChanged(object sender, EventArgs e)
        {
            utility.DateTimeFiller_TextChanged(sender as TextBox);
        }

        private void textBoxNgayLap_KeyPress(object sender, KeyPressEventArgs e)
        {
            utility.DateTimeFiller_KeyPressed(sender as TextBox, e);
        }

        public void buttonLuuEnable(object sender, EventArgs e)
        {
            buttonLuu.Enabled = true;
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
            if (textBoxMaDaoTao.Text.Length == 0)
            {
                MessageBox.Show("Số quyết định không hợp lệ");
                return false;
            }
            if (ValidDateTime(textBoxNgayLap.Text))
            {
                DaoTaoBUS daoTaoBUS = new DaoTaoBUS();
                if( daoTaoBUS.ThemDaoTao(new DTO.DaoTao(textBoxMaDaoTao.Text,DateTime.Parse(textBoxNgayLap.Text),textBoxMucDich.Text, Int32.Parse(textBoxSoLuong.Text), textBoxNguoiPhuTrach.Text, decimal.Parse(textBoxChiPhi.Text), comboBoxTinhTrang.Text)))
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
