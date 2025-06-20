using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Timer
{
    public partial class Form1 : Form
    {
        // Time counters in seconds
        int readingTime = 0;
        int thinkingTime = 0;
        int codingTime = 0;
        int debuggingTime = 0;
        int optimizationTime = 0;
        int totalTime = 0;

        // Enum to track current phase
        enum Phase { None, Reading, Thinking, Coding, Debugging, Optimization }
        Phase currentPhase = Phase.None;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) // Reading Time button
        {
            currentPhase = Phase.Reading;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e) // Thinking Time button
        {
            currentPhase = Phase.Thinking;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e) // coding Time button
        {
            currentPhase = Phase.Coding;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e) // Debugging Time button
        {
            currentPhase = Phase.Debugging;
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e) // Optimization Time button
        {
            currentPhase = Phase.Optimization;
            timer1.Start();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e) // Reset Time button
        {
            timer1.Stop();
            currentPhase = Phase.None;

            readingTime = thinkingTime = codingTime = debuggingTime = optimizationTime = totalTime = 0;

            labelReading.Text = "00:00";
            labelThinking.Text = "00:00";
            labelCoding.Text = "00:00";
            labelDebugging.Text = "00:00";
            labelOptimization.Text = "00:00";
            labelTotal.Text = "00:00";
        }
        private void button7_Click(object sender, EventArgs e) // Stop Timer button
        {
            timer1.Stop();
            currentPhase = Phase.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            totalTime++;

            switch (currentPhase)
            {
                case Phase.Reading:
                    readingTime++;
                    labelReading.Text = $"{TimeSpan.FromSeconds(readingTime):mm\\:ss}";
                    break;

                case Phase.Thinking:
                    thinkingTime++;
                    labelThinking.Text = $"{TimeSpan.FromSeconds(thinkingTime):mm\\:ss}";
                    break;

                case Phase.Coding:
                    codingTime++;
                    labelCoding.Text = $"{TimeSpan.FromSeconds(codingTime):mm\\:ss}";
                    break;

                case Phase.Debugging:
                    debuggingTime++;
                    labelDebugging.Text = $"{TimeSpan.FromSeconds(debuggingTime):mm\\:ss}";
                    break;

                case Phase.Optimization:
                    optimizationTime++;
                    labelOptimization.Text = $"{TimeSpan.FromSeconds(optimizationTime):mm\\:ss}";
                    break;
            }

            labelTotal.Text = $"{TimeSpan.FromSeconds(totalTime):mm\\:ss}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
