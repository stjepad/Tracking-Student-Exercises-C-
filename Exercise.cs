using System;

namespace StudentExercises
{
    class Exercise
    {
        public string Name {get; set;}
        public string Language {get; set;}

        // constructor
        public Exercise (string name, string language)
        {
            Name = name;
            Language = language;
        }
    }
}
