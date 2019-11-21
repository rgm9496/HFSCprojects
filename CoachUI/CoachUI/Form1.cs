using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachUI
{
    public partial class Form1 : Form
    {
        public Coach myCoach = new Coach(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(nameTextBox.Text, Convert.ToInt32(ageTextBox.Text));
            int seat = myCoach.AddPerson(p1);
            seatTextBox.Text = seat + "";
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            string getSeatByName = nameTextBox.Text;
            seatTextBox.Text = getSeatByName;
          
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            seatTextBox.Text = "";
        }
    }
}
