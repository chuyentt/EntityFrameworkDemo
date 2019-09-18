using EntityFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();

      // Tạo cơ sở dữ liệu nếu chưa có
      DataAccess.DataAccess.CreateDatabase();

      // Xóa cơ sở dữ liệu (nếu cần thiết)
      //DataAccess.DataAccess.DeleteDatabase();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // Thử tạo một đối tượng Group (nhở using EntityFrameworkDemo.Models;)
      Group group = new Group("ABC01");

      // Thêm đối tượng vào CSDL
      //DataAccess.DataAccess.AddGroup(group);

      // Thử tạo một đối tượng Student
      Student student = new Student("Nguyễn Văn A");
      student.Score1 = 8;
      student.Score2 = 6;
      student.Score3 = 10;
      MessageBox.Show("Điểm hệ 10: " + student.Grade().ToString()+ "; Điểm chữ: " + student.GradeA());
      // Gán sinh viên thuộc nhóm học phần
      student.Group = group;

      // Thêm đối tượng sinh viên vào CSDL
      //DataAccess.DataAccess.AddStudent(student);
    }
  }
}
