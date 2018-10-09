using System;

namespace StudentExercises
{
    class Instructor
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}
        public Cohort Cohort {get; set;}


        // constructor

        public Instructor (string firstName, string lastName, string slackHandle, Cohort cohort)

        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

        // public no response necessary.
        // AssignExercise is a variable that we declare and call it as such.
        // Exercise grabs the information from Program.cs. exercise is taco that carries the information.
        // Student grabls the information from Program.cs. student is taco that carries the information.
        // .Add exercises to student.Exercises.
        public void AssignExercise (Exercise exercise, Student student){
            student.Exercises.Add(exercise);
        }
    }
}
