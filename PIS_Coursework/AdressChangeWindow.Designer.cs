namespace PIS_Coursework
{
    partial class AdressChangeWindow
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxAdress = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonConfirmChanges = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(77, 21);
            label1.Name = "label1";
            label1.Size = new Size(234, 30);
            label1.TabIndex = 1;
            label1.Text = "Введите новый адрес";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(43, 83);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(311, 23);
            textBoxAdress.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // buttonConfirmChanges
            // 
            buttonConfirmChanges.Location = new Point(106, 135);
            buttonConfirmChanges.Name = "buttonConfirmChanges";
            buttonConfirmChanges.Size = new Size(181, 31);
            buttonConfirmChanges.TabIndex = 4;
            buttonConfirmChanges.Text = "Принять изменения";
            buttonConfirmChanges.UseVisualStyleBackColor = true;
            buttonConfirmChanges.Click += buttonConfirmChanges_Click;
            // 
            // AdressChangeWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 195);
            Controls.Add(buttonConfirmChanges);
            Controls.Add(textBoxAdress);
            Controls.Add(label1);
            Name = "AdressChangeWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Изменение адреса";
            Load += AdressChangeWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAdress;
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonConfirmChanges;
    }
}