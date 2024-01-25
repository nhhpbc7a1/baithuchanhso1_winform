
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        TeacherDAO teacherDAO = new TeacherDAO();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM GiaoVien");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtGiaoVien = new DataTable();
                adapter.Fill(dtGiaoVien);
                gvGiaoVien.DataSource = dtGiaoVien; /// gvHsinh = name cua data gridview
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtHoVaTen.Text, txtDiaChi.Text, txtCMND.Text, dtNgaysinh.Value);
            teacherDAO.Add(teacher);
            Form2_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtHoVaTen.Text, txtDiaChi.Text, txtCMND.Text, dtNgaysinh.Value);

            teacherDAO.Delete(teacher);
            Form2_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(txtHoVaTen.Text, txtDiaChi.Text, txtCMND.Text, dtNgaysinh.Value);

            teacherDAO.Update(teacher);
            Form2_Load(sender, e);
        }

        private void gvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gvGiaoVien.Rows[e.RowIndex];
                txtHoVaTen.Text = row.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtCMND.Text = row.Cells["Cmnd"].Value.ToString();
                dtNgaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
            }
        }
    }
}
