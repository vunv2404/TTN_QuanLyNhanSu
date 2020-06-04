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

namespace TTN_QuanLyNhanSu.GUI.BaoHiem
{
    public partial class ThemBaoHiem : Form
    {
        public ThemBaoHiem()
        {
            InitializeComponent();
        }
        /**
            - Đưa dữ liệu từ database lên combobox Mã nhân viên.

            - Textbox tên nhân viên sẽ hiển thị tên nhân viên đồng bộ dữ liệu theo combobox mã nhân viên.

            - Xử lí ngày cấp Convert dạng string.

            - Thêm Bảo hiểm cho 1 nhân viên.

            - Khi thêm hiện ra thông báo có chắc chắn thêm 

            - kiểm tra các trường phải đủ . khi thiếu đặt focus chuột vào nơi thiếu thông tin.
         
            - xử lí dữ liệu trước khi thêm.(regex)
             */
        BaoHiemBUS baoHiemController = new BaoHiemBUS();
        DTO.BaoHiem baoHiem;
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (checkInfo() == true)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin bản ghi ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        baoHiem = new DTO.BaoHiem(
                        comboBoxMaNhanVien.Text,
                        textBoxTenNhanVien.Text,
                        textBoxSoBaoHiemXH.Text,
                        textBoxSoBaoHiemYT.Text,
                        textBoxNoiCap.Text,
                        Convert.ToDateTime(textBoxNgayCap.Text));
                        baoHiemController.Insert_1_BaoHiem(baoHiem);
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
            text = textBoxSoBaoHiemXH.Text.Trim();
            if (text != "")
            {
                checkRegex = Regex.IsMatch(text, "^[a-zA-Z0-9]*$");
                if (checkRegex == false)
                {
                    error += " Error: Số Bảo Hiểm Xã Hội Chỉ Gồm Chữ Cái Và Số";
                    checkAll = false;
                }
            }
            else
            {
                error += " Error: Số Bảo Hiểm Xã Hội Không được để trống";
                checkAll = false;
            }
            text = textBoxSoBaoHiemYT.Text.Trim();
            if (text != "")
            {
                checkRegex = Regex.IsMatch(text, "^[a-zA-Z0-9]*$");
                if (checkRegex == false)
                {
                    error += "\n Error: Số Bảo Hiểm Y Tế Chỉ Gồm Chữ Cái Và Số";
                    checkAll = false;
                }
            }
            else
            {
                error += "\n Error: Số Bảo Hiểm Y Tế Không được để trống";
                checkAll = false;
            }
            text = textBoxNoiCap.Text.Trim();
            if (text != "")
            {
                checkRegex = Regex.IsMatch(NonUnicode(text), "^[a-zA-Z ]*$");
                if (checkRegex == false)
                {
                    error += "\n Error: Nơi Cấp Là Tên Thành Phố";
                    checkAll = false;
                }
            }
            else
            {
                error += "\n Error: Nơi Cấp Không được để trống";
                checkAll = false;
            }
            text = textBoxNgayCap.Text.Trim();
            if (text != "")
            {

                checkRegex = Regex.IsMatch(text, "^[0-9/]*$");
                DateTime temp;
                bool checkDate = DateTime.TryParse(textBoxNgayCap.Text, out temp);
                if (checkRegex == false || checkDate == false)
                {
                    error += $"\n Error: Ngày Cấp có định dạng dd/mm/yyyy";
                    checkAll = false;
                }
            }
            else
            {
                error += $"\n Error: Ngày Cấp không được để trống";
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

        private void ThemBaoHiem_Load(object sender, EventArgs e)
        {
            List<string> maNVs = new List<string>();
            DataTable dt = baoHiemController.DT_NhanVienKoCoBaoHiem();
            foreach(DataRow dr in dt.Rows)
            {
                maNVs.Add(dr[0].ToString());
            }
            comboBoxMaNhanVien.DataSource = maNVs;
            comboBoxMaNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxMaNhanVien.Text != "")
            {
                if(DataProvider.Instance.ExecuteScalar("" +
                    "select HoTenNV " +
                    "from HoSoNhanSu " +
                    $"where MaNV = {comboBoxMaNhanVien.Text}") != null)
                {
                    string text = DataProvider.Instance.ExecuteScalar("" +
                    "select HoTenNV " +
                    "from HoSoNhanSu " +
                    $"where MaNV = {comboBoxMaNhanVien.Text}").ToString();
                    textBoxTenNhanVien.Text = text ;
                }    
                
            }
        }
    }
}
