//
// Calculates weighted averages of student scores in different areas.
//

using System;
using System.Collections.Generic;

namespace StudentGradeCalculator
{
    class StudentGradeCalculator
    {

        static void Main()
        {
            var weights = new Dictionary<String, Decimal>();
            weights.Add("Homework", 0.10m);
            weights.Add("Projects", 0.35m);
            weights.Add("Quizes", 0.10m);
            weights.Add("Exams", 0.30m);
            weights.Add("Final Exam", 0.15m);

            var grades = new Dictionary<String, Decimal>();
            grades.Add("Homework", 97m);
            grades.Add("Projects", 82m);
            grades.Add("Quizes", 60m);
            grades.Add("Exams", 75m);
            grades.Add("Final Exam", 80m);
            decimal totalComputedScore = 0;

            foreach (KeyValuePair<String, Decimal> grade in grades)
            {
                decimal gradeWt;
                weights.TryGetValue(grade.Key, out gradeWt);
                var computedScore = gradeWt * grade.Value;
                totalComputedScore += computedScore;

                Console.WriteLine(
                  "{0}".PadRight(17 - grade.Key.Length)
                  + "Raw score: {2} Wt: {1:p0} Computed score: {3:0.0}",
                  grade.Key,
                  gradeWt,
                  grade.Value,
                  computedScore
                );
            }
            Console.WriteLine("\nTotal computed score: {0:0.0}", totalComputedScore);
            Console.WriteLine("\nPress any key to close.");
            Console.ReadKey();
        }
    }
}