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
    public partial class ViewMatchesForm : Form
    {
        public ViewMatchesForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewMatchesForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            listView1.Items.Clear();

            foreach (Match match in Database.Database.Matches)
            {
                ListViewItem item = new ListViewItem(match.Id.ToString());
                item.SubItems.Add(match.TeamA);
                item.SubItems.Add(match.TeamB);
                item.SubItems.Add(match.Date.ToString());
                item.SubItems.Add(match.Winner);
                listView1.Items.Add(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                string team_a = textBox5.Text;
                string team_b = textBox3.Text;
                DateTime date = dateTimePicker2.Value;

                Database.Database.UpdateMatch(id, team_a, team_b, date);
                refresh();
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                textBox5.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
                dateTimePicker2.Value = DateTime.Parse(item.SubItems[3].Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                Database.Database.DeleteMatch(id);
                refresh();
            }
        }
    }
}
