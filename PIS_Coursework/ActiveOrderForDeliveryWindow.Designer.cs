namespace PIS_Coursework
{
    partial class ActiveOrderForDeliveryWindow
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
            buttonShowOrder = new Button();
            buttonTakeOrder = new Button();
            dataGridViewOrders = new DataGridView();
            buttonBackWindow = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // buttonShowOrder
            // 
            buttonShowOrder.Location = new Point(226, 374);
            buttonShowOrder.Name = "buttonShowOrder";
            buttonShowOrder.Size = new Size(166, 43);
            buttonShowOrder.TabIndex = 13;
            buttonShowOrder.Text = "Подробнее о заказе";
            buttonShowOrder.UseVisualStyleBackColor = true;
            buttonShowOrder.Click += buttonShowOrder_Click;
            // 
            // buttonTakeOrder
            // 
            buttonTakeOrder.Location = new Point(398, 374);
            buttonTakeOrder.Name = "buttonTakeOrder";
            buttonTakeOrder.Size = new Size(166, 43);
            buttonTakeOrder.TabIndex = 14;
            buttonTakeOrder.Text = "Принять заказ";
            buttonTakeOrder.UseVisualStyleBackColor = true;
            buttonTakeOrder.Click += buttonTakeOrder_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(146, 74);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(486, 285);
            dataGridViewOrders.TabIndex = 12;
            // 
            // buttonBackWindow
            // 
            buttonBackWindow.Location = new Point(16, 24);
            buttonBackWindow.Name = "buttonBackWindow";
            buttonBackWindow.Size = new Size(75, 23);
            buttonBackWindow.TabIndex = 11;
            buttonBackWindow.Text = "<- Назад";
            buttonBackWindow.UseVisualStyleBackColor = true;
            buttonBackWindow.Click += buttonBackWindow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(292, 16);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 10;
            label2.Text = "Список заказов";
            // 
            // ActiveOrderForDeliveryWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowOrder);
            Controls.Add(buttonTakeOrder);
            Controls.Add(dataGridViewOrders);
            Controls.Add(buttonBackWindow);
            Controls.Add(label2);
            Name = "ActiveOrderForDeliveryWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Активные заказы";
            Load += ActiveOrderForDeliveryWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShowOrder;
        private Button buttonTakeOrder;
        private DataGridView dataGridViewOrders;
        private Button buttonBackWindow;
        private Label label2;
    }
}