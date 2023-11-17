using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMNI
{
  internal static class Normal
  {
    public static double BoxMuller(double mean, double stdDev, double rand1, double rand2)
    {
      // https://stackoverflow.com/questions/218060/random-gaussian-variables

      double u1 = 1.0 - rand1; //uniform(0,1] random doubles
      double u2 = 1.0 - rand2;
      double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                   Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
      double randNormal = mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
      return randNormal;
    }

    public static double BoxMuller(double mean, double stdDev, Random rand)
    {
      double rand1 = rand.NextDouble();
      double rand2 = rand.NextDouble();
      return (BoxMuller(mean, stdDev, rand1, rand2));
    }
  }
}
