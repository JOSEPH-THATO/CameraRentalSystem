using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CameraRental.Camera_RentalDataSetTableAdapters;
using CameraRental.Properties;

namespace CameraRental
{
    public partial class FrmCreateCustomer : Form
    {
        public FrmCreateCustomer()
        {
            InitializeComponent();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            Boolean valid = validator();
            if (valid==true) {
                Camera_RentalDataSet CRDataset = new Camera_RentalDataSet();
                CUSTOMERTableAdapter customerTableAdapter = new CUSTOMERTableAdapter();
                Camera_RentalDataSet.CUSTOMERRow newCustomer = CRDataset.CUSTOMER.NewCUSTOMERRow();
            }
        }

        private bool validator()
        {
            throw new NotImplementedException();
        }
    }
}
