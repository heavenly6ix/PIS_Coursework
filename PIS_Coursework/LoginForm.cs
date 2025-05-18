using DataAccess;
using System.Drawing.Text;

namespace PIS_Coursework
{
    public partial class LoginForm : Form
    {
        private readonly FacadeDatabase _facade;

        public LoginForm()
        {
            InitializeComponent();
            _facade = new FacadeDatabase();
        }

        public LoginForm(FacadeDatabase facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void buttonExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEntering_Click(object sender, EventArgs e)
        {
            string login = textBox_Login.Text;
            string password = textBox_Password.Text;

            if (_facade.AuthManager(login, password))
            {
                var managerMainWindow = new ManagerMainWindow(_facade);
                managerMainWindow.Show();
                this.Hide();
            }
            else if (_facade.AuthCourier(login, password))
            {
                var courierMainWindow = new CourierMainWindow(_facade);
                courierMainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ошибка входа! Неверный логин или пароль");
            }
        }

    }
}
