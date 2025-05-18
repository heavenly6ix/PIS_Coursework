using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_Coursework
{
    public partial class CourierInfoOrder : Form
    {
        private readonly FacadeDatabase _facade;
        public int IdOrder;
        public DateTime DateOrder;
        public string AdressOrder;
        public string StatusOrder;

        public CourierInfoOrder
            (FacadeDatabase facade, int selectedIdOrder, DateTime selectedDate, string selectedAdress)
        {
            InitializeComponent();
            _facade = facade;
            IdOrder = selectedIdOrder;
            DateOrder = selectedDate;
            AdressOrder = selectedAdress;
            StatusOrder = facade.GetStatusByIdOrder(selectedIdOrder);
        }

        private void CourierInfoOrder_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            var orderItem = _facade.GetOrderItems(IdOrder);
            dataGridViewOrderItems.DataSource = orderItem;
            labelAdress.Text = AdressOrder;
            labelIdOrder.Text = IdOrder.ToString();
            labelCreatedDate.Text = DateOrder.ToString();

            var status = new List<string>() { "Принят", "Доставляется", "Доставлен" };
            comboBoxStatus.Items.AddRange(status.ToArray());
            comboBoxStatus.SelectedItem = StatusOrder;
        }
        private void ConfigureDataGridView()
        {
            // Настройка колонок для dataGridViewOrderItems
            dataGridViewOrderItems.Columns.Clear();
            dataGridViewOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn idOrderItem = new DataGridViewTextBoxColumn();
            idOrderItem.DataPropertyName = "ID";
            idOrderItem.Name = "ID";
            idOrderItem.Visible = false;
            dataGridViewOrderItems.Columns.Add(idOrderItem);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Название товара";
            nameColumn.DataPropertyName = "ProductName";
            nameColumn.Name = "ProductName";
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrderItems.Columns.Add(nameColumn);


            DataGridViewTextBoxColumn countColumn = new DataGridViewTextBoxColumn();
            countColumn.HeaderText = "Количество";
            countColumn.DataPropertyName = "Count";
            countColumn.Name = "Count";
            countColumn.Width = 100;
            dataGridViewOrderItems.Columns.Add(countColumn);

            // Дополнительные настройки (ширина, запрет редактирования)
            dataGridViewOrderItems.ReadOnly = true;
        }

        private void buttonBackWindow_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBoxStatus.SelectedItem?.ToString();
        }

        private void buttonConfirmChanges_Click(object sender, EventArgs e)
        {
            if(comboBoxStatus.Text != StatusOrder)
            {
                _facade.ChangeOrderStatus(IdOrder, comboBoxStatus.Text);
                MessageBox.Show("Статус успешно изменен!");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Измените статус!");
            }
        }
    }
}
