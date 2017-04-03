using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmurilloLab9
{
    public partial class FrmAddRegistration : Form
    {
        public FrmAddRegistration()
        {
            InitializeComponent();
        }
        DateTime aDate;
       // public bool getCustomer;
       //  public Customer customer;
       //customer = new Customer();
       // this.LoadCustomerComboBox;

        private void LoadCustomerComboBox()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                customers = CustomerDB.GetCustomer();
                cboCustomer.DataSource = customers;
                cboCustomer.DisplayMember = "name";
                cboCustomer.ValueMember = "customerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoadProductComboBox()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = ProductDB.GetProduct();
                cboProduct.DataSource = products;
                cboProduct.DisplayMember = "name";
                cboProduct.ValueMember = "productCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        //private void DisplayCustomer()
        //{
        //   // txtName.Text = customer.Name;
        //   // txtAddress.Text = customer.Address;
        //   // txtCity.Text = customer.City;
        //    cboCustomer.SelectedValue = customer.name;
        //   // txtZipCode.Text = customer.ZipCode;
        //}

        private void PutCustomerData(Customer customerID)
        {
            customerID.customerID = Convert.ToInt32(cboCustomer.SelectedValue);
        }

        private void PutProductData(Product productCode)
        {
            productCode.productCode = Convert.ToString(cboProduct.SelectedValue);
        }

        private void PutRegistrationData(Registration registration)
        {

            try
            {

                if (string.IsNullOrEmpty(txtRegDate.Text) || !DateTime.TryParse(txtRegDate.Text, out aDate))  // if arrival date is null or empty or not a date
                {
                    MessageBox.Show("Invalid date. Please enter in format DD/MM/YYYY", "Error");
                    txtRegDate.Focus();
                }
                registration.registrationDate = Convert.ToDateTime(txtRegDate.Text);
            }
            catch
            {
                MessageBox.Show("Must be date format ##/##/####", "Error");
            }

    }







        private void FrmAddRegistration_Load(object sender, EventArgs e)
        {
            this.txtRegDate.Text = DateTime.Today.ToString();
            this.LoadCustomerComboBox();
            this.LoadProductComboBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            Customer customerID = new Customer();
            this.PutCustomerData(customerID);
            Product productCode = new Product();
            this.PutProductData(productCode);
            //registration = new Registration();
            Registration registration = new Registration();
            this.PutRegistrationData(registration);


           // Registration registration = new Registration();
            RegistrationDB r = new RegistrationDB();
            //FrmAddRegistration modifyCustomerForm = new FrmAddRegistration();
            RegistrationDB.AddRegistration(registration, customerID, productCode);
                //customer = new Customer();
            //product = new Product();
            //customer = new Customer();
            //this.PutCustomerData(customer);
 //           this.PutProductData(product);
            //try
            //{
            //   registration.CustomerID = RegistrationDB.AddRegistration(registration);
            ////    this.DialogResult = DialogResult.OK;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, ex.GetType().ToString());
            //}
        }

        private void txtRegDate_TextChanged(object sender, EventArgs e)
        {
         //   this.txtRegDate.Text = DateTime.Now.ToString("dd/mm/YYYY");
        }
    }
    }

