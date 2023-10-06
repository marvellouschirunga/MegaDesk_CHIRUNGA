using MegaDesk_CHIRUNGA.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_CHIRUNGA
{
    public partial class AddQuote : Form
    {
        private MainMenu mainMenu;
        private const int MIN_WIDTH = Desk.MIN_WIDTH;
        private const int MAX_WIDTH = Desk.MAX_WIDTH;
        private const int MIN_DEPTH = Desk.MIN_DEPTH;
        private const int MAX_DEPTH = Desk.MAX_DEPTH;

        public AddQuote(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.ControlBox = false;
            PopulateMaterialBox();
            PopulateDeliveryBox();
            PopulateDrawerBox();
        }

        private void AddQoute_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void PopulateMaterialBox()
        {
            foreach (DesktopMaterial material in Enum.GetValues(typeof(DesktopMaterial)))
            {
                surfaceMaterialComboBox.Items.Add(material.ToString());
            }
            surfaceMaterialComboBox.SelectedItem = "Rosewood";
        }

        private void PopulateDeliveryBox()
        {
            int[] rushOrderValues = { 3, 5, 7, 14 };

            foreach (int value in rushOrderValues)
            {
                deliveryComboBox.Items.Add(value);
            }
            deliveryComboBox.SelectedItem = 14;
        }

        private void PopulateDrawerBox()
        {
            // 0 to 7 drawers
            for (int i = 0; i <= 7; i++)
            {
                numberOfDrawersComboBox.Items.Add(i);
            }
            numberOfDrawersComboBox.SelectedItem = 2;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }

        private void submitQuotebutton_Click(object sender, EventArgs e)
        {
            //get all data from form
            string customerName = customerNameTextBox.Text;
            string widthText = widthTextBox.Text;
            string depthText = depthTextBox.Text;
            string drawersText = numberOfDrawersComboBox.SelectedItem.ToString();
            string surfaceMaterialText = surfaceMaterialComboBox.SelectedItem.ToString();
            string rushOrderText = deliveryComboBox.SelectedItem.ToString();

            //Validate width 
            string errorMsg;
            if (!ValidWidth(widthText, out errorMsg))
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate depth
            string depthErrorMsg;
            if (!ValidDepth(depthText, out depthErrorMsg))
            {
                MessageBox.Show(depthErrorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Quote submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
            // Creating a DeskQuote instance with the quote data
            DeskQuote deskQuote = new DeskQuote(
                new Desk(int.Parse(widthText), 
                         int.Parse(depthText), 
                         int.Parse(drawersText), 
                         (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), 
                         surfaceMaterialText), int.Parse(rushOrderText)),
                         customerName,
                         DateTime.Now
            );

            deskQuote.CreateNewQuote();

            decimal totalPrice = deskQuote.TotalPrice;

            // Create and show the DisplayQuote form with the quote data
            DisplayQuote displayQuoteForm = new DisplayQuote(deskQuote, this, totalPrice);
            displayQuoteForm.Show();
            this.Hide();

        }

        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(widthTextBox.Text, out errorMsg))
            {
                e.Cancel = true;
                widthTextBox.Select(0, widthTextBox.Text.Length);
                errorProvider1.SetError(widthTextBox, errorMsg);
            }
        }

        private void widthTextBox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(widthTextBox, "");
        }

        public bool ValidWidth(string widthText, out string errorMsg)
        {

            if (widthText.Length == 0)
            {
                errorMsg = "Width is required.";
                return false;
            }

            if (!int.TryParse(widthText, out int width))
            {
                errorMsg = "Width must be a valid number.";
                return false;
            }

            if (width < MIN_WIDTH || width > MAX_WIDTH)
            {
                errorMsg = $"Width must be between {MIN_WIDTH} and {MAX_WIDTH}.";
                return false;
            }

            errorMsg = string.Empty;

            return true;

        }

        private void depthTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidDepth(depthTextBox.Text, out errorMsg))
            {
                e.Cancel = true;
                depthTextBox.Select(0, depthTextBox.Text.Length);
                errorProvider1.SetError(depthTextBox, errorMsg);
            }
        }

        private void depthTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(depthTextBox, "");
        }

        public bool ValidDepth(string depthText, out string errorMsg)
        {
            if (depthText.Length == 0)
            {
                errorMsg = "Depth is required.";
                return false;
            }

            if (!int.TryParse(depthText, out int depth))
            {
                errorMsg = "Depth must be a valid number.";
                return false;
            }

            if (depth < MIN_DEPTH || depth > MAX_DEPTH)
            {
                errorMsg = $"Depth must be between {MIN_DEPTH} and {MAX_DEPTH}.";
                return false;
            }

            errorMsg = string.Empty;
            return true;

        }
    }
}
