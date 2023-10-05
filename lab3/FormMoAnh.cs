    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class FormMoAnh : System.Windows.Forms.Form
    {
        public FormMoAnh()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sư dụng dialog để mở file 
            OpenFileDialog of = new OpenFileDialog();
            // Chỉ đinh các laoij file được mở
            of.Filter = "Bitnap file |*.bnp |jpeg file|*.jpg";
            if(of.ShowDialog() == DialogResult.OK)
            {
                //Tạo form con Truyền tên file 
                FormXuatAnh f2 = new FormXuatAnh(of.FileName);
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }
    }
}
