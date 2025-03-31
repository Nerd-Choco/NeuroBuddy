
namespace NeuroBuddy
{
    partial class LoggingView
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            SignUpBtn = new Button();
            SignInBtn = new Button();
            NameBox = new TextBox();
            NameLabel = new Label();
            PasswordLabel = new Label();
            PasswordBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(28, 201);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(88, 36);
            SignUpBtn.TabIndex = 0;
            SignUpBtn.Text = "Sign up";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += this.SignUpBtn_Click;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(131, 201);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(88, 36);
            SignInBtn.TabIndex = 1;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(28, 90);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(191, 23);
            NameBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(28, 71);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(38, 16);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(28, 122);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 16);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(28, 141);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(191, 23);
            PasswordBox.TabIndex = 4;
            // 
            // LoggingView
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(248, 315);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordBox);
            Controls.Add(NameLabel);
            Controls.Add(NameBox);
            Controls.Add(SignInBtn);
            Controls.Add(SignUpBtn);
            Name = "LoggingView";
            Text = "Neuro Buddy";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private BindingSource bindingSource1;
        private Button SignUpBtn;
        private Button SignInBtn;
        private TextBox NameBox;
        private Label NameLabel;
        private Label PasswordLabel;
        private TextBox PasswordBox;
    }
}
