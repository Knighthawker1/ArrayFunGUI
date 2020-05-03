using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayFunGUI
{
    public partial class frmArrayFunGUI : Form
    {
        //Declare and initialize global constants
        const int ARRAYSIZE = 10;
        const int MINVAL = 1;
        const int MAXVAL = 101;

        //Declare and initialize global variables
        static int[] numArray = new int[ARRAYSIZE];
        static int[] origArray = new int[ARRAYSIZE];

        public frmArrayFunGUI()
        {
            InitializeComponent();
        }

        //*******************************************

        private void btnDisplayArray_Click(object sender, EventArgs e)
        {
            generateArray();
            displayArray();
        }

        //*******************************************

        private void btnLowest_Click(object sender, EventArgs e)
        {
            showLowest();
        }

        //*******************************************

        private void btnHighest_Click(object sender, EventArgs e)
        {
            showHighest();
        }

        //*******************************************

        private void btnSum_Click(object sender, EventArgs e)
        {
            showSum();
        }

        //*******************************************

        private void btnAverage_Click(object sender, EventArgs e)
        {
            showAvg();
        }

        //*******************************************

        private void btnAscending_Click(object sender, EventArgs e)
        {
            showAsc();
            displayArray();
        }

        //*******************************************

        private void btnDescending_Click(object sender, EventArgs e)
        {
            showDesc();
            displayArray();
        }

        //*******************************************

        private void btnSearch_Click(object sender, EventArgs e)
        {
            arraySearch();
        }

        //*******************************************

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearListBox();
        }

        //*******************************************

        private void btnHelp_Click(object sender, EventArgs e)
        {
            displayMessageBox("Press Display Array to generate a new array."+
                              "\nPress Display Lowest to show a message box showing the lowest item in the array." +
                              "\nPress Display Highest to show a message box showing the highest item in the array." +
                              "\nPress Display Sum to show the sum of all the elements in the array" +
                              "\nPress Display Avg to show the average of all the elements in the array" +
                              "\nPress Sort Ascending to show the array elements in ascending order." +
                              "\nPress Sort Descending to show the array elements in descending order." +
                              "\nPress Binary Search to search for the input in the nearby textbox." +
                              "\nPress Clear to empty the list box." +
                              "\nPress Exit to close the program",
                              "HELP");
        }

        //*******************************************

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitApplication();
        }

        //*******************************************

        private void displayArray()
        {
            clearListBox();
            for (int i = 0; i < ARRAYSIZE; ++i)
            {
                listboxDisplay.Items.Add(numArray[i].ToString());
            }
        }

        //*******************************************

        static void generateArray()
        {
            //Generates a new array, 10 numbers between 1 and 100
            Random randNum = new Random();
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                numArray[i] = randNum.Next(MINVAL, MAXVAL);
                origArray[i] = randNum.Next(MINVAL, MAXVAL);
            }
        }

        //*******************************************

        private void showLowest()
        {
            int lowest = 0;

            Array.Sort(numArray);
            lowest = numArray[0];

            displayMessageBox("The lowest number in the array is " + lowest,
                              "LOWEST ELEMENT");
        }

        //*******************************************

        private void showHighest()
        {
            int highest = 0;

            Array.Sort(numArray);
            highest = numArray[9];

            displayMessageBox("The highest number in the array is " + highest,
                              "Highest ELEMENT");
        }

        //*******************************************

        private int showSum()
        {
            int sum = 0;

            for (int i = 0; i < ARRAYSIZE; ++i)
            {
                sum += numArray[i];
            }
            
            displayMessageBox("The sum of the array's elements is " + sum,
                              "ARRAY SUM");
            return sum;
        }

        //*******************************************

        private void showAvg()
        {
            int avg = showSum() / ARRAYSIZE;

            displayMessageBox("The average of the array's elements is " + avg,
                              "ARRAY AVERAGE");
        }

        //*******************************************

        private void showAsc()
        {
            Array.Sort(numArray);
        }

        //*******************************************

        private void showDesc()
        {
            Array.Sort(numArray);
            Array.Reverse(numArray);
        }

        //*******************************************

        private void arraySearch()
        {
            int myIndex = 0;
            int searchItem = 0;

            Array.Sort(numArray);
            if (isNumeric(txtSearch.Text))
            {
                searchItem = Convert.ToInt32(txtSearch.Text);
                if((searchItem > 0) && (searchItem < 101))
                {
                    myIndex = Array.BinarySearch(numArray, searchItem);
                    if (myIndex < 0)
                    {
                        displayErrorMessage("Input was not found in the array.",
                                              "SEARCH ERROR");
                    }
                    else
                    {
                        myIndex += 1;
                        displayMessageBox(searchItem + " is item " + myIndex + " in the array.",
                                          "ARRAY SEARCH");
                    }
                }
                else
                {
                    displayErrorMessage("Input must be a number between 1 and 100",
                                      "SEARCH ERROR");
                }
            }
            else
            {
                displayErrorMessage("Input must be a number between 1 and 100",
                                      "SEARCH ERROR");
            }
        }



        private void clearListBox()
        {
            listboxDisplay.Items.Clear();
        }

        //*******************************************

        static bool isNumeric(String input)
        {
            double test;
            return double.TryParse(input, out test);  //Return true if the input can converted to an double
        }

        //*******************************************

        private void displayMessageBox(string msg, string title)
        {
            MessageBox.Show(msg,
                            title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        //*******************************************

        private void displayErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg,
                            title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        //*******************************************

        private void exitApplication()
        {
            if (MessageBox.Show("Exit Program Now?",
                                "EXIT PROGRAM???",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) ==
                                DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
