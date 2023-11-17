using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMNI
{
  internal class Model
  {
    public const double COMPUTERS = 10;
    public const double PRINTERS = 1;
    public double Mu { get; set; }
    public double MuDelta { get; set; }
    public double T { get; set; }
    public double TDelta { get; set; }
    public double Q { get; set; }
    public double A { get; set; }
    public double Time { get; set; }
    public double TimeToNext { get; set; }

    public List<Student> Queue { get; private set; }
    public List<Student> Working { get; private set; }

    public Stats Stats { get; private set; }

    private Random random;

    public Model(double mu, double muDelta, double t, double tDelta, double q, double a)
    {
      Mu = mu;
      T = t; Q = q; A = a;
      TDelta = tDelta;
      MuDelta = muDelta;
      Time = 0;
      Queue = new List<Student>();
      Working = new List<Student>();
      random = new Random();
      TimeToNext = RandomMu();
      Stats = new Stats();
    }

    public double RandomT()
    {
      //return T + TDelta * 2 * (random.NextDouble() - 0.5);
      return Normal.BoxMuller(T, TDelta, random);
    }

    public double RandomMu()
    {
      //return Mu + MuDelta * 2 * (random.NextDouble() - 0.5);
      return Normal.BoxMuller(Mu, MuDelta, random);
    }


    public void AddStudent(Student student = null)
    {
      if(student == null)
      {
        // 1 / 3 of new students want to use the printer
        bool wantPrinter = (random.Next() % 3 == 0);
        double time = RandomT();
        student = new Student(time, wantPrinter);
      }
      else
      {
        double time = RandomT();
        student.T = time;
      }
      // try to get a free seat
      if (FreeComputer() && (FreePrinter() || !student.UsesPrinter))
      {
        PutStudentToWork(student);
        Stats.StudentsEntered++;
      }
      else
      {
        // queue
        if (Queue.Count < Q)
        {
          Queue.Add(student);
          Stats.StudentsEntered++;
        }
        else // or rejection
        {

          Stats.StudentsRejected++;
        }
      }
    }

    public void PutStudentToWork(Student student)
    {
      Queue.Remove(student);
      Working.Add(student);
      Stats.StudentsWorked++;
    }

    public bool FreeComputer()
    {
      return COMPUTERS > Working.Count;
    }

    public bool FreePrinter()
    {
      return PRINTERS > Working.Where(s => s.UsesPrinter).Count();
    }

    bool MoveQueue()
    {
      for(int i = 0; i < Queue.Count; i++)
      {
        Student student = Queue[i];
        if(FreeComputer() && (FreePrinter() || !student.UsesPrinter ))
        {
          PutStudentToWork(student);
          return true;
        } 
      }
      return false;
    }

    void FreeStudent(Student student)
    {
      Working.Remove(student);
      // check if this one returns by chance to use printer
      if(!student.UsesPrinter && random.NextDouble() < A / 100)
      {
        student.State = Student.StudentState.RETURNING;
        student.UsesPrinter = true;
        AddStudent(student);
        Stats.StudentsReturned++;
      }
    }

    public void Run(double maxTime = -1)
    {
      // sooner event: add a new student, or free one
      double t1 = (Working.Count > 0) ? Working.Min(s => s.T) : double.PositiveInfinity;
      double t2 = TimeToNext;
      double t = (t1 < t2)? t1 : t2;
      if(maxTime > -1 && maxTime < t)
      {
        t = maxTime;
      }
      // time passes for students
      foreach(Student student in Working)
      {
        student.T -= t;
      }
      // some finish their work
      List<Student> finishedWork = Working.Where(s => s.T <= 0).ToList();
      foreach(Student student in finishedWork)
      {
        FreeStudent(student);
      }
      // some will take to the computers
      while (MoveQueue()) { }
      // new come in
      TimeToNext -= t;
      if (TimeToNext <= 0)
      {
        AddStudent();
        TimeToNext = RandomMu();
      }
      // update the time variable
      Time += t;
    }


  }
}
