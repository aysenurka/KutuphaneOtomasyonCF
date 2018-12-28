using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonCF
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private MemberForm memberForm;
        private BookForm bookForm;
        private RentForm rentForm;

        private void uyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memberForm == null || memberForm.IsDisposed)
                memberForm = new MemberForm();

            memberForm.MdiParent = this;
            memberForm.Show();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bookForm == null || bookForm.IsDisposed)
                bookForm = new BookForm();

            bookForm.MdiParent = this;
            bookForm.Show();
        }

        private void kiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rentForm == null || rentForm.IsDisposed)
                rentForm = new RentForm();

            rentForm.MdiParent = this;
            rentForm.Show();
        }
    }
}
