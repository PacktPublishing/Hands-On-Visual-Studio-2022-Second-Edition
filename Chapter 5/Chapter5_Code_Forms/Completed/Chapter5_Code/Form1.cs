namespace Chapter5_Code
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            //Create a list of 5 customers whose ID starts
            //with the number 50, and whose names start with the letter M
            customers.Add(new Customer { Id = 50, FirstName = "Mary", 
                LastName = "Smith", ZipCode = 12345 });
            customers.Add(new Customer { Id = 51, FirstName = "Mark", 
                LastName = "Jones", ZipCode = 12345 });
            customers.Add(new Customer { Id = 52, FirstName = "Molly", 
                LastName = "Smith", ZipCode = 12345 });
            customers.Add(new Customer { Id = 53, FirstName = "Mike", 
                LastName = "Smith", ZipCode = 12345 });
            customers.Add(new Customer { Id = 54, FirstName = "Megan", 
                LastName = "Smith", ZipCode = 12345 });
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Fill lstCustomers with the list of customers
            lstCustomers.DataSource = customers;
            lstCustomers.DisplayMember = "FullName";
            lstCustomers.SelectedIndex = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCustomers.CheckedItems.Count <= 0) // Do not execute code if no item is selected
                return;

            // Loop through the checked items and remove the selected customers from the customers list
            for (int i = lstCustomers.CheckedItems.Count - 1; i >= 0; i--)
            {
                var item = lstCustomers.CheckedItems[i];
                customers.Remove(item as Customer);
            }

            // Refresh the data source with the updated customers list
            lstCustomers.DataSource = null;            
            lstCustomers.DataSource = customers;
            lstCustomers.DisplayMember = "FullName";
        }

    }
}