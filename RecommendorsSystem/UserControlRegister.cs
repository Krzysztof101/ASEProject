using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NavigationInterfaces;

namespace RecommendorsSystem
{
    public partial class UserControlRegister : UserControl
    {
        IRegisterFunctions iRegFunctions;
        INavRegister iNavRegister;
        public UserControlRegister(IRegisterFunctions iregfuns, INavRegister inavreg)
        {
            InitializeComponent();
            iNavRegister = inavreg;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            iNavRegister.goToLogin();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(checkCredentials())
            {

            }
            else
            {  }
        }
        private bool checkCredentials()
        {
            string user = textBoxUser.Text;
            string pswd1 = textBoxPassword1.Text;
            string pswd2 = textBoxPassword2.Text;
            if(user.Length == 0 || pswd1.Length == 0 || pswd2.Length == 0)
            {
                return false;
            }
            if(pswd1 != pswd2)
            {
                return false;
            }
            if(!passwordStrong(pswd))
            {
                return false;
            }
            return true;
        }
    }
}
