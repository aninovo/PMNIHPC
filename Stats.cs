using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMNI
{
  internal class Stats
  {
    public double StudentsEntered = 0;
    public double StudentsWorked = 0;
    public double StudentsReturned = 0;
    public double StudentsRejected = 0;
    public double RejectionRate
    {
      get { return ((StudentsRejected + StudentsEntered) > 0)? StudentsRejected / (StudentsRejected + StudentsEntered) : 0; }
    }
    public double TimeWorked = 0;

    public void AddStats(Stats other)
    {
      StudentsEntered += other.StudentsEntered;
      StudentsWorked += other.StudentsWorked;
      StudentsRejected += other.StudentsRejected;
      StudentsReturned += other.StudentsReturned;
      TimeWorked += other.TimeWorked;
    }

    public void DivideStats(double n)
    {
      if (n == 0) return;
      StudentsEntered /= n;
      StudentsWorked /= n;
      StudentsRejected /= n;
      StudentsReturned /= n;
      TimeWorked /= n;
    }
  }
}
