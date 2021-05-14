namespace Electrical_Bill_Processer
{
    public class Customer_Data
    {
        private decimal numOfKwhUsed;
        public decimal BillAmount;

        //public properites
        public decimal NumOfKwhUsed
        {
            get { return numOfKwhUsed; }
            set
            {
                if (value >= 0)

                    numOfKwhUsed = value;
            }
        }

        public int AccountNo { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int accountNumberSeed = 1234567890;

        //Constructor
        public Customer_Data(string fname, string lname, decimal KwhUsed)

        {
            this.AccountNo = accountNumberSeed++;
            this.FirstName = fname;
            this.LastName = lname;
            this.NumOfKwhUsed = KwhUsed;
        }

        //Public methods
        public decimal CalculateCharge()
        {
            const decimal administrativeCharge = 12m;
            const decimal perKwhCharge = .07m;
            return BillAmount = administrativeCharge + (perKwhCharge * numOfKwhUsed);
        }

        //refine override ToString() for customer objects
        public override string ToString()
        {
            return "AccountNo: " + AccountNo + " , " + "First Name: " + FirstName + " , " + "Last Name: " + LastName + " , " + "Number of kWh Used: " + NumOfKwhUsed.ToString("n") + " , " + "The Bill Amount is: " + BillAmount.ToString("c");
        }
    }
}