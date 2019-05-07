using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace LAB_
{
    public partial class Form1 : Form
    {
        List<string> names;
        Dictionary<string, List<string>> twoSignsDic;
        Dictionary<string, List<string>> threeSignsDic;
        TimeSpan readTime, threeSignsDicTime, twoSignsDicTime;
        public Form1()
        {
            InitializeComponent();
            Stopwatch timer = new Stopwatch();

            timer.Start();
            var file = new StreamReader("nazwiska.txt");
            string line;
            names = new List<string>();

            while ((line = file.ReadLine()) != null) 
            {
                //System.Console.WriteLine(line);
                var lineArray = line.Split();
                //System.Console.WriteLine(lineArray[1]);
                var temp = lineArray[1];
                //System.Console.WriteLine(temp);
                names.Add(temp);
            }
            timer.Stop();
            readTime = timer.Elapsed;
            readTimeLabel.Text = readTime.ToString();
            timer.Reset();

            timer.Start();
            twoSignsDic = new Dictionary<string, List<string>>();
            foreach (var name in names)
            {
                string twoSigns = name[0].ToString() + name[1].ToString();
                //System.Console.WriteLine(twoSigns);
                if(!twoSignsDic.ContainsKey(twoSigns))
                {
                    var tempVal = new List<string>();
                    tempVal.Add(name);
                    twoSignsDic[twoSigns] = tempVal;
                }
                else
                {
                    var tempVal = twoSignsDic[twoSigns];
                    tempVal.Add(name);
                    twoSignsDic[twoSigns] = tempVal;
                }
            }
            timer.Stop();
            twoSignsDicTime = timer.Elapsed;
            twoDicTimeLabel.Text = twoSignsDicTime.ToString();
            timer.Reset();

            timer.Start();

            threeSignsDic = new Dictionary<string, List<string>>();
            foreach (var name in names)
            {
                if (name.Length > 2)
                {
                    string threeSigns = name[0].ToString() + name[1].ToString() + name[2].ToString();
                    //System.Console.WriteLine(threeSigns);
                    if (!threeSignsDic.ContainsKey(threeSigns))
                    {
                        var tempVal = new List<string>();
                        tempVal.Add(name);
                        threeSignsDic[threeSigns] = tempVal;
                    }
                    else
                    {
                        var tempVal = threeSignsDic[threeSigns];
                        tempVal.Add(name);
                        twoSignsDic[threeSigns] = tempVal;
                    }
                }
            }
            timer.Stop();
            threeSignsDicTime = timer.Elapsed;
            threeDicTimeLabel.Text = threeSignsDicTime.ToString();
            timer.Reset();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            if(inputText.Text.Length == 0)
            {
                firstSearched.Text = " ";
            }
            else if(inputText.Text.Length==2)
            {
                try
                {
                    var temp = twoSignsDic[inputText.Text];
                    firstSearched.Text = temp[0];
                }
                catch
                {
                    firstSearched.Text = "Nie istnieje";
                }
                
            }
            else if (inputText.Text.Length == 3)
            {
                try
                {
                    var temp = threeSignsDic[inputText.Text];
                    firstSearched.Text = temp[0];
                }
                catch
                {
                    firstSearched.Text = "Nie istnieje";
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
