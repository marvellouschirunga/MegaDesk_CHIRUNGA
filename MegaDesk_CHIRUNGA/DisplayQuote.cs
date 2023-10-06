using MegaDesk_CHIRUNGA.Models;
using System;
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
    public partial class DisplayQuote : Form
    {
        AddQuote addQuote;
        DeskQuote deskQuote;
        Desk desk;
        int rush;
        DesktopMaterial material;
        int drawers;
        int depth;
        int width;
        DateTime date;
        string name;
        decimal price;


        internal DisplayQuote(DeskQuote deskQuote, AddQuote addQuote, decimal totalPrice)
        {
            InitializeComponent();
            this.deskQuote = deskQuote;
            this.desk = deskQuote.Desk;
            this.rush = desk.RushOrderDays;
            this.material = desk.DesktopMaterial;
            this.drawers = desk.NumberOfDrawers;
            this.depth = desk.Depth;
            this.width = desk.Width;
            this.date = deskQuote.Date;
            this.name = deskQuote.CustomerName;
            this.price = deskQuote.TotalPrice;
            this.addQuote = addQuote;
            PopulateForm();

            this.ControlBox = false;
        }

        private void PopulateForm()
        {
            customerNamelabel.Text = name;
            dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
            depthLabel.Text = depth.ToString() + " inches";
            widthLabel.Text = width.ToString() + " inches";
            drawersLabel.Text = drawers.ToString();
            surfaceLabel.Text = material.ToString();
            deliveryLabel.Text = rush.ToString() + " days";
            if (rush == 14)
            {
                deliveryLabel.Text = "(Not in a rush)";
            }
            priceLabel.Text = price.ToString("C");
        }



        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void EditQuotebutton_Click(object sender, EventArgs e)
        {
            addQuote.Show();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
