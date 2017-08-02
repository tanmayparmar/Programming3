using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300872344_ASS_2
{
    public partial class Calculate_Bill : Form
    {
        public Calculate_Bill()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // initialize variables
            decimal beveragePrice = 0M;
            decimal appetizerPrice = 0M;
            decimal mainCoursePrice = 0M;
            decimal dessertPrice = 0M;

            // switch case for beverage combo box
            switch (comboBev.Text)
            {
                case "Soda":
                    beveragePrice = 1.95M;
                    listPrice.Items.Add("$" + beveragePrice);
                    listItem.Items.Add(comboBev.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Tea":
                    beveragePrice = 1.50M;
                    listPrice.Items.Add("$" + beveragePrice);
                    listItem.Items.Add(comboBev.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Milk":
                    beveragePrice = 1.50M;
                    listPrice.Items.Add("$" + beveragePrice);
                    listItem.Items.Add(comboBev.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Coffee":
                    beveragePrice = 1.25M;
                    listPrice.Items.Add("$" + beveragePrice);
                    listItem.Items.Add(comboBev.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Mineral Water":
                    beveragePrice = 2.95M;
                    listPrice.Items.Add("$" + beveragePrice);
                    listItem.Items.Add(comboBev.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                case "Juice":
                    beveragePrice = 2.50M;
                    listPrice.Items.Add("$" + beveragePrice);
                    listItem.Items.Add(comboBev.Text);
                    Program.variables.Bill += beveragePrice;
                    break;

                default:
                    break;
            }


            // switch case for appetizer combobox
            switch (comboApp.Text)
            {
                case "Buffalo Wings":
                    appetizerPrice = 5.95M;
                    listPrice.Items.Add("$" + appetizerPrice);
                    listItem.Items.Add(comboApp.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                case "Buffalo Fingers":
                case "Chips and Salsa":
                    appetizerPrice = 6.95M;
                    listPrice.Items.Add("$" + appetizerPrice);
                    listItem.Items.Add(comboApp.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                case "Potato Skins":
                case "Nachos":
                    appetizerPrice = 8.95M;
                    listPrice.Items.Add("$" + appetizerPrice);
                    listItem.Items.Add(comboApp.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                case "Mushroom Caps":
                    appetizerPrice = 10.95M;
                    listPrice.Items.Add("$" + appetizerPrice);
                    listItem.Items.Add(comboApp.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                case "Shrimp Cocktail":
                    appetizerPrice = 12.95M;
                    listPrice.Items.Add("$" + appetizerPrice);
                    listItem.Items.Add(comboApp.Text);
                    Program.variables.Bill += appetizerPrice;
                    break;

                default:
                    break;
            }

            // switch case for main course combobox
            switch (comboMain.Text)
            {
                case "Seafood Alfredo":
                    mainCoursePrice = 15.95M;
                    listPrice.Items.Add("$" + mainCoursePrice);
                    listItem.Items.Add(comboMain.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Chicken Alfedo":
                case "Chicken Picatta":
                    mainCoursePrice = 13.95M;
                    listPrice.Items.Add("$" + mainCoursePrice);
                    listItem.Items.Add(comboMain.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Turkey Club":
                    mainCoursePrice = 11.95M;
                    listPrice.Items.Add("$" + mainCoursePrice);
                    listItem.Items.Add(comboMain.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Lobster Pie":
                    mainCoursePrice = 19.95M;
                    listPrice.Items.Add("$" + mainCoursePrice);
                    listItem.Items.Add(comboMain.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Prime Rib":
                    mainCoursePrice = 20.95M;
                    listPrice.Items.Add("$" + mainCoursePrice);
                    listItem.Items.Add(comboMain.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Shrimp Scampi":
                    mainCoursePrice = 18.95M;
                    listPrice.Items.Add("$" + mainCoursePrice);
                    listItem.Items.Add(comboMain.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Turkey Dinner":
                    mainCoursePrice = 13.95M;
                    listPrice.Items.Add("$" + mainCoursePrice);
                    listItem.Items.Add(comboMain.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                case "Stuffed Chicken":
                    mainCoursePrice = 14.95M;
                    listPrice.Items.Add("$" + mainCoursePrice);
                    listItem.Items.Add(comboMain.Text);
                    Program.variables.Bill += mainCoursePrice;
                    break;

                default:
                    break;
            }

            // switch case for dessert combobox
            switch (comboDes.Text)
            {
                case "Apple Pie":
                case "Carrot Pie":
                case "Apple Crisp":
                    dessertPrice = 5.95M;
                    listPrice.Items.Add("$" + dessertPrice);
                    listItem.Items.Add(comboDes.Text);
                    Program.variables.Bill += dessertPrice;
                    break;

                case "Sundae":
                    dessertPrice = 3.95M;
                    listPrice.Items.Add("$" + dessertPrice);
                    listItem.Items.Add(comboDes.Text);
                    Program.variables.Bill += dessertPrice;
                    break;

                case "Mud Pie":
                    dessertPrice = 4.95M;
                    listPrice.Items.Add("$" + dessertPrice);
                    listItem.Items.Add(comboDes.Text);
                    Program.variables.Bill += dessertPrice;
                    break;

                default:
                    break;
            }



            
            comboBev.ResetText();
            comboApp.ResetText();
            comboMain.ResetText();
            comboDes.ResetText();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnTotal.Enabled = true;
            btnAdd.Enabled = true;

            // discard all combo boxes, list boxes and reset bill
            comboDes.ResetText();
            comboMain.ResetText();
            comboApp.ResetText();
            comboBev.ResetText();

            listItem.Items.Clear();
            listPrice.Items.Clear();

            Program.variables.Bill = 0M;
            tbTotal.Text = "$0";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
           

            Decimal SubTotal = Program.variables.Bill;
            tbSub.Text = "$" + SubTotal.ToString();

            Decimal Tax = Program.variables.Bill * 13 / 100;
            tbTax.Text = "$" + Tax.ToString();

            Program.variables.Bill += Program.variables.Bill * 13 / 100;
            tbTotal.Text = "$" + Math.Round(Program.variables.Bill, 2).ToString();


            btnTotal.Enabled = false;
            btnAdd.Enabled = false;
            tbSub.Enabled = false;
            tbTax.Enabled = false;
            tbTotal.Enabled = false;
             
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void Calculate_Bill_Load(object sender, EventArgs e)
        {

        }
    }


}
