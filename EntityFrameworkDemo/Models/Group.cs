using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Models
{
  /// <summary>
  /// Class Group (Nhóm lớp học)
  /// </summary>
  public class Group
  {
    // Biến thành viên Id (mã số)
    private int mId;

    // Biến thành viên Name (Tên lớp học)
    private string mName;

    // Thuộc tính Id (là tên trường trong bảng dữ liệu Group, chính là thuộc tính Id của thực thể Group)
    public int Id
    {
      get { return mId; }
      protected set { mId = value; }
    }

    // Thuộc tính Name (là tên trường trong bảng dữ liệu Group, chính là thuộc tính Name của thực thể Group)
    public string Name
    {
      get { return mName; }
      set { mName = value; }
    }

    // Interface danh sách sinh viên của lớp (một nhóm lớp học có nhiều sinh viên tham gia)
    public IList<Student> ListStudent { get; set; }

    /// <summary>
    /// Hàm tạo của Group
    /// </summary>
    public Group()
    {
      mName = "GR01";
    }

    /// <summary>
    /// Hàm tạo có đối số của Group
    /// </summary>
    /// <param name="vName"></param>
    public Group(string vName)
    {
      mName = vName;
    }
  }
}
