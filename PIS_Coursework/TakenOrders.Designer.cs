namespace PIS_Coursework
{
    partial class TakenOrders
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
            dataGridViewOrders = new DataGridView();
            buttonBackWindow = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // buttonShowOrder
            // 
            buttonShowOrder.Location = new Point(307, 372);
            buttonShowOrder.Name = "buttonShowOrder";
            buttonShowOrder.Size = new Size(166, 43);
            buttonShowOrder.TabIndex = 18;
            buttonShowOrder.Text = "Подробнее о заказе";
            buttonShowOrder.UseVisualStyleBackColor = true;
            buttonShowOrder.Click += buttonShowOrder_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(147, 71);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(486, 285);
            dataGridViewOrders.TabIndex = 17;
            // 
            // buttonBackWindow
            // 
            buttonBackWindow.Location = new Point(17, 21);
            buttonBackWindow.Name = "buttonBackWindow";
            buttonBackWindow.Size = new Size(75, 23);
            buttonBackWindow.TabIndex = 16;
            buttonBackWindow.Text = "<- Назад";
            buttonBackWindow.UseVisualStyleBackColor = true;
            buttonBackWindow.Click += buttonBackWindow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(293, 13);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 15;
            label2.Text = "Активные заказы";
            // 
            // TakenOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonShowOrder);
            Controls.Add(dataGridViewOrders);
            Controls.Add(buttonBackWindow);
            Controls.Add(label2);
            Name = "TakenOrders";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Активные заказы";
            Load += TakenOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonShowOrder;
        private DataGridView dataGridViewOrders;
        private Button buttonBackWindow;
        private Label label2;
    }
}