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
    public partial class AdressChangeWindow : Form
    {
        private readonly FacadeDatabase _facade;
        public AdressWindow _adressWindow;
        public string OldAdress;

        public AdressChangeWindow(FacadeDatabase facade, 
            AdressWindow adressWindow, string oldAdress)
        {
            InitializeComponent();
            _facade = facade;
            _adressWindow = adressWindow;
            OldAdress = oldAdress;
        }

        private void buttonConfirmChanges_Click(object sender, EventArgs e)
        {
            string NewAdress = textBoxAdress.Text;
            _facade.ChangeAdress(Session.CurrentSessionID, NewAdress);
            var adressWindow = new AdressWindow(_facade);
            adressWindow.Show();
            this.Close();
        }

        private void AdressChangeWindow_Load(object sender, EventArgs e)
        {
            textBoxAdress.Text = OldAdress;
        }
    }
}
