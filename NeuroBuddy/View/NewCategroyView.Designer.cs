namespace NeuroBuddy.View
{
    partial class NewCategroyView
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
            comboBox1 = new ComboBox();
            parentCategory = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            AddCategory = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Root" });
            comboBox1.Location = new Point(48, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 24);
            comboBox1.TabIndex = 0;
            // 
            // parentCategory
            // 
            parentCategory.AutoSize = true;
            parentCategory.Location = new Point(48, 72);
            parentCategory.Name = "parentCategory";
            parentCategory.Size = new Size(91, 16);
            parentCategory.TabIndex = 1;
            parentCategory.Text = "Parent CategoryLabel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 17);
            label2.Name = "label2";
            label2.Size = new Size(88, 16);
            label2.TabIndex = 2;
            label2.Text = "Categroy Title";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 3;
            // 
            // AddCategory
            // 
            AddCategory.Dock = DockStyle.Bottom;
            AddCategory.Location = new Point(0, 244);
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(251, 36);
            AddCategory.TabIndex = 4;
            AddCategory.Text = "Add CategoryLabel";
            AddCategory.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(AddCategory);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(parentCategory);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(16, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 280);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 130);
            label3.Name = "label3";
            label3.Size = new Size(49, 16);
            label3.TabIndex = 5;
            label3.Text = "Set Icon";
            // 
            // NewCategroyView
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 318);
            Controls.Add(panel1);
            Name = "NewCategroyView";
            Text = "NewCategroyView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label parentCategory;
        private Label label2;
        private TextBox textBox1;
        private Button AddCategory;
        private Panel panel1;
        private Label label3;
    }
}