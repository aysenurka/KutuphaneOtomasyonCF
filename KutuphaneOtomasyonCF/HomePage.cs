using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KutuphaneOtomasyonCF.MockData;

namespace KutuphaneOtomasyonCF
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private MemberForm frmMember;
        private BookForm frmBook;
        private RentForm frmRent;
        private AuthorForm frmAuthor;

        private void uyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMember == null || frmMember.IsDisposed)
            {
                frmMember = new MemberForm()
                {
                    MdiParent = this
                };
                frmMember.Show();
            }
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBook == null || frmBook.IsDisposed)
            {
                frmBook = new BookForm()
                {
                    MdiParent = this
                };
                frmBook.Show();
            }
        }

        private void kiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRent == null || frmRent.IsDisposed)
            {
                frmRent = new RentForm()
                {
                    MdiParent = this
                };
                frmRent.Show();
            }
        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAuthor == null || frmAuthor.IsDisposed)
            {
                frmAuthor = new AuthorForm()
                {
                    MdiParent = this
                };
                frmAuthor.Show();
            }
        }


        public static MockContext MockContext { get; set; }
        private void HomePage_Load(object sender, EventArgs e)
        {
            MockContext = new MockData.MockContext();
        }
    }
}
