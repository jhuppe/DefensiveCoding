using ACM.BL;
using System;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class OrderWin : Form
    {

        //private readonly Customer _customer; 
        public OrderWin()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button != null)
            {
                button.Text = "Processing ...";
            }

            PlaceOrder();
        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            // Populate the customer instance

            var order = new Order();
            // Populate the order instance

            var allowSplitOrders = true;
            var emailReceipt = true;

            var payment = new Payment();

            var orderController = new OrderController();

            try
            {
                orderController.PlaceOrder(customer, order, payment,
                allowSplitOrders: false,
                emailReceipt: true);
            }
            catch (ArgumentNullException ex)
            {

                //log the issue
                //display a message to the user that the order was not successful
            }
            
        }

        
    }
}