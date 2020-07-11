using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace libaraymvp.Views.forms
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_category frm = new frm_category();
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm_bookplace frm = new frm_bookplace();
            frm.ShowDialog();
        }
    }
}