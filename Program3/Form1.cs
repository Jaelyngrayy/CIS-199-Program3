//Grading ID: R5560
//Program 3
//Due Date: April 1, 2021
//Course Section: CIS 199-01
//Description: GUI Application that takes user input for farm, item number and pounds and tells the user the price of their order. Uses parallel arrays and for loops to search the arrays. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class GroceryCalculator : Form
    {
        public GroceryCalculator()
        {
            InitializeComponent();
        }

        string[] farmNameArray = { "NE", "NW", "SE", "SW" }; //array for Farm names. 
        double[] shipmentFeeArray = { .06, .0717, .07, .0874 }; //array for fees corresponding to each farm
        int[] itemNumberArray = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };//array for item numbers
        double[] costPerPoundArray = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };//corresponding price per pound for each item
        int[] poundsLowLimitArray = { 0, 6, 11, 21 }; //Lower limits of specific ranges of pounds
        double[] discountArray = { 0, .05, .1, .15 }; //corresponding discounts for each range of pounds


        //When clicked, it takes the values input by the user and finds the values in the arrays. Once values in array are found, the various prices are calculated using said values and the values of the corresponding parallel arrays. 
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int itemNumber, //item number input by the user stored here
                quantity; //# of pounds input by user stored here
            double initialCost, //used to hold the calculated initial cost
                discountCost,//used to hold the calculated discounted cost
                shipCost,//used to hold the calculated shipping cost
                totalPrice,//used to hold the calculated Total price of the order
                costPerPound = 0, //cost of specified item per pound
                discount, //discount that corresponds to the range of pounds input
                shipFee = 0; //Shipment Fee of specifeid farm
            bool found2, found3 = false; //used to hold boolean value for array searches 
            bool found1 = false; //Same as above


            //TryParse the checks if the values input are valid. If not, they are taken to the else statement at the bottom. If they are, program runs.
            if (int.TryParse(itemTextBox.Text, out itemNumber) && (int.TryParse(quantityTextBox.Text, out quantity)) && (farmComboBox.SelectedIndex >= 0) && itemNumber >= 10001 && itemNumber <= 10007 && quantity >= 0)
            {
                for (int x = 0; x < itemNumberArray.Length; x++)//for loop that searches the item number array to search the array for the value input by user
                {
                    if (itemNumberArray[x] == itemNumber)//when value is found
                    {
                        found1 = true;//found 1 becomes true
                        costPerPound = costPerPoundArray[x];//the cost per pound variable becomes the value that corresponds with specified item 
                        x = itemNumberArray.Length; // x becomes the length of the array to end the for loop as soon as the value is found
                    }
                }

                int y = poundsLowLimitArray.Length - 1;
                while (y >= 0 && quantity < poundsLowLimitArray[y])//while loop that determines what range the quanitiy input falls into
                {
                    --y;
                }
                discount = discountArray[y]; //discount variable becomes the value that corresponds to the specified quanitity range
                found2 = true;//found2 becomes true

                for(int x = 0; x < farmNameArray.Length; x++)//for loop that seaches the farm name array for the value chose by the user in the combo box
                {
                    if(farmNameArray[x] == farmComboBox.Text)//when value is found
                    {
                        found3 = true;//found 3 becomes true
                        shipFee = shipmentFeeArray[x]; //shipment fee variable becomes the value that corresponds to the specifie farm
                        x = farmNameArray.Length;//ends search as soon as value is found
                    }
                }

                if(found2 && found3 && found1)//if/when all 3 values are found, the final prices are calculated used the values found and assigned in the array searches
                {
                    initialCost = costPerPound * quantity;//calculates initial cost
                    discountCost = initialCost * (1 - discount);//calculates discount cost
                    shipCost = discountCost * shipFee;//calculates shipment cost
                    totalPrice = shipCost + discountCost;//calculates total cost

                    initialCostOutLabel.Text = $"{initialCost:C}"; //outputs into output label and converts it to currency format
                    discountedCostOutLabel.Text = $"{discountCost:C}";//same
                    shipmentCostOutLabel.Text = $"{shipCost:C}";//same
                    totalPriceOutLabel.Text = $"{totalPrice:C}";//same
                }

                    
                     
            }
            else//this happens if any of the values input into the GUi are invalid
            {
                if (int.TryParse(itemTextBox.Text, out itemNumber) == false || itemNumber < 10001 || itemNumber > 10007)//if item number is invalid  or not between 10001 and 10007
                {
                    MessageBox.Show("Invalid Item Number. Must be between 10001 and 10007");//message box
                }
                else if (int.TryParse(quantityTextBox.Text, out quantity) == false || quantity < 0)//if quantiity input is invalid or negative
                {
                    MessageBox.Show("Invalid Quanitity input");//message box
                }
                else if(farmComboBox.SelectedIndex < 0)//if no farm is selected in the combo box
                {
                    MessageBox.Show("Please Choose A Farm");//message box
                }
            }
        }
    }
} 
    

