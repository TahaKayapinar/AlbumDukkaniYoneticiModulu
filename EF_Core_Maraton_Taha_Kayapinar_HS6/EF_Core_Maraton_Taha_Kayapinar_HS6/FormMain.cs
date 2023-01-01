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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            var form = new FormUserTransactions();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void btnAlbumNewDeleteUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormAlbumTransactions();
            form.ShowDialog();
        }
        private void btnUserDeleteInsertUpdate_Click(object sender, EventArgs e)
        {
            var form = new FormUserTransactions();
            form.ShowDialog();
        }

        private void manuSatisiDurmusAlbumler_Click(object sender, EventArgs e)
        {

        }











        //-----------------------------------------------------------------------------------------
        private void menuIndirimdekiAlbumler_Click(object sender, EventArgs e)
        {
            // BOŞ BIRAK , SİLERSEN STUDIO PATLIYOR
        }

        private void menuAlbum_Click(object sender, EventArgs e)
        {
            // BOŞ BIRAK , SİLERSEN STUDIO PATLIYOR
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // BOŞ BIRAK , SİLERSEN STUDIO PATLIYOR
        }
        
        //-----------------------------------------------------------------------------------------
    }
}
