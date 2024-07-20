﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOPOrnek1.Entities
{
    public class Exam : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<ExamResult> ExamResults { get; set; }

        public override string ToString()
        {
            return $"{Name}--{Date.ToShortDateString()}";
        }

    }
}
