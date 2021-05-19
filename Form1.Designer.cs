namespace Lab_Exercise_1A
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbCourse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCourse = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPartime = new System.Windows.Forms.RadioButton();
            this.rbFullTime = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.Location = new System.Drawing.Point(38, 83);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(100, 23);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name\r\n";
            // 
            // lbLastName
            // 
            this.lbLastName.Location = new System.Drawing.Point(38, 151);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(100, 23);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "Last Name\r\n";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(124, 80);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(124, 148);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lbCourse
            // 
            this.lbCourse.FormattingEnabled = true;
            this.lbCourse.Items.AddRange(new object[] {"Music\t", "Tested", "Gaming"});
            this.lbCourse.Location = new System.Drawing.Point(113, 204);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(120, 95);
            this.lbCourse.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "List box";
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.ItemHeight = 23;
            this.cbCourse.Items.AddRange(new object[] {"Music\t", "Gaming", "Politics"});
            this.cbCourse.Location = new System.Drawing.Point(103, 327);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 29);
            this.cbCourse.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "List box";
            // 
            // rbPartime
            // 
            this.rbPartime.Location = new System.Drawing.Point(113, 394);
            this.rbPartime.Name = "rbPartime";
            this.rbPartime.Size = new System.Drawing.Size(104, 24);
            this.rbPartime.TabIndex = 8;
            this.rbPartime.TabStop = true;
            this.rbPartime.Text = "Part Time";
            this.rbPartime.UseVisualStyleBackColor = true;
            // 
            // rbFullTime
            // 
            this.rbFullTime.Location = new System.Drawing.Point(232, 394);
            this.rbFullTime.Name = "rbFullTime";
            this.rbFullTime.Size = new System.Drawing.Size(104, 24);
            this.rbFullTime.TabIndex = 9;
            this.rbFullTime.TabStop = true;
            this.rbFullTime.Text = "Full Time";
            this.rbFullTime.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(563, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.Location = new System.Drawing.Point(452, 98);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(100, 23);
            this.lbOutput.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Blue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Blue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbFullTime);
            this.Controls.Add(this.rbPartime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "Form1";
            this.Text = "Question Two";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label lbOutput;

        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.RadioButton rbPartime;

        private System.Windows.Forms.RadioButton rbFullTime;

        private System.Windows.Forms.RadioButton radioButton2;

        private MetroFramework.Controls.MetroComboBox cbCourse;
        private System.Windows.Forms.RadioButton radioButton1;

        private MetroFramework.Controls.MetroComboBox metroComboBox1;

        private System.Windows.Forms.ListBox lbCourse;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;

        private System.Windows.Forms.Label lbLastName;

        private System.Windows.Forms.Label lbFirstName;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}