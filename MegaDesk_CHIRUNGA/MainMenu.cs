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
    public partial class MainMenu : Form
    {
        private AddQuote addQuoteView;
        private ViewAllQuotes viewAllQuotesView;
        private SearchQuotes searchQuotesView;

        public MainMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void addQuoteButton_Click_Click(object sender, EventArgs e)
        {
            if (addQuoteView == null) 
            {
                addQuoteView = new AddQuote(this);
            }
            this.Hide();
            addQuoteView.Show();
        }

        private void viewAllQuotesButton_Click_Click(object sender, EventArgs e)
        {
            if (viewAllQuotesView == null) 
            {
                viewAllQuotesView = new ViewAllQuotes(this);
            }
            this.Hide();
            viewAllQuotesView.Show();
        }

        private void searchQoutesButton_Click_Click(object sender, EventArgs e)
        {
            if (searchQuotesView == null)
            {
                searchQuotesView = new SearchQuotes(this);
            }
            this.Hide();
            searchQuotesView.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
