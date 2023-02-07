using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Calculator
    {
        // Variables that are used in the get and set from the calculator app
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int assignments { get; set; }
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Group_Projects { get; set; }
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Quizzes { get; set; }
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Miderm_Exam { get; set; }
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Final_Exam { get; set; }
        [Range(0, 100, ErrorMessage = "Values must be between 0 and 100")]
        public int Intex { get; set; }
    }
}
