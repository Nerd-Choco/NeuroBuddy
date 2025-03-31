namespace NeuroBuddy.View
{
    partial class scheduledTaskForm
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
            dateTimePicker1 = new DateTimePicker();
            DateLabel = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(42, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(42, 45);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(65, 16);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "Pick a Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 100);
            label1.Name = "label1";
            label1.Size = new Size(68, 16);
            label1.TabIndex = 2;
            label1.Text = "Time Range";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(18, 24);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(56, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(114, 24);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(53, 23);
            numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(114, 68);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(53, 23);
            numericUpDown3.TabIndex = 5;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(21, 68);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(53, 23);
            numericUpDown4.TabIndex = 6;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 5);
            label2.Name = "label2";
            label2.Size = new Size(34, 16);
            label2.TabIndex = 7;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 31);
            label3.Name = "label3";
            label3.Size = new Size(20, 16);
            label3.TabIndex = 8;
            label3.Text = "Hr";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 75);
            label4.Name = "label4";
            label4.Size = new Size(27, 16);
            label4.TabIndex = 9;
            label4.Text = "min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 75);
            label5.Name = "label5";
            label5.Size = new Size(20, 16);
            label5.TabIndex = 8;
            label5.Text = "Hr";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 31);
            label6.Name = "label6";
            label6.Size = new Size(27, 16);
            label6.TabIndex = 9;
            label6.Text = "min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 50);
            label7.Name = "label7";
            label7.Size = new Size(19, 16);
            label7.TabIndex = 10;
            label7.Text = "To";
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numericUpDown4);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(39, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 118);
            panel1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Time range", "Amount of time", "Event" });
            comboBox1.Location = new Point(42, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 24);
            comboBox1.TabIndex = 12;
            // 
            // scheduledTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 337);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(DateLabel);
            Controls.Add(dateTimePicker1);
            Name = "scheduledTaskForm";
            Text = "scheduledTaskForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label DateLabel;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private ComboBox comboBox1;
    }
}