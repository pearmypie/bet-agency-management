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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewFormUsers().Show();
        }

        private void teamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewFormTeams().Show();
        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewMatchesForm().Show();
        }

        private void betsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ViewBetsForm().Show();
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {
            DateTime treshholdDate = DateTime.Now.AddYears(-18);

            string cnp = userCNPTB.Text;
            string name = userNameTB.Text;
            DateTime dob = userDOBDP.Value;

            if (cnp.Length != 13)
            {
                MessageBox.Show("CNP must have 13 characters!");
                return;
            }

            if (name.Length == 0)
            {
                MessageBox.Show("Name must not be empty!");
                return;
            }

            if (dob > treshholdDate)
            {
                MessageBox.Show("User must be at least 18 years old!");
                return;
            }

            Database.Database.InsertGambler(cnp, name, dob);
        }

        private void registerTeamButton_Click(object sender, EventArgs e)
        {
            string name = teamNameTB.Text;
            string country = countryComboBox.Text;

            if (name.Length == 0)
            {
                MessageBox.Show("Name must not be empty!");
                return;
            }

            if (country.Length == 0)
            {
                MessageBox.Show("Country must not be empty!");
                return;
            }

            Database.Database.InsertTeam(country, name);
        }

        private void registerMatchButton_Click(object sender, EventArgs e)
        {
            string team_a = teamA_CB.Text;
            string team_b = teamB_CB.Text;
            DateTime date = matchDateDP.Value;

            if (team_a.Length == 0)
            {
                MessageBox.Show("Team A must not be empty!");
                return;
            }

            if (team_b.Length == 0)
            {
                MessageBox.Show("Team B must not be empty!");
                return;
            }

            if (team_a == team_b)
            {
                MessageBox.Show("Teams must be different!");
                return;
            }

            Database.Database.InsertMatch(team_a, team_b, date);
        }

        private void placeBetButton_Click(object sender, EventArgs e)
        {
            int match_id = Int32.Parse(matchComboBox.Text.Split(':')[0]);
            int user_id = Int32.Parse(userID_CB.Text.Split(':')[0]);
            double amount = Double.Parse(amountNumericUD.Text);

            Database.Database.InsertBet(user_id, match_id, amount);
        }

        private void refresh()
        {
            Database.Database.LoadDatabase();

            teamA_CB.Items.Clear();
            teamB_CB.Items.Clear();

            foreach (var team in Database.Database.Teams)
            {
                teamA_CB.Items.Add(team.NameOrDescription);
                teamB_CB.Items.Add(team.NameOrDescription);
            }

            matchComboBox.Items.Clear();

            foreach (var match in Database.Database.Matches)
            {
                matchComboBox.Items.Add(match.Id + ": " + match.TeamA + " vs. " + match.TeamB);
            }

            userID_CB.Items.Clear();

            foreach (var user in Database.Database.Users)
            {
                userID_CB.Items.Add(user.Id + ": " + user.NameOrDescription);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void showBetsForUserByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BetQuery().Show();
        }
    }
}
