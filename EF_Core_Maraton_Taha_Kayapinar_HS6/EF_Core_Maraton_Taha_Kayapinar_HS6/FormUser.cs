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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // FillControl();
            FillForm();
        }

        private void FillForm()
        {
            int userId = Convert.ToInt32(this.Tag);    // Form açıldığında Tag seçili ise, seçili kullanıcının bilgileri ekrana gelecek
            if (userId > 0)
            {
                using (Album_Context DB = new Album_Context())
                {
                    var result = DB.Users.FirstOrDefault(t0 => t0.UserID == userId);
                    if (result != null)
                    {
                        txtAddress.Text = result.Address;
                        txtPassword.Text = result.Password;  //-----------------------------------------------------
                        txtPhone.Text = result.Phone;
                        txtEmail.Text = result.Email;
                        txtReelName.Text = result.ReelName;
                        txtReelSurname.Text = result.ReelSurname;
                        txtTcNo.Text = result.TcNo;
                        txtUserName.Text = result.UserName;
                    }
                }
            }
        }

        //private void FillControl()
        //{
        //    throw new NotImplementedException();
        //}

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            txtUserName.Text = "";
            txtTcNo.Text = "";
            txtReelSurname.Text = "";
            txtReelName.Text = "";
            txtPhone.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            this.Tag = 0;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!SameControl())
            {
                FormSave();
                FormClear();
            }
            else
            {
                var formUser = new FormUser();
                this.Hide();
                MessageBox.Show("Kullanıcı adı kullanılıyor. Farklı bir kullanıcı adı seçiniz");
                formUser.ShowDialog();
            }
        }

        private bool SameControl()
        {
            bool isSame = false;

            using (Album_Context DB = new Album_Context())
            {
                var users = DB.Users.ToList();    // DB deki kullanıcıları List olarak getirdi
                foreach (var item in users)
                {
                    if (item.UserName == txtUserName.Text)
                    {
                        isSame = true;
                    }
                }
            }
            return isSame;
        }

        // not: contains => bundan varmı içinde ?

        private void FormSave()
        {
            int userId = Convert.ToInt32(this.Tag);

            try
            {
                User? userEntity = null;
                using (Album_Context DB = new Album_Context())
                {
                    if (userId == 0)       //userId sıfırsa veritabanına kaydı ekle
                    {
                        userEntity = new User();
                        DB.Users.Add(userEntity);
                    }
                    else
                    {
                        userEntity = DB.Users.FirstOrDefault(t0 => t0.UserID == userId);
                    }

                    if (userEntity != null)
                    {
                        userEntity.Address = txtAddress.Text;
                        userEntity.Password = txtPassword.Text;
                        userEntity.Email = txtEmail.Text;
                        userEntity.Phone = txtPhone.Text;
                        userEntity.TcNo = txtTcNo.Text;
                        userEntity.UserName = txtUserName.Text;
                        userEntity.ReelName = txtReelName.Text;
                        userEntity.ReelSurname = txtReelSurname.Text;

                        DB.SaveChanges();
                        this.Tag = userEntity.UserID;
                        MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            FormDelete();
        }

        private void FormDelete()
        {
            int userId = Convert.ToInt32(this.Tag);
            if (userId > 0)
            {
                var dialog = MessageBox.Show("Mevcut kullanıcıyı silmek istiyor musunuz?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    using (Album_Context DB = new Album_Context())
                    {
                        var result = DB.Users.FirstOrDefault(t0 => t0.UserID == userId);    // username == && password == 
                        if (result != null)
                        {
                            DB.Users.Remove(result);
                            DB.SaveChanges();
                            MessageBox.Show("Silme işlemi başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            this.Close();
        }
    }
}
