using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Instructor : NSSPerson
    {
        public string Specialty { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
            exercise.Students.Add(student);
        }
    }
}
