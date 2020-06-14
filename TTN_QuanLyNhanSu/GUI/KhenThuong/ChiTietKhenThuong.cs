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

namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{
    public partial class ChiTietKhenThuong : Form
    {

        /// <summary>
        /// 
        /// - Ném dữu liệu bên bảng danh sách khên thưởng sang vứt lên các textbox, combobox .
        /// 
        /// - trạng thái có 3 trang thái : phê duyệt , đang phê duyệt , không phê duyệt.
        /// 
        /// - xử lý ngày(regex)
        /// 
        /// - trước khi bấm lưu thông báo có muốn lưu thay đổi.
        /// 
        /// - 
        /// 
        /// </summary>
        KhenThuongBUS khenThuongController = new KhenThuongBUS();
        DTO.KhenThuong khenThuongCu;
        public ChiTietKhenThuong()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if(checkInfo() == true)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin bản ghi ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    { 
                        DTO.KhenThuong khenThuong = new DTO.KhenThuong();
                        khenThuong.SoQuyetDinh = textBoxSoQuyetDinh.Text.Trim();
                        khenThuong.NgayHieuLuc = Convert.ToDateTime(textBoxNgayHieuLuc.Text.Trim());
                        khenThuong.NgayHetHan = Convert.ToDateTime(textBoxNgayHetHan.Text.Trim());
                        khenThuong.NoiDung = textBoxNoiDung.Text.Trim();
                        khenThuong.HinhThuc = textBoxHinhThuc.Text.Trim();
                        khenThuong.SoTien = Convert.ToDecimal(textBoxSoTien.Text.Trim());
                        khenThuong.TrangThai = comboBoxTrangThai.Text.Trim();
                        khenThuongController.Modify_1_KhenThuong(khenThuong);
                        LoadThongTin();
                        MessageBox.Show("---Thành Công---");
                    }
                    catch (Exception)
                {

                    MessageBox.Show("---Thất Bại---");
                }
            }
            }
            
        }

        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadThongTin()
        {
            List<DTO.KhenThuong> khenThuongs = khenThuongController.Show_1_KhenThuong(QuyetDinhKhenThuong.soQuyetDinh);
            if (khenThuongs.Count != 0)
            {
                khenThuongCu = khenThuongs[0];
                textBoxSoQuyetDinh.Text = khenThuongCu.SoQuyetDinh;
                textBoxNgayHieuLuc.Text = khenThuongCu.NgayHieuLuc.ToShortDateString();
                textBoxNgayHetHan.Text = khenThuongCu.NgayHetHan.ToShortDateString();
                textBoxNoiDung.Text = khenThuongCu.NoiDung;
                textBoxHinhThuc.Text = khenThuongCu.HinhThuc;
                textBoxSoTien.Text = khenThuongCu.SoTien.ToString();
                comboBoxTrangThai.Text = khenThuongCu.TrangThai;
            }
        }
        private void ChiTietKhenThuong_Load(object sender, EventArgs e)
        {
            comboBoxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxSoQuyetDinh.Enabled = false;
            buttonLuu.Enabled = false;
            LoadThongTin();
        }

        private void textBoxNgayHieuLuc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSoQuyetDinh.Text.Trim() != khenThuongCu.SoQuyetDinh ||
            textBoxNgayHieuLuc.Text.Trim() != khenThuongCu.NgayHieuLuc.ToShortDateString() ||
            textBoxNgayHetHan.Text.Trim() != khenThuongCu.NgayHetHan.ToShortDateString() ||
            textBoxNoiDung.Text.Trim() != khenThuongCu.NoiDung ||
            textBoxHinhThuc.Text.Trim() != khenThuongCu.HinhThuc ||
            textBoxSoTien.Text.Trim() != khenThuongCu.SoTien.ToString() ||
            comboBoxTrangThai.Text.Trim() != khenThuongCu.TrangThai)
            {
                buttonLuu.Enabled = true;
            }
            else
                buttonLuu.Enabled = false;
        }
        private bool checkInfo()
        {
            string error = "";
            bool checkRegex;
            bool checkAll = true;
            string text = "";
            
            text = textBoxNgayHieuLuc.Text.Trim();
            if (text != "")
            {

                checkRegex = Regex.IsMatch(text, "^[0-9/]*$");
                DateTime temp;
                bool checkDate = DateTime.TryParse(textBoxNgayHieuLuc.Text, out temp);
                if (checkRegex == false || checkDate == false)
                {
                    error += $"\n Error: Ngày hiệu lực có định dạng tháng/ngày/năm: mm/dd/yyyy";
                    checkAll = false;
                }
            }
            else
            {
                error += $"\n Error: Ngày hiệu lực không được để trống";
                checkAll = false;
            }
            text = textBoxNgayHetHan.Text.Trim();
            if (text != "")
            {

                checkRegex = Regex.IsMatch(text, "^[0-9/]*$");
                DateTime temp;
                bool checkDate = DateTime.TryParse(textBoxNgayHetHan.Text, out temp);
                if (checkRegex == false || checkDate == false)
                {
                    error += $"\n Error: Ngày hết hạn có định dạng tháng/ngày/năm: mm/dd/yyyy";
                    checkAll = false;
                }
            }
            else
            {
                error += $"\n Error: Ngày hết hạn không được để trống";
                checkAll = false;
            }
            text = textBoxNoiDung.Text.Trim();
            if(text == "")
            {
                error += $"\n Error: Nội dung không được để trống";
                checkAll = false;
            }
            text = textBoxHinhThuc.Text.Trim();
            if(text == "")
            {
                error += $"\n Error: Hình thức không được để trống";
                checkAll = false;
            }    
            else if(text.Length > 50)
            {
                error += $"\n Error: Hình thức dài tối đa 50 kí tự";
                checkAll = false;
            }
            text = textBoxSoTien.Text.Trim();
            if(text != "")
            {
                decimal temp;
                bool checkDecimal = Decimal.TryParse(text,out temp);
                if(checkDecimal == false)
                {
                    error += $"\n Error: Số tiền sai định dạng";
                    checkAll = false;
                }    
            }
            else
            {
                error += $"\n Error: Số tiền không được để trống";
                checkAll = false;
            }
            if (checkAll == false)
            {
                DialogResult dialogError = MessageBox.Show(error);
            }
            return checkAll;
        }
        private string NonUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
                                            "đ",
                                            "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
                                            "í","ì","ỉ","ĩ","ị",
                                            "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
                                            "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
                                            "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
                                            "d",
                                            "e","e","e","e","e","e","e","e","e","e","e",
                                            "i","i","i","i","i",
                                            "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
                                            "u","u","u","u","u","u","u","u","u","u","u",
                                            "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
    }
}
