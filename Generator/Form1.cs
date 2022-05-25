using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Generator
{
    public partial class Form1 : Form
    {
        private readonly string file = @"./list.txt";
        private readonly string obsFile = @"./obs.txt";
        private readonly System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
            this.init();

            aTimer = new System.Timers.Timer();
            aTimer.Interval = 30 * 1000;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void init()
        {
            try
            {
                if (!File.Exists(this.file))
                {
                    using (FileStream fs = File.Create(this.file))
                    {
                        Byte[] empty = new UTF8Encoding(true).GetBytes("");
                        fs.Write(empty, 0, empty.Length);
                        fs.Close();
                    }
                }

                if (!File.Exists(this.obsFile))
                {
                    using (FileStream fs = File.Create(this.obsFile))
                    {
                        Byte[] empty = new UTF8Encoding(true).GetBytes("");
                        fs.Write(empty, 0, empty.Length);
                        fs.Close();
                    }
                }

                FileInfo fi = new FileInfo(this.obsFile);
                obsFilePathTextBox.Text = fi.FullName;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.file))
            {
                MessageBox.Show("Le fichier n'existe plus");
                return;
            }
            try
            {
                if (addToListInput.TextLength == 0)
                {
                    return;
                }

                File.AppendAllText(this.file, addToListInput.Text + Environment.NewLine);
                addToListInput.Text = null;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                MessageBox.Show("Une erreur est survenue");
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(this.obsFile);
            Process.Start(fi.FullName);
        }

        private void buttonOpenList_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(this.file);
            Process.Start(fi.FullName);
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                var lines = File.ReadAllLines(this.file);
                Random rnd = new Random();
                int rng = rnd.Next(0, lines.Count());
                File.WriteAllText(this.obsFile, lines[rng]);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }
        }
    }
}
