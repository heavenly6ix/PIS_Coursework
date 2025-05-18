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
    public partial class AdressWindow : Form
    {
        private readonly FacadeDatabase _facade;
        public AdressWindow(FacadeDatabase facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void buttonBackWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdressWindow_Load(object sender, EventArgs e)
        {
            labelAdress.Text = _facade.GetAdressManager(Session.CurrentSessionID);
        }

        private void buttonChangeAdress_Click(object sender, EventArgs e)
        {
            var adressChangeWindow = new 
                AdressChangeWindow(_facade, this, labelAdress.Text);
            adressChangeWindow.Show();
            this.Close();

        }
    }
}
