namespace hw17
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> CourseIds { get; set; }
    }
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, Name = "Alice", Age = 20, CourseIds = new List<int> { 1, 2, 3 } },
                new Student { StudentId = 2, Name = "Bob", Age = 22, CourseIds = new List<int> { 2, 3, 4 } },
                new Student { StudentId = 3, Name = "Charlie", Age = 21, CourseIds = new List<int> { 1, 3, 5 } },
                // Добавьте еще студентов при необходимости
                new Student { StudentId = 4, Name = "Leo", Age = 23, CourseIds = new List<int> {} },
                new Student { StudentId = 5, Name = "Mark", Age = 20, CourseIds = new List<int> {3, 4, 5} },
                new Student { StudentId = 6, Name = "Brian", Age = 26, CourseIds = new List<int> {1, 2, 3} }
            };

            List<Course> courses = new List<Course>
            {
                new Course { CourseId = 1, CourseName = "Math" },
                new Course { CourseId = 2, CourseName = "Physics" },
                new Course { CourseId = 3, CourseName = "Computer Science" },
                new Course { CourseId = 4, CourseName = "Biology" },
                new Course { CourseId = 5, CourseName = "Chemistry" },
                new Course { CourseId = 6, CourseName = "English" },
                // Добавьте еще курсы при необходимости
            };

            //•	Вывести имена студентов, у которых есть курсы и которые не учатся на курсах "Math" и "Physics".
            //var result = from s in students
            //             from c in courses
            //             where s.CourseIds.Any() && !s.CourseIds.Intersect(courses.Where(c => c.CourseName == "Math" || c.CourseName == "Physics").Select(c => c.CourseId))
            //            .Any()
            //             select s;
            //foreach (var item in result.Distinct())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //•	Найти студентов, у которых есть курсы и которые учатся хотя бы на одном курсе в каждой категории (Math, Physics, Computer Science).
            //var result = from s in students
            //             from c in courses
            //             where s.CourseIds.Any() && s.CourseIds.Intersect(courses.Where(
            //                 c => c.CourseName == "Math" || c.CourseName == "Physics" || c.CourseName == "Computer Science")
            //             .Select(c => c.CourseId))
            //            .Any()
            //             select s;
            //foreach (var item in result.Distinct())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //•	Вывести имена студентов, у которых есть курсы, и у каждого курса есть хотя бы один другой курс с тем же количеством студентов.
            //•	Найти студентов, у которых есть хотя бы один курс, и у всех их курсов есть другие курсы с тем же количеством студентов.
            //var courseStudentCounts = courses.Select(c => new
            //{
            //    CourseId = c.CourseId,
            //    StudentCount = students.Count(s => s.CourseIds.Contains(c.CourseId))
            //}).ToList();

            //var coursesWithSameCount = courseStudentCounts
            //    .Where(c => courseStudentCounts.Any(other => other.CourseId != c.CourseId && other.StudentCount == c.StudentCount))
            //    .Select(c => c.CourseId).ToList();

            //var query = students
            //    .Where(s => s.CourseIds.Any(cid => coursesWithSameCount.Contains(cid)))
            //    .Select(s => s.Name);

            //Console.WriteLine("Students enrolled in courses where another course has the same number of students:");
            //foreach (var studentName in query)
            //{
            //    Console.WriteLine(studentName);
            //}

            //•	Вывести имена студентов, у которых есть хотя бы один курс, и у всех их курсов средний возраст студентов больше 18 лет.
            //var courseAvgAge = courses.GroupBy(c => c.CourseId).Select(g => new
            //{
            //    CourseId = g.Key,
            //    AvgAge = students.Where(s => s.CourseIds.Contains(g.Key)).Average(s => s.Age)
            //});
            //var query = students.Where(s => s.CourseIds.Any()).Where(s => s.CourseIds.All(cid =>
            //        courseAvgAge.First(c => c.CourseId == cid).AvgAge > 18)).Select(s => s.Name);

            //Console.WriteLine("Students where the average age of students in all their courses is greater than 18:");
            //foreach (var studentName in query)
            //{
            //    Console.WriteLine(studentName);
            //}

            //•	Найти студентов, у которых возраст на всех курсах выше среднего возраста студентов в целом.
            //var overallAvgAge = students.Average(s => s.Age);
            //var courseAvgAge = courses.GroupBy(c => c.CourseId).Select(g => new
            //{
            //    CourseId = g.Key,
            //    AvgAge = students.Where(s => s.CourseIds.Contains(g.Key)).Average(s => s.Age)
            //});
            //var query = students.Where(s => s.CourseIds.Any()).Where(s => s.CourseIds.Average(cid => courseAvgAge.First(c => c.CourseId == cid).AvgAge) > overallAvgAge);
            //foreach (var studentName in query)
            //{
            //    Console.WriteLine(studentName.Name);
            //}
        }
    }
}
