using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace PIS_Coursework
{
    public partial class CreateOrderWindow : Form
    {
        private readonly FacadeDatabase _facade;
        public ManagerMainWindow _managerMainWindow;
        public int idManager;
        public int idNullOrder;

        public CreateOrderWindow(FacadeDatabase facade, ManagerMainWindow managerMainWindow)
        {
            InitializeComponent();
            _facade = facade;
            _managerMainWindow = managerMainWindow;
        }


        private void CreateOrderWindow_Load(object sender, EventArgs e)
        {
            var types = _facade.LoadProductTypes();
            comboBoxDetailType.Items.AddRange(types.ToArray());
            comboBoxDetailType.SelectedIndex = 0;

            idManager = _facade.GetCurrentManagerId();
            idNullOrder = _facade.CreateNullOrder(idManager);

            ConfigureDataGridView();
        }

        private void buttonBackWindow_Click(object sender, EventArgs e)
        {
            _facade.CancelOrder(idNullOrder);
            _managerMainWindow.Show();
            this.Close();
        }

        private void comboBoxDetailType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxDetailType.SelectedItem?.ToString();
            var names = _facade.LoadProductNames(selectedType);
            comboBoxDetailName.Items.Clear();
            comboBoxDetailName.Items.AddRange(names.ToArray());
        }

        private void comboBoxDetailName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = comboBoxDetailName.SelectedItem?.ToString();
            labelCountInStock.Text = Convert.ToString(_facade.GetCountByName(selectedName));
        }

        private void buttonAddDetailToOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxDetailName.SelectedItem != null && textBoxDetailCount.Text != null)
            {
                try
                {
                    int idProduct = _facade.GetProductIdByName(comboBoxDetailName.Text);
                    _facade.AddProductToOrder(idNullOrder, idProduct, Convert.ToInt32(textBoxDetailCount.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Недостаточно товара на складе! ");
                }

                //Отрисовка в dataGridView
                var orderItems = _facade.GetOrderItems(idNullOrder);
                dataGridViewOrderItems.DataSource = orderItems;
            }
            else MessageBox.Show("Ошибка! Укажите товар и его количество.");
        }

        private void ConfigureDataGridView()
        {
            // Настройка колонок для dataGridViewOrderItems
            dataGridViewOrderItems.Columns.Clear();
            dataGridViewOrderItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridViewOrderItems.AutoGenerateColumns = false;

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

        private void buttonChangeCount_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderItems.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите товар для изменения!");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewOrderItems.SelectedRows[0];
            int selectedIdOrderItem = Convert.ToInt32(selectedRow.Cells[columnName: "ID"].Value);
            int selectedCount = Convert.ToInt32(selectedRow.Cells[columnName: "Count"].Value);
            string selectedName = selectedRow.Cells[columnName: "ProductName"].Value.ToString();
            ChangeCountForm changeCountForm = new ChangeCountForm(_facade, selectedIdOrderItem, selectedCount, selectedName);
            if (changeCountForm.ShowDialog() == DialogResult.OK)
            {
                var orderItems = _facade.GetOrderItems(idNullOrder);
                dataGridViewOrderItems.DataSource = orderItems;
            }
        }

        private void buttonDeleteDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderItems.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите товар для изменения!");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewOrderItems.SelectedRows[0];
            int selectedIdOrderItem = Convert.ToInt32(selectedRow.Cells[columnName: "ID"].Value);
            _facade.DeleteProductInOrderItems(selectedIdOrderItem);

            //Обновляем DataGridView
            var orderItems = _facade.GetOrderItems(idNullOrder);
            dataGridViewOrderItems.DataSource = orderItems;
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            _facade.CreateOrder(idNullOrder);
            MessageBox.Show("Заказ успешно сформирован!");
            _managerMainWindow.Show();
            this.Close();
        }
    }
}
