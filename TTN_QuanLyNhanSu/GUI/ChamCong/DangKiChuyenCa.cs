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
using TTN_QuanLyNhanSu.DTO;

namespace TTN_QuanLyNhanSu.GUI.ChamCong
{
    public partial class DangKiChuyenCa : Form
    {

        /// <summary>
        /// 
        /// - Dữ liệu dưới database ném lên combobox
        /// 
        /// - cập nhật luôn cả tên nhân viên theo mã 
        /// 
        /// - Xử lí dữ liệu ngày 
        /// 
        /// - Xử lí dữ liệu trước khi thêm , thiếu thì đặt focus vào đúng ô thiếu.
        /// 
        /// - Hiện ra thông báo có muốn thêm không.
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview
        /// 
        /// </summary>
        //string ma;
        List<DTO.DangKiChuyenCa> dangKiChuyenCas;
        ChamCongBUS chamCongController = new ChamCongBUS();
        public DangKiChuyenCa()
        {
            InitializeComponent();
        }

        private void DangKiChuyenCa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.DangKiChuyenCa' table. You can move, or remove it, as needed.
            this.dangKiChuyenCaTableAdapter.Fill(this.tTN_QLNhanSuDataSet.DangKiChuyenCa);
            dataGridViewDangKiChuyenCa.AllowUserToAddRows = false;
            dataGridViewDangKiChuyenCa.AllowUserToDeleteRows = false;
            dataGridViewDangKiChuyenCa.AllowUserToResizeRows = false;
            dataGridViewDangKiChuyenCa.MultiSelect = false;
            dataGridViewDangKiChuyenCa.ReadOnly = true;
            dataGridViewDangKiChuyenCa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDangKiChuyenCa.RowHeadersVisible = false;
            List<int> maNVs = new List<int>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select MaNV from HoSoNhanSu");
            foreach (DataRow dr in dt.Rows)
            {
                maNVs.Add(Convert.ToInt32(dr[0].ToString()));
            }
            maNVs.Sort();
            comboBoxMaNhanVien.DataSource = maNVs;
            comboBoxMaNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateThongTin();
            DataGridViewRow currentRow = dataGridViewDangKiChuyenCa.CurrentRow;
            /*DataGridViewColumn column1 = new DataGridViewColumn();
            column1.HeaderText = "Mã";
            dataGridViewDangKiChuyenCa.Columns.Add(column1);*/
            if (currentRow != null)
            {
                comboBoxMaNhanVien.Text = currentRow.Cells[1].Value.ToString();
                textBoxTenNhanVien.Text = currentRow.Cells[2].Value.ToString();
                textBoxCaCu.Text = currentRow.Cells[3].Value.ToString();
                textBoxCaMoi.Text = currentRow.Cells[4].Value.ToString();
                textBoxTuNgay.Text = Convert.ToDateTime(currentRow.Cells[5].Value.ToString()).ToShortDateString();
                textBoxDenNgay.Text = Convert.ToDateTime(currentRow.Cells[6].Value.ToString()).ToShortDateString();
                textBoxLiDo.Text = currentRow.Cells[7].Value.ToString();
                comboBoxTrangThai.Text = currentRow.Cells[8].Value.ToString();
            }
        }
        private void UpdateThongTin()
        {
            dangKiChuyenCas = chamCongController.Show_All_DangKiChuyenCas();
            dataGridViewDangKiChuyenCa.DataSource = dangKiChuyenCas;
            if (dangKiChuyenCas.Count == 0)
            {               
                textBoxTong.Text = "0";
            }
            else
            {    
                textBoxTong.Text = dangKiChuyenCas.Count.ToString();
            }
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
                        DTO.DangKiChuyenCa dangKiChuyenCa = new DTO.DangKiChuyenCa();
                        DataGridViewRow currentRow = dataGridViewDangKiChuyenCa.CurrentRow;
                        dangKiChuyenCa.MaNV = comboBoxMaNhanVien.Text;
                        dangKiChuyenCa.HoTenNV = textBoxTenNhanVien.Text;

                        dangKiChuyenCa.CaCu = textBoxCaCu.Text;
                        dangKiChuyenCa.CaMoi = textBoxCaMoi.Text;
                        dangKiChuyenCa.TuNgay = Convert.ToDateTime(textBoxTuNgay.Text);
                        dangKiChuyenCa.DenNgay = Convert.ToDateTime(textBoxDenNgay.Text);
                        dangKiChuyenCa.LiDo = textBoxLiDo.Text;
                        dangKiChuyenCa.TrangThai = comboBoxTrangThai.Text;
                        chamCongController.Insert_1_DangKiChuyenCa(dangKiChuyenCa);
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
        private bool checkInfo()
        {
            string error = "";
            bool checkRegex;
            bool checkAll = true;
            string text = "";
            text = textBoxCaCu.Text.Trim();
            if (text == "")
            {
                error += $"\n Error: Ca cũ không được để trống";
                checkAll = false;
            }
            text = textBoxCaMoi.Text.Trim();
            if (text == "")
            {
                error += $"\n Error: Ca mới không được để trống";
                checkAll = false;
            }
            text = textBoxTuNgay.Text.Trim();
            if (text != "")
            {

                checkRegex = Regex.IsMatch(text, "^[0-9/]*$");
                DateTime temp;
                bool checkDate = DateTime.TryParse(text, out temp);
                if (checkRegex == false || checkDate == false)
                {
                    error += $"\n Error: Từ ngày có định dạng tháng/ngày/năm: mm/dd/yyyy";
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
                    error += $"\n Error: Đến ngày có định dạng tháng/ngày/năm: mm/dd/yyyy";
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
        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDangKiChuyenCa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewDangKiChuyenCa.CurrentRow;
            //ma = currentRow.Cells[0].Value.ToString();
            if (currentRow != null)
            {
                comboBoxMaNhanVien.Text = currentRow.Cells[1].Value.ToString();
                textBoxTenNhanVien.Text = currentRow.Cells[2].Value.ToString();
                textBoxCaCu.Text = currentRow.Cells[3].Value.ToString();
                textBoxCaMoi.Text = currentRow.Cells[4].Value.ToString();
                textBoxTuNgay.Text = Convert.ToDateTime(currentRow.Cells[5].Value.ToString()).ToShortDateString();
                textBoxDenNgay.Text = Convert.ToDateTime(currentRow.Cells[6].Value.ToString()).ToShortDateString();
                textBoxLiDo.Text = currentRow.Cells[7].Value.ToString();
                comboBoxTrangThai.Text = currentRow.Cells[8].Value.ToString();
            }
        }

        private void comboBoxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hoTenNV = DataProvider.Instance.ExecuteScalar($"select HoTenNV from HoSoNhanSu where MaNV = '{comboBoxMaNhanVien.Text}'").ToString();
            textBoxTenNhanVien.Text = hoTenNV;
        }
    }
}
