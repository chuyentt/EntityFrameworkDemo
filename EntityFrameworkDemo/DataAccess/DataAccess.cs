using EntityFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.DataAccess
{
  class DataAccess
  {
    private static Context context = new Context();
    public static void CreateDatabase()
    {
      context.Database.CreateIfNotExists();
    }

    public static void DeleteDatabase()
    {
      context.Database.Delete();
    }

    public static bool SaveDatabase()
    {
      return context.SaveChanges() > 0;
    }

    #region Student
    public static List<Student> GetListStudent()
    {
      return context.students.ToList<Student>();
    }

    public static List<Student> GetListStudentByGroupId(int vGroupId)
    {
      using (context)
      {
        var students = from b in context.students.Include("Group")
                       where b.Group.Id == vGroupId
                       select b;
        return students.ToList<Student>();
      }
    }

    public static List<Student> GetListStudentByGroup(Group vGroup)
    {
      using (context)
      {
        var students = from b in context.students.Include("Group")
                       where b.Group == vGroup
                       select b;
        return students.ToList<Student>();
      }
    }

    public static bool AddStudent(Student vStudent)
    {
      context.students.Add(vStudent);
      return context.SaveChanges() > 0;
    }

    public static bool RemoveStudent(Student vStudent)
    {
      context.students.Remove(vStudent);
      return context.SaveChanges() > 0;
    }
    #endregion Student

    #region Group
    public static List<Group> GetListGroup()
    {
      return context.groups.ToList();
    }

    public static bool AddGroup(Group vGroup)
    {
      context.groups.Add(vGroup);
      return context.SaveChanges() > 0;
    }

    public static bool RemoveGroup(Group vGroup)
    {
      context.groups.Remove(vGroup);
      return context.SaveChanges() > 0;
    }

    public static Group GetGroupById(int vGroupId)
    {
      return context.groups.Where(info => info.Id == vGroupId).Single();
    }
    #endregion Group
  }
}
