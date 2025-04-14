namespace NeuroBuddy.View
{
    partial class AddTaskView
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
            TaskLabel = new Label();
            TaskNameTextBox = new TextBox();
            CategoryLabel = new Label();
            CategoryListComboBox = new ComboBox();
            StateLabel = new Label();
            StateCheckListBox = new CheckedListBox();
            label4 = new Label();
            ScheduleTaskBtn = new Button();
            NoteTextBox = new TextBox();
            NotesLabel = new Label();
            SetReminderBtn = new Button();
            AddBtn = new Button();
            SuspendLayout();
            // 
            // TaskLabel
            // 
            TaskLabel.AutoSize = true;
            TaskLabel.Location = new Point(32, 38);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(29, 16);
            TaskLabel.TabIndex = 0;
            TaskLabel.Text = "Task";
            // 
            // TaskNameTextBox
            // 
            TaskNameTextBox.Location = new Point(32, 57);
            TaskNameTextBox.Name = "TaskNameTextBox";
            TaskNameTextBox.Size = new Size(244, 23);
            TaskNameTextBox.TabIndex = 1;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(32, 93);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(54, 16);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category";
            // 
            // CategoryListComboBox
            // 
            CategoryListComboBox.FormattingEnabled = true;
            CategoryListComboBox.Location = new Point(32, 112);
            CategoryListComboBox.Name = "CategoryListComboBox";
            CategoryListComboBox.Size = new Size(125, 24);
            CategoryListComboBox.TabIndex = 3;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Location = new Point(163, 93);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(33, 16);
            StateLabel.TabIndex = 4;
            StateLabel.Text = "State";
            // 
            // StateCheckListBox
            // 
            StateCheckListBox.FormattingEnabled = true;
            StateCheckListBox.Items.AddRange(new object[] { "Not Started", "In Progress", "incompelete ", "Compelete" });
            StateCheckListBox.Location = new Point(163, 112);
            StateCheckListBox.Name = "StateCheckListBox";
            StateCheckListBox.Size = new Size(113, 76);
            StateCheckListBox.TabIndex = 5;
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
            ScheduleTaskBtn.Text = "Schedule";
            ScheduleTaskBtn.UseVisualStyleBackColor = true;
            ScheduleTaskBtn.Click += ScheduleTaskBtn_Click;
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(32, 161);
            NoteTextBox.Multiline = true;
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(125, 97);
            NoteTextBox.TabIndex = 8;
            // 
            // NotesLabel
            // 
            NotesLabel.AutoSize = true;
            NotesLabel.Location = new Point(32, 142);
            NotesLabel.Name = "NotesLabel";
            NotesLabel.Size = new Size(38, 16);
            NotesLabel.TabIndex = 9;
            NotesLabel.Text = "Notes";
            // 
            // SetReminderBtn
            // 
            SetReminderBtn.Location = new Point(163, 229);
            SetReminderBtn.Name = "SetReminderBtn";
            SetReminderBtn.Size = new Size(113, 29);
            SetReminderBtn.TabIndex = 11;
            SetReminderBtn.Text = "Set Reminder";
            SetReminderBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddBtn.Dock = DockStyle.Bottom;
            AddBtn.Location = new Point(0, 269);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(303, 29);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Add Task";
            AddBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += Add_Click;
            // 
            // AddTaskView
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 298);
            Controls.Add(AddBtn);
            Controls.Add(SetReminderBtn);
            Controls.Add(NotesLabel);
            Controls.Add(NoteTextBox);
            Controls.Add(ScheduleTaskBtn);
            Controls.Add(label4);
            Controls.Add(StateCheckListBox);
            Controls.Add(StateLabel);
            Controls.Add(CategoryListComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(TaskNameTextBox);
            Controls.Add(TaskLabel);
            Name = "AddTaskView";
            Text = "What's Planned?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TaskLabel;
        private TextBox TaskNameTextBox;
        private Label CategoryLabel;
        private ComboBox CategoryListComboBox;
        private Label StateLabel;
        private CheckedListBox StateCheckListBox;
        private Label label4;
        private Button ScheduleTaskBtn;
        private TextBox NoteTextBox;
        private Label NotesLabel;
        private Button SetReminderBtn;
        private Button AddBtn;
    }
}