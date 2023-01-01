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
    public partial class FormAlbumTransactions : Form
    {
        public FormAlbumTransactions()
        {
            InitializeComponent();
        }

        private void FormAlbumTransactions_Load(object sender, EventArgs e)
        {
            FillAlbum();
        }

        private void FillAlbum()
        {
            dataGridView1.DataSource = null;                              // DB deki albümleri datagridview de göster
            using (Album_Context DB = new Album_Context())
            {
                var result = DB.Albums.ToList();
                dataGridView1.DataSource = result;
            }
        }
        private void btnNewAlbum_Click(object sender, EventArgs e)
        {
            FormAlbum formAlbum = new FormAlbum();
            formAlbum.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var album = (dataGridView1.DataSource as List<Album>)[e.RowIndex];   // seçili row index
            if (album != null)
            {
                ShowAlbumForm(album.AlbumId);
            }
            FillAlbum();
        }

        private void ShowAlbumForm(int albumId)
        {
            FormAlbum formAlbum = new FormAlbum();
            formAlbum.Tag = albumId;
            formAlbum.ShowDialog();
        }
    }
}
