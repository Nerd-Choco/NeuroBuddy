namespace NeuroBuddy.View
{
    partial class TaskManagerView
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            splitter1 = new Splitter();
            SetReminder = new Button();
            Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(32, 16);
            label1.TabIndex = 0;
            label1.Text = "Task ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 93);
            label2.Name = "label2";
            label2.Size = new Size(54, 16);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 24);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 93);
            label3.Name = "label3";
            label3.Size = new Size(33, 16);
            label3.TabIndex = 4;
            label3.Text = "State";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Uncompelete ", "Compelete" });
            checkedListBox1.Location = new Point(163, 112);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(113, 58);
            checkedListBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 152);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(179, 176);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 7;
            button1.Text = "Schedule Task";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 161);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 79);
            textBox2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 142);
            label5.Name = "label5";
            label5.Size = new Size(38, 16);
            label5.TabIndex = 9;
            label5.Text = "Notes";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 288);
            splitter1.TabIndex = 10;
            splitter1.TabStop = false;
            // 
            // SetReminder
            // 
            SetReminder.Location = new Point(179, 211);
            SetReminder.Name = "SetReminder";
            SetReminder.Size = new Size(97, 29);
            SetReminder.TabIndex = 11;
            SetReminder.Text = "Set Reminder";
            SetReminder.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Add.Dock = DockStyle.Bottom;
            Add.Location = new Point(3, 259);
            Add.Name = "Add";
            Add.Size = new Size(292, 29);
            Add.TabIndex = 12;
            Add.Text = "Add Task";
            Add.UseVisualStyleBackColor = true;
            // 
            // TaskManagerView
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 288);
            Controls.Add(Add);
            Controls.Add(SetReminder);
            Controls.Add(splitter1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "TaskManagerView";
            Text = "What's Planned?";
            Load += TaskMangerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private Button button1;
        private TextBox textBox2;
        private Label label5;
        private Splitter splitter1;
        private Button SetReminder;
        private Button Add;
    }
}