using System;
using System.Collections.Generic;
using System.Linq;

class StudentsByGroup
{
    static void Main()
    {
        var students = new List<Student>
		{
			new Student("Dimitar", "Dimitrov",18,1,"0897777777","dimitar@gmail.com",new List<int> {5, 3, 4, 6},2),
			new Student("Georgi", "Ivanov",18,2,"0897553344","georgi@abv.bg",new List<int> {5, 4, 5, 6},1),
			new Student("Ivan", "Georgiev",19,3,"0888664425","ivanov@@g,ail.com",new List<int> {6, 6, 5, 6},1),
			new Student("Dimitrinka", "Ivanova",19,4,"02-12356","ivanova@gmail.com",new List<int> {5, 5, 5, 5},2),
			new Student("Katya", "Georgieva",20,5,"03022221","jdjdjdj@ght.gh",new List<int> {4, 5, 6, 4},1),
			new Student("Mishael", "Tonchev",18,6,"0878919299","dffdf@abv.bg",new List<int> {4, 2, 2, 6},2),
		};

        var groupStudentsTwo =
               from st in students
               where st.GroupNumber == 2
               orderby st.FirstName
               select st;

        foreach (var st in groupStudentsTwo)
        {
            Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}", st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks), st.GroupNumber);
        }
    }
}


