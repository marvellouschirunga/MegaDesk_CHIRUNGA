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
    public partial class SearchQuotes : Form
    {
        private MainMenu mainMenu;
        public SearchQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
