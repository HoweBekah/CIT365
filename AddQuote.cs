using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_BekahHowe
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void MainmenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void validInt(object sender, CancelEventArgs e)
        {
            Desk newDesk = new Desk();
            
            if ( newDesk.Width < Desk.MINWIDTH)
            {
                MessageBox.Show("Please enter a width between 24in and 96in.");
            }
            else if (newDesk.Width > Desk.MAXWIDTH)
            {
                MessageBox.Show("Please enter a width between 24in and 96in.");
            }
           else {
                newDesk.Width = Width;
            }

            if (newDesk.Depth < Desk.MINDEPTH)
            {
                MessageBox.Show("Please enter a depth between 12in and 48in.");
            }
            else if (newDesk.Depth > Desk.MAXDEPTH)
            {
                MessageBox.Show("Please enter a depth between 12in and 48in.");
            }
            else
            {
                newDesk.Depth = newDesk.Depth;
            }
        }

        private void GetQuote_Click(object sender, EventArgs e)
        {
            DisplayQuote viewNewQuote = new DisplayQuote();
            viewNewQuote.Tag = this;
            viewNewQuote.Show(this);
            Hide();
        }
    }
}
