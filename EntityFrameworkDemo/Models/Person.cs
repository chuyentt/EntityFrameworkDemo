using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Models
{
  /// <summary>
  /// Lớp trừu tượng, lớp cha của lớp Student
  /// </summary>
  public abstract class Person
  {
    // Biến thành viên Id của Person (mã số)
    private int mId;

    // Biến thành viên Họ và tên của một người
    private string mFullName;

    // Thuộc tính Id (là tên trường trong bảng dữ liệu được dẫn xuất, chính là thuộc tính Id của thực thể được dẫn xuất)
    public int Id
    {
      get { return mId; }
      protected set { mId = value; }
    }

    // Thuộc tính FullName (là tên trường trong bảng dữ liệu được dẫn xuất, chính là thuộc tính FullName của thực thể được dẫn xuất)
    public string FullName
    {
      get { return mFullName; }
      set { mFullName = value; }
    }

    /// <summary>
    /// Hàm tạo của Person
    /// </summary>
    public Person() {}

    /// <summary>
    /// Hàm tạo có đối số của Person
    /// </summary>
    /// <param name="vFullName">Họ và tên</param>
    public Person(string vFullName)
    {
      mFullName = vFullName;
    }
  }
}
