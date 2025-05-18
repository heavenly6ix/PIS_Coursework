namespace PIS_Coursework
{
    partial class CourierMainWindow
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
            buttonExitSystem = new Button();
            buttonLogOut = new Button();
            buttonLoadActiveOrderList = new Button();
            buttonLoadOrdersList = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonExitSystem
            // 
            buttonExitSystem.Location = new Point(246, 258);
            buttonExitSystem.Name = "buttonExitSystem";
            buttonExitSystem.Size = new Size(308, 41);
            buttonExitSystem.TabIndex = 3;
            buttonExitSystem.Text = "Выйти из системы";
            buttonExitSystem.UseVisualStyleBackColor = true;
            buttonExitSystem.Click += buttonExitSystem_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(246, 212);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(308, 41);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "Выйти из аккаунта";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonLoadActiveOrderList
            // 
            buttonLoadActiveOrderList.Location = new Point(246, 165);
            buttonLoadActiveOrderList.Name = "buttonLoadActiveOrderList";
            buttonLoadActiveOrderList.Size = new Size(308, 41);
            buttonLoadActiveOrderList.TabIndex = 7;
            buttonLoadActiveOrderList.Text = "Активные заказы";
            buttonLoadActiveOrderList.UseVisualStyleBackColor = true;
            buttonLoadActiveOrderList.Click += buttonLoadActiveOrderList_Click;
            // 
            // buttonLoadOrdersList
            // 
            buttonLoadOrdersList.Location = new Point(246, 119);
            buttonLoadOrdersList.Name = "buttonLoadOrdersList";
            buttonLoadOrdersList.Size = new Size(308, 41);
            buttonLoadOrdersList.TabIndex = 8;
            buttonLoadOrdersList.Text = "Список заказов";
            buttonLoadOrdersList.UseVisualStyleBackColor = true;
            buttonLoadOrdersList.Click += buttonLoadOrdersList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(272, 60);
            label1.Name = "label1";
            label1.Size = new Size(254, 30);
            label1.TabIndex = 2;
            label1.Text = "Главное меню системы";
            // 
            // CourierMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExitSystem);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonLoadActiveOrderList);
            Controls.Add(buttonLoadOrdersList);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CourierMainWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonExitSystem;
        private Button buttonLogOut;
        private Button buttonLoadActiveOrderList;
        private Button buttonLoadOrdersList;
        private Label label1;
    }
}