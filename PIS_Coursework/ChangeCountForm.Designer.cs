namespace PIS_Coursework
{
    partial class ChangeCountForm
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
            textBoxCount = new TextBox();
            label2 = new Label();
            buttonConfirmChanges = new Button();
            buttonCancelChanges = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 0;
            label1.Text = "Изменить количество";
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(34, 74);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(241, 23);
            textBoxCount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 56);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Введите количество";
            // 
            // buttonConfirmChanges
            // 
            buttonConfirmChanges.Location = new Point(50, 115);
            buttonConfirmChanges.Name = "buttonConfirmChanges";
            buttonConfirmChanges.Size = new Size(99, 27);
            buttonConfirmChanges.TabIndex = 3;
            buttonConfirmChanges.Text = "Применить";
            buttonConfirmChanges.UseVisualStyleBackColor = true;
            buttonConfirmChanges.Click += buttonConfirmChanges_Click;
            // 
            // buttonCancelChanges
            // 
            buttonCancelChanges.Location = new Point(155, 115);
            buttonCancelChanges.Name = "buttonCancelChanges";
            buttonCancelChanges.Size = new Size(99, 27);
            buttonCancelChanges.TabIndex = 3;
            buttonCancelChanges.Text = "Отменить";
            buttonCancelChanges.UseVisualStyleBackColor = true;
            // 
            // ChangeCountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 167);
            Controls.Add(buttonCancelChanges);
            Controls.Add(buttonConfirmChanges);
            Controls.Add(label2);
            Controls.Add(textBoxCount);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangeCountForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCount;
        private Label label2;
        private Button buttonConfirmChanges;
        private Button buttonCancelChanges;
    }
}