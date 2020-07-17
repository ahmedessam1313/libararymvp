using libaraymvp.Logic.presenter;
using libaraymvp.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libaraymvp.Views.forms
{
    public partial class frm_category : Form ,icategory

    {
        categorypresenter catpresenter;

        public int id
        {
            get
            {
             return Convert.ToInt32(txtid.Text);
            }

            set
            {
               txtid.Text = value.ToString();
            }
        }

        public string name
        {
            get
            {
               return Convert.ToString(txtname.Text);
            }

            set
            {
                txtname.Text = value.ToString();
            }
        }

        public frm_category()
        {
            InitializeComponent();
            catpresenter = new categorypresenter(this);
        }

        private void frm_category_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           bool check = catpresenter.catinsert();
            if(check == true)
            {
                MessageBox.Show("Add Successfuly");
            }
            else
            {
                MessageBox.Show("Fail To Add");
            }
        }
    }
}
