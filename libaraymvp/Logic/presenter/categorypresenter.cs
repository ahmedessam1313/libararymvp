using libaraymvp.Logic.services;
using libaraymvp.Models;
using libaraymvp.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libaraymvp.Logic.presenter
{
    class categorypresenter 
    {
        icategory icategory;
        categorymodel catmodel = new categorymodel();
       
        public categorypresenter(icategory view)
        {
            this.icategory = view;
        }

        //connect between modelcategory and interface
        public  void connectbetweenmodelinterface()
        {
            catmodel.id = icategory.id;
            catmodel.name = icategory.name;
        }

        public bool catinsert()
        {
            connectbetweenmodelinterface();
            return categoryservices.categoryinsert(catmodel.id, catmodel.name);
        }
    }
}
