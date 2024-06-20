
using _05_LinqQUERAndMethod;
using System;

IList<Student>studentList=new  List<Student>();
{
    new Student() { StudentId = 1, StudentName = "john", Age = 18 };
    new Student() { StudentId = 2, StudentName = "Steve", Age = 19 };
    new Student() { StudentId = 3, StudentName = "Bill", Age = 20 };
}

var result1= from s in studentList select s;    
foreach(var item in studentList)
{
    Console.WriteLine($"Query Syntax Id:{item.StudentId} Name:{item.StudentName}");

}
//SELECT StudentID StudentName from student
var result2= from s in studentList select new {s.StudentId,s.StudentName};
foreach(var item in studentList)
{
    Console.WriteLine($"Query Syntax Id:{item.StudentId} Name:{item.StudentName}");
}

var result3=from s in studentList orderby s.StudentName ascending select s;

var resul4=from s in studentList where (s.Age>30) orderby s.StudentName ascending select s;

var result5=studentList.ToList();
foreach(var item in studentList)
{
    Console.WriteLine($"Query Syntax Id:{item.StudentId} Name:{item.StudentName}");
}
var resul6 = studentList;
foreach(var item in studentList)
{
    Console.WriteLine($"Query Syntax Id:{item.StudentId} Name:{item.StudentName}");
}
//SELECT *FROMSTUDENT oRDER by Student Name
var resul7=studentList.OrderBy(s=>s.StudentName).ToList();
foreach(var item in studentList)
{
    Console.WriteLine($"Query Syntax Id:{item.StudentId} Name:{item.StudentName}");
}

//SELECT *FROM Student ORDER BY StudentName DESC
var result8 = studentList.OrderBy(s => s.StudentName).ToList();
foreach (var item in result8)
{
    Console.WriteLine($"Query Syntax Id:{item.StudentId} Name:{item.StudentName}");
}