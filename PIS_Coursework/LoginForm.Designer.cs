namespace PIS_Coursework
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_Login = new TextBox();
            textBox_Password = new TextBox();
            buttonEntering = new Button();
            buttonExitSystem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(124, 29);
            label1.Name = "label1";
            label1.Size = new Size(169, 30);
            label1.TabIndex = 0;
            label1.Text = "Вход в систему";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(43, 97);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 0;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(43, 167);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 0;
            label3.Text = "Пароль";
            // 
            // textBox_Login
            // 
            textBox_Login.Location = new Point(43, 125);
            textBox_Login.Name = "textBox_Login";
            textBox_Login.Size = new Size(343, 23);
            textBox_Login.TabIndex = 1;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(43, 195);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(343, 23);
            textBox_Password.TabIndex = 2;
            // 
            // buttonEntering
            // 
            buttonEntering.Location = new Point(78, 252);
            buttonEntering.Name = "buttonEntering";
            buttonEntering.Size = new Size(131, 39);
            buttonEntering.TabIndex = 3;
            buttonEntering.Text = "Войти";
            buttonEntering.UseVisualStyleBackColor = true;
            buttonEntering.Click += buttonEntering_Click;
            // 
            // buttonExitSystem
            // 
            buttonExitSystem.Location = new Point(215, 252);
            buttonExitSystem.Name = "buttonExitSystem";
            buttonExitSystem.Size = new Size(131, 39);
            buttonExitSystem.TabIndex = 4;
            buttonExitSystem.Text = "Выйти из системы";
            buttonExitSystem.UseVisualStyleBackColor = true;
            buttonExitSystem.Click += buttonExitSystem_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 323);
            Controls.Add(buttonExitSystem);
            Controls.Add(buttonEntering);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Login;
        private TextBox textBox_Password;
        private Button buttonEntering;
        private Button buttonExitSystem;
    }
}
