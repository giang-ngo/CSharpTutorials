using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HelloWorldForm
{
    public partial class BindingDataGridviewForm : Form
    {
        private DataTable dt = new DataTable();
        private bool isDataLoaded = false; // Biến cờ để kiểm soát

        public BindingDataGridviewForm()
        {
            InitializeComponent();
        }

        private void BindingDataGridviewForm_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.learnCSharpDataSet.Student);
        }

        private void LoadDataHanlder(object sender, EventArgs e)
        {
            if (isDataLoaded)
            {
                MessageBox.Show("Dữ liệu đã được tải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Ngăn không tải lại dữ liệu
            }

            var connString = @"Data Source=LAPTOP-LLTJI6NG;Initial Catalog=LearnCSharp;User ID=sa;Password=123456";
            //var sql = "SELECT * FROM Student WHERE FullName LIKE '%t%'";
            var sql = "SELECT * FROM Student";
            var conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                var command = new SqlCommand(sql, conn);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                    dataGridView1.DataSource = dt;
                }

                isDataLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
