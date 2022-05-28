using RemontV2.Models;
using RemontV2.Views;
using System;
using System.Windows.Forms;

namespace RemontV2
{
    public partial class AuthFRM : Form
    {
        public static Авторизация UFN { get; set; }
        public static AuthFRM ATH { get; set; }


        Model1 db = new Model1();
        public AuthFRM()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            if (LoginTxt.Text == "" || PassTxt.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            Авторизация UsersFind = db.Авторизация.Find(LoginTxt.Text);
            if ((UsersFind != null) && (UsersFind.Пароль == PassTxt.Text))
            {
                UFN = UsersFind;
                ATH = this;
                if (UFN.Сотрудник.ID_роли == 1)
                {
                    //LoggedRole ="1" ;
                    AdminForm FRMadm = new AdminForm();
                    FRMadm.Show();
                    this.Hide();
                    MessageBox.Show("Добро пожаловать в форму администратора!");
                }

                else if (UFN.Сотрудник.ID_роли == 2)
                {
                    //LoggedRole = "2";
                    ManagerForm FRMmang = new ManagerForm();
                    FRMmang.Show();
                    this.Hide();
                    MessageBox.Show("Добро пожаловать в форму менеджера!");
                }

                //else if (UFN.Сотрудник.ID_роли == 3)
                //{
                //    //LoggedRole = "3";
                //    Engineer FRMeng = new Engineer();
                //    FRMeng.Show();
                //    this.Hide();
                //    MessageBox.Show("Добро пожаловать в форму инженера!");
                //}

            }
            else
            {
                MessageBox.Show("Логин или пароль введены неверно!");
                return;
            }
        }

        private void LoginTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ShutDownBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
