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
    public partial class ManagerMainWindow : Form
    {
        private readonly FacadeDatabase _facade;

        public ManagerMainWindow(FacadeDatabase facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void buttonExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm(_facade);
            loginForm.Show();
            this.Close();
        }

        private void buttonLoadAdress_Click(object sender, EventArgs e)
        {
            var adressWindow = new AdressWindow(_facade);
            adressWindow.Show();
        }
        private void buttonLoadCreateOrder_Click(object sender, EventArgs e)
        {
            var createOrderWindow = new CreateOrderWindow(_facade, this);
            createOrderWindow.Show();
            this.Hide();
        }

        private void buttonLoadActiveOrderList_Click(object sender, EventArgs e)
        {
            var activeOrderWindow = new ActiveOrderWindow(_facade, this);
            activeOrderWindow.Show();
            this.Hide();
        }

        private void buttonLoadHistoryOrders_Click(object sender, EventArgs e)
        {
            var completedOrdersWindow = new CompletedOrdersWindow(_facade, this);
            completedOrdersWindow.Show();
            this.Hide();
        }
    }
}
