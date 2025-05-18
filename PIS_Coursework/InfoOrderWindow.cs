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
    public partial class InfoOrderWindow : Form
    {
        private readonly FacadeDatabase _facade;
        public int IdOrder;
        public string StatusOrder;
        public DateTime DateOrder;
        public string AdressOrder;

        public InfoOrderWindow(FacadeDatabase facade, int selectedIdOrder, string selectedStatus, DateTime selectedDate)
        {
            InitializeComponent();
            _facade = facade;
            IdOrder = selectedIdOrder;
            StatusOrder = selectedStatus;
            DateOrder = selectedDate;
        }

        public InfoOrderWindow(FacadeDatabase facade, int selectedIdOrder, DateTime selectedDate)
        {
            InitializeComponent();
            _facade = facade;
            IdOrder = selectedIdOrder;
            StatusOrder = "Доставлен";
            DateOrder = selectedDate;
        }

        public InfoOrderWindow
            (FacadeDatabase facade, int selectedIdOrder, DateTime selectedDate, string selectedAdress)
        {
            InitializeComponent();
            _facade = facade;
            IdOrder = selectedIdOrder;
            DateOrder = selectedDate;
            AdressOrder = selectedAdress;
        }

        private void InfoOrder_Load(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            var order = _facade.GetOrderItems(IdOrder);
            dataGridViewOrderItems.DataSource = order;
            labelIdOrder.Text = IdOrder.ToString();
            labelCreatedDate.Text = DateOrder.ToString();
            if (AdressOrder == "" || AdressOrder == null)
            {
                labelStatusOrder.Text = StatusOrder;
                if (StatusOrder == "Создан")
                {
                    labelCourier.Visible = false;
                    label4.Visible = false;
                    label6.Visible = false;
                    labelAdress.Visible = false;
                }
                else if (StatusOrder == "Доставлен")
                {
                    label6.Visible = false;
                    labelAdress.Visible = false;
                    labelCourier.Text = _facade.GetCourierByCompletedOrder(IdOrder);
                    label5.Text = "Дата доставки:";

                }
                else
                {
                    label6.Visible = false;
                    labelAdress.Visible = false;
                    labelCourier.Text = _facade.GetCourierByIdOrder(IdOrder);
                }
            }
            else
            {
                labelCourier.Visible = false;
                label4.Visible = false;
                labelAdress.Text = AdressOrder;
            }
            
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
    }
}
