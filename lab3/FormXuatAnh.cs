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
    public partial class FormXuatAnh : System.Windows.Forms.Form
    {
        public FormXuatAnh(string FileHinhAnh)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(FileHinhAnh);
            this.Text = FileHinhAnh.Substring(FileHinhAnh.LastIndexOf("\\") + 1);
        }
        public FormXuatAnh()
        {
            InitializeComponent();
        }
    }
}
