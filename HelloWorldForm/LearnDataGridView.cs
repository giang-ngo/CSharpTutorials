using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForm
{
    public partial class DataGridView : Form
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public DataGridView()
        {
            InitializeComponent();
            CreateFakeData();
        }

        private void CreateFakeData()
        {
            Students.Add(new Student("001", "Trần Trung Đức", "CNTT", new DateTime(2009, 10, 15), 3.15f));
            Students.Add(new Student("002", "Lê Văn Hùng", "CNTT", new DateTime(2009, 3, 17), 3.45f));
            Students.Add(new Student("003", "Ma văn Thắng", "CNTT", new DateTime(2009, 9, 25), 3.55f));
            Students.Add(new Student("004", "Trần Ngô Mỹ Duyên", "CNTT", new DateTime(2009, 12, 11), 3.35f));
            Students.Add(new Student("005", "Lê Hoàng Diệp Thảo", "CNTT", new DateTime(2009, 1, 14), 3.65f));
            Students.Add(new Student("006", "Nguyễn Mai Trần Long", "CNTT", new DateTime(2009, 11, 15), 3.25f));
            Students.Add(new Student("007", "Hoàng Đức Sơn", "CNTT", new DateTime(2009, 4, 27), 3.75f));
            Students.Add(new Student("008", "Nông Văn Tấn", "CNTT", new DateTime(2009, 2, 18), 3.05f));
            Students.Add(new Student("009", "Chu Đình Dũng", "CNTT", new DateTime(2009, 10, 30), 3.15f));
            Students.Add(new Student("010", "Ma Thùy Quyên", "CNTT", new DateTime(2009, 8, 28), 3.45f));
        }


        private void FillData()
        {
            dataGridViewStudent.Rows.Clear();
            foreach (var item in Students)
            {
                dataGridViewStudent.Rows.Add(item.ToPropertiesArray());
            }
        }

        private void FillDataHandler(object sender, EventArgs e)
        {
            FillData();
        }

        private void removeDataHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewStudent.Columns["colRemove"].Index && e.RowIndex != -1)
            {
                var row = dataGridViewStudent.Rows[e.RowIndex];
                var id = row.Cells["colId"].Value.ToString();
                var indexToRemove = FindIndex(id);
                if (indexToRemove > -1)
                {
                    var confirmAns = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hay không?", "Xóa bản ghi"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmAns == DialogResult.Yes)
                    {
                        Students.RemoveAt(indexToRemove);
                        FillData();
                        MessageBox.Show($"Bản ghi đã bị xóa \"{id}\"!", "Kết quả xóa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private int FindIndex(string id)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (id.CompareTo(Students[i].Id) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
