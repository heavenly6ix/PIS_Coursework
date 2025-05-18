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
    public partial class ActiveOrderWindow : Form
    {
        private readonly FacadeDatabase _facade;
        public ManagerMainWindow _managerMainWindow;

        public ActiveOrderWindow(FacadeDatabase facade, ManagerMainWindow managerMainWindow)
        {
            InitializeComponent();
            _facade = facade;
            _managerMainWindow = managerMainWindow;
        }

        private void buttonBackWindow_Click(object sender, EventArgs e)
        {
            _managerMainWindow.Show();
            this.Close();
        }

        private void ActiveOrderWindow_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            //Отрисовка
            var orders = _facade.GetOrders(Session.CurrentSessionID);
            dataGridViewOrders.DataSource = orders;
        }

        public void ConfigureDataGridView()
        {
            // Настройка колонок для dataGridViewOrderItems
            dataGridViewOrders.Columns.Clear();
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn idOrder = new DataGridViewTextBoxColumn();
            idOrder.DataPropertyName = "IdOrder";
            idOrder.Name = "IdOrder";
            idOrder.HeaderText = "Номер заказа";
            idOrder.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrders.Columns.Add(idOrder);

            DataGridViewTextBoxColumn statusOrder = new DataGridViewTextBoxColumn();
            statusOrder.DataPropertyName = "Status";
            statusOrder.Name = "Status";
            statusOrder.HeaderText = "Статус заказа";
            statusOrder.Width = 100;
            dataGridViewOrders.Columns.Add(statusOrder);

            DataGridViewTextBoxColumn dateOrder = new DataGridViewTextBoxColumn();
            dateOrder.DataPropertyName = "Date";
            dateOrder.Name = "Date";
            dateOrder.HeaderText = "Дата заказа";
            dateOrder.Width = 100;
            dataGridViewOrders.Columns.Add(dateOrder);

            dataGridViewOrders.ReadOnly = true;
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите товар для изменения!");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
            int selectedIdOrder = Convert.ToInt32(selectedRow.Cells[columnName: "IdOrder"].Value);
            _facade.CancelOrder(selectedIdOrder);

            var orders = _facade.GetOrders(Session.CurrentSessionID);
            dataGridViewOrders.DataSource = orders;
        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите товар для изменения!");
            }

            DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
            int selectedIdOrder = Convert.ToInt32(selectedRow.Cells[columnName: "IdOrder"].Value);
            string selectedStatus = selectedRow.Cells[columnName: "Status"].Value.ToString();
            if (selectedStatus != "Доставлен")
            {
                MessageBox.Show("Заказ не доставлен!");
            }
            else
            {
                _facade.ConfirmOrder(selectedIdOrder);
                MessageBox.Show("Заказ успешно подтвержден!");

                var orders = _facade.GetOrders(Session.CurrentSessionID);
                dataGridViewOrders.DataSource = orders;
            }
        }

        private void buttonShowOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите товар для просмотра!");
            }

            DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
            int selectedIdOrder = Convert.ToInt32(selectedRow.Cells[columnName: "IdOrder"].Value);
            string selectedStatus = selectedRow.Cells[columnName: "Status"].Value.ToString();
            DateTime selectedDate = Convert.ToDateTime(selectedRow.Cells[columnName: "Date"].Value);

            var infoOrderWindow = new InfoOrderWindow(_facade, selectedIdOrder, selectedStatus, selectedDate);
            this.Hide();
            if (infoOrderWindow.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
