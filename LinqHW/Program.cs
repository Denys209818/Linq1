using LinqHW.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHW
{
    class Program
    {
        static void Main()
        {
            //
            Teacher teacher1 = new Teacher { Name = "Samantha", Surname = "Adams", Salary = 10000 };
            Teacher teacher2 = new Teacher { Name = "Vasja", Surname = "Petrov", Salary = 9000 };
            Teacher teacher3 = new Teacher { Name = "Ivan", Surname = "Ivanov", Salary = 10000 };

            //  Teachers
            List<Teacher> teachersComputerTechnology = new List<Teacher> 
            {
            teacher1,
            teacher2
            };
            List<Teacher> teachersEkonomika = new List<Teacher>
            {
            teacher1,
            teacher3
            };

            //
            Faculty faculty1 = new Faculty { Name = "Computer Science", Financing = 10000 };
            Faculty faculty2 = new Faculty { Name = "Web-Design", Financing = 100000 };
            Faculty faculty3 = new Faculty { Name = "Ekonomika", Financing = 8000 };

            //  Faculties
            List<Faculty> facultiesComputerTechnology = new List<Faculty> 
            {
                faculty1,
                faculty2
            };
            List<Faculty> facultiesEkonomika = new List<Faculty>
            {
             faculty1,
             faculty3
            };

            //  Groups
            List<Group> groupsComputerTechnology = new List<Group> 
            {
             new Group { Name = "P107", Course = 3, faculties = facultiesComputerTechnology, teachers = teachersComputerTechnology }
            };
            List<Group> groupsEkonomika = new List<Group>
            {
             new Group { Name = "P197", Course = 5, faculties = facultiesEkonomika, teachers = teachersEkonomika }
            };

            //  Departmens
            List<Department> departments = new List<Department> 
            {
            new Department { Name = "Computer Technology", Financing = 20000, groups = groupsComputerTechnology },
            new Department { Name = "Ekonomika", Financing = 15000, groups = groupsEkonomika }
            };

            //
            faculty1.departments = departments;
            faculty2.departments = departments;
            faculty3.departments = departments;

            teacher1.departments = departments;
            teacher2.departments = departments;
            teacher3.departments = departments;


            //  1. Вывести все возможные пары строк преподавателей и групп.
            //IEnumerable<Group> Enumer = departments.SelectMany((Department dep) 
            //     => { return dep.groups.Select((Group g) => 
            //     { return g; }); });

            // foreach(Group g in Enumer) 
            // {
            //     Console.WriteLine(g.Name);
            //     IEnumerable<string> teachers = from x in g.teachers select x.Name;
            //     foreach (var teach in teachers) 
            //     {
            //         Console.WriteLine("  " + teach);
            //     }
            // }

            //............................................................
            //  2.Вывести названия факультетов, фонд финансирования
            //  кафедр которых превышает фонд финансирования фа -
            //  культета.

            //IEnumerable<Faculty> faculties = 
            //    departments.SelectMany((Department dep) => 
            //    { return dep.groups.SelectMany((Group g)=> 
            //    { return g.faculties.Select((Faculty facult) => 
            //    { return facult; }).Where((Faculty faculty) => { return faculty.Financing < dep.Financing; }); }); }).Distinct();

            //foreach (var faculty in faculties) 
            //{
            //    Console.WriteLine(faculty.Name);
            //}


            //............................................................
            //  3.Вывести имена и фамилии преподавателей, которые читают
            //  лекции у группы “P107”.

            //var groups =
            //     departments.SelectMany((Department dep) => 
            //     { return dep.groups.Select((Group g) => { return g; }).Where((Group g) => {return g.Name.Contains("P107"); }); });

            //Group g = groups.SingleOrDefault((Group group) => { return group.Name.Contains("P107"); });

            //Console.WriteLine(g.Name);
            //foreach (Teacher teacher in g.teachers) 
            //{
            //    Console.WriteLine(" " + teacher.Name + " " + teacher.Surname);

            //............................................................
            //  4.Вывести фамилии преподавателей и названия факультетов
            //  на которых они читают лекции.

            //var groups = 
            //    departments.Select((Department dep) => 
            //    { return dep.groups.Select((Group g) => { return g; }); });

            //foreach (var group in groups) 
            //{
            //    var faculties = group.SelectMany((Group g) => { return g.faculties.Select((Faculty f) => { return f; }); });
            //    var teachers = group.SelectMany((Group g) => { return g.teachers.Select((Teacher t) => { return t; }); });
            //    Console.WriteLine("--------------------");
            //    Console.WriteLine("Факультети:");
            //    foreach (var el in faculties) 
            //    {
            //        Console.WriteLine(el.Name);
            //    }
            //    Console.WriteLine("Преподователи:");
            //    foreach (var el in teachers) 
            //    {
            //        Console.WriteLine(el.Name + " " + el.Surname);
            //    }
            //    Console.WriteLine("--------------------");

            //}


            //............................................................
            //  5.Вывести названия кафедр и названия групп, которые к
            //  ним относятся.
            //var dep = departments.Select((Department dep) => { return dep; });
            //foreach (var department in dep) 
            //{
            //    Console.WriteLine("Назва факультета: " + department.Name + "\nГрупи");
            //    foreach (var group in department.groups) 
            //    {
            //        Console.WriteLine(group.Name);
            //    }
            //}

            //............................................................
            //  6.Вывести названия кафедр, на которых читает препода -
            //  ватель “Samantha Adams”.
            //var groups = departments.Select(depart => { return new { Groups = depart.groups, Name = depart.Name }; });

            //foreach (var item in groups) 
            //{
            //    var teachers = 
            //        item.Groups.SelectMany((Group g) => { return g.teachers.Select((Teacher t) => t); });
            //    if (teachers.Contains(teacher1))
            //    {
            //        Console.WriteLine(item.Name);
            //    }                
            //}


            //............................................................
            //  7.Вывести названия групп, которые относятся к факультету
            //  “Computer Science”.
            //Console.WriteLine("названия групп, которые относятся к факультету “Computer Science”");
            //var groups =
            //    departments.SelectMany((Department d) =>
            //    {
            //        return d.groups.SelectMany((Group g) =>
            //      {
            //          return g.faculties.Select((Faculty f) =>
            //      { return new { Name = g.Name, Facult = f }; });
            //      });
            //    });

            //foreach (var group in groups)
            //{
            //    if (group.Facult.Name.Contains("Computer Science"))
            //    {
            //        Console.WriteLine(group.Name);
            //    }
            //}


            //............................................................
            //  8.Вывести названия групп 5 - го курса, а также название фа-
            //  культетов, к которым они относятся.
            //Console.WriteLine("названия групп 5 - го курса, а также название факультетов, к которым они относятся.");
            //var groups = departments.SelectMany((Department dep) => 
            //{ return dep.groups.Where((Group g) => { return g.Course == 5; })
            //    .Select(g => g); });

            //foreach (var group in groups) 
            //{
            //    Console.WriteLine(group.Name);
            //    foreach (var it in group.faculties) 
            //    {
            //        Console.WriteLine(it.Name);
            //    }
            //}








        }
    }
}
