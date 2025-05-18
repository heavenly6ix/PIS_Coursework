namespace PIS_Coursework
{
    partial class InfoOrderWindow
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
            dataGridViewOrderItems = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelIdOrder = new Label();
            labelStatusOrder = new Label();
            labelCourier = new Label();
            labelCreatedDate = new Label();
            label6 = new Label();
            labelAdress = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // buttonBackWindow
            // 
            buttonBackWindow.Location = new Point(14, 25);
            buttonBackWindow.Name = "buttonBackWindow";
            buttonBackWindow.Size = new Size(75, 23);
            buttonBackWindow.TabIndex = 9;
            buttonBackWindow.Text = "<- Назад";
            buttonBackWindow.UseVisualStyleBackColor = true;
            buttonBackWindow.Click += buttonBackWindow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(280, 17);
            label2.Name = "label2";
            label2.Size = new Size(241, 30);
            label2.TabIndex = 8;
            label2.Text = "Информация о заказе";
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(153, 83);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.Size = new Size(486, 158);
            dataGridViewOrderItems.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 272);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 11;
            label1.Text = "Номер заказа:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 302);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 11;
            label3.Text = "Статус заказа:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 362);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 11;
            label4.Text = "Курьер:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 332);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 11;
            label5.Text = "Дата заказа:";
            // 
            // labelIdOrder
            // 
            labelIdOrder.AutoSize = true;
            labelIdOrder.Location = new Point(244, 272);
            labelIdOrder.Name = "labelIdOrder";
            labelIdOrder.Size = new Size(0, 15);
            labelIdOrder.TabIndex = 11;
            // 
            // labelStatusOrder
            // 
            labelStatusOrder.AutoSize = true;
            labelStatusOrder.Location = new Point(242, 302);
            labelStatusOrder.Name = "labelStatusOrder";
            labelStatusOrder.Size = new Size(0, 15);
            labelStatusOrder.TabIndex = 11;
            // 
            // labelCourier
            // 
            labelCourier.AutoSize = true;
            labelCourier.Location = new Point(208, 362);
            labelCourier.Name = "labelCourier";
            labelCourier.Size = new Size(0, 15);
            labelCourier.TabIndex = 11;
            // 
            // labelCreatedDate
            // 
            labelCreatedDate.AutoSize = true;
            labelCreatedDate.Location = new Point(241, 332);
            labelCreatedDate.Name = "labelCreatedDate";
            labelCreatedDate.Size = new Size(0, 15);
            labelCreatedDate.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 302);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 11;
            label6.Text = "Адрес доставки:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(248, 302);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(0, 15);
            labelAdress.TabIndex = 11;
            // 
            // InfoOrderWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCreatedDate);
            Controls.Add(label5);
            Controls.Add(labelAdress);
            Controls.Add(labelCourier);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(labelStatusOrder);
            Controls.Add(label3);
            Controls.Add(labelIdOrder);
            Controls.Add(label1);
            Controls.Add(dataGridViewOrderItems);
            Controls.Add(buttonBackWindow);
            Controls.Add(label2);
            Name = "InfoOrderWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о заказе";
            Load += InfoOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBackWindow;
        private Label label2;
        private DataGridView dataGridViewOrderItems;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelIdOrder;
        private Label labelStatusOrder;
        private Label labelCourier;
        private Label labelCreatedDate;
        private Label label6;
        private Label labelAdress;
    }
}