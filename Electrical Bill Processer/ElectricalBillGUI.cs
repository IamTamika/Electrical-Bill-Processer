using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Electrical_Bill_Processer
{//Created by Tamika Taylor- Lab 2
    public partial class ElectricalBillGUI : Form

    {// List that all customers will in entered into
        private List<Customer_Data> AllCustomersList = new List<Customer_Data>();

        public ElectricalBillGUI()
        {
            InitializeComponent();
        }
        //Add a customer and calculate the stats button
        private void btnCal_Click(object sender, EventArgs e)
        {
            decimal numOfKwhUsed;
            string firstName;
            string lastName;
            
            
             Customer_Data account;
            if (Validator.IsPresent(txtBoxFirstName, "First Name") &&
                Validator.IsPresent(txtBoxLastName, "Last Name") &&
                Validator.IsNonNegativeDecimal(txtBoxKwhUsed, "KwH") &&
                Validator.IsPresent(txtBoxKwhUsed, "kWh"))
            {
                //Inputs
                numOfKwhUsed = Convert.ToDecimal(txtBoxKwhUsed.Text);
                firstName = txtBoxFirstName.Text;
                lastName = txtBoxLastName.Text;
                // New instance of object
                account = new Customer_Data(firstName, lastName, numOfKwhUsed);
                AllCustomersList.Add(account);
            }
            //Display customer data in listbox
            void DisplayCustomers()
            {
                listboxCustomerDataDisplay.Items.Clear(); // start from empty
                foreach (Customer_Data a in AllCustomersList)
                    listboxCustomerDataDisplay.Items.Add(a);

                //Display all the stats
                decimal TotalNumOfCustomers = AllCustomersList.Count();
                decimal TotalBillAvg = CalculateTotalOfAllBillsAndGetAvg();
                decimal TotalkWh = CalculateAllKwh();

                txtBoxAvgBillAmt.Text = TotalBillAvg.ToString("c");
                txtBoxTotalNumOfKwhUsed.Text = TotalkWh.ToString("n");
                txtBoxNumOfCustomersProcessed.Text = TotalNumOfCustomers.ToString();
            }
            //Methods

            //Go through all the customers in the list and log and add together each of their bill totals then divide by the amount of customers in the list  to get the avg bill amount
            decimal CalculateTotalOfAllBillsAndGetAvg()
            {
                decimal total = 0;
                foreach (Customer_Data bill in AllCustomersList)
                    total += bill.CalculateCharge();
                if (total == 0)
                    return total;
                return total / AllCustomersList.Count();
            }
            //Go through all the customers in the list and log and add together each of their kWh's together
            decimal CalculateAllKwh()
            {
                decimal total = 0;
                foreach (Customer_Data k in AllCustomersList)
                    total += k.NumOfKwhUsed;
                return total;
            }
            // call the methods
            CalculateTotalOfAllBillsAndGetAvg();
            CalculateAllKwh();
            DisplayCustomers();
        }

        //Clear all the input fields except the customer list and stats
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxKwhUsed.Clear();
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
        }

        //Exit app
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}