using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Major { get; set; }
        public int Age { get; set; }

        public Student(string name, string iD, string major,int age) {
            Name = name;
            ID = iD;
            Major = major;
            Age = age;
        }
    }


    class Program
    {

        List<Student> students = new List<Student>(){
                new Student("zhang","011","computer science",20),
                new Student("li","010","software engineering",22),
                new Student("wang","009","computer science",19),
                new Student("zhao","013","computer science",19),
                new Student("zhao","018","computer science",18)
            };

        static void Main(string[] args) {
            Program p = new Program();
            //p.QueryFormWhere();
            //p.QuerySelect();
            p.QueryOrderBy();
            //p.QueryToOthers();
        }

        private void QueryFormWhere() {
            //query的类型是IEnumerable<Student>，我们一般使用var来简写。
            IEnumerable<Student> query = from s in students
                                         where s.Major == "computer science"
                                         where s.ID != "011"
                                         select s;
            foreach (var s in query)
            {
                Console.WriteLine($"{s.ID}\t {s.Name}\t{s.Major}");
            }

            var query2 = students
                    .Where(s => s.Major == "computer science")
                    .Where(s => s.ID != "011");
            foreach (var s in query2)
            {
                Console.WriteLine($"{s.ID}\t {s.Name}\t{s.Major}");
            }

            //二次过滤
            var query3 = query.Where(s => s.Major == "computer science");
            var query4 = from s in query3
                         where s.ID != "011"
                         select s;
            foreach (var s in query4)
            {
                Console.WriteLine($"{s.ID}\t {s.Name}\t{s.Major}");
            }


        }

        private void QuerySelect() {
            var query1 = from s in students
                         where s.Major == "computer science"
                         select s.Name;
            var query2 = students
               .Where(s => s.Major == "computer science")
               .Select(s => s.Name);
            foreach (var s in query1)
            {
                Console.WriteLine($"{s}");
            }

            var query3 = from s in students
                         where s.Major == "computer science"
                         select new { s.Name, s.ID };

            var query4 = students
                .Where(s => s.Major == "computer science")
                .Select(s => new { s.Name, s.ID });

            foreach (var s in query3)
            {
                Console.WriteLine($"{s.ID}\t {s.Name}");
            }
        }

        private void QueryOrderBy() {

            var query1 = from s in students
                         where s.Major == "computer science"
                         orderby s.Name, s.ID descending
                         select s;

            foreach (var s in query1)
            {
                Console.WriteLine($"{s.ID}\t {s.Name}");
            }

            var query2 = students
                .Where(s => s.Major == "computer science")
                .OrderBy(s => s.ID);

            foreach (var s in query2)
            {
                Console.WriteLine($"{s.ID}\t {s.Name}");
            }

            var query3 = students
                .Where(s => s.Major == "computer science")
                .OrderByDescending(s => s.ID);

            foreach (var s in query3)
            {
                Console.WriteLine($"{s.ID}\t {s.Name}");
            }
            var query4 = students
              .Where(s => s.Major == "computer science")
              .OrderBy(s => s.Name)
              .ThenByDescending(s => s.ID);

            foreach (var s in query4)
            {
                Console.WriteLine($"{s.ID}\t {s.Name}");
            }

        }

        private void QueryToOthers() {
            var query = students
               .Where(s => s.Major == "computer science");
            Student[] array = query.ToArray();
            List<Student> list = query.ToList();
            Dictionary<string,Student> dic = query.ToDictionary(s=>s.ID);
            int count = query.Count();
            Student student = query.First();
            int sum=query.Sum(s=>s.Age);
            double average=query.Average(s => s.Age);

            Console.ReadKey();
        }
    }
}
