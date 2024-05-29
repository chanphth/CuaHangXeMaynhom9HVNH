using CuaHangXeMay.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangXeMay
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            Function.Functions.ketnoi();
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {
            Forms.frmnhanvien f = new Forms.frmnhanvien();
            f.Show();
        }
    }
}
