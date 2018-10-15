using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
        // exercises
             Exercise chickenMonkey = new Exercise ("Chicken Monkey", "Javascript");
             Exercise arrays = new Exercise ("Arrays", "Javascript");
             Exercise trackingStudent = new Exercise ("Tracking Student Exercise", "C#");
             Exercise lists = new Exercise ("Lists", "C#");

        // create new cohorts
            Cohort twentyFive = new Cohort ("Cohort 25");
            Cohort twentySix= new Cohort ("Cohort 26");
            Cohort twentySeven = new Cohort ("Cohort 27");

        // Create 4, or more, students and assign them to one of the cohorts.

            Student helen = new Student("Helen", "Chalmers", "@survivor", twentySeven );
            Student austin = new Student("Austin", "Gorman", "@tallAss", twentySix);
            Student raf = new Student("Rafael", "Cevallos", "@rifraf", twentyFive );
            Student jon = new Student("Jonathan", "Elfers", "@numberOne", twentySeven );
            Student ricky = new Student("Ricky", "Bruner", "@numberTwo", twentySeven );

        // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor steve = new Instructor("Steve", "Brownlee", "@coach", twentySeven);
            Instructor jisie = new Instructor("Jisie", "David", "@jisie", twentySix);
            Instructor Joe = new Instructor("Joe", "Joes", "@joe", twentyFive);

        // Have each instructor assign 2 exercises to each of the students.
        Joe.AssignExercise(chickenMonkey, helen);
        Joe.AssignExercise(arrays, austin);
        jisie.AssignExercise(lists, helen);
        jisie.AssignExercise(trackingStudent, raf);
        jisie.AssignExercise(arrays, raf);
        steve.AssignExercise(lists, raf);
        steve.AssignExercise(chickenMonkey, jon);

        List<Student> students = new List<Student>() {
    helen,
    austin,
    raf,
    jon,
    ricky
};

List<Instructor> instructors = new List<Instructor>() {
    steve,
    jisie,
    Joe
};

List<Cohort> cohorts = new List<Cohort>() {
    twentyFive,
    twentySix,
    twentySeven
};

List<Exercise> exercises = new List<Exercise>() {
    chickenMonkey,
    arrays,
    trackingStudent,
    lists
};

// List exercises for the JavaScript language by using the Where() LINQ method.
IEnumerable<Exercise> JsExercises = from e in exercises
where e.Language == "Javascript"
select e;
JsExercises.ToList();

foreach(Exercise n in JsExercises)
        {
            Console.WriteLine($" Exercises in JavaScript: {n.Name}");
        }
        Console.WriteLine("-------------");


// List students in a particular cohort by using the Where() LINQ method.

IEnumerable<Student> studentInCohort27 = from s in students
where s.Cohort == twentySeven
select s;
studentInCohort27.ToList();

foreach(Student cohort27 in studentInCohort27)
        {
            Console.WriteLine($"{cohort27.FirstName} {cohort27.LastName} is in Cohort 27");
        }
        Console.WriteLine("-------------");

IEnumerable<Student>  studentsInCohort26 = from i in students
where i.Cohort == twentySix
select i;
studentsInCohort26.ToList();
foreach(Student cohort26 in studentsInCohort26)
        {
            Console.WriteLine($"{cohort26.FirstName} {cohort26.LastName} is in Cohort 26");
        }
        Console.WriteLine("-------------");
// List instructors in a particular cohort by using the Where() LINQ method.

IEnumerable<Instructor> InstructorInCohort27 = from q in instructors
where q.Cohort == twentySeven
select q;
InstructorInCohort27.ToList();

foreach(Instructor Ins27 in InstructorInCohort27)
        {
        Console.WriteLine($"{Ins27.FirstName} {Ins27.LastName} teaches Cohort 27");
        }
        Console.WriteLine("-------------");

// Sort the students by their last name.

IEnumerable<Student> studentLastAscending = students.OrderBy(stud => stud.LastName);
foreach(var stud in studentLastAscending)
        {
            Console.WriteLine(stud.LastName);
        }
        Console.WriteLine("-------------");

// Display any students that aren't working on any exercises
// (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
IEnumerable<Student> studentNone = students.Where(stude => stude.Exercises.Count() == 0).ToList();
foreach(var stude in studentNone)
        {
            Console.WriteLine($"{stude.FirstName} {stude.LastName} insn't doing exercises!");
        }
        Console.WriteLine("-------------");

// Which student is working on the most exercises? Make sure one of your students has more exercises than the others.

// wtf I dont understand this at all


// How many students in each cohort?
var howMany = students.GroupBy(c => c.Cohort.Name);
foreach(var co in howMany)
        {
            Console.WriteLine($"{co.Key} has {co.Count()} students");
        }
        }
    }
}

// var numberOfStudentsInEachCohort = students.GroupBy(c => c.Cohort.Name);
//             // looks at every group of students
//             foreach (var studentGroup in numberOfStudentsInEachCohort)
//             {
//                 // key is the thing you grouped by
//                 Console.WriteLine($"{studentGroup.Key} has {studentGroup.Count()} students");
//             }
