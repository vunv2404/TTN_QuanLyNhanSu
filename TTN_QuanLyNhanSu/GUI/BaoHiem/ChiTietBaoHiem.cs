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

namespace TTN_QuanLyNhanSu.GUI.BaoHiem
{
    public partial class ChiTietBaoHiem : Form
    {

        /// <summary>
        /// - Ném dữ liệu bên danh sách bảo hiểm từ dataGridView vứt vào từng textBox.
        /// 
        /// - Thay đổi dữ liệu . 
        /// 
        /// - button cập nhật được bật lên khi click vào textbox thay đổi dữ liệu.
        /// 
        /// - có bảng thông báo hiện lên có chắc chắn muốn cập nhật bản ghi đó.
        /// 
        /// - Xử lí dữ liệu của ngày cấp.
        /// 
        /// - kiểm tra các trường phải đủ . khi thiếu đặt focus chuột vào nơi thiếu thông tin.
        /// 
        /// - xử lí dữ liệu trước khi cập nhật.(regex)
        /// 
        /// </summary>
        public static string MaNV = "";
        BaoHiemBUS BaoHiemController = new BaoHiemBUS();
        public ChiTietBaoHiem()
        {
            InitializeComponent();
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (checkInfo() == true)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin bản ghi ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        DTO.BaoHiem baoHiemNew = new DTO.BaoHiem(
                            textBoxMaNhanVien.Text,
                            textBoxTenNhanVien.Text,
                            textBoxSoBaoHiemXH.Text,
                            textBoxSoBaoHiemYT.Text,
                            textBoxNoiCap.Text,
                            Convert.ToDateTime(textBoxNgayCap.Text));
                        BaoHiemController.Modify_1_BaoHiem(baoHiemNew);
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
        private bool checkInfo()
        {
            string error = "";
            bool checkRegex;
            bool checkAll = true;
            string text = "";
            text = textBoxSoBaoHiemXH.Text.Trim();
            if(text != "")
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
            if(text != "")
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
            if(text != "")
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
            if(text != "")
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
        private void buttonquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietBaoHiem_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
        private void LoadThongTin()
        {
            if (MaNV != "")
            {
                //DataTable dt = BaoHiemController.Show_1_ChiTietBaoHiem(MaNV);
                List<DTO.BaoHiem> baoHiems = BaoHiemController.Show_1_ChiTietBaoHiem(MaNV);
                if (baoHiems.Count != 0)
                {
                    DTO.BaoHiem baoHiem = baoHiems[0];
                    textBoxMaNhanVien.Text = baoHiem.MaNV;
                    textBoxTenNhanVien.Text = baoHiem.HoTenNV;
                    textBoxSoBaoHiemXH.Text = baoHiem.SoBaoHiemXH;
                    textBoxSoBaoHiemYT.Text = baoHiem.SoBaoHiemYT;
                    textBoxNoiCap.Text = baoHiem.NoiCap;
                    textBoxNgayCap.Text = baoHiem.NgayCap.ToShortDateString();

                }
                else
                    MessageBox.Show("Error");

            }
            buttonCapNhat.Enabled = true;
        }
        private void textBoxSoBaoHiemXH_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChiTietBaoHiem_LocationChanged(object sender, EventArgs e)
        {

        }
    }
}
