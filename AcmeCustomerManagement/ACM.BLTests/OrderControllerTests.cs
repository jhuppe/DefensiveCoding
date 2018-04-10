using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Library;

namespace ACM.BL.Tests
{
    [TestClass()]
    public class OrderControllerTests
    {
        [TestMethod()]
        public void PlaceOrderTest()
        {
            var orderController = new OrderController();
            var customer = new Customer() { EmailAddress = "tester@gmail.com" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            OperationResult op = orderController.PlaceOrder(customer, order, payment,
                                                 allowSplitOrders: true, emailReceipt: true);

            Assert.AreEqual(true, op.Success);
            Assert.AreEqual(0, op.MessageList.Count);
        }
    }
}