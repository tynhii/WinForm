using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTap_Nhom
{
    public partial class QuanLySV : Form
    {
        public QuanLySV()
        {
            InitializeComponent();
        }       
        public SqlConnection getconnect()
        {
            return new SqlConnection
                (@"Data Source=DESKTOP-TRF9TC6\TUYNHI;Initial Catalog=QuanLySV;User ID=sa;Password=tuynhi3012");
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
                this.Close();
        }
        private void QuanLySV_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = getconnect();
            SqlDataAdapter ds = new SqlDataAdapter("select MaSV,HoSV, TenSV,GioiTinh,NgaySinh,MaKhoa from ThongTinSV", cnn);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            dataGridView_SV.DataSource = dt;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
            txt_HoSV.Enabled = false;
            txt_MaKhoa.Enabled = false;
            txt_MaSV.Enabled = false;
            txt_TenSV.Enabled = false;
            cbox_Sex.Enabled = false;
            dtimePick_DOB.Enabled = false;
        }
        private void dataGridView_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chiso = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dataGridView_SV.DataSource;
            chiso = dataGridView_SV.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[chiso];
            txt_MaSV.Text = hang["MaSV"].ToString();
            txt_HoSV.Text = hang["HoSV"].ToString();
            txt_TenSV.Text = hang["TenSV"].ToString();
            dtimePick_DOB.Value = Convert.ToDateTime(hang["NgaySinh"].ToString());
            txt_MaKhoa.Text = hang["MaKhoa"].ToString();
            cbox_Sex.Text=hang["GioiTinh"].ToString();
        }
        int flag;
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            flag = 0;
            cbox_Sex.ResetText();
            dtimePick_DOB.ResetText();
            txt_TenSV.ResetText();
            txt_MaSV.ResetText();
            txt_HoSV.ResetText();
            txt_MaKhoa.ResetText();

            cbox_Sex.Enabled = true;
            dtimePick_DOB.Enabled = true;
            txt_TenSV.Enabled = true;
            txt_MaSV.Enabled = true;
            txt_HoSV.Enabled = true;
            txt_MaKhoa.Enabled = true;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Insert.Enabled = false;            
            txt_MaSV.Focus();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = getconnect();
            con.Open();
            if (txt_MaSV.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("delete  from ThongTinSV where MaSV='" + txt_MaSV.Text.ToString() + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                txt_MaSV.ResetText();
                txt_HoSV.ResetText();
                txt_TenSV.ResetText();
                txt_MaKhoa.ResetText();
                cbox_Sex.ResetText();
                dtimePick_DOB.ResetText();                
                txt_MaSV.Focus();

                QuanLySV_Load(sender, e);
            }               
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }                      
            con.Close();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            flag = 1;
            cbox_Sex.Enabled = true;
            dtimePick_DOB.Enabled = true;
            txt_TenSV.Enabled = true;
            txt_MaSV.Enabled = true;
            txt_HoSV.Enabled = true;
            txt_MaKhoa.Enabled = true;
            txt_MaSV.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Insert.Enabled = false;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_MaSV.ResetText();
            txt_HoSV.ResetText();
            txt_TenSV.ResetText();
            txt_MaKhoa.ResetText();
            cbox_Sex.ResetText();
            dtimePick_DOB.ResetText();  
            
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Update.Enabled = true;
            btn_Delete.Enabled = true;
            btn_Insert.Enabled = true;

            cbox_Sex.Enabled = false;
            dtimePick_DOB.Enabled = false;
            txt_TenSV.Enabled = false;
            txt_MaSV.Enabled = false;
            txt_HoSV.Enabled = false;
            txt_MaKhoa.Enabled = false;
            txt_MaSV.Enabled = false;
            txt_MaSV.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (txt_MaSV.Text != "")
                {
                    SqlConnection con = getconnect();
                    con.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = System.String.Concat("Insert into ThongTinSV Values(N'" + txt_MaSV.Text.ToString() + "',N'" + txt_HoSV.Text.ToString() + "',N'" + txt_TenSV.Text.ToString() + "',N'" + cbox_Sex.Text.ToString() + "',N'" + dtimePick_DOB.Value.ToShortDateString() + "',N'" + txt_MaKhoa.Text.ToString() + "')");
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        txt_MaSV.ResetText();
                        txt_HoSV.ResetText();
                        txt_TenSV.ResetText();
                        txt_MaKhoa.ResetText();
                        cbox_Sex.ResetText();
                        dtimePick_DOB.ResetText();                    

                        btn_Save.Enabled = false;
                        btn_Cancel.Enabled = false;
                        btn_Update.Enabled = true;
                        btn_Delete.Enabled = true;
                        btn_Insert.Enabled = true;

                        QuanLySV_Load(sender, e);
                        MessageBox.Show("Thêm dữ liệu mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_MaSV.Focus();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã SV đã tồn tại! Vui lòng nhập lai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_MaSV.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_MaSV.Focus();
                }                    
            }
            else if (flag == 1)
            {
                SqlConnection con = getconnect();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("Update ThongTinSV set  HoSV= N'" + txt_HoSV.Text.ToString() + "'," + "TenSV=N'" + txt_TenSV.Text.ToString() + "'," + "GioiTinh=N'" + cbox_Sex.Text.ToString() + "'," + "NgaySinh='" + dtimePick_DOB.Value.ToShortDateString() + "'," + "MaKhoa=N'" + txt_MaKhoa.Text.ToString() + "'" + "where MaSV=N'" + txt_MaSV.Text.ToString() + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                txt_MaSV.ResetText();
                txt_HoSV.ResetText();
                txt_TenSV.ResetText();
                txt_MaKhoa.ResetText();
                cbox_Sex.ResetText();
                dtimePick_DOB.ResetText();
                txt_MaSV.Focus();

                btn_Save.Enabled = false;
                btn_Cancel.Enabled = false;
                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
                btn_Insert.Enabled = true;
                QuanLySV_Load(sender, e);
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }
    }
}


