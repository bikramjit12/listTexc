using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listTexc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFruitList_Click(object sender, EventArgs e)
        {
            List<string> FruitList = new List <string>();
            FruitList.Add("orange");
            FruitList.Add("apple");
            FruitList.Add("banana");
            FruitList.Sort();
            //sort Alphabetically
            btnFruitList.Text = Convert.ToString(FruitList.Count);
            //count how many fruit and show on the button
            //This loops through each of the fruit and shows them in the list. It is the most common way to iterate through a list.
            foreach (string fruit in FruitList)
            //Loop through List with foreach
            {
                lblFruitList.Items.Add("Foreach" + fruit);
            }
            for (int i = 0; i < FruitList.Count; i++)
            {
                lblFruitList.Items.Add("For" + FruitList[i]);
            }
        }
    }
}
