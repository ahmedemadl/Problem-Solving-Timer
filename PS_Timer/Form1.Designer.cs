namespace PS_Timer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.labelReading = new System.Windows.Forms.Label();
            this.labelThinking = new System.Windows.Forms.Label();
            this.labelCoding = new System.Windows.Forms.Label();
            this.labelDebugging = new System.Windows.Forms.Label();
            this.labelOptimization = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reading";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(189, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thinking\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(339, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Coding\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(495, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Debug";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(645, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Optimize";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(631, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 52);
            this.button6.TabIndex = 5;
            this.button6.Text = "Reset\r\n\r\n";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelReading
            // 
            this.labelReading.AutoSize = true;
            this.labelReading.BackColor = System.Drawing.Color.Transparent;
            this.labelReading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReading.Location = new System.Drawing.Point(54, 234);
            this.labelReading.Name = "labelReading";
            this.labelReading.Size = new System.Drawing.Size(82, 31);
            this.labelReading.TabIndex = 6;
            this.labelReading.Text = "00:00";
            this.labelReading.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelThinking
            // 
            this.labelThinking.AutoSize = true;
            this.labelThinking.BackColor = System.Drawing.Color.Transparent;
            this.labelThinking.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThinking.Location = new System.Drawing.Point(204, 234);
            this.labelThinking.Name = "labelThinking";
            this.labelThinking.Size = new System.Drawing.Size(82, 31);
            this.labelThinking.TabIndex = 7;
            this.labelThinking.Text = "00:00";
            this.labelThinking.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCoding
            // 
            this.labelCoding.AutoSize = true;
            this.labelCoding.BackColor = System.Drawing.Color.Transparent;
            this.labelCoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoding.Location = new System.Drawing.Point(356, 234);
            this.labelCoding.Name = "labelCoding";
            this.labelCoding.Size = new System.Drawing.Size(82, 31);
            this.labelCoding.TabIndex = 8;
            this.labelCoding.Text = "00:00";
            this.labelCoding.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelDebugging
            // 
            this.labelDebugging.AutoSize = true;
            this.labelDebugging.BackColor = System.Drawing.Color.Transparent;
            this.labelDebugging.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebugging.Location = new System.Drawing.Point(512, 234);
            this.labelDebugging.Name = "labelDebugging";
            this.labelDebugging.Size = new System.Drawing.Size(82, 31);
            this.labelDebugging.TabIndex = 9;
            this.labelDebugging.Text = "00:00";
            this.labelDebugging.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelOptimization
            // 
            this.labelOptimization.AutoSize = true;
            this.labelOptimization.BackColor = System.Drawing.Color.Transparent;
            this.labelOptimization.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptimization.Location = new System.Drawing.Point(662, 234);
            this.labelOptimization.Name = "labelOptimization";
            this.labelOptimization.Size = new System.Drawing.Size(82, 31);
            this.labelOptimization.TabIndex = 10;
            this.labelOptimization.Text = "00:00";
            this.labelOptimization.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(357, 365);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(98, 37);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "00:00";
            this.labelTotal.Click += new System.EventHandler(this.label6_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(26, 388);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 52);
            this.button7.TabIndex = 12;
            this.button7.Text = "Stop";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelOptimization);
            this.Controls.Add(this.labelDebugging);
            this.Controls.Add(this.labelCoding);
            this.Controls.Add(this.labelThinking);
            this.Controls.Add(this.labelReading);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Problem-Solving Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelReading;
        private System.Windows.Forms.Label labelThinking;
        private System.Windows.Forms.Label labelCoding;
        private System.Windows.Forms.Label labelDebugging;
        private System.Windows.Forms.Label labelOptimization;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button7;
    }
}

