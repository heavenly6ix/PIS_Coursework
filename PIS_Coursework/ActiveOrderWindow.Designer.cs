namespace PIS_Coursework
{
    partial class ActiveOrderWindow
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
            buttonBackWindow = new Button();
            label2 = new Label();
            dataGridViewOrders = new DataGridView();
            buttonDeleteOrder = new Button();
            buttonShowOrder = new Button();
            buttonConfirmOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // buttonBackWindow
            // 
            buttonBackWindow.Location = new Point(10, 21);
            buttonBackWindow.Name = "buttonBackWindow";
            buttonBackWindow.Size = new Size(75, 23);
            buttonBackWindow.TabIndex = 7;
            buttonBackWindow.Text = "<- Назад";
            buttonBackWindow.UseVisualStyleBackColor = true;
            buttonBackWindow.Click += buttonBackWindow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(286, 13);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 6;
            label2.Text = "Активные заказы";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(140, 71);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(486, 285);
            dataGridViewOrders.TabIndex = 8;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.Location = new Point(472, 372);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(166, 43);
            buttonDeleteOrder.TabIndex = 9;
            buttonDeleteOrder.Text = "Отменить заказ";
            buttonDeleteOrder.UseVisualStyleBackColor = true;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // buttonShowOrder
            // 
            buttonShowOrder.Location = new Point(128, 372);
            buttonShowOrder.Name = "buttonShowOrder";
            buttonShowOrder.Size = new Size(166, 43);
            buttonShowOrder.TabIndex = 9;
            buttonShowOrder.Text = "Подробнее о заказе";
            buttonShowOrder.UseVisualStyleBackColor = true;
            buttonShowOrder.Click += buttonShowOrder_Click;
            // 
            // buttonConfirmOrder
            // 
            buttonConfirmOrder.Location = new Point(300, 372);
            buttonConfirmOrder.Name = "buttonConfirmOrder";
            buttonConfirmOrder.Size = new Size(166, 43);
            buttonConfirmOrder.TabIndex = 9;
            buttonConfirmOrder.Text = "Подтвердить заказ";
            buttonConfirmOrder.UseVisualStyleBackColor = true;
            buttonConfirmOrder.Click += buttonConfirmOrder_Click;
            // 
            // ActiveOrderWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowOrder);
            Controls.Add(buttonConfirmOrder);
            Controls.Add(buttonDeleteOrder);
            Controls.Add(dataGridViewOrders);
            Controls.Add(buttonBackWindow);
            Controls.Add(label2);
            Name = "ActiveOrderWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Активные заказы";
            Load += ActiveOrderWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonBackWindow;
        private Label label2;
        private DataGridView dataGridViewOrders;
        private Button buttonDeleteOrder;
        private Button buttonShowOrder;
        private Button buttonConfirmOrder;
    }
}