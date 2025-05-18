namespace PIS_Coursework
{
    partial class CreateOrderWindow
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
            comboBoxDetailType = new ComboBox();
            label2 = new Label();
            comboBoxDetailName = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBoxDetailCount = new TextBox();
            buttonAddDetailToOrder = new Button();
            buttonBackWindow = new Button();
            dataGridViewOrderItems = new DataGridView();
            buttonCreateOrder = new Button();
            label5 = new Label();
            labelCountInStock = new Label();
            buttonChangeCount = new Button();
            buttonDeleteDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(272, 21);
            label1.Name = "label1";
            label1.Size = new Size(243, 30);
            label1.TabIndex = 0;
            label1.Text = "Формирование заказа";
            // 
            // comboBoxDetailType
            // 
            comboBoxDetailType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDetailType.FormattingEnabled = true;
            comboBoxDetailType.Location = new Point(164, 103);
            comboBoxDetailType.Name = "comboBoxDetailType";
            comboBoxDetailType.Size = new Size(198, 23);
            comboBoxDetailType.TabIndex = 1;
            comboBoxDetailType.SelectedIndexChanged += comboBoxDetailType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 85);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Тип детали:";
            // 
            // comboBoxDetailName
            // 
            comboBoxDetailName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDetailName.FormattingEnabled = true;
            comboBoxDetailName.Location = new Point(368, 103);
            comboBoxDetailName.Name = "comboBoxDetailName";
            comboBoxDetailName.Size = new Size(176, 23);
            comboBoxDetailName.TabIndex = 1;
            comboBoxDetailName.SelectedIndexChanged += comboBoxDetailName_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 85);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "Деталь:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 85);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 2;
            label4.Text = "Количество:";
            // 
            // textBoxDetailCount
            // 
            textBoxDetailCount.Location = new Point(550, 103);
            textBoxDetailCount.Name = "textBoxDetailCount";
            textBoxDetailCount.Size = new Size(100, 23);
            textBoxDetailCount.TabIndex = 3;
            // 
            // buttonAddDetailToOrder
            // 
            buttonAddDetailToOrder.Location = new Point(164, 161);
            buttonAddDetailToOrder.Name = "buttonAddDetailToOrder";
            buttonAddDetailToOrder.Size = new Size(155, 37);
            buttonAddDetailToOrder.TabIndex = 4;
            buttonAddDetailToOrder.Text = "Добавить деталь в заказ";
            buttonAddDetailToOrder.UseVisualStyleBackColor = true;
            buttonAddDetailToOrder.Click += buttonAddDetailToOrder_Click;
            // 
            // buttonBackWindow
            // 
            buttonBackWindow.Location = new Point(12, 28);
            buttonBackWindow.Name = "buttonBackWindow";
            buttonBackWindow.Size = new Size(75, 23);
            buttonBackWindow.TabIndex = 5;
            buttonBackWindow.Text = "<- Назад";
            buttonBackWindow.UseVisualStyleBackColor = true;
            buttonBackWindow.Click += buttonBackWindow_Click;
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(164, 223);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.Size = new Size(486, 139);
            dataGridViewOrderItems.TabIndex = 6;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(323, 374);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(163, 37);
            buttonCreateOrder.TabIndex = 4;
            buttonCreateOrder.Text = "Сформировать заказ";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 129);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 7;
            label5.Text = "Количество на складе:";
            // 
            // labelCountInStock
            // 
            labelCountInStock.AutoSize = true;
            labelCountInStock.Location = new Point(296, 129);
            labelCountInStock.Name = "labelCountInStock";
            labelCountInStock.Size = new Size(0, 15);
            labelCountInStock.TabIndex = 7;
            // 
            // buttonChangeCount
            // 
            buttonChangeCount.Location = new Point(325, 161);
            buttonChangeCount.Name = "buttonChangeCount";
            buttonChangeCount.Size = new Size(164, 37);
            buttonChangeCount.TabIndex = 9;
            buttonChangeCount.Text = "Изменить количество";
            buttonChangeCount.UseVisualStyleBackColor = true;
            buttonChangeCount.Click += buttonChangeCount_Click;
            // 
            // buttonDeleteDetail
            // 
            buttonDeleteDetail.Location = new Point(495, 161);
            buttonDeleteDetail.Name = "buttonDeleteDetail";
            buttonDeleteDetail.Size = new Size(155, 37);
            buttonDeleteDetail.TabIndex = 10;
            buttonDeleteDetail.Text = "Удалить деталь";
            buttonDeleteDetail.UseVisualStyleBackColor = true;
            buttonDeleteDetail.Click += buttonDeleteDetail_Click;
            // 
            // CreateOrderWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteDetail);
            Controls.Add(buttonChangeCount);
            Controls.Add(labelCountInStock);
            Controls.Add(label5);
            Controls.Add(dataGridViewOrderItems);
            Controls.Add(buttonBackWindow);
            Controls.Add(buttonCreateOrder);
            Controls.Add(buttonAddDetailToOrder);
            Controls.Add(textBoxDetailCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxDetailName);
            Controls.Add(comboBoxDetailType);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateOrderWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Формирование заказа";
            Load += CreateOrderWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxDetailType;
        private Label label2;
        private ComboBox comboBoxDetailName;
        private Label label3;
        private Label label4;
        private TextBox textBoxDetailCount;
        private Button buttonAddDetailToOrder;
        private Button buttonBackWindow;
        private DataGridView dataGridViewOrderItems;
        private Button buttonCreateOrder;
        private Label label5;
        private Label labelCountInStock;
        private Button buttonChangeCount;
        private Button buttonDeleteDetail;
    }
}