using System;
using System.Windows.Forms;
using System.Linq;

namespace Seyd
{
    public partial class Form1 : Form
    {
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
            OwnerList.Items.Add(ownerName + ',' +  ownedPortion);
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
            RamLamList.Items.Add(weight.ToString());
        }

        private void AddEveLamb_Click(object sender, EventArgs e)
        {
            var weight = EveLambWeight.Value;
            EveLambWeight.Value = 0;
            EveLambList.Items.Add(weight.ToString());
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            var mountain = GetMountain();
        }

        private Mountain GetMountain()
        {
            var owners = OwnerList.Items.Cast<ListViewItem>().Select(x =>
            {
                var values = x.Text.Split(',');
                return (values[0], decimal.Parse(values[1]));
            }).ToArray();
            
            var eves = EveList.Items.Cast<ListViewItem>().Select(x => decimal.Parse(x.Text)).ToArray();
            var eveLambs = EveLambList.Items.Cast<ListViewItem>().Select(x => decimal.Parse(x.Text)).ToArray();
            var ramLambs = RamLamList.Items.Cast<ListViewItem>().Select(x => decimal.Parse(x.Text)).ToArray();
            return new Mountain(owners, eves, eveLambs, ramLambs);
        }
    }
}
