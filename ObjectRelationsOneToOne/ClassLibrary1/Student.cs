﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College;

namespace College
{
    public class Student
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public Branch branch { get; set; } //contains reference to object of Branch class,
       // that represents the branch that the current student 
      // belongs to

    }
}
