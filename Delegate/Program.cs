using DelegateAssignment.Models;

class Program
{

    static void Main(string[] args)
    {
        List<StudentModel> students = new List<StudentModel>();

        students.Add(new StudentModel { Id = 100, Name = "Ram", Age = 15, Score = 99f });
        students.Add(new StudentModel { Id = 121, Name = "Arjun", Age = 19, Score = 89.8f });
        students.Add(new StudentModel { Id = 101, Name = "Rahul", Age = 15, Score = 99.9f });
        students.Add(new StudentModel { Id = 102, Name = "Riya", Age = 16, Score = 78.5f });

        Func<StudentModel, StudentModel, bool> compareByScore = (s1, s2) => s1.Score > s2.Score;

        
        Sort(students, compareByScore);

        foreach(StudentModel student in students)
        {
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Score);
            Console.WriteLine(student.Id);
            Console.WriteLine("\n");
        }

    }


    public static void Sort(List<StudentModel> students, Func<StudentModel, StudentModel, bool> comparisonFunc)
    {
        for (int i = 0; i < students.Count; i++)
        {
            for (int j = 0; j < students.Count - i - 1; j++)
            {
                if (comparisonFunc(students[j], students[j + 1]))
                {
              
                    var temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
    }
}


