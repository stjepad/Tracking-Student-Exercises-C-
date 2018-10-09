using System;

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

        // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor steve = new Instructor("Steve", "Brownlee", "@coach", twentySeven);
            Instructor jisie = new Instructor("Jisie", "David", "@jisie", twentySix);
            Instructor Joe = new Instructor("Joe", "Joes", "@joe", twentyFive);

        // Have each instructor assign 2 exercises to each of the students.
        Joe.AssignExercise(chickenMonkey, helen);
        Joe.AssignExercise(arrays, austin);
        jisie.AssignExercise(lists, helen);
        jisie.AssignExercise(trackingStudent, raf);
        steve.AssignExercise(lists, raf);
        steve.AssignExercise(chickenMonkey, jon);
        }
    }
}
