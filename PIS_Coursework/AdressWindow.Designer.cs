namespace PIS_Coursework
{
    partial class AdressWindow
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
            label2 = new Label();
            labelAdress = new Label();
            buttonBackWindow = new Button();
            buttonChangeAdress = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(97, 20);
            label1.Name = "label1";
            label1.Size = new Size(201, 30);
            label1.TabIndex = 0;
            label1.Text = "Адрес мастерской";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 1;
            label2.Text = "Адрес вашей мастерской:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(27, 92);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(0, 15);
            labelAdress.TabIndex = 2;
            // 
            // buttonBackWindow
            // 
            buttonBackWindow.Location = new Point(112, 136);
            buttonBackWindow.Name = "buttonBackWindow";
            buttonBackWindow.Size = new Size(85, 31);
            buttonBackWindow.TabIndex = 3;
            buttonBackWindow.Text = "OK";
            buttonBackWindow.UseVisualStyleBackColor = true;
            buttonBackWindow.Click += buttonBackWindow_Click;
            // 
            // buttonChangeAdress
            // 
            buttonChangeAdress.Location = new Point(203, 136);
            buttonChangeAdress.Name = "buttonChangeAdress";
            buttonChangeAdress.Size = new Size(85, 31);
            buttonChangeAdress.TabIndex = 3;
            buttonChangeAdress.Text = "Изменить";
            buttonChangeAdress.UseVisualStyleBackColor = true;
            buttonChangeAdress.Click += buttonChangeAdress_Click;
            // 
            // AdressWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 195);
            Controls.Add(buttonChangeAdress);
            Controls.Add(buttonBackWindow);
            Controls.Add(labelAdress);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdressWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Адрес мастерской";
            Load += AdressWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelAdress;
        private Button buttonBackWindow;
        private Button buttonChangeAdress;
    }
}