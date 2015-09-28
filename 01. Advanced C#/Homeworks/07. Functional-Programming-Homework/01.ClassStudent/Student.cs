using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public int FacultyNumber { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public IList<int> Marks { get; set; }

    public int GroupNumber { get; set; }

    public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.FacultyNumber = facultyNumber;
        this.Phone = phone;
        this.Email = email;
        this.Marks = marks;
        this.GroupNumber = groupNumber;

    }
    public static void Main()
    {
        var students = new List<Student>
		{
			new Student("Dimitar", "Dimitrov",20,1,"0897777777","dimitar@gmail.com",new List<int> {5, 3, 4, 6},2),
			new Student("Georgi", "Ivanov",22,2,"0897553344","georgi@abv.bg",new List<int> {5, 4, 5, 6},1),
			new Student("Ivan", "Georgiev",20,3,"0888664425","ivanov@@g,ail.com",new List<int> {6, 6, 5, 6},1),
			new Student("Dimitrinka", "Ivanova",22,4,"02-12356","ivanova@gmail.com",new List<int> {5, 5, 5, 5},2),
			new Student("Katya", "Georgieva",18,5,"03022221","jdjdjdj@ght.gh",new List<int> {4, 5, 6, 4},1),
			new Student("Mishael", "Tonchev",18,6,"0878919299","dffdf@abv.bg",new List<int> {4, 2, 2, 6},2),
		};

    }

}




