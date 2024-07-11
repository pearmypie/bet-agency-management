using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAW
{
    public partial class BetQuery : Form
    {
        public BetQuery()
        {
            InitializeComponent();
        }

        private void idquerybtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBox1.Text);

            listView1.Items.Clear();
            foreach (var bet in Database.Database.Bets)
            {
                if (bet.GamblerId == id)
                {
                    foreach (var match in Database.Database.Matches)
                    {
                        if (match.Id == bet.MatchId)
                        {
                            ListViewItem item = new ListViewItem(bet.Id.ToString());

                            item.SubItems.Add(bet.MatchId.ToString() + ": " + match.TeamA + " vs. " + match.TeamB);

                            item.SubItems.Add(bet.GamblerId.ToString());
                            item.SubItems.Add(bet.Amount.ToString());
                            item.SubItems.Add(bet.Result);

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void namequerybtn_Click(object sender, EventArgs e)
        {
            string name = userNameTB.Text;
            int? id = null;

            listView1.Items.Clear();
            foreach (var user in Database.Database.Users)
            {
                if (user.NameOrDescription.Equals(name))
                {
                    id = user.Id;
                }
            }

            if (id != null)
            {
                foreach (var bet in Database.Database.Bets)
                {
                    if (bet.GamblerId == id)
                    {
                        foreach (var match in Database.Database.Matches)
                        {
                            if (match.Id == bet.MatchId)
                            {
                                ListViewItem item = new ListViewItem(bet.Id.ToString());

                                item.SubItems.Add(bet.MatchId.ToString() + ": " + match.TeamA + " vs. " + match.TeamB);

                                item.SubItems.Add(bet.GamblerId.ToString());
                                item.SubItems.Add(bet.Amount.ToString());
                                item.SubItems.Add(bet.Result);

                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }

        private void cnpquerybtn_Click(object sender, EventArgs e)
        {
            string cnp = userCNPTB.Text;
            int? id = null;

            listView1.Items.Clear();
            foreach (var user in Database.Database.Users)
            {
                if (user.CNP.Equals(cnp))
                {
                    id = user.Id;
                }
            }

            if (id != null)
            {
                foreach (var bet in Database.Database.Bets)
                {
                    if (bet.GamblerId == id)
                    {
                        foreach (var match in Database.Database.Matches)
                        {
                            if (match.Id == bet.MatchId)
                            {
                                ListViewItem item = new ListViewItem(bet.Id.ToString());

                                item.SubItems.Add(bet.MatchId.ToString() + ": " + match.TeamA + " vs. " + match.TeamB);

                                item.SubItems.Add(bet.GamblerId.ToString());
                                item.SubItems.Add(bet.Amount.ToString());
                                item.SubItems.Add(bet.Result);

                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }

        private void dobquerybtn_Click(object sender, EventArgs e)
        {
            DateTime dob = userDOBDP.Value;
            int? id = null;

            listView1.Items.Clear();
            foreach (var user in Database.Database.Users)
            {
                if (user.DOB.Equals(dob))
                {
                    id = user.Id;
                }
            }

            if (id != null)
            {
                foreach (var bet in Database.Database.Bets)
                {
                    if (bet.GamblerId == id)
                    {
                        foreach (var match in Database.Database.Matches)
                        {
                            if (match.Id == bet.MatchId)
                            {
                                ListViewItem item = new ListViewItem(bet.Id.ToString());

                                item.SubItems.Add(bet.MatchId.ToString() + ": " + match.TeamA + " vs. " + match.TeamB);

                                item.SubItems.Add(bet.GamblerId.ToString());
                                item.SubItems.Add(bet.Amount.ToString());
                                item.SubItems.Add(bet.Result);

                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }
    }
}
