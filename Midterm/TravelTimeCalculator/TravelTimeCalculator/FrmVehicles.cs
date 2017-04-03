using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelTimeCalculator
{
    public partial class FrmVehicles : Form
    {
        public FrmVehicles()
        {
            InitializeComponent();
        }

        // Arrays for each object type 
        string[] OTSelection =
        {
             "Automobile" , "Plane", "Train"
        };
        string[] AutomobileSelect =
        {
            "Manual", "Automatic"
        };
        string[] PlaneSelect =
        {
            "Jet", "TurboProp"
        };
        string[] TrainSelect =
        {
            "Less than 20", "Greater than 20"
        };
        
        // shows all of the textboxes and labels
        public bool ShowBox()
        {
            lblType.Visible = true;
        //    lblIdNum.Visible = true; txtIdNum.Visible = true;
        //    lblFirstName.Visible = true; txtFirstName.Visible = true;
        //    lblLastName.Visible = true; txtLastName.Visible = true;
            lblDrop.Visible = true; cbxDrop.Visible = true;
        //    lblSwap.Visible = true; txtSwap.Visible = true;
            return true;
        }

        public bool HideBox()
        {
            lblType.Visible = false;
          //  lblIdNum.Visible = false; txtIdNum.Visible = false;
           // lblFirstName.Visible = false; txtFirstName.Visible = false;
           // lblLastName.Visible = false; txtLastName.Visible = false;
            lblDrop.Visible = false; cbxDrop.Visible = false;
          //  lblSwap.Visible = false; txtSwap.Visible = false;
            return true;
        }



        private void FrmVehicles_Load(object sender, EventArgs e)
        {
            lblType.Visible = true;
            int populate = OTSelection.GetLength(0);
            for (int i = 0; i < populate; i++)
            {
                cbxObjectType.Items.Add(OTSelection[i]);
            }
        }

        private void cbxObjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if Automobile is chosen, for loop to populate the automobile ddl
            if (cbxObjectType.Text == "Automobile")
            {
                clearAll();  // clear all if type is changed
                ShowBox();
                lblDrop.Text = "Transmission Type:";
         //       lblSwap.Text = "Annual Salary:";
                int engine = AutomobileSelect.GetLength(0);
                for (int t = 0; t < engine; t++)
                    cbxDrop.Items.Add(AutomobileSelect[t]);
            }

            // if plane is chosen, for loop to populate the plane ddl
            if (cbxObjectType.Text == "Plane")
            {
                clearAll();  // clear all if type is changed
                ShowBox();
                lblDrop.Text = "Engine Type:";
            //    lblSwap.Text = "Engine Type:";
                int engine = PlaneSelect.GetLength(0);
                for (int s = 0; s < engine; s++)
                    cbxDrop.Items.Add(PlaneSelect[s]);
            }

            if (cbxObjectType.Text == "Train")
            {
                clearAll();  // clear all if type is changed
                ShowBox();
                lblDrop.Text = "Trolly Cars:";
             //   lblSwap.Text = "Hourly-Rate:";
                int admin = TrainSelect.GetLength(0);
                for (int a = 0; a < admin; a++)
                    cbxDrop.Items.Add(TrainSelect[a]);
            }


        }

        public void clearAll()
        {
            cbxDrop.Items.Clear();
            cbxObjectType.Text = "";
        //    txtFirstName.Clear();
        //    txtLastName.Clear();
        //    txtIdNum.Clear();
            txtSwap.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
             // if nothing is chosen at all and result is clicked
            if (cbxObjectType.Text == "")
            {
                MessageBox.Show("Please choose a type.", "Error");
            }

            else
            {
                // If Teacher is chosen as type - 
                if (cbxObjectType.Text == "Automobile")
                {
                    // checks to see if the data entered is valid
      //              if (IsValidData() && SalaryValid())
             //       {
                        // sends it to the automobile class 
                    Automobile results1 = new Automobile(cbxObjectType.Text, cbxDrop.Text, Convert.ToDecimal(txtSwap.Text));
                    Trip results = new Trip(cbxObjectType.Text, cbxDrop.Text, Convert.ToDecimal(txtSwap.Text));
                        results.TripCalculate();
                        // grab string method from person class and teacher class and show results
                        MessageBox.Show(results.displayTypeandAverageSpeed());
                        clearAll();
                    }
                }

                // If Student is chosen as type -  
                if (cbxObjectType.Text == "Plane")
                {
                    // checks to see if the data entered is valid
          //          if (IsValidData() && GPAValid())
                    {
                        Plane results1 = new Plane(cbxObjectType.Text, cbxDrop.Text, Convert.ToDecimal(txtSwap.Text));
                        Trip results = new Trip(cbxObjectType.Text, cbxDrop.Text, Convert.ToDecimal(txtSwap.Text));
                        results.TripCalculate();
                        // grab string method from person class and student class and show results
                        MessageBox.Show(results.displayTypeandAverageSpeed());
                        clearAll();
                    }
                }

                // If Admin is chosen as type 
                if (cbxObjectType.Text == "Train")
                {
                    // checks to see if the data entered is valid
                //    if (IsValidData() && HoursValid())
                    {
                        Trip results = new Trip(cbxObjectType.Text, cbxDrop.Text, Convert.ToDecimal(txtSwap.Text));
                        results.TripCalculate();
                        // grab string method from person class and admin class and show results
                        MessageBox.Show(results.displayTypeandAverageSpeed());
                        clearAll();
                    }
                }
            }
        }
        }



    

