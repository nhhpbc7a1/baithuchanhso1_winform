using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Form1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        StudentDAO studentDAO = new StudentDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvHsinh.DataSource = studentDAO.Load(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtHoVaTen.Text, txtDiaChi.Text, txtCMND.Text, dtNgaysinh.Value);
            studentDAO.Add(student);
            Form1_Load(sender, e);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtHoVaTen.Text, txtDiaChi.Text, txtCMND.Text, dtNgaysinh.Value);
            studentDAO.Delete(student);
            Form1_Load(sender, e);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtHoVaTen.Text, txtDiaChi.Text, txtCMND.Text, dtNgaysinh.Value);
            studentDAO.Update(student);
            Form1_Load(sender, e);

        }

        private void gvHsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvHsinh.Rows[e.RowIndex];
                txtHoVaTen.Text = row.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtCMND.Text = row.Cells["Cmnd"].Value.ToString();
                dtNgaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtHoVaTen.Text, txtDiaChi.Text, txtCMND.Text, dtNgaysinh.Value);
            try
            {
                conn.Open();
                string sqlStr = string.Format(
                    "SELECT *FROM HocSinh " +
                    "where " +
                    "(ten='{0}' or '{0}'='')" +
                    " and (diachi='{1}' or '{1}'='')" +
                    " and (cmnd='{2}' or '{2}'='') "
                   // " and (ngaysinh={3} or {3}='') "
                    ,student.Name, student.Address, student.Id, student.Birth);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                gvHsinh.DataSource = dtSinhVien; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}