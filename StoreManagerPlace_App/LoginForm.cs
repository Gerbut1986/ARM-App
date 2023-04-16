namespace StoreManagerPlace_App
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using StoreManagerPlace_App.Forms;
    using StoreManagerPlace_App.Services;
    using StoreManagerPlace_App.Entities.Security;

    public partial class LoginForm : Form
    {
        private readonly SMP_Service service;
        public Entities.User CurrentUser { get; set; }

        public LoginForm()
        {
            //new CreateOrderForm().ShowDialog();
            InitializeComponent();
            service = new SMP_Service(Credential.ConnectStr);
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            var res = EnterCheckAction();
            if (res is string)
                Error_Lbl.Text = res.ToString();
            else if (res is Entities.User)
            {
                LoginGroupBox.Enabled = false;
                var mf = new MainForm(CurrentUser, service.GetProducts());
                mf.Owner = this;
                mf.ShowDialog();
            }
            else
            {
                ClearFields();
                Error_Lbl.Text = "Невірно введений логін або пароль...";
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e) => CloseAction();

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) => CloseAction(true);

        #region Auxiliary methods:
        private object EnterCheckAction()
        {
            if (Login_Txt.Text == "" && Pass_Txt.Text == "")
                return "Ви залишили поля пустими...";
            else if (Login_Txt.Text == "" || Pass_Txt.Text == "")
                return "Якесь текстове поле пусте...";
            else
                return CurrentUser =
                    service.GetUsers().FirstOrDefault(l =>
                    (l.Login.Equals(Login_Txt.Text) && l.Password.Equals(Pass_Txt.Text)));               
        }

        private void ClearFields()
        {
            Login_Txt.Text = Pass_Txt.Text = "";
        }

        private void CloseAction(bool isFormClosing = false)
        {
            try
            {
                CurrentUser.RememberMe = RememberMe_Chb.Checked;
                CurrentUser.DateExit = DateTime.Now;
                var closeRes = service.UpdateUser(CurrentUser);
            }
            catch { if(!isFormClosing) this.Close(); }
            finally { if (!isFormClosing) this.Close(); }
        }
        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var user = service.GetUsers().OrderByDescending(o => o.DateExit).First();
            if (user.RememberMe)
            {
                Login_Txt.Text = user.Login;
                Pass_Txt.Text = user.Password;
                RememberMe_Chb.Checked = true;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            LoginGroupBox.Enabled = true;
        }
    }
}
