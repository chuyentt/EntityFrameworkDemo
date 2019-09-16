using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Models
{
  /// <summary>
  /// Class Student (Sinh viên), kế thừa lớp Person
  /// </summary>
  public class Student : Person
  {
    // Biến thành viên nhóm lớp học của sinh viên
    private Group mGroup;

    // Biến thành viên Điểm của 3 thành phần
    private float mScore1; // Giống như điểm thi của một học phần (A)
    private float mScore2; // Giống như điểm kiểm tra giữa kỳ (B)
    private float mScore3; // Giống như điểm chuyên cần (C)

    /// <summary>
    /// Thuộc tính của biến thành viên
    /// </summary>
    public float Score1
    {
      get { return mScore1; }
      set { mScore1 = value; }
    }

    /// <summary>
    /// Thuộc tính của biến thành viên
    /// </summary>
    public float Score2
    {
      get { return mScore2; }
      set { mScore2 = value; }
    }

    /// <summary>
    /// Thuộc tính của biến thành viên
    /// </summary>
    public float Score3
    {
      get { return mScore3; }
      set { mScore3 = value; }
    }

    /// <summary>
    /// Phương thức tính điểm trung bình hệ 10
    /// </summary>
    /// <returns>Theo quy chế đào tạo HUMG = A*0.6+B*0.3+C*0.1</returns>
    public float Grade()
    {
      return (mScore1 * 0.6f + mScore2 * 0.3f + mScore3 * 0.1f);
    }

    /// <summary>
    /// Phương thức tính điểm bằng chữ
    /// </summary>
    /// <returns>Điểm bằng chữ từ điểm được tính theo hệ 10</returns>
    public string GradeA()
    {
      float g = this.Grade();
      if (g > 8.4f) return "A";
      if (g > 7.9f) return "B+";
      if (g > 6.9f) return "B";
      if (g > 6.4f) return "C+";
      if (g > 5.4f) return "C";
      if (g > 4.9f) return "D+";
      if (g >= 4.0f) return "D";
      return "F";
    }

    // Thuộc tính quan hệ (là tên trường Group_Id trong bảng dữ liệu Student, chính là thuộc tính Group_Id của thực thể Student)
    public Group Group
    {
      get { return mGroup; }
      set { mGroup = value; }
    }

    /// <summary>
    /// Hàm tạo của Student
    /// </summary>
    public Student() {}

    /// <summary>
    /// Hàm tạo có đối số của Student
    /// </summary>
    /// <param name="vFullName">Họ và tên sinh viên</param>
    public Student(string vFullName) : base(vFullName)
    {
      
    }
  }
}
