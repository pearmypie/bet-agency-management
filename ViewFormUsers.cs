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
    public partial class ViewFormUsers : Form
    {
        public ViewFormUsers()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewFormUsers_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var user = (Gambler)listView1.SelectedItems[0].Tag;

            if (user != null)
            {
                textBox1.Text = user.NameOrDescription;
                textBox2.Text = user.CNP;
                dateTimePicker1.Value = user.DOB;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                Database.Database.DeleteUser(id);
                refresh();
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                textBox1.Text = item.SubItems[1].Text;
                textBox2.Text = item.SubItems[2].Text;
                dateTimePicker1.Value = DateTime.Parse(item.SubItems[3].Text);
            }
        }

        private void refresh()
        {
            listView1.Items.Clear();

            foreach (Gambler user in Database.Database.Users)
            {
                ListViewItem item = new ListViewItem(user.Id.ToString());
                item.SubItems.Add(user.NameOrDescription);
                item.SubItems.Add(user.CNP);
                item.SubItems.Add(user.DOB.ToString());
                listView1.Items.Add(item);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int id = Int32.Parse(item.SubItems[0].Text);

                string name = textBox1.Text;
                string cnp = textBox2.Text;
                DateTime dob = dateTimePicker1.Value;

                Database.Database.UpdateUser(id, cnp, name, dob);
                refresh();
            }
        }
    }
}
