using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShiftManager.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clear all textbox text
            clearTextBoxes();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // create new ProductionWorker object
                ProductionWorker worker = new ProductionWorker();

                // check name text
                checkName();

                // set name
                worker.employeeName = textBoxName.Text;

                // set number
                worker.employeeNumber = int.Parse(textBoxEmployeeNumber.Text);

                // set shift
                worker.shiftNumber = int.Parse(textBoxShiftNumber.Text);

                // check for valid shift
                checkShiftNumber(worker);

                // set hourly rate
                worker.hourlyRate = double.Parse(textBoxHourlyRate.Text);

                // format string
                string workerString = string.Format("Name: " + worker.employeeName + " | ID: " + worker.employeeNumber + " | Shift Number: " + worker.shiftNumber + " | Hourly Rate: " + worker.hourlyRate);

                // add to list box
                listBoxProductionWoker.Items.Add(workerString);

                // clear textboxes 
                clearTextBoxes();
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid input please review and submit again.");
            }
           
        }

        private void checkName()
        {
            // if name textbox is null or blank through exception
            if (textBoxName.Text == null || textBoxName.Text == "")
            {
                throw new Exception();
            }
        }

        private void checkShiftNumber(ProductionWorker worker)
        {
            // if shift number is not 1 or 2 through exception
            if (worker.shiftNumber < 1 || worker.shiftNumber > 2)
            {
                throw new Exception();
            }
        }

        private void clearTextBoxes()
        {
            // clear all textboxes
            textBoxName.Text = "";
            textBoxEmployeeNumber.Text = "";
            textBoxShiftNumber.Text = "";
            textBoxHourlyRate.Text = "";
        }

    }
}
