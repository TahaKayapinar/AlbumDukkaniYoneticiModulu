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
    public partial class FormAlbum : Form
    {
        public FormAlbum()
        {
            InitializeComponent();
        }
        private void FormAlbum_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void FillForm()
        {
            int albumId = Convert.ToInt32(this.Tag);

            if (albumId > 0)
            {
                using (Album_Context DB = new Album_Context())
                {
                    var result = DB.Albums.FirstOrDefault(t0 => t0.AlbumId == albumId);
                    if (result != null)
                    {
                        txtAlbumName.Text = result.AlbumName;
                        txtSinger.Text = result.Singer;

                        dtAlbumBirthDate.Value = Convert.ToDateTime(result.BirthDate);
                        //  dtAlbumBirthDate.Value = DateTime.Now  -  CLEAR İŞLEMİNDE

                        numPrice.Value = Convert.ToDecimal(result.Price);
                        numDiscountRate.Value = Convert.ToDecimal(result.DiscountRate);

                        //if (radioNO)   //Eğer YES ise satış devam ediyo NO ise etmiyor. ????????????
                        //{

                        //}

                    }
                    else
                    {

                    }
                }
            }
        }
        private void btnNewAlbum_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void FormClear()
        {
            txtAlbumName.Text = "";
            txtSinger.Text = "";
            dtAlbumBirthDate.Value = DateTime.Now;
            numPrice.Value = 0;
            numDiscountRate.Value = 0;
            this.Tag = 0;
        }

        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            FormSave();
        }

        private void FormSave()
        {
            int albumId = Convert.ToInt32(this.Tag);

            try
            {
                Album? albumEntity = null;
                using (Album_Context DB = new Album_Context())
                {
                    if (albumId == 0)
                    {
                        albumEntity = new Album();
                        DB.Albums.Add(albumEntity);
                    }
                    else
                    {
                        albumEntity = DB.Albums.FirstOrDefault(t0 => t0.AlbumId == albumId);
                    }

                    if (albumEntity != null)
                    {
                        albumEntity.AlbumName = txtAlbumName.Text;
                        albumEntity.Singer = txtSinger.Text;
                        albumEntity.BirthDate = dtAlbumBirthDate.Value;
                        albumEntity.Price = Convert.ToDouble(numPrice.Value);
                        albumEntity.DiscountRate = Convert.ToDouble(numDiscountRate.Value);

                        DB.SaveChanges();
                        this.Tag = albumEntity.AlbumId;
                        MessageBox.Show("İşlem başarılı bir şekilde gerçekleşti");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnDeleteAlbum_Click(object sender, EventArgs e)
        {
            FormDelete();
        }

        private void FormDelete()
        {
            int albumId = Convert.ToInt32(this.Tag);

            if (albumId > 0)
            {
                var dialog = MessageBox.Show("Mevcut kaydı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    using (Album_Context DB = new Album_Context())
                    {
                        var result = DB.Albums.FirstOrDefault(t0 => t0.AlbumId == albumId);

                        if (result != null)
                        {
                            DB.Albums.Remove(result);
                            DB.SaveChanges();
                            MessageBox.Show("İşlem başarılı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
            }
            this.Close();
        }
    }
}

