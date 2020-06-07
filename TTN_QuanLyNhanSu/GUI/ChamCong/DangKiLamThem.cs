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

namespace TTN_QuanLyNhanSu.GUI.ChamCong
{
    public partial class DangKiLamThem : Form
    {

        /// <summary>
        /// - Ném dữ liệu từ dưới database lên combobox mã nhân viên.
        /// 
        /// - textBox tên nhân viên cũng đồng bộ tên nhaanvieen theo mã
        /// 
        /// - Xử lí dữ liệu trước khi thêm ,thiếu thì đặt focus vào đúng ô thiếu.
        /// 
        /// - hiện thông báo có muốn thêm không
        /// 
        /// - Xử lí dữ liệu ngày
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// </summary>
        public DangKiLamThem()
        {
            InitializeComponent();
        }
        ChamCongBUS chamCongController = new ChamCongBUS();
        private void DangKiLamThem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKilamThem' table. You can move, or remove it, as needed.
            this.dangKilamThemTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKilamThem);
            dataGridViewDangKiLamThem.AllowUserToAddRows = false;
            dataGridViewDangKiLamThem.AllowUserToDeleteRows = false;
            dataGridViewDangKiLamThem.AllowUserToResizeRows = false;
            dataGridViewDangKiLamThem.MultiSelect = false;
            dataGridViewDangKiLamThem.ReadOnly = true;
            dataGridViewDangKiLamThem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDangKiLamThem.RowHeadersVisible = false;
            dataGridViewDangKiLamThem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBoxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            List<int> maNVs = new List<int>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select MaNV from HoSoNhanSu");
            foreach (DataRow dr in dt.Rows)
            {
                maNVs.Add(Convert.ToInt32(dr[0].ToString()));
            }
            maNVs.Sort();
            comboBox1.DataSource = maNVs;
            UpdateThongTin();
        }
        private void UpdateThongTin()
        {
            dataGridViewDangKiLamThem.DataSource = chamCongController.Show_All_DangKiLamThem();
            int i = dataGridViewDangKiLamThem.RowCount;
            textBoxTong.Text = i.ToString();
            DataGridViewRow currentRow = dataGridViewDangKiLamThem.CurrentRow;
            if (currentRow != null)
            {
                comboBox1.Text = currentRow.Cells[1].Value.ToString();
                textBoxTenNhanVien.Text = currentRow.Cells[2].Value.ToString();
                textBoxTuNgay.Text = Convert.ToDateTime(currentRow.Cells[3].Value.ToString()).ToShortDateString();
                textBoxDenNgay.Text = Convert.ToDateTime(currentRow.Cells[4].Value.ToString()).ToShortDateString();
                textBoxLuong.Text = currentRow.Cells[5].Value.ToString();
                textBoxSoGio.Text = currentRow.Cells[6].Value.ToString();
                comboBoxTrangThai.Text = currentRow.Cells[7].Value.ToString();
            }
        }
        private bool checkInfo()
        {
            string error = "";
            bool checkRegex;
            bool checkAll = true;
            string text = "";

            text = textBoxTuNgay.Text.Trim();
            if (text != "")
            {

                checkRegex = Regex.IsMatch(text, "^[0-9/]*$");
                DateTime temp;
                bool checkDate = DateTime.TryParse(text, out temp);
                if (checkRegex == false || checkDate == false)
                {
                    error += $"\n Error: Từ ngày có định dạng dd/mm/yyyy";
                    checkAll = false;
                }
            }
            else
            {
                error += $"\n Error: Từ ngày không được để trống";
                checkAll = false;
            }
            text = textBoxDenNgay.Text.Trim();
            if (text != "")
            {

                checkRegex = Regex.IsMatch(text, "^[0-9/]*$");
                DateTime temp;
                bool checkDate = DateTime.TryParse(text, out temp);
                if (checkRegex == false || checkDate == false)
                {
                    error += $"\n Error: Đến ngày có định dạng dd/mm/yyyy";
                    checkAll = false;
                }
            }
            else
            {
                error += $"\n Error: Đến ngày không được để trống";
                checkAll = false;
            }
            text = textBoxLuong.Text.Trim();
            if (text != "")
            {
                decimal temp;
                bool checkDecimal = Decimal.TryParse(text, out temp);
                if (checkDecimal == false)
                {
                    error += $"\n Error: Lương/1 giờ sai định dạng";
                    checkAll = false;
                }
            }
            else
            {
                error += $"\n Error: Lương/1 giờ không được để trống";
                checkAll = false;
            }
            text = textBoxSoGio.Text.Trim();
            if (text != "")
            {
                int temp;
                bool checkInt = Int32.TryParse(text, out temp);
                if (checkInt == false)
                {
                    error += $"\n Error: Số giờ sai định dạng";
                    checkAll = false;
                }
            }
            else
            {
                error += $"\n Error: Số giờ không được để trống";
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
        private void buttonLuu_Click(object sender, EventArgs e)
        {

            if (checkInfo() == true)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin bản ghi ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    try
                    {
                        DTO.DangKiLamThem dangKiLamThem = new DTO.DangKiLamThem();
                        DataGridViewRow currentRow = dataGridViewDangKiLamThem.CurrentRow;
                        dangKiLamThem.MaNV = comboBox1.Text;
                        dangKiLamThem.HoTenNV = textBoxTenNhanVien.Text;
                        dangKiLamThem.TuNgay = Convert.ToDateTime(textBoxTuNgay.Text);
                        dangKiLamThem.DenNgay = Convert.ToDateTime(textBoxDenNgay.Text);
                        dangKiLamThem.LuongTangCa = Convert.ToDecimal(textBoxLuong.Text);
                        dangKiLamThem.SoGio = Convert.ToInt32(textBoxSoGio.Text);
                        dangKiLamThem.TrangThai = comboBoxTrangThai.Text;
                        chamCongController.Insert_1_DangKiLamThem(dangKiLamThem);
                        UpdateThongTin();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hoTenNV = DataProvider.Instance.ExecuteScalar($"select HoTenNV from HoSoNhanSu where MaNV = '{comboBox1.Text}'").ToString();
            textBoxTenNhanVien.Text = hoTenNV;
        }
    }
}
