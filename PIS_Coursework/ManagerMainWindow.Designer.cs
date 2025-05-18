
namespace PIS_Coursework
{
    partial class ManagerMainWindow
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
            buttonLoadCreateOrder = new Button();
            buttonLoadActiveOrderList = new Button();
            buttonLoadHistoryOrders = new Button();
            buttonLoadAdress = new Button();
            buttonLogOut = new Button();
            buttonExitSystem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(271, 40);
            label1.Name = "label1";
            label1.Size = new Size(254, 30);
            label1.TabIndex = 0;
            label1.Text = "Главное меню системы";
            // 
            // buttonLoadCreateOrder
            // 
            buttonLoadCreateOrder.Location = new Point(245, 99);
            buttonLoadCreateOrder.Name = "buttonLoadCreateOrder";
            buttonLoadCreateOrder.Size = new Size(308, 41);
            buttonLoadCreateOrder.TabIndex = 1;
            buttonLoadCreateOrder.Text = "Сформировать заказ";
            buttonLoadCreateOrder.UseVisualStyleBackColor = true;
            buttonLoadCreateOrder.Click += buttonLoadCreateOrder_Click;
            // 
            // buttonLoadActiveOrderList
            // 
            buttonLoadActiveOrderList.Location = new Point(245, 145);
            buttonLoadActiveOrderList.Name = "buttonLoadActiveOrderList";
            buttonLoadActiveOrderList.Size = new Size(308, 41);
            buttonLoadActiveOrderList.TabIndex = 1;
            buttonLoadActiveOrderList.Text = "Активные заказы";
            buttonLoadActiveOrderList.UseVisualStyleBackColor = true;
            buttonLoadActiveOrderList.Click += buttonLoadActiveOrderList_Click;
            // 
            // buttonLoadHistoryOrders
            // 
            buttonLoadHistoryOrders.Location = new Point(245, 191);
            buttonLoadHistoryOrders.Name = "buttonLoadHistoryOrders";
            buttonLoadHistoryOrders.Size = new Size(308, 41);
            buttonLoadHistoryOrders.TabIndex = 1;
            buttonLoadHistoryOrders.Text = "История заказов";
            buttonLoadHistoryOrders.UseVisualStyleBackColor = true;
            buttonLoadHistoryOrders.Click += buttonLoadHistoryOrders_Click;
            // 
            // buttonLoadAdress
            // 
            buttonLoadAdress.Location = new Point(245, 237);
            buttonLoadAdress.Name = "buttonLoadAdress";
            buttonLoadAdress.Size = new Size(308, 41);
            buttonLoadAdress.TabIndex = 1;
            buttonLoadAdress.Text = "Адрес мастерской";
            buttonLoadAdress.UseVisualStyleBackColor = true;
            buttonLoadAdress.Click += buttonLoadAdress_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Location = new Point(245, 283);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(308, 41);
            buttonLogOut.TabIndex = 1;
            buttonLogOut.Text = "Выйти из аккаунта";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonExitSystem
            // 
            buttonExitSystem.Location = new Point(245, 329);
            buttonExitSystem.Name = "buttonExitSystem";
            buttonExitSystem.Size = new Size(308, 41);
            buttonExitSystem.TabIndex = 1;
            buttonExitSystem.Text = "Выйти из системы";
            buttonExitSystem.UseVisualStyleBackColor = true;
            buttonExitSystem.Click += buttonExitSystem_Click;
            // 
            // ManagerMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExitSystem);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonLoadAdress);
            Controls.Add(buttonLoadHistoryOrders);
            Controls.Add(buttonLoadActiveOrderList);
            Controls.Add(buttonLoadCreateOrder);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManagerMainWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню системы";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonLoadCreateOrder;
        private Button buttonLoadActiveOrderList;
        private Button buttonLoadHistoryOrders;
        private Button buttonLoadAdress;
        private Button buttonLogOut;
        private Button buttonExitSystem;
    }
}