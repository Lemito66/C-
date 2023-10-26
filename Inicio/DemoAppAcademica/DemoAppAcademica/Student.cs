using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppAcademica
{
    internal class Student
    {
        /*
        public Student(int code, string name, double scoreOne, double scoreTwo, double finalScore, string status  )
        {
            this.Code = code;
            this.Name = name;
            this.ScoreOne = scoreOne;
            this.ScoreTwo = scoreTwo;
            this.FinalScore = finalScore;
            this.Status = status;
        } */

        public int Code { get; set; }
        public string Name { get; set; }
        public double ScoreOne { get; set; }
        public double ScoreTwo { get; set; }
        public double FinalScore { get; set; }
        public string Status { get; set; }

    }
}
