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
    public partial class ChangeCountForm : Form
    {
        FacadeDatabase _facade;
        public int _selectedIdOrderItem { get; private set; }
        public int newCount { get; private set; }
        public int _oldCount { get; private set; }
        public string _selectedName { get; private set; }
        
        public ChangeCountForm(FacadeDatabase facade,int selectedIdOrderItem, int oldCount, string selectedName)
        {
            InitializeComponent();
            _facade = facade;
            _selectedIdOrderItem = selectedIdOrderItem;
            _oldCount = oldCount;
            textBoxCount.Text = Convert.ToString(oldCount);
            _selectedName = selectedName;
        }

        private void buttonConfirmChanges_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxCount.Text) > _facade.GetCountByName(_selectedName))
            {
                MessageBox.Show("Недостаточно товара на складе!");
            }
            else if (Convert.ToInt32(textBoxCount.Text) != _oldCount && textBoxCount.Text != null)
            {
                newCount = Convert.ToInt32(textBoxCount.Text);
                _facade.ChangeCount(_selectedIdOrderItem, newCount);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Введите новое количество деталей!");

        }
    }
}
