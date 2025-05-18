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
    public partial class CourierMainWindow : Form
    {
        private readonly FacadeDatabase _facade;
        public CourierMainWindow(FacadeDatabase facade)
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

        private void buttonLoadOrdersList_Click(object sender, EventArgs e)
        {
            var activeOrderForDeliveryWindow = new ActiveOrderForDeliveryWindow(_facade, this);
            activeOrderForDeliveryWindow.Show();
            this.Hide();
        }

        private void buttonLoadActiveOrderList_Click(object sender, EventArgs e)
        {
            var takenOrders = new TakenOrders(_facade, this);
            takenOrders.Show();
            this.Hide();
        }
    }
}
