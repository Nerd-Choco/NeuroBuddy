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
            Task_Box = new TextBox();
            Category = new Label();
            CategoryList = new ComboBox();
            State = new Label();
            StateCheckBox = new CheckedListBox();
            label4 = new Label();
            ScheduleTaskBtn = new Button();
            textBox2 = new TextBox();
            Notes = new Label();
            SetReminder = new Button();
            Add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(29, 16);
            label1.TabIndex = 0;
            label1.Text = "Task";
            // 
            // Task_Box
            // 
            Task_Box.Location = new Point(32, 57);
            Task_Box.Name = "Task_Box";
            Task_Box.Size = new Size(244, 23);
            Task_Box.TabIndex = 1;
            Task_Box.TextChanged += Task_Box_TextChanged;
            // 
            // Category
            // 
            Category.AutoSize = true;
            Category.Location = new Point(32, 93);
            Category.Name = "Category";
            Category.Size = new Size(54, 16);
            Category.TabIndex = 2;
            Category.Text = "Category";
            // 
            // CategoryList
            // 
            CategoryList.FormattingEnabled = true;
            CategoryList.Location = new Point(32, 112);
            CategoryList.Name = "CategoryList";
            CategoryList.Size = new Size(125, 24);
            CategoryList.TabIndex = 3;
            CategoryList.SelectedIndexChanged += CategoryList_SelectedIndexChanged;
            // 
            // State
            // 
            State.AutoSize = true;
            State.Location = new Point(163, 93);
            State.Name = "State";
            State.Size = new Size(33, 16);
            State.TabIndex = 4;
            State.Text = "State";
            // 
            // StateCheckBox
            // 
            StateCheckBox.FormattingEnabled = true;
            StateCheckBox.Items.AddRange(new object[] { "Not Started", "In Progress", "incompelete ", "Compelete" });
            StateCheckBox.Location = new Point(163, 112);
            StateCheckBox.Name = "StateCheckBox";
            StateCheckBox.Size = new Size(113, 76);
            StateCheckBox.TabIndex = 5;
            StateCheckBox.SelectedIndexChanged += StateCheckBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 152);
            label4.Name = "label4";
            label4.Size = new Size(0, 16);
            label4.TabIndex = 6;
            // 
            // ScheduleTaskBtn
            // 
            ScheduleTaskBtn.Location = new Point(163, 194);
            ScheduleTaskBtn.Name = "ScheduleTaskBtn";
            ScheduleTaskBtn.Size = new Size(113, 29);
            ScheduleTaskBtn.TabIndex = 7;
            ScheduleTaskBtn.Text = "Schedule NeuroTask";
            ScheduleTaskBtn.UseVisualStyleBackColor = true;
            ScheduleTaskBtn.Click += ScheduleTaskBtn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 161);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 97);
            textBox2.TabIndex = 8;
            // 
            // Notes
            // 
            Notes.AutoSize = true;
            Notes.Location = new Point(32, 142);
            Notes.Name = "Notes";
            Notes.Size = new Size(38, 16);
            Notes.TabIndex = 9;
            Notes.Text = "Notes";
            // 
            // SetReminder
            // 
            SetReminder.Location = new Point(163, 229);
            SetReminder.Name = "SetReminder";
            SetReminder.Size = new Size(113, 29);
            SetReminder.TabIndex = 11;
            SetReminder.Text = "Set Reminder";
            SetReminder.UseVisualStyleBackColor = true;
            SetReminder.Click += SetReminder_Click;
            // 
            // Add
            // 
            Add.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Add.Dock = DockStyle.Bottom;
            Add.Location = new Point(0, 269);
            Add.Name = "Add";
            Add.Size = new Size(303, 29);
            Add.TabIndex = 12;
            Add.Text = "Add Task";
            Add.TextImageRelation = TextImageRelation.ImageAboveText;
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // TaskManagerView
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 298);
            Controls.Add(Add);
            Controls.Add(SetReminder);
            Controls.Add(Notes);
            Controls.Add(textBox2);
            Controls.Add(ScheduleTaskBtn);
            Controls.Add(label4);
            Controls.Add(StateCheckBox);
            Controls.Add(State);
            Controls.Add(CategoryList);
            Controls.Add(Category);
            Controls.Add(Task_Box);
            Controls.Add(label1);
            Name = "TaskManagerView";
            Text = "What's Planned?";
            Load += TaskMangerView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Task_Box;
        private Label Category;
        private ComboBox CategoryList;
        private Label State;
        private CheckedListBox StateCheckBox;
        private Label label4;
        private Button ScheduleTaskBtn;
        private TextBox textBox2;
        private Label Notes;
        private Button SetReminder;
        private Button Add;
    }
}