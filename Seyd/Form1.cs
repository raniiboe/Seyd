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

        private void button1_Click(object sender, EventArgs e)
        {
            var weight = EveWeight.Value;
            EveWeight.Value = 0;
            EveList.Items.Add(weight.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deleteSelectedFromListView(EveLambList);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var ownedPortion = OwnedPortion.Value;
            OwnedPortion.Value = 0;
            var ownerName = OwnerName.Text;
            OwnerName.Text = "";
            OwnerList.Items.Add(ownerName + ", " +  ownedPortion);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deleteSelectedFromListView(OwnerList);
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
            foreach (ListViewItem item in listView.SelectedItems)
            {
                listView.Items.Remove(item);
            }
        }

        private void AddRamLam_Click(object sender, EventArgs e)
        {
            var weight = RamLamWeight.Value;
            RamLamWeight.Value = 0;
            ramLam.Add(weight);
            RamLamList.Items.Add(weight.ToString());
        }

        private void AddEveLamb_Click(object sender, EventArgs e)
        {
            var weight = EveLambWeight.Value;
            EveLambWeight.Value = 0;
            eveLam.Add(weight);
            EveLambList.Items.Add(weight.ToString());
        }
    }
}
