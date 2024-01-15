using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VendingMachine coffee_machine = new VendingMachine();


        private void black_btn_Click(object sender, EventArgs e)
        {
            bool make = coffee_machine.make_blackCoffee();
            if (make)
            {
                Product.Image = Properties.Resources.blackCoffee;
            }
            else
            {
                Product.Image = Properties.Resources.OutOfStock;
            }
        }

        private void latte_btn_Click(object sender, EventArgs e)
        {
            bool make = coffee_machine.make_latte();
            if (make)
            {
                Product.Image = Properties.Resources.Latte;
            }
            else
            {
                Product.Image = Properties.Resources.OutOfStock;
            }
        }

        private void mocca_btn_Click(object sender, EventArgs e)
        {
            bool make = coffee_machine.make_moccca();
            if (make)
            {
                Product.Image = Properties.Resources.Mocca;
            }
            else
            {
                Product.Image = Properties.Resources.OutOfStock;
            }
        }

        private void choco_btn_Click(object sender, EventArgs e)
        {
            bool make = coffee_machine.make_chocolate();
            if (make)
            {
                Product.Image = Properties.Resources.chocolate;
            }
            else
            {
                Product.Image = Properties.Resources.OutOfStock;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coffee_machine.increaseMaterial(500, 500, 500, 500);
        }
    }
}
