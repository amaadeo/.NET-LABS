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

            speedLabel.Text = "0";
            depthLabel.Text = "0";
            altitudeLabel.Text = "0";

            speedTable.Enabled = false;
            depthTable.Enabled = false;
            altitudeTable.Enabled = false;

            if (toy is IAccelerate)
            {
                IAccelerate accelerate = toy as IAccelerate;
                speedLabel.Text = accelerate.Speed.ToString();
                speedTable.Enabled = true;
            }

            if (toy is IDive)
            {
                IDive dive = toy as IDive;
                depthTable.Text = dive.Submersion.ToString();
                depthTable.Enabled = true;
            }

            if (toy is IRise)
            {
                IRise rise = toy as IRise;
                altitudeTable.Text = rise.Altitude.ToString();
                altitudeTable.Enabled = true;
            }
        }

        private void speedUpButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IAccelerate accelerate = toy as IAccelerate;

            accelerate.Accelerate(accelerate.Speed + 1);

            speedLabel.Text = accelerate.Speed.ToString();
        }

        private void speedDownButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IAccelerate accelerate = toy as IAccelerate;

            if (accelerate.Speed > 0)
            {
                accelerate.Accelerate(accelerate.Speed - 1);

                speedLabel.Text = accelerate.Speed.ToString();
            }
        }

        private void depthDownButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IDive dive = toy as IDive;

            if (dive.Submersion > 0)
            {
                dive.Dive(dive.Submersion - 1);

                depthLabel.Text = dive.Submersion.ToString();
            }
        }

        private void depthUpButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IDive dive = toy as IDive;

            dive.Dive(dive.Submersion + 1);

            depthLabel.Text = dive.Submersion.ToString();
        }

        private void altitudeDownButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IRise rise = toy as IRise;

            if (rise.Altitude > 0)
            {
                rise.Rise(rise.Altitude - 1);

                altitudeLabel.Text = rise.Altitude.ToString();
            }

        }

        private void altitudeUpButton_Click(object sender, EventArgs e)
        {
            object toy = selectedList.SelectedItem;

            IRise rise = toy as IRise;

            rise.Rise(rise.Altitude + 1);

            altitudeLabel.Text = rise.Altitude.ToString();
        }
    }
}
