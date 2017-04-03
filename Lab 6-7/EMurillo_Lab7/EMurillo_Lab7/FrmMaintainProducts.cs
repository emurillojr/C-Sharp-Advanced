using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ernesto Murillo Lab 7 part 1 c# 

namespace EMurillo_Lab7
{
    public partial class FrmMaintainProducts : Form
    {
        public FrmMaintainProducts()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
                this.Validate();
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.techSupportDataSet);
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'techSupportDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.techSupportDataSet.Products);

        }
        

        // to catch errors
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            MessageBox.Show("Invalid Format", "Error"); // + anError.Context.ToString());


        }

    }
}
