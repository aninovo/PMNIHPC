using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PMNI
{
  public partial class Form1 : Form
  {
    Model[] models;
    DateTime start, update;
    public Form1()
    {
      InitializeComponent();
      saveFileDialog.InitialDirectory = Application.StartupPath;
    }

    private void timerMain_Tick(object sender, EventArgs e)
    {
      if(models != null)
      {
        Stats avg = new Stats();
        foreach(Model model in models)
        {
          model.Run((DateTime.Now - update).TotalSeconds);
          update = DateTime.Now;
          if(models.Length == 1)
            outputStats(model);
          else
            avg.AddStats(model.Stats);
        }
        avg.DivideStats(models.Length);
        if (models.Length > 1)
          outputStats(avg);
      }
    }

    private Stats CalculateAvgStats()
    {
      Stats avg = new Stats();
      foreach (Model m in models)
        avg.AddStats(m.Stats);
      avg.DivideStats(models.Length);
      return avg;
    }
    private void outputStats(Stats stats)
    {
      textBoxModelTime.Text = models[0].Time.ToString("0.00");
      textBoxQueue.Text = "*";
      textBoxTimeToNext.Text = "*";
      textBoxWorking.Text = "*";
      textBoxRejections.Text = (stats.RejectionRate * 100d).ToString("0.00");
      checkBoxPrinter.Checked = false;
      textBoxStudentsEntered.Text = stats.StudentsEntered.ToString();
      textBoxStudentsReturned.Text = stats.StudentsReturned.ToString();
      textBoxStudentsRejected.Text = stats.StudentsRejected.ToString();
    }

    private void outputStats(Model model)
    {
      textBoxModelTime.Text = model.Time.ToString("0.00");
      textBoxQueue.Text = model.Queue.Count.ToString();
      textBoxTimeToNext.Text = model.TimeToNext.ToString("0.00");
      textBoxWorking.Text = model.Working.Count.ToString();
      textBoxRejections.Text = (model.Stats.RejectionRate * 100d).ToString("0.00");
      checkBoxPrinter.Checked = model.FreePrinter();
      textBoxStudentsEntered.Text = model.Stats.StudentsEntered.ToString();
      textBoxStudentsReturned.Text = model.Stats.StudentsReturned.ToString();
      textBoxStudentsRejected.Text = model.Stats.StudentsRejected.ToString();
    }

    private Model initModel()
    {
      Model model = null;
      try
      {
        // read the parameters
        double t, tDelta, mu, muDelta, q, a;
        t = double.Parse(textBoxT.Text);
        tDelta = double.Parse(textBoxTDeviation.Text);
        mu = double.Parse(textBoxMu.Text);
        muDelta = double.Parse(textBoxMuDeviation.Text);
        q = double.Parse(textBoxQ.Text);
        a = double.Parse(textBoxA.Text);
        // Init a new model
        model = new Model(mu, muDelta, t, tDelta, q, a);
      }
      catch (FormatException)
      {
        MessageBox.Show("Input number parameters!");
      }
      return model;
    }

    private Model[] initModels()
    {
      Model[] arr = null;
      try
      {
        // read params
        int n = int.Parse(textBoxParallel.Text);
        arr = new Model[n];
        for (int i = 0; i < n; i++)
        {
          arr[i] = initModel();
        }
      }
      catch (FormatException)
      {
        MessageBox.Show("Input number parameters!");
      }
      catch
      {
        MessageBox.Show("Fail to init models!");
      }
      return arr;
    }
    private void buttonRun_Click(object sender, EventArgs e)
    {
      if (models == null) 
        models = initModels();
      if (models == null) return;
      // start it
      start = update = DateTime.Now;
      timerMain.Enabled = true;
    }

    private void runXminutes(int minutes)
    {
      if (models == null)
        models = initModels();
      if (models == null) return;
      // run another X minutes
      
      if(models.Length == 1)
      {
        Model model = models[0];
        runXminutes(model, minutes);
        outputStats(model);
      }
      if(models.Length > 1)
      {
        // MULTITHREAD
        Thread[] threads = new Thread[models.Length];
        for(int i = 0; i < models.Length; i++)
        {
          Model model = models[i];
          threads[i] = new Thread(
            () => runXminutes(model, minutes)
            );
          threads[i].Start();
        }
        // wait for completion
        foreach (Thread thread in threads)
          thread.Join();
        outputStats(CalculateAvgStats());
      }
      
    }

    private void runXminutes(Model model, int minutes)
    {
      double beginning = model.Time;
      while (model.Time < beginning + minutes)
      {
        model.Run(1);
      }
    }
      private void buttonRun100_Click(object sender, EventArgs e)
    {
      runXminutes(100);
    }


    private void buttonRun1000_Click(object sender, EventArgs e)
    {
      runXminutes(1000);
    }

    private void buttonRun10000_Click(object sender, EventArgs e)
    {
      runXminutes(10000);
    }

    private void buttonRun100000_Click(object sender, EventArgs e)
    {
      runXminutes(100000);
    }

    private void buttonRestart_Click(object sender, EventArgs e)
    {
      Model[] newModels = initModels();

      if (newModels != null)
      {
        models = newModels;
        if (models.Length == 1)
          outputStats(models[0]);
        else
          outputStats(CalculateAvgStats());
      } 
    }

    private bool saveFile(string filename)
    {
      try
      {
        StreamWriter writer = new StreamWriter(filename, false);
        if(models == null || models.Length == 0)
        {
          writer.WriteLine("# Models not initialized");
          writer.Close();
          return false;
        }
        Model model = models[0];
        writer.WriteLine("# Parameters");
        writer.WriteLine("Mu = " + model.Mu + " +/- " + model.MuDelta);
        writer.WriteLine("T = " + model.T + " +/- " + model.TDelta);
        writer.WriteLine("Q = " + model.Q);
        writer.WriteLine("A = " + model.A);
        for (int i = 0; i < models.Length; i++)
        {
          model = models[i];
          writer.WriteLine("# Model " + (i+1) + " state");
          writer.WriteLine("Time = " + model.Time);
          writer.WriteLine("Queue = " + model.Queue.Count);
          writer.WriteLine("Working = " + model.Working.Count);
          writer.WriteLine("# Statistic");
          writer.WriteLine("Entered = " + model.Stats.StudentsEntered);
          writer.WriteLine("Worked = " + model.Stats.StudentsWorked);
          writer.WriteLine("Returned = " + model.Stats.StudentsReturned);
          writer.WriteLine("Rejected = " + model.Stats.StudentsRejected);
          writer.WriteLine("Rejection = " + model.Stats.RejectionRate);
        }
        if(models.Length > 1)
        {
          Stats avg = CalculateAvgStats(); 
          writer.WriteLine("# Statistic");
          writer.WriteLine("Entered = " + avg.StudentsEntered);
          writer.WriteLine("Worked = " + avg.StudentsWorked);
          writer.WriteLine("Returned = " + avg.StudentsReturned);
          writer.WriteLine("Rejected = " + avg.StudentsRejected);
          writer.WriteLine("Rejection = " + avg.RejectionRate);
        }
        writer.Close();
        return true;
      }
      catch
      {
        MessageBox.Show("Failed to save a file");
        return false;
      }
    }

    private void buttonSaveFile_Click(object sender, EventArgs e)
    {
      DialogResult result = saveFileDialog.ShowDialog(this);
      if (result == DialogResult.OK)
      {
        saveFile(saveFileDialog.FileName);
      }
    }

    private void buttonStop_Click(object sender, EventArgs e)
    {
      timerMain.Enabled = false;
    }

  }
}
