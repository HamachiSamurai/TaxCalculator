using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorForTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButtonClicked(object sender, EventArgs e)
        {
            int price;
            bool success = int.TryParse(this.priceBox.Text, out price);

            if (success)
            {
                double tax = 1.1;
                int taxPrice = (int)(price * tax);
                this.taxBox.Text = taxPrice.ToString();
            } else
            {
                this.taxBox.Text = "正しい税抜き価格を入力してください";
            }
        }
    }
}
