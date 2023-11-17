namespace PMNI
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxMu = new System.Windows.Forms.TextBox();
      this.groupBoxParameters = new System.Windows.Forms.GroupBox();
      this.buttonSaveFile = new System.Windows.Forms.Button();
      this.buttonRestart = new System.Windows.Forms.Button();
      this.buttonRun10000 = new System.Windows.Forms.Button();
      this.buttonRun1000 = new System.Windows.Forms.Button();
      this.buttonRun100 = new System.Windows.Forms.Button();
      this.buttonStop = new System.Windows.Forms.Button();
      this.buttonRun = new System.Windows.Forms.Button();
      this.textBoxA = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBoxQ = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxTDeviation = new System.Windows.Forms.TextBox();
      this.textBoxT = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxMuDeviation = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.timerMain = new System.Windows.Forms.Timer(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBoxStudentsRejected = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.textBoxStudentsEntered = new System.Windows.Forms.TextBox();
      this.label13 = new System.Windows.Forms.Label();
      this.textBoxStudentsReturned = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.checkBoxPrinter = new System.Windows.Forms.CheckBox();
      this.label11 = new System.Windows.Forms.Label();
      this.textBoxRejections = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.textBoxWorking = new System.Windows.Forms.TextBox();
      this.textBoxQueue = new System.Windows.Forms.TextBox();
      this.textBoxModelTime = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.textBoxTimeToNext = new System.Windows.Forms.TextBox();
      this.buttonRun100000 = new System.Windows.Forms.Button();
      this.textBoxParallel = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.groupBoxParameters.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(275, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Інтервал прибуття студентів: ";
      // 
      // textBoxMu
      // 
      this.textBoxMu.Location = new System.Drawing.Point(9, 62);
      this.textBoxMu.Name = "textBoxMu";
      this.textBoxMu.Size = new System.Drawing.Size(59, 28);
      this.textBoxMu.TabIndex = 1;
      this.textBoxMu.Text = "10";
      // 
      // groupBoxParameters
      // 
      this.groupBoxParameters.Controls.Add(this.textBoxParallel);
      this.groupBoxParameters.Controls.Add(this.label15);
      this.groupBoxParameters.Controls.Add(this.buttonRun100000);
      this.groupBoxParameters.Controls.Add(this.buttonSaveFile);
      this.groupBoxParameters.Controls.Add(this.buttonRestart);
      this.groupBoxParameters.Controls.Add(this.buttonRun10000);
      this.groupBoxParameters.Controls.Add(this.buttonRun1000);
      this.groupBoxParameters.Controls.Add(this.buttonRun100);
      this.groupBoxParameters.Controls.Add(this.buttonStop);
      this.groupBoxParameters.Controls.Add(this.buttonRun);
      this.groupBoxParameters.Controls.Add(this.textBoxA);
      this.groupBoxParameters.Controls.Add(this.label6);
      this.groupBoxParameters.Controls.Add(this.textBoxQ);
      this.groupBoxParameters.Controls.Add(this.label5);
      this.groupBoxParameters.Controls.Add(this.textBoxTDeviation);
      this.groupBoxParameters.Controls.Add(this.textBoxT);
      this.groupBoxParameters.Controls.Add(this.label4);
      this.groupBoxParameters.Controls.Add(this.label3);
      this.groupBoxParameters.Controls.Add(this.textBoxMuDeviation);
      this.groupBoxParameters.Controls.Add(this.label2);
      this.groupBoxParameters.Controls.Add(this.label1);
      this.groupBoxParameters.Controls.Add(this.textBoxMu);
      this.groupBoxParameters.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBoxParameters.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.groupBoxParameters.Location = new System.Drawing.Point(0, 0);
      this.groupBoxParameters.Name = "groupBoxParameters";
      this.groupBoxParameters.Size = new System.Drawing.Size(357, 662);
      this.groupBoxParameters.TabIndex = 2;
      this.groupBoxParameters.TabStop = false;
      this.groupBoxParameters.Text = "Параметри";
      // 
      // buttonSaveFile
      // 
      this.buttonSaveFile.Location = new System.Drawing.Point(29, 611);
      this.buttonSaveFile.Name = "buttonSaveFile";
      this.buttonSaveFile.Size = new System.Drawing.Size(307, 39);
      this.buttonSaveFile.TabIndex = 17;
      this.buttonSaveFile.Text = "Зберегти у файл";
      this.buttonSaveFile.UseVisualStyleBackColor = true;
      this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
      // 
      // buttonRestart
      // 
      this.buttonRestart.Location = new System.Drawing.Point(29, 562);
      this.buttonRestart.Name = "buttonRestart";
      this.buttonRestart.Size = new System.Drawing.Size(134, 32);
      this.buttonRestart.TabIndex = 16;
      this.buttonRestart.Text = "Скинути";
      this.buttonRestart.UseVisualStyleBackColor = true;
      this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
      // 
      // buttonRun10000
      // 
      this.buttonRun10000.Location = new System.Drawing.Point(169, 524);
      this.buttonRun10000.Name = "buttonRun10000";
      this.buttonRun10000.Size = new System.Drawing.Size(167, 32);
      this.buttonRun10000.TabIndex = 15;
      this.buttonRun10000.Text = "Пуск (10000)";
      this.buttonRun10000.UseVisualStyleBackColor = true;
      this.buttonRun10000.Click += new System.EventHandler(this.buttonRun10000_Click);
      // 
      // buttonRun1000
      // 
      this.buttonRun1000.Location = new System.Drawing.Point(169, 486);
      this.buttonRun1000.Name = "buttonRun1000";
      this.buttonRun1000.Size = new System.Drawing.Size(167, 32);
      this.buttonRun1000.TabIndex = 14;
      this.buttonRun1000.Text = "Пуск (1000)";
      this.buttonRun1000.UseVisualStyleBackColor = true;
      this.buttonRun1000.Click += new System.EventHandler(this.buttonRun1000_Click);
      // 
      // buttonRun100
      // 
      this.buttonRun100.Location = new System.Drawing.Point(169, 448);
      this.buttonRun100.Name = "buttonRun100";
      this.buttonRun100.Size = new System.Drawing.Size(167, 32);
      this.buttonRun100.TabIndex = 13;
      this.buttonRun100.Text = "Пуск (100)";
      this.buttonRun100.UseVisualStyleBackColor = true;
      this.buttonRun100.Click += new System.EventHandler(this.buttonRun100_Click);
      // 
      // buttonStop
      // 
      this.buttonStop.Location = new System.Drawing.Point(29, 524);
      this.buttonStop.Name = "buttonStop";
      this.buttonStop.Size = new System.Drawing.Size(134, 32);
      this.buttonStop.TabIndex = 12;
      this.buttonStop.Text = "Стоп";
      this.buttonStop.UseVisualStyleBackColor = true;
      this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
      // 
      // buttonRun
      // 
      this.buttonRun.Location = new System.Drawing.Point(29, 448);
      this.buttonRun.Name = "buttonRun";
      this.buttonRun.Size = new System.Drawing.Size(134, 70);
      this.buttonRun.TabIndex = 3;
      this.buttonRun.Text = "Пуск";
      this.buttonRun.UseVisualStyleBackColor = true;
      this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
      // 
      // textBoxA
      // 
      this.textBoxA.Location = new System.Drawing.Point(9, 282);
      this.textBoxA.Name = "textBoxA";
      this.textBoxA.Size = new System.Drawing.Size(59, 28);
      this.textBoxA.TabIndex = 11;
      this.textBoxA.Text = "5";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 235);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(208, 40);
      this.label6.TabIndex = 10;
      this.label6.Text = "Процент % студентів, \r\nщо повертаються:";
      // 
      // textBoxQ
      // 
      this.textBoxQ.Location = new System.Drawing.Point(9, 191);
      this.textBoxQ.Name = "textBoxQ";
      this.textBoxQ.Size = new System.Drawing.Size(59, 28);
      this.textBoxQ.TabIndex = 9;
      this.textBoxQ.Text = "10";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 163);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(166, 20);
      this.label5.TabIndex = 8;
      this.label5.Text = "Допустима черга:";
      // 
      // textBoxTDeviation
      // 
      this.textBoxTDeviation.Location = new System.Drawing.Point(102, 126);
      this.textBoxTDeviation.Name = "textBoxTDeviation";
      this.textBoxTDeviation.Size = new System.Drawing.Size(59, 28);
      this.textBoxTDeviation.TabIndex = 7;
      this.textBoxTDeviation.Text = "2";
      // 
      // textBoxT
      // 
      this.textBoxT.Location = new System.Drawing.Point(9, 126);
      this.textBoxT.Name = "textBoxT";
      this.textBoxT.Size = new System.Drawing.Size(59, 28);
      this.textBoxT.TabIndex = 6;
      this.textBoxT.Text = "10";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(74, 129);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 20);
      this.label4.TabIndex = 5;
      this.label4.Text = "+/-";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 98);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(340, 20);
      this.label3.TabIndex = 4;
      this.label3.Text = "Час роботи студента за комп\'ютером:";
      // 
      // textBoxMuDeviation
      // 
      this.textBoxMuDeviation.Location = new System.Drawing.Point(102, 62);
      this.textBoxMuDeviation.Name = "textBoxMuDeviation";
      this.textBoxMuDeviation.Size = new System.Drawing.Size(59, 28);
      this.textBoxMuDeviation.TabIndex = 3;
      this.textBoxMuDeviation.Text = "2";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(74, 65);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "+/-";
      // 
      // timerMain
      // 
      this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBoxTimeToNext);
      this.groupBox1.Controls.Add(this.textBoxStudentsRejected);
      this.groupBox1.Controls.Add(this.label14);
      this.groupBox1.Controls.Add(this.textBoxStudentsEntered);
      this.groupBox1.Controls.Add(this.label13);
      this.groupBox1.Controls.Add(this.textBoxStudentsReturned);
      this.groupBox1.Controls.Add(this.label12);
      this.groupBox1.Controls.Add(this.checkBoxPrinter);
      this.groupBox1.Controls.Add(this.label11);
      this.groupBox1.Controls.Add(this.textBoxRejections);
      this.groupBox1.Controls.Add(this.label10);
      this.groupBox1.Controls.Add(this.textBoxWorking);
      this.groupBox1.Controls.Add(this.textBoxQueue);
      this.groupBox1.Controls.Add(this.textBoxModelTime);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label7);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(357, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(288, 662);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Модель";
      // 
      // textBoxStudentsRejected
      // 
      this.textBoxStudentsRejected.Location = new System.Drawing.Point(24, 421);
      this.textBoxStudentsRejected.Name = "textBoxStudentsRejected";
      this.textBoxStudentsRejected.ReadOnly = true;
      this.textBoxStudentsRejected.Size = new System.Drawing.Size(176, 28);
      this.textBoxStudentsRejected.TabIndex = 24;
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(20, 394);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(77, 20);
      this.label14.TabIndex = 23;
      this.label14.Text = "Відмов:";
      // 
      // textBoxStudentsEntered
      // 
      this.textBoxStudentsEntered.Location = new System.Drawing.Point(24, 305);
      this.textBoxStudentsEntered.Name = "textBoxStudentsEntered";
      this.textBoxStudentsEntered.ReadOnly = true;
      this.textBoxStudentsEntered.Size = new System.Drawing.Size(176, 28);
      this.textBoxStudentsEntered.TabIndex = 22;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(20, 278);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(173, 20);
      this.label13.TabIndex = 21;
      this.label13.Text = "Студентів зайшло:";
      // 
      // textBoxStudentsReturned
      // 
      this.textBoxStudentsReturned.Location = new System.Drawing.Point(24, 363);
      this.textBoxStudentsReturned.Name = "textBoxStudentsReturned";
      this.textBoxStudentsReturned.ReadOnly = true;
      this.textBoxStudentsReturned.Size = new System.Drawing.Size(176, 28);
      this.textBoxStudentsReturned.TabIndex = 20;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(20, 336);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(221, 20);
      this.label12.TabIndex = 19;
      this.label12.Text = "Студентів повернулося:";
      // 
      // checkBoxPrinter
      // 
      this.checkBoxPrinter.AutoSize = true;
      this.checkBoxPrinter.Checked = true;
      this.checkBoxPrinter.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBoxPrinter.Enabled = false;
      this.checkBoxPrinter.Location = new System.Drawing.Point(112, 235);
      this.checkBoxPrinter.Name = "checkBoxPrinter";
      this.checkBoxPrinter.Size = new System.Drawing.Size(100, 24);
      this.checkBoxPrinter.TabIndex = 18;
      this.checkBoxPrinter.Text = "вільний";
      this.checkBoxPrinter.UseVisualStyleBackColor = true;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(20, 235);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(86, 20);
      this.label11.TabIndex = 17;
      this.label11.Text = "Прінтер:";
      // 
      // textBoxRejections
      // 
      this.textBoxRejections.Location = new System.Drawing.Point(24, 479);
      this.textBoxRejections.Name = "textBoxRejections";
      this.textBoxRejections.ReadOnly = true;
      this.textBoxRejections.Size = new System.Drawing.Size(176, 28);
      this.textBoxRejections.TabIndex = 16;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(20, 452);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(180, 20);
      this.label10.TabIndex = 13;
      this.label10.Text = "Процент % відмов:";
      // 
      // textBoxWorking
      // 
      this.textBoxWorking.Location = new System.Drawing.Point(24, 191);
      this.textBoxWorking.Name = "textBoxWorking";
      this.textBoxWorking.ReadOnly = true;
      this.textBoxWorking.Size = new System.Drawing.Size(176, 28);
      this.textBoxWorking.TabIndex = 15;
      // 
      // textBoxQueue
      // 
      this.textBoxQueue.Location = new System.Drawing.Point(24, 129);
      this.textBoxQueue.Name = "textBoxQueue";
      this.textBoxQueue.ReadOnly = true;
      this.textBoxQueue.Size = new System.Drawing.Size(88, 28);
      this.textBoxQueue.TabIndex = 14;
      // 
      // textBoxModelTime
      // 
      this.textBoxModelTime.Location = new System.Drawing.Point(24, 62);
      this.textBoxModelTime.Name = "textBoxModelTime";
      this.textBoxModelTime.ReadOnly = true;
      this.textBoxModelTime.Size = new System.Drawing.Size(176, 28);
      this.textBoxModelTime.TabIndex = 13;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(20, 163);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(109, 20);
      this.label9.TabIndex = 3;
      this.label9.Text = "Працюють:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(20, 98);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(68, 20);
      this.label8.TabIndex = 2;
      this.label8.Text = "Черга:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(20, 33);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(113, 20);
      this.label7.TabIndex = 1;
      this.label7.Text = "Час моделі:";
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.DefaultExt = "txt";
      this.saveFileDialog.FileName = "experiment";
      this.saveFileDialog.Filter = "Text files|*.txt|All files|*.*";
      this.saveFileDialog.RestoreDirectory = true;
      // 
      // textBoxTimeToNext
      // 
      this.textBoxTimeToNext.Location = new System.Drawing.Point(118, 129);
      this.textBoxTimeToNext.Name = "textBoxTimeToNext";
      this.textBoxTimeToNext.ReadOnly = true;
      this.textBoxTimeToNext.Size = new System.Drawing.Size(82, 28);
      this.textBoxTimeToNext.TabIndex = 25;
      // 
      // buttonRun100000
      // 
      this.buttonRun100000.Location = new System.Drawing.Point(169, 562);
      this.buttonRun100000.Name = "buttonRun100000";
      this.buttonRun100000.Size = new System.Drawing.Size(167, 32);
      this.buttonRun100000.TabIndex = 18;
      this.buttonRun100000.Text = "Пуск (100000)";
      this.buttonRun100000.UseVisualStyleBackColor = true;
      this.buttonRun100000.Click += new System.EventHandler(this.buttonRun100000_Click);
      // 
      // textBoxParallel
      // 
      this.textBoxParallel.Location = new System.Drawing.Point(15, 364);
      this.textBoxParallel.Name = "textBoxParallel";
      this.textBoxParallel.Size = new System.Drawing.Size(59, 28);
      this.textBoxParallel.TabIndex = 20;
      this.textBoxParallel.Text = "1";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(12, 336);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(184, 20);
      this.label15.TabIndex = 19;
      this.label15.Text = "Паралельні моделі:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(645, 662);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBoxParameters);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Модель студентського машинного залу";
      this.groupBoxParameters.ResumeLayout(false);
      this.groupBoxParameters.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxMu;
    private System.Windows.Forms.GroupBox groupBoxParameters;
    private System.Windows.Forms.TextBox textBoxTDeviation;
    private System.Windows.Forms.TextBox textBoxT;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxMuDeviation;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxQ;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBoxA;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button buttonRun;
    private System.Windows.Forms.Button buttonStop;
    private System.Windows.Forms.Timer timerMain;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBoxRejections;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox textBoxWorking;
    private System.Windows.Forms.TextBox textBoxQueue;
    private System.Windows.Forms.TextBox textBoxModelTime;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button buttonRun100;
    private System.Windows.Forms.Button buttonRun10000;
    private System.Windows.Forms.Button buttonRun1000;
    private System.Windows.Forms.CheckBox checkBoxPrinter;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox textBoxStudentsEntered;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox textBoxStudentsReturned;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox textBoxStudentsRejected;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Button buttonRestart;
    private System.Windows.Forms.Button buttonSaveFile;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.TextBox textBoxTimeToNext;
    private System.Windows.Forms.Button buttonRun100000;
    private System.Windows.Forms.TextBox textBoxParallel;
    private System.Windows.Forms.Label label15;
  }
}

