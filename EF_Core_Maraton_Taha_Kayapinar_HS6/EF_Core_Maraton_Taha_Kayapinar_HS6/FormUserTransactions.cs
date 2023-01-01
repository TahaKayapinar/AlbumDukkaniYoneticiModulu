using EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Context;
using EF_Core_Maraton_Taha_Kayapinar_HS6.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Core_Maraton_Taha_Kayapinar_HS6
{
    public partial class FormUserTransactions : Form
    {
        public FormUserTransactions()
        {
            InitializeComponent();
        }

        private void FormUserTransactions_Load(object sender, EventArgs e)
        {
            FillUser();
        }

        private void FillUser()    //  Form un load ında dataGridView1 e  DB den çek  Users leri bas
        {
            dataGridView1.DataSource = null;
            using (Album_Context DB = new Album_Context())
            {
                var result = DB.Users.ToList();
                dataGridView1.DataSource = result;
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.ShowDialog();
        }

        //private void btnUserDelete_Click(object sender, EventArgs e)
        //{
        //    FormUser formUser = new FormUser();
        //    formUser.ShowDialog();
        //}

        //private void btnUserUpdate_Click(object sender, EventArgs e)
        //{
        //    FormUser formUser = new FormUser();
        //    formUser.ShowDialog();
        //}
            

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var user = (dataGridView1.DataSource as List<User>)[e.RowIndex];  // seçili row index i 
            if (user!=null)
            {
                ShowUserForm(user.UserID);
            }
            FillUser();
        }

        private void ShowUserForm(int userID)
        {
            FormUser formUser = new FormUser();
            formUser.Tag = userID;
            formUser.ShowDialog();
        }
    }
}
