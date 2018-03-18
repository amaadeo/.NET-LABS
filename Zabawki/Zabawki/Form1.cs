using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zabawki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toSelectingList.Items.Add(Toys.CAR);
            toSelectingList.Items.Add(Toys.SUBMARINE);
            toSelectingList.Items.Add(Toys.PLANE);
            toSelectingList.Items.Add(Toys.COMPUTER);
            toSelectingList.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Toys toy = (Toys)toSelectingList.SelectedItem;
            
            switch (toy)
            {
                case Toys.CAR:
                    if (nameTextBox.Text != "") 
                    {
                        selectedList.Items.Add(new Car(nameTextBox.Text));

                    } 
                    break;

                case Toys.SUBMARINE:
                    if (nameTextBox.Text != "")
                    {
                        selectedList.Items.Add(new Submarine(nameTextBox.Text));
                    }
                    break;

                case Toys.PLANE:
                    if (nameTextBox.Text != "")
                    {
                        selectedList.Items.Add(new Plane(nameTextBox.Text));
                    }
                    break;

                case Toys.COMPUTER:
                    if (nameTextBox.Text != "")
                    {
                        selectedList.Items.Add(new Computer(nameTextBox.Text));
                    }
                    break;

                default:

                    break;
            }

            nameTextBox.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;
            selectedList.Items.Remove(toy);

        }

        private void selectedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            //CAR
            if (toy is IAccelerate && !(toy is IRise) && !(toy is IDive))
            {
                Car car = toy as Car;
                speedLabel.Text = car.speed.ToString();
                depthLabel.Text = "0";
                altitudeLabel.Text = "0";

                speedTable.Enabled = true;
                depthTable.Enabled = false;
                altitudeTable.Enabled = false;
            }
        
            //SUBMARINE
            else if (toy is IAccelerate && toy is IDive)
            {
                Submarine sub = toy as Submarine;
                
                speedLabel.Text = sub.speed.ToString();
                depthLabel.Text = sub.submersion.ToString();
                altitudeLabel.Text = "0";

                speedTable.Enabled = true;
                depthTable.Enabled = true;
                altitudeTable.Enabled = false;
            }

            //PLANE
            else if (toy is IAccelerate && toy is IRise)
            {
                Plane plane = toy as Plane;

                speedLabel.Text = plane.speed.ToString();
                altitudeLabel.Text = plane.altitude.ToString();
                depthLabel.Text = "0";

                speedTable.Enabled = true;
                depthTable.Enabled = false;
                altitudeTable.Enabled = true;
            }

            else
            {
                speedLabel.Text = "0";
                altitudeLabel.Text = "0";
                depthLabel.Text = "0";
                speedTable.Enabled = false;
                depthTable.Enabled = false;
                altitudeTable.Enabled = false;
            }

            
        }

        /*int FindMyStringInList(ListBox lb, string searchString)
        {
            for (int i = 0; i < lb.Items.Count; ++i)
            {
                string lbString = lb.Items[i].ToString();
                if (lbString.ToString().Equals(searchString))
                    return 1;
            }
            return -1;
        }*/

        private void speedUpButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IAccelerate accelerate = toy as IAccelerate;

            accelerate.Accelerate(accelerate.speed + 1);

            speedLabel.Text = accelerate.speed.ToString();
        }

        private void speedDownButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IAccelerate accelerate = toy as IAccelerate;

            if (accelerate.speed > 0)
            {
                accelerate.Accelerate(accelerate.speed - 1);

                speedLabel.Text = accelerate.speed.ToString();
            }
        }

        private void depthDownButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IDive dive = toy as IDive;

            if (dive.submersion > 0)
            {
                dive.Dive(dive.submersion - 1);

                depthLabel.Text = dive.submersion.ToString();
            }
        }

        private void depthUpButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IDive dive = toy as IDive;

            dive.Dive(dive.submersion + 1);

            depthLabel.Text = dive.submersion.ToString();
        }

        private void altitudeDownButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IRise rise = toy as IRise;

            if (rise.altitude > 0)
            {
                rise.Rise(rise.altitude - 1);

                altitudeLabel.Text = rise.altitude.ToString();
            }

        }

        private void altitudeUpButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IRise rise = toy as IRise;

            rise.Rise(rise.altitude + 1);

            altitudeLabel.Text = rise.altitude.ToString();
        }
    }
}
