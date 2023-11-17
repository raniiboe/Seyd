using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Seyd
{
    public partial class Form1 : Form
    {
        private List<(string, decimal)> owners = new List<(string, decimal)> ();
        private List<decimal> ramLam = new List<decimal> ();
        private List<decimal> eveLam = new List<decimal> ();
        private List<decimal> eve = new List<decimal> ();
        private List<decimal> sheep = new List<decimal> ();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            deleteSelectedFromListView(EveLambList);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var ownedPortion = OwnedPortion.Value;
            OwnedPortion.Value = 0;
            var ownerName = OwnerName.Text;
            OwnerName.Text = "";
            owners.Add((ownerName, ownedPortion));            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deleteSelectedFromListView(OwnerList);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void OwnerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveRamLam_Click(object sender, EventArgs e)
        {
            deleteSelectedFromListView(RamLamList); 
        }

        private void RemoveEve_Click(object sender, EventArgs e)
        {
            deleteSelectedFromListView(EveList);
        }

        private void deleteSelectedFromListView(ListView listView)
        {
            foreach (ListViewItem item in listView.Items)
            {
                OwnerList.Items.Remove(item);
            }
        }
    }
}
