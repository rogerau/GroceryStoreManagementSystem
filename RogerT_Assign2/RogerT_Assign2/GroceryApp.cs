using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


// Section 001, Roger Diaz Tazza, 300341127


namespace RogerT_Assign2
{
    public partial class GroceryAppForm : Form
    {
        public GroceryAppForm()
        {
            //Builds the form at run time.
            //All the properties that are set during the design are placed in this method.
            //All the changes in the properties are placed in this method.
            InitializeComponent();
        }

        //1. Create a list of the class Grocery to hold all the groceries items.
        //   Each element of the list is a grocery item.
        List<Grocery> GroceryList = new List<Grocery>();

        //2. Event-handler methods (EHM)
        //EHM when the form is loaded
        private void GroceryAppForm_Load(object sender, EventArgs e)
        {
            //Show a welcome message to the grocery app
            MessageBox.Show("Welcome to the Grocery App!");
        }

        //EHM when the load data button is clicked
        private void LDButton_Click(object sender, EventArgs e)
        {
            //First call the method that reads and add the groceries items from the source file
            //into the grocery list
            AddGroceryDataToList();
            //Then, call the method that add each grocery item from the grocery list into the ListBox
            LoadGroceryData(GroceryList);
            //Finally, display an status message in the StatusLabel with the number of groceries items added into the grocery list
            StatusLabel.Text = "Loaded " + GroceryList.Count + " items from the input file";

        }

        //EHM when a grocery item selection changes
        private void GroceryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Store the index of the grocery item selected
            int index = GroceryListBox.SelectedIndex;

            //If the index selected is the header(0)
            //Display the message in the StatusLabel "Selected header in the listbox"
            if (index == 0)
            {
                StatusLabel.Text = "Selected header in the listbox";

            }
            //If the index selectes is greater than 0 and there is groceries added in the grocery list
            //display the message in the StatusLabel "Selected item index in listbox is X, Selected grocery is Y"
            else if (index > 0 && GroceryList.Count > 0)
            {
                StatusLabel.Text = "Selected item index in listbox is " + index
                                      + "\nSelected Grocery is " + GroceryList[index - 1].ItemCode;
            }
        }

        //EHM when the update sold quantity button is clicked
        private void UQSButton_Click(object sender, EventArgs e)
        {
            //First call the method to update the sold quantity 
            UpdateSoldQty();
            //Then, clear the textbox field for entering the sold quantity
            UQSTextBox.Text = "";
            //Finally, focus again the textbox field for entering the sold quantity for a new entry
            UQSTextBox.Focus();
        }

        //EHM when the update restocked quantity button is clicked
        private void UQRButton_Click(object sender, EventArgs e)
        {
            //First call the method to update the restocked quantity
            UpdateRestockedQty();
            //Then, clear the textbox field for entering the restocked quantity
            UQRTextBox.Text = "";
            //Finally, focus again the textbox field for entering the restocked quantity for a new entry
            UQRTextBox.Focus();
        }

        //EHM when the delete grocery button is clicked
        private void DGButton_Click(object sender, EventArgs e)
        {
            //Call the method to delete a grocery item
            DeleteGrocery();

        }

        //EHM when the sort items based on sale button is clicked
        private void SGButton_Click(object sender, EventArgs e)
        {
            //Call the method to sort the grocery items based on the total sales made
            SortItemsBasedOnSales();
        }

        //EHM when the save groceries data button is clicked
        private void SDButton_Click(object sender, EventArgs e)
        {
            //First, call the method to save the available grocery data into a new file
            SaveGroceryData(GroceryList.OrderByDescending(grocery => grocery.TotalSales).ToList());
            //Then, clear the listbox
            GroceryListBox.Items.Clear();
        }

        //EHM when the save sales report button is clicked
        private void SSRButton_Click(object sender, EventArgs e)
        {
            //First, call the method to save the available grocery data that their quantity sold is greater than 0 into a new file
            SaveSalesReport(GroceryList.OrderByDescending(grocery => grocery.TotalSales).ToList());
            //Then, clear the listbox
            GroceryListBox.Items.Clear();
        }

        //EHM when the save restock needs report button is clicked
        private void SRRButton_Click(object sender, EventArgs e)
        {
            //First, call the method to save the available grocery data that have the available quantity lesser than the min quantity
            //for restock into a new file
            SaveRestockReport(GroceryList.OrderByDescending(grocery => grocery.TotalSales).ToList());
            //Then, clear the listbox
            GroceryListBox.Items.Clear();
        }

        //3. Methods
        //Void method to write program instructions(program objective and program inputs)
        // Method that reads and add the groceries items from the source file into the grocery list
        private void AddGroceryDataToList()
        {
            //Clear the grocery list each time this method is called
            GroceryList.Clear();
            //Create a string variable to hold each record read from the source file (keeps tracking)
            string inputLine;
            //Use a Try Catch block that helps to identifty any error generated when we read data from files
            try
            {
                //Use the using block that replaces the necessity of testing if the file exists or not, as well as
                //closing the file after the read is done. Basically, the using block generates a scope for the file. After
                //the using block is closed, the file is closed.
                //Create an instance of the StreamReader class
                using (StreamReader inputFile = new StreamReader("superstore.csv"))
                {
                    //As the StreamReader is a pointer that will read each record from the top to the end of the file,
                    //we start storing the first record read from the file into the inputLine variable (which will be the header)
                    inputLine = inputFile.ReadLine();
                    //Test if this record is not null (exists) and show a windows message with the content and a message that 
                    //this record will no be considered into the grocery list
                    if (inputLine != null)
                    {
                        MessageBox.Show("This is the header: " + inputLine + " It will not be considered into the grocery list.");
                    }
                    //Now the pointer comes to the second record in the file. Including this record and after it, will be included
                    //into the grocery list. So, set a loop to read every record if it is not null, then split the record into variables (parse if necessary)
                    //and populate each grocery item. Finally, insert each grocery item into the grocery list. 

                    //Create an array to hold the variables from each record
                    string[] inputArray = new string[7];
                    while ((inputLine = inputFile.ReadLine()) != null)
                    {
                        //Split each record and store the information into variables (parse if necessary)
                        inputArray = inputLine.Split(",");
                        string iCode = inputArray[0];
                        string iName = inputArray[1];
                        double.TryParse(inputArray[2], out double uPrice);
                        int.TryParse(inputArray[3], out int qMinRestock);
                        int.TryParse(inputArray[4], out int iQuantity);
                        int.TryParse(inputArray[5], out int qSold);
                        int.TryParse(inputArray[6], out int qRestocked);
                        //Populate each grocery item with their respective information
                        Grocery eachGrocery = new Grocery(iCode, iName, uPrice, qMinRestock, iQuantity, qSold, qRestocked);
                        //Add each grocery item into the grocery list
                        GroceryList.Add(eachGrocery);
                    }
                }
            }
            //Identify and display an error message if the file is not found
            catch (FileNotFoundException fex)
            {
                MessageBox.Show("File Not Found: " + fex.Message);
            }
            //Identify and display an error message if any file error occurs
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message);
            }
        }
        //Method that adds each grocery item from the grocery list into the ListBox (takes as an input the grocery list)
        private void LoadGroceryData(List<Grocery> AnyGroceryList)
        {
            //Using formatted string in string.format() to format the header for the listbox
            string objectStr2 = String.Format("{0, -15} {1, -20} {2, -15} {3, -18} {4, -15} {5, -15} {6, -15} {7, -15} {8, -15}",
                             "ItemCode", "ItemName", "UnitPrice", "QtyMinForRestock", "InitialQty",
                             "QtySold", "QtyRestocked", "AvailableQty", "TotalSales");
            //Clear the listbox
                GroceryListBox.Items.Clear();
            //Add the formatted header into the listbox
                GroceryListBox.Items.Add(objectStr2);
            //Add each formatted grocery information into the listbox
                foreach (Grocery item in AnyGroceryList)
                {
                    GroceryListBox.Items.Add(item); 
                }
        }

        //Method that updates the quantity sold for a selected item
        private void UpdateSoldQty()
        {
            //Store the index of the grocery item selected
            int index = GroceryListBox.SelectedIndex;

            //If the index selected is the header(0) or nothing is selected(-1)
            //display the message in the StatusLabel "Please select a grocery item to increment sold qty"
            if (index <= 0)
            {
                StatusLabel.Text = "Please select a grocery item to increment sold qty";
                //Then, focus the textbox to allow the user enter a new value
                UQSTextBox.Focus();
            }

            //If the index selected is greater than 0 and the quantity registered is not an integer, less than 0
            //and greater than the available quantity, display the message in the statusLabel
            //"Please insert a value greater than 0 and less than the avalable qty"
            else
            {
                if (!int.TryParse(UQSTextBox.Text, out int qIncrement) || 
                    qIncrement <= 0 || 
                    qIncrement > GroceryList[index - 1].AvailableQty) 
                {
                    StatusLabel.Text = "Please insert a value greater than 0 and less than the available qty";
                    //Then, focus the textbox to allow the user enter a new value
                    UQSTextBox.Focus();
                }

                //If the index selected is greater than 0 and the quantity registered is an integer, greater than 0
                //and less than the available quantity,
                //Add the quantity entered to the quantity sold variable for the respective grocery item selected
                //in the grocery list. Also, update the information for the grocery item selected in the listbox
                //Then, display the message in the statusLabel
                //"Sold Qty has been increased for the item with the item code X"
                else
                {
                    GroceryList[index - 1].QtySold += qIncrement;
                    GroceryListBox.Items[index] = GroceryList[index - 1];
                    StatusLabel.Text = "Sold Qty has been increased for the item with the item code " +
                    GroceryList[index - 1].ItemCode;
                }
            }

        }
        //Method that updates the quantity restocked for a selected item
        private void UpdateRestockedQty()
        {
            //Store the index of the grocery item selected
            int index = GroceryListBox.SelectedIndex;

            //If the index selected is the header(0) or nothing is selected(-1)
            //display the message in the StatusLabel "Please select a grocery item to increment restocked qty"
            if (index <= 0)
            {
                StatusLabel.Text = "Please select a grocery item to increment restocked qty";
                //Then, focus the textbox to allow the user enter a new value
                UQRTextBox.Focus();
            }

            //If the index selected is greater than 0 and the quantity registered is not an integer and less than 0
            //display the message in the statusLabel
            //"Please insert a value greater than 0"
            else
            {
                if (!int.TryParse(UQRTextBox.Text, out int rIncrement) ||
                    rIncrement <= 0) 
                {
                    StatusLabel.Text = "Please insert a value greater than 0";
                    //Then, focus the textbox to allow the user enter a new value
                    UQRTextBox.Focus();
                }

                //If the index selected is greater than 0 and the quantity registered is an integer and greater than 0
                //Add the quantity entered to the quantity restocked variable for the respective grocery item selected
                //in the grocery list. Also, update the information for the grocery item selected in the listbox
                //Then, display the message in the statusLabel
                //"Incremented Restocked Qty for item with item code X"
                else
                {
                    GroceryList[index - 1].QtyRestocked += rIncrement;
                    GroceryListBox.Items[index] = GroceryList[index - 1];
                    StatusLabel.Text = "Incremented Restocked Qty for item with item code " +
                    GroceryList[index - 1].ItemCode;
                }
            }
        }
        //Method that deletes a grocery item if selected
        private void DeleteGrocery()
        {
            //Store the index of the grocery item selected
            int index = GroceryListBox.SelectedIndex;

            //If the index selected is the header(0) or nothing is selected(-1)
            //display the message in the StatusLabel "Please select a grocery item to delete"
            if (index <= 0)
            {
                StatusLabel.Text = "Please select a grocery item to delete";
            }

            //If the index selected is greater than 0, remove the grocery item from the listbox.
            //Then, display the message in the statusLabel "Delete item with item code X"
            //Finally, remove the grocery item from the grocery list
            else
            {
                GroceryListBox.Items.RemoveAt(index);
                StatusLabel.Text = "Delete item with item code " +
                GroceryList[index - 1].ItemCode;
                GroceryList.RemoveAt(index - 1);
            }
        }

        //Method to sort the grocery items based on total sales
        private void SortItemsBasedOnSales()
        {
            //Create a new grocery list to hold each grocery item sorted in descending by the total sales
            List<Grocery> SortedGroceryList = GroceryList.OrderByDescending(grocery => grocery.TotalSales).ToList();
            //Call the method to add each grocery item sorted again into the listbox
            LoadGroceryData(SortedGroceryList);
        }

        //Method to save the grocery data into a new file
        private void SaveGroceryData(List<Grocery>AnyGroceryList)
        {
            //Use a Try Catch block that helps to identifty any error generated when we write data into a file
            try
            {
                //Use the using block that replaces the necessity of closing the file after the write is done.
                //Basically, the using block generates a scope for the file. After
                //the using block is closed, the file is closed.
                //Create an instance of the StreamWriter class
                using (StreamWriter outputFile = new StreamWriter("updatedgrocery.csv",false))
                {
                    //Write the header for this new file into the file
                    outputFile.WriteLine("ItemCode,ItemName,UnitPrice,QtyMinForRestock,InitialQty,QtySold,QtyRestocked");
                    //Set a counter to count how many grocery items are written into the file
                    int counter = 0;
                    //Set a loop to write each grocery item left (updated or not) into the grocery list
                    //Each time a grocery item is written, the counter will be risen by 1
                    foreach (Grocery item in AnyGroceryList)
                    {
                        outputFile.WriteLine(item.ItemCode + "," + item.ItemName + "," + item.UnitPrice + "," +
                            item.QtyMinForRestock + "," + item.InitialQty + "," + item.QtySold + "," + item.QtyRestocked);
                        counter++;
                    }
                    //Finally, display an status message in the StatusLabel with the number of records save into the new file
                    StatusLabel.Text = "Saved " + counter + " records into the output inventory file";
                }
            }
            //Identify and display an error message if the directory for this new file is not found
            catch (DirectoryNotFoundException dex)
            {
                MessageBox.Show("Directory Not Found: " + dex.Message);
            }
            //Identify and display an error message if any file error occurs
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message);
            }
        }

        //Method to save the grocery sales report into a new file
        private void SaveSalesReport(List<Grocery>AnyGroceryList)
        {
            //Use a Try Catch block that helps to identifty any error generated when we write data into a file
            try
            {
                //Use the using block that replaces the necessity of closing the file after the write is done.
                //Basically, the using block generates a scope for the file. After
                //the using block is closed, the file is closed.
                //Create an instance of the StreamWriter class
                using (StreamWriter outputFile = new StreamWriter("grocerysales.csv", false))
                {
                    //Write the header for this new file into the file
                    outputFile.WriteLine("ItemCode,ItemName,UnitPrice,QtySold,Sales");
                    //Set a counter to count how many grocery items are written into the file
                    int counter = 0;
                    //Set a loop to write each grocery item left (updated or not), whose quantity sold is greater than 0,
                    //into the grocery list.
                    //Each time a grocery item is written, the counter will be risen by 1
                    foreach (Grocery item in AnyGroceryList)
                    {
                        if (item.QtySold>0)
                        {
                            outputFile.WriteLine(item.ItemCode + "," + item.ItemName + "," + item.UnitPrice.ToString("C2") + "," +
                             item.QtySold + "," + item.TotalSales.ToString("C2"));
                            counter++;
                        }
                    }
                    //Finally, display an status message in the StatusLabel with the number of records save into the new file
                    StatusLabel.Text = "Saved " + counter + " records into the output sales file";
                }
            }
            //Identify and display an error message if the directory for this new file is not found
            catch (DirectoryNotFoundException dex)
            {
                MessageBox.Show("Directory Not Found: " + dex.Message);
            }
            //Identify and display an error message if any file error occurs
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message);
            }
        }
        //Method to save the grocery restock data into a new file
        private void SaveRestockReport(List<Grocery> AnyGroceryList)
        {
            //Use a Try Catch block that helps to identifty any error generated when we write data into a file
            try
            {
                //Use the using block that replaces the necessity of closing the file after the write is done.
                //Basically, the using block generates a scope for the file. After
                //the using block is closed, the file is closed.
                //Create an instance of the StreamWriter class
                using (StreamWriter outputFile = new StreamWriter("groceryrestocks.csv", false))
                {
                    //Write the header for this new file into the file
                    outputFile.WriteLine("ItemCode,ItemName,AvailableQty,QtyMinForRestock");
                    //Set a counter to count how many grocery items are written into the file
                    int counter = 0;
                    //Set a loop to write each grocery item left (updated or not), whose quantity avaiable is less than the minimum quantity for restock,
                    //into the grocery list.
                    //Each time a grocery item is written, the counter will be risen by 1
                    foreach (Grocery item in AnyGroceryList)
                    {
                        if (item.AvailableQty < item.QtyMinForRestock)
                        {
                            outputFile.WriteLine(item.ItemCode + "," + item.ItemName + "," + item.AvailableQty + "," +
                             item.QtyMinForRestock);
                            counter++;
                        }

                    }
                    //Finally, display an status message in the StatusLabel with the number of records save into the new file
                    StatusLabel.Text = "Saved " + counter + " records into the restocks needed output file";
                }
            }
            //Identify and display an error message if the directory for this new file is not found
            catch (DirectoryNotFoundException dex)
            {
                MessageBox.Show("Directory Not Found: " + dex.Message);
            }
            //Identify and display an error message if any file error occurs
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.Message);
            }
        }

    
    }
}
