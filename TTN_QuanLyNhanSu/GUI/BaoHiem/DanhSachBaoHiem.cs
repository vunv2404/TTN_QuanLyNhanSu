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

namespace TTN_QuanLyNhanSu.GUI.BaoHiem
{
    public partial class DanhSachBaoHiem : Form
    {



        /// <summary>
        /// - Khi bấm vào 1 dòng trên datagridview thì nút chi tiết mới hiện lên
        /// 
        /// - Đưa dữ liệu sang bên bảng chi tiết .
        /// 
        /// - Click vào thêm chuyển sang bên Bảng Thêm
        /// 
        /// - Combobox tìm kiếm sẽ cho tìm kiếm theo loại Mã Nhân viên và tên nhân viên
        /// 
        /// - textBox Tìm kiếm : gõ từ muốn tìm kiếm 
        /// 
        /// - Textbox tổng là tổng dòng dữ liệu đang có trên datagridview 
        /// 
        /// </summary>

        List<DTO.BaoHiem> baoHiems;
        BaoHiemBUS baoHiemController = new BaoHiemBUS();
        public DanhSachBaoHiem()
        {
            InitializeComponent();
        }

        private void DanhSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.BaoHiem' table. You can move, or remove it, as needed.
            this.baoHiemTableAdapter.Fill(this.tTN_QLNhanSuDataSet.BaoHiem);
            //// TODO: This line of code loads data into the 'tTN_QLNhanSuDataSet.BaoHiem' table. You can move, or remove it, as needed.
            //this.baoHiemTableAdapter.Fill(this.tTN_QLNhanSuDataSet.BaoHiem);
            dataGridViewdsBaoHiem.AllowUserToAddRows = false;
            dataGridViewdsBaoHiem.AllowUserToDeleteRows = false;
            dataGridViewdsBaoHiem.AllowUserToResizeRows = false;
            dataGridViewdsBaoHiem.AllowUserToResizeColumns = false;
            dataGridViewdsBaoHiem.MultiSelect = false;
            dataGridViewdsBaoHiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewdsBaoHiem.ReadOnly = true;
            dataGridViewdsBaoHiem.RowHeadersVisible = false;
            comboBoxTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            baoHiems = baoHiemController.Show_All_BaoHiem();
            updateThongTin();
        }
        private void updateThongTin()
        {
            dataGridViewdsBaoHiem.DataSource = baoHiems;
            if (baoHiems.Count == 0)
            {
                MessageBox.Show("Danh sách trống");
                textBoxTong.Text = "0";
            }     
            else
            {
                int num = 0;
                foreach (DataGridViewRow dr in dataGridViewdsBaoHiem.Rows)
                {
                    num++;
                }
                textBoxTong.Text = num.ToString();
            }    
            
        }
        
        private void buttonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemBaoHiem formThemBaoHiem = new ThemBaoHiem();
            formThemBaoHiem.FormClosed += FormThemBaoHiem_FormClosed;
            formThemBaoHiem.Show();
        }

        private void FormThemBaoHiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            baoHiems = baoHiemController.Show_All_BaoHiem();
            updateThongTin();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietBaoHiem formChiTietBaoHiem = new ChiTietBaoHiem();
            formChiTietBaoHiem.FormClosed += FormChiTietBaoHiem_FormClosed;
            formChiTietBaoHiem.Show();
        }

        private void FormChiTietBaoHiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            baoHiems = baoHiemController.Show_All_BaoHiem();
            updateThongTin();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            string keyWord = textBoxTimKiem.Text;
            if (keyWord != "")
            {
                if (comboBoxTimKiem.Text == "")
                    MessageBox.Show("Chon loai thong tin muon tim kiem!");
                else
                {
                    if (comboBoxTimKiem.Text == "Mã Nhân Viên")
                    {
                        baoHiems = baoHiemController.Search_MaNV(keyWord);
                        updateThongTin();
                    }
                    else if (comboBoxTimKiem.Text == "Tên Nhân Viên")
                    {
                        baoHiems = baoHiemController.Search_TenNV(keyWord);
                        updateThongTin();
                    }
                }
            }
            else
            {
                baoHiems = baoHiemController.Show_All_BaoHiem();
                updateThongTin();
            }    
        }

        private void dataGridViewdsBaoHiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridViewdsBaoHiem.CurrentRow; 
            buttonChiTiet.Enabled = true;
            ChiTietBaoHiem.MaNV = currentRow.Cells[0].Value.ToString();
        }
    }
}
