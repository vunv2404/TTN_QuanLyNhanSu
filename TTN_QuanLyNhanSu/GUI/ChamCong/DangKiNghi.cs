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
    public partial class DangKiNghi : Form
    {

        /// <summary>
        /// 
        /// - Ném dữ liệu từ database lên combobox mã nhân viên
        /// 
        /// - textBOx tên nhân viên sẽ cập nhật tên nhân viên theo mã nhân viên.
        /// 
        /// - Xử lí dữ liệu ngày
        /// 
        /// - Xử lí dữ liệu trước khi thêm . thiếu thì đặt focus vào đúng ô thiếu.
        /// 
        /// - hiện thông báo có muốn thêm không.
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// </summary>
        /// 
        ChamCongBUS chamCongController = new ChamCongBUS();
        public DangKiNghi()
        {
            InitializeComponent();
        }

        private void DangKiNghi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKiNghi' table. You can move, or remove it, as needed.
            this.dangKiNghiTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKiNghi);
            dataGridViewDangKiNghi.AllowUserToAddRows = false;
            dataGridViewDangKiNghi.AllowUserToDeleteRows = false;
            dataGridViewDangKiNghi.AllowUserToResizeRows = false;
            dataGridViewDangKiNghi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDangKiNghi.MultiSelect = false;
            dataGridViewDangKiNghi.RowHeadersVisible = false;
            dataGridViewDangKiNghi.ReadOnly = true;
            dataGridViewDangKiNghi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comboBoxMaNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            List<int> maNVs = new List<int>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select MaNV from HoSoNhanSu");
            foreach (DataRow dr in dt.Rows)
            {
                maNVs.Add(Convert.ToInt32(dr[0].ToString()));
            }
            maNVs.Sort();
            comboBoxMaNhanVien.DataSource = maNVs;
            UpdateThongTin();
        }
        private void UpdateThongTin()
        {
            dataGridViewDangKiNghi.DataSource = chamCongController.Show_All_DangKiNghi();
            int i = dataGridViewDangKiNghi.RowCount;
            textBoxTong.Text = i.ToString();
            DataGridViewRow currentRow = dataGridViewDangKiNghi.CurrentRow;
            if(currentRow != null)
            {
                comboBoxMaNhanVien.Text = currentRow.Cells[1].Value.ToString();
                textBoxTenNhanVien.Text = currentRow.Cells[2].Value.ToString();
                textBoxTuNgay.Text = Convert.ToDateTime(currentRow.Cells[3].Value.ToString()).ToShortDateString();
                textBoxDenNgay.Text = Convert.ToDateTime(currentRow.Cells[4].Value.ToString()).ToShortDateString();
                textBoxLiDo.Text = currentRow.Cells[5].Value.ToString();
                comboBoxTrangThai.Text = currentRow.Cells[6].Value.ToString();
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

            text = textBoxLiDo.Text.Trim();
            if (text == "")
            {
                error += $"\n Error: Lí do không được để trống";
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
                        DTO.DangKiNghi dangKiNghi = new DTO.DangKiNghi();
                        DataGridViewRow currentRow = dataGridViewDangKiNghi.CurrentRow;
                        dangKiNghi.MaNV = comboBoxMaNhanVien.Text;
                        dangKiNghi.HoTenNV = textBoxTenNhanVien.Text;
                        dangKiNghi.TuNgay = Convert.ToDateTime(textBoxTuNgay.Text);
                        dangKiNghi.DenNgay = Convert.ToDateTime(textBoxDenNgay.Text);
                        dangKiNghi.LiDo = textBoxLiDo.Text;
                        dangKiNghi.TrangThai = comboBoxTrangThai.Text;
                        chamCongController.Insert_1_DangKiNghi(dangKiNghi);
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

        private void comboBoxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hoTenNV = DataProvider.Instance.ExecuteScalar($"select HoTenNV from HoSoNhanSu where MaNV = '{comboBoxMaNhanVien.Text}'").ToString();
            textBoxTenNhanVien.Text = hoTenNV;
        }

        private void dataGridViewDangKiNghi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewDangKiNghi.CurrentRow;
            //ma = currentRow.Cells[0].Value.ToString();
            if (currentRow != null)
            {
                comboBoxMaNhanVien.Text = currentRow.Cells[1].Value.ToString();
                textBoxTenNhanVien.Text = currentRow.Cells[2].Value.ToString();

                textBoxTuNgay.Text = Convert.ToDateTime(currentRow.Cells[3].Value.ToString()).ToShortDateString();
                textBoxDenNgay.Text = Convert.ToDateTime(currentRow.Cells[4].Value.ToString()).ToShortDateString();
                textBoxLiDo.Text = currentRow.Cells[5].Value.ToString();
                comboBoxTrangThai.Text = currentRow.Cells[6].Value.ToString();
            }
        }
    }
}
