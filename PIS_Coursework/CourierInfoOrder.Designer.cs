namespace PIS_Coursework
{
    partial class CourierInfoOrder
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
            labelCreatedDate = new Label();
            label5 = new Label();
            labelAdress = new Label();
            label6 = new Label();
            labelIdOrder = new Label();
            label1 = new Label();
            dataGridViewOrderItems = new DataGridView();
            buttonBackWindow = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBoxStatus = new ComboBox();
            buttonConfirmChanges = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // labelCreatedDate
            // 
            labelCreatedDate.AutoSize = true;
            labelCreatedDate.Location = new Point(242, 335);
            labelCreatedDate.Name = "labelCreatedDate";
            labelCreatedDate.Size = new Size(0, 15);
            labelCreatedDate.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 335);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 16;
            label5.Text = "Дата заказа:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(249, 304);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(0, 15);
            labelAdress.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(154, 304);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 19;
            label6.Text = "Адрес доставки:";
            // 
            // labelIdOrder
            // 
            labelIdOrder.AutoSize = true;
            labelIdOrder.Location = new Point(245, 275);
            labelIdOrder.Name = "labelIdOrder";
            labelIdOrder.Size = new Size(0, 15);
            labelIdOrder.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 275);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 24;
            label1.Text = "Номер заказа:";
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(154, 86);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.Size = new Size(486, 158);
            dataGridViewOrderItems.TabIndex = 14;
            // 
            // buttonBackWindow
            // 
            buttonBackWindow.Location = new Point(15, 28);
            buttonBackWindow.Name = "buttonBackWindow";
            buttonBackWindow.Size = new Size(75, 23);
            buttonBackWindow.TabIndex = 13;
            buttonBackWindow.Text = "<- Назад";
            buttonBackWindow.UseVisualStyleBackColor = true;
            buttonBackWindow.Click += buttonBackWindow_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(281, 20);
            label2.Name = "label2";
            label2.Size = new Size(241, 30);
            label2.TabIndex = 12;
            label2.Text = "Информация о заказе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 366);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 16;
            label3.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(206, 363);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 25;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // buttonConfirmChanges
            // 
            buttonConfirmChanges.Location = new Point(305, 399);
            buttonConfirmChanges.Name = "buttonConfirmChanges";
            buttonConfirmChanges.Size = new Size(181, 31);
            buttonConfirmChanges.TabIndex = 26;
            buttonConfirmChanges.Text = "Принять изменения";
            buttonConfirmChanges.UseVisualStyleBackColor = true;
            buttonConfirmChanges.Click += buttonConfirmChanges_Click;
            // 
            // CourierInfoOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonConfirmChanges);
            Controls.Add(comboBoxStatus);
            Controls.Add(labelCreatedDate);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(labelAdress);
            Controls.Add(label6);
            Controls.Add(labelIdOrder);
            Controls.Add(label1);
            Controls.Add(dataGridViewOrderItems);
            Controls.Add(buttonBackWindow);
            Controls.Add(label2);
            Name = "CourierInfoOrder";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о заказе";
            Load += CourierInfoOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCreatedDate;
        private Label label5;
        private Label labelAdress;
        private Label label6;
        private Label labelIdOrder;
        private Label label1;
        private DataGridView dataGridViewOrderItems;
        private Button buttonBackWindow;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxStatus;
        private Button buttonConfirmChanges;
    }
}