using EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Context;
using EF_Core_Maraton_Taha_Kayapinar_HS6.Helper;

namespace EF_Core_Maraton_Taha_Kayapinar_HS6
{
    public partial class FormLogin : Form
    {


        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string passwordHash = UIHelper.sha256_hash(password);


            UIHelper uIHelper = new UIHelper();
            // var user = uIHelper.GetHashCode(username, password);


            using (Album_Context DB = new Album_Context())
            {
                var resultUserName = DB.Users.FirstOrDefault(t0 => t0.UserName == username);

                try
                {
                    if (resultUserName == null)
                    {
                        LoginError();
                    }
                    else if (password == resultUserName.Password)
                    {
                        MessageBox.Show("Sisteme giriþ baþarýlý");
                        this.Hide();
                        FormMain form = new FormMain();
                        form.ShowDialog();
                    }
                    else
                    {
                        LoginError();
                    }
                }
                catch (Exception ex)
                {
                    LoginError();
                }
            }
        }

        private void LoginError()
        {
            UIHelper.ErrorMessage("Kullanýcý adý veya þifre yanlýþ");
            this.Hide();
            FormLogin formLog = new FormLogin();
            formLog.ShowDialog();
        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}