using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMNI
{
  internal class Student
  {
    public enum StudentState {NEWCOMER, RETURNING };
    public StudentState State {get; set; }
    public bool UsesPrinter { get; set; }
    public double T { get; set; }
    public Student(double t = 0, bool usesPrinter = false, StudentState state = StudentState.NEWCOMER) {
      State = state;
      UsesPrinter = usesPrinter;
      T = t;
    }
  }
}
