using ProjectA.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA.Forms
{
    public partial class frmInvoiceDetail : Form
    {
        int customerId = 0;
        public frmInvoiceDetail(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void frmInvoiceDetail_Load(object sender, EventArgs e)
        {
            using (InvoiceRepository invoiceRepository = new InvoiceRepository())
            {
                dgvInvoice.DataSource = invoiceRepository.GetAll(customerId);
            }
        }
    }
}
