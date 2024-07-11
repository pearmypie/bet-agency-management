using PAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW
{
    public partial class ViewBetsForm : Form
    {
        public ViewBetsForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewBetsForm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach (Bet bet in Database.Database.Bets)
            {
                ListViewItem item = new ListViewItem(bet.Id.ToString());
                item.SubItems.Add(bet.MatchId.ToString());
                item.SubItems.Add(bet.GamblerId.ToString());
                item.SubItems.Add(bet.Amount.ToString());
                item.SubItems.Add(bet.Result);
                listView1.Items.Add(item);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var bet = (Bet)listView1.SelectedItems[0].Tag;

            //comboBox2.Text = bet.
        }
    }
}
