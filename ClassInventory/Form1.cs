using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // TODO - create a List to store all inventory objects
        List<Player> players = new List<Player>();
        private Player y;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // TODO - gather all information from screen 
            string name = c.Text;
            int age = Convert.ToInt32(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;

            Player newPlayer = new Player(name, age, team, position);
            // TODO - create object with gathered information
            players.Add(newPlayer);
            // TODO - add object to global list
            label1.Text = "New Player Added";
            // TODO - display message to indicate addition made
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            
            // TODO - if object is in list remove it
            int index = players.FindIndex(y => y.name == removeInput.Text);

            if (index >= 0)

            {

                players.RemoveAt(index);

            }
            else
            {
                label1.Text = " ";
                label1.Text = "The player " + removeInput.Text + " does not exist";
            }

            // TODO - display message to indicate deletion made
            label1.Text = "";
            label1.Text = "You have removed " + removeInput.Text;
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------
            Player teammate = players.Find(y => y.name == textBox1.Text);

            // TODO - if object entered exists in list show it
            label1.Text = "";
            for (int i =0; i < players.Count(); i++)
            {
                if (teammate == players[i])
                {
                    label1.Text += teammate + "\n";
                    break;
                }
                else
                {
                    label1.Text = "The player " + textBox1.Text + " does not exist";
                }
            }
            
            // TODO - else show not found message
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions.
            //---------------------------

            // TODO - show all objects in list
            label1.Text = "";

            foreach (Player p in players)
            {
                label1.Text += p.name + ", " + p.age + ", " + p.team + ", " + p.position + "\n";
            }
        }
    }
}
