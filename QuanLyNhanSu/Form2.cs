using BUS;
using DTO;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;
namespace QuanLyNhanSu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        PhuCap_BUS PC = new PhuCap_BUS();
        private void Insert_Click(object sender, EventArgs e)
        {
            Phu_cap ob = new Phu_cap(txtCV.Text, txtHSL.Text, txtHSPC.Text);
            PC.Insert_Bus(ob);
            Form2_Load(sender, e);
            txtCV.Clear(); txtHSL.Clear(); txtHSPC.Clear();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = PC.Load_Bus();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Phu_cap ob = new Phu_cap(txtCV.Text, txtHSL.Text, txtHSPC.Text);
            PC.Update_Bus(ob);
            Form2_Load(sender ,e);
            txtCV.Clear(); txtHSL.Clear(); txtHSPC.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            PC.Delete_Bus(txtCV.Text);
            Form2_Load(sender, e);
            txtCV.Clear(); txtHSL.Clear(); txtHSPC.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = PC.Load_Bus();
        }

        private void Chon_dong(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtCV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtHSL.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtHSPC.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

        }

        private void Export_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2012 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "Nguyễn Truong Thinh";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = "Danh sách :";

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add("Danh_sach_Lop");

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[1];

                    // đặt tên cho sheet
                    ws.Name = "Danh_sach_Lop_";
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // Tạo danh sách các column header
                    string[] arrColumnHeader = {
                                                "Số thứ tự",
                                                "Mã số",
                                                "Họ tên",
                                                "Ngày sinh",
                                                
                };

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = arrColumnHeader.Count();

                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = "Danh sách sinh viên lớp ";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in arrColumnHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //gán giá trị
                        cell.Value = item;
                        colIndex++;
                    }

                    // Khai báo danh sách sinh viên
                    List<Phu_cap> userList = new List<Phu_cap>();
                    // lấy ra danh sách chuyển sang List từ gridview
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        Phu_cap ob = new Phu_cap();
                        
                        ob.Ma_chuc_vu = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        ob.He_so_luong = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        ob.He_so_phu_cap = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        
                        userList.Add(ob);
                    }
                    // với mỗi item trong danh sách sẽ ghi trên 1 dòng
                    foreach (var item in userList)
                    {
                        // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
                        colIndex = 2;

                        // rowIndex tương ứng từng dòng dữ liệu
                        rowIndex++;

                        //gán giá trị cho từng cell                      
                        ws.Cells[rowIndex, colIndex++].Value = item.Ma_chuc_vu;
                        ws.Cells[rowIndex, colIndex++].Value = item.He_so_luong;
                        ws.Cells[rowIndex, colIndex++].Value = item.He_so_phu_cap;
                       
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Xuất excel thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }
            }
    }
}
