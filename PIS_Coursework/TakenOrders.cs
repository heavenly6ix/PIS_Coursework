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
    public partial class TakenOrders : Form
    {
        private readonly FacadeDatabase _facade;
        public CourierMainWindow _courierMainWindow;
        public TakenOrders(FacadeDatabase facade, CourierMainWindow courierMainWindow)
        {
            InitializeComponent();
            _facade = facade;
            _courierMainWindow = courierMainWindow;
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

            DataGridViewTextBoxColumn adress = new DataGridViewTextBoxColumn();
            adress.DataPropertyName = "Adress";
            adress.Name = "Adress";
            adress.HeaderText = "Адрес доставки";
            adress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrders.Columns.Add(adress);

            DataGridViewTextBoxColumn dateOrder = new DataGridViewTextBoxColumn();
            dateOrder.DataPropertyName = "Date";
            dateOrder.Name = "Date";
            dateOrder.HeaderText = "Дата заказа";
            dateOrder.Width = 100;
            dataGridViewOrders.Columns.Add(dateOrder);

            dataGridViewOrders.ReadOnly = true;
        }

        private void TakenOrders_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();

            var takenOrders = _facade.GetTakenOrders(Session.CurrentSessionID);
            dataGridViewOrders.DataSource = takenOrders;
        }

        private void buttonBackWindow_Click(object sender, EventArgs e)
        {
            _courierMainWindow.Show();
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
            string selectedAdress = selectedRow.Cells[columnName: "Adress"].Value.ToString();
            DateTime selectedDate = Convert.ToDateTime(selectedRow.Cells[columnName: "Date"].Value);
            var courierInfoOrder = new CourierInfoOrder(_facade, selectedIdOrder, selectedDate, selectedAdress);
            this.Hide();
            if (courierInfoOrder.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
