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
    public partial class CompletedOrdersWindow : Form
    {
        private readonly FacadeDatabase _facade;
        public ManagerMainWindow _managerMainWindow;

        public CompletedOrdersWindow(FacadeDatabase facade, ManagerMainWindow managerMainWindow)
        {
            InitializeComponent();
            _facade = facade;
            _managerMainWindow = managerMainWindow;
        }

        private void CompletedOrdersWindow_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            //Отрисовка
            var orders = _facade.GetCompletedOrders(Session.CurrentSessionID);
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

            DataGridViewTextBoxColumn dateOrder = new DataGridViewTextBoxColumn();
            dateOrder.DataPropertyName = "Date";
            dateOrder.Name = "Date";
            dateOrder.HeaderText = "Дата доставки";
            dateOrder.Width = 200;
            dataGridViewOrders.Columns.Add(dateOrder);

            dataGridViewOrders.ReadOnly = true;
        }

        private void buttonBackWindow_Click(object sender, EventArgs e)
        {
            _managerMainWindow.Show();
            this.Close();
        }

        private void buttonShowOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите товар для просмотра!");
            }

            DataGridViewRow selectedRow = dataGridViewOrders.SelectedRows[0];
            int selectedIdOrder = Convert.ToInt32(selectedRow.Cells[columnName: "IdOrder"].Value);
            DateTime selectedDate = Convert.ToDateTime(selectedRow.Cells[columnName: "Date"].Value);

            var infoOrderWindow = new InfoOrderWindow(_facade, selectedIdOrder, selectedDate);
            this.Hide();
            if(infoOrderWindow.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
