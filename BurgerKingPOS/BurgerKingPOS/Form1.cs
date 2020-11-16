using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerKingPOS
{

    public partial class Form1 : Form
    {

        int price = 000;
        string priceE = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodListBox.Items.Remove(FoodListBox.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(ItemName1.Text);
            int price1 = int.Parse(PriceButton.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }
        private void PriceButton2_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(ItemName2.Text);
            int price1 = int.Parse(PriceButton2.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PriceButton3_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(PriceLabel3.Text);
            int price1 = int.Parse(PriceButton3.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PriceButton4_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(PriceLabel4.Text);
            int price1 = int.Parse(PriceButton4.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PriceButton5_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(PriceLabel5.Text);
            int price1 = int.Parse(PriceButton5.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PriceButton6_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(PriceLabel6.Text);
            int price1 = int.Parse(PriceButton6.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PriceButton7_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(PriceLabel7.Text);
            int price1 = int.Parse(PriceButton7.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PriceButton8_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(PriceLabel8.Text);
            int price1 = int.Parse(PriceButton8.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PriceButton9_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(PriceLabel9.Text);
            int price1 = int.Parse(PriceButton9.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PriceButton10_Click(object sender, EventArgs e)
        {
            FoodListBox.Items.Add(PriceLabel10.Text);
            int price1 = int.Parse(PriceButton10.Text);
            price += price1;
            priceE = price.ToString();
            label3.Text = priceE;
        }

        private void PaymentBox_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            textBox1.Visible = true;
            textBox1.ReadOnly = false;
            ChangeBox.Enabled = true;
        }

        private void ChangeBox_Click(object sender, EventArgs e)
        {
            int pay = int.Parse(textBox1.Text);
            if (price < pay)
            {
                textBox1.ReadOnly = true;
                price -= pay;
                PaymentBox.Enabled = false;
                NewOrderBox.Enabled = true;
                ChangeBox.Enabled = false;
                MessageBox.Show("your change is: " + price * -1);
            }
            else 
            {
                MessageBox.Show("your payment is not up to par");
            }


        }

        private void NewOrderBox_Click(object sender, EventArgs e)
        {
            PaymentBox.Enabled = true;
            NewOrderBox.Enabled = false;
            ChangeBox.Enabled = false;
            priceE = "000";
            price = 0;
            label3.Text = priceE;
            textBox1.Text = "";
            textBox1.Visible = false;
            label5.Visible = false;
            FoodListBox.Items.Clear();
            return;
        }
    }
}
