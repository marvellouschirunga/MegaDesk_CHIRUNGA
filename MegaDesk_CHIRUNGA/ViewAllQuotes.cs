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
    public partial class ViewAllQuotes : Form
    {
        private MainMenu mainMenu;
        public ViewAllQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu.Show();
        }
    }
}
