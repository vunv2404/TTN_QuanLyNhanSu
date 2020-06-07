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
using TTN_QuanLyNhanSu.DAL;

namespace TTN_QuanLyNhanSu.GUI.KhenThuong
{
    public partial class ThemQuyetDinhKhenThuong : Form
    {

        /// <summary>
        /// 
        /// - Thêm dữ liệu vào các textbox , combox có sãn dữ liệu : Phê duyệt , đang phe duyệt , không phê duyệt
        /// 
        /// - xử lý dư liệu ngày (regex).
        /// 
        /// - khi bấm lưu thì thông báo có muốn thêm .
        /// 
        /// </summary>

        
        public ThemQuyetDinhKhenThuong()
        {
            InitializeComponent();
        }
        KhenThuongBUS khenThuongController = new KhenThuongBUS();
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            if (checkInfo() == true)
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
                        khenThuongController.Insert_1_KhenThuong(khenThuong);
                        
                        MessageBox.Show("---Thành Công---");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("---Thất Bại---");
                    }
                }
            }
        }
        private bool checkInfo()
        {
            string error = "";
            bool checkRegex;
            bool checkAll = true;
            string text = "";
            text = textBoxSoQuyetDinh.Text.Trim();
            if(text!= "")
            {
                checkRegex = Regex.IsMatch(text, "^[0-9]*$");
                if(checkRegex == false)
                {
                    error += " Error: Số quyết định chỉ gồm chữ số";
                    checkAll = false;
                }
                else
                {
                    DataTable dt = DataProvider.Instance.ExecuteQuery($"select * from KhenThuong where SoQuyetDinh = '{text}'");
                    if(dt.Rows.Count > 0)
                    {
                        error += " Error: Số quyết định đã tồn tại";
                        checkAll = false;
                    }    
                }    
            }    
            else
            {
                error += " Error: Số quyết định không được để trống";
                checkAll = false;
            }    
            text = textBoxNgayHieuLuc.Text.Trim();
            if (text != "")
            {

                checkRegex = Regex.IsMatch(text, "^[0-9/]*$");
                DateTime temp;
                bool checkDate = DateTime.TryParse(textBoxNgayHieuLuc.Text, out temp);
                if (checkRegex == false || checkDate == false)
                {
                    error += $"\n Error: Ngày hiệu lực có định dạng dd/mm/yyyy";
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
                    error += $"\n Error: Ngày hết hạn có định dạng dd/mm/yyyy";
                    checkAll = false;
                }
            }
            else
            {
                error += $"\n Error: Ngày hết hạn không được để trống";
                checkAll = false;
            }
            text = textBoxNoiDung.Text.Trim();
            if (text == "")
            {
                error += $"\n Error: Nội dung không được để trống";
                checkAll = false;
            }
            text = textBoxHinhThuc.Text.Trim();
            if (text == "")
            {
                error += $"\n Error: Hình thức không được để trống";
                checkAll = false;
            }
            else if (text.Length > 50)
            {
                error += $"\n Error: Hình thức dài tối đa 50 kí tự";
                checkAll = false;
            }
            text = textBoxSoTien.Text.Trim();
            if (text != "")
            {
                decimal temp;
                bool checkDecimal = Decimal.TryParse(text, out temp);
                if (checkDecimal == false)
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
        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
