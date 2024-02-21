using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._9_RestaurantBillCalc
{
    public partial class Form1 : Form
    {
        public struct Orders
        {
            public string item;
            public double price;
        }
        const double TAX = 0.08; //8% tax
        Orders order = new Orders();
        static double subtotal = 0; //w/o taxes
        static double totalTaxes = 0;
        static double total = 0; //w/taxes
        string finalBill = "FINAL BILL: \n";

        public Form1()
        {
            InitializeComponent();
        }

        private void getValues(string custOrder)
        {
            order.item = custOrder.Split('$')[0];
            order.price = Convert.ToDouble(custOrder.Split('$')[1]);
            lstOutput.Items.Add("Price: " + order.price);
            finalBill += "Ordered Items: " + order.item + "\nPrice: " + order.price.ToString("C2") + "\n";
            updateBill();

        }

        private void updateBill()
        {
            subtotal += order.price;
            total += order.price + (order.price * TAX);
            totalTaxes += order.price * TAX;

            lstOutput.Items.Clear();
            lstOutput.Items.AddRange(finalBill.Split('\n'));
            lstOutput.Items.Add("Subtotal: " + subtotal.ToString("C2"));
            lstOutput.Items.Add("Tax: " + totalTaxes.ToString("C2"));
            lstOutput.Items.Add("Total: " + total.ToString("C2"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dropdownSelection(object sender, EventArgs e)
        {
            if (sender == bevs)
                getValues(bevs.SelectedItem.ToString());
            else if (sender == apps)
                getValues(apps.SelectedItem.ToString());
            else if (sender == mains)
                getValues(mains.SelectedItem.ToString());
            else
                getValues(dess.SelectedItem.ToString());

        }

        private void clear_Click(object sender, EventArgs e)
        {
            subtotal = 0; //w/o taxes
            totalTaxes = 0;
            total = 0; //w/taxes
            finalBill = "FINAL BILL: \n";
            lstOutput.Items.Clear();
        }
    }
}
