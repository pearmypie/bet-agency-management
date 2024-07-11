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
    public partial class ViewFormTeams : Form
    {
        public ViewFormTeams()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewFormTeams_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
           listView1.Items.Clear();

            foreach (Team team in Database.Database.Teams)
            {
                ListViewItem item = new ListViewItem(team.Id.ToString());
                item.SubItems.Add(team.NameOrDescription);
                item.SubItems.Add(team.Country);
                listView1.Items.Add(item);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                textBox4.Text = item.SubItems[1].Text;
                comboBox1.Text = item.SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                string name = textBox4.Text;
                string country = comboBox1.Text;

                Database.Database.UpdateTeam(id, country, name);
                refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                Database.Database.DeleteTeam(id);
                refresh();
            }
        }
    }
}
