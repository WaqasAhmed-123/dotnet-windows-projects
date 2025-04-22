using LocalDbPractice.BL;
using LocalDbPractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDbPractice
{
    public partial class AddExpense : Form
    {
        private DatabaseEntities _entity = new DatabaseEntities();
        private string _way;

        public AddExpense(string way)
        {
            _way = way;
            InitializeComponent();

            if(way == "add")
            {
                groupBox.Text = "New Expense";
                label.Text = "Add your expense here";
                btnSubmit.Text = "Add";
            }
            else if(way == "update")
            {
                groupBox.Text = "Update Expense";
                label.Text = "Update your expense";
                btnSubmit.Text = "Update";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            resMsg.Text = "";
            Loader loaderForm = new Loader();
            loaderForm.Show();
            loaderForm.loaderLabel.Text = "Processing..,";
            Application.DoEvents();

            if (_way == "add")
            {
                User u = Program.loggedinUser; 

                Expense obj = new Expense()
                {
                    UserId = u.Id,
                    Date = txtDate.Value,
                    Notes = txtNotes.Text,
                    TotalExpense = txtExpense.Value.ToString(),
                    IsActive = 1,
                    CreatedAt = DateTime.Now
                };

                if (!new ExpenseBL().AddExpense(obj, _entity))
                {
                    MessageBox.Show("Database insertion failed, please try again.");
                    loaderForm.Close();
                    return;
                }

                loaderForm.Close();
                resMsg.Text = "Expense inserted successfully.";
                txtDate.Value = DateTime.Now;
                txtExpense.Value = 1;
            }
            else
            {
                Expense obj = new ExpenseBL().GetExpenseById(Convert.ToInt32(txtId.Text), _entity);
                obj.Date = txtDate.Value;
                obj.Notes = txtNotes.Text;
                obj.TotalExpense = txtExpense.Value.ToString();

                if (!new ExpenseBL().UpdateExpense(obj, _entity))
                {
                    MessageBox.Show("Database updation failed, please try again.");
                    loaderForm.Close();
                    return;
                }

                loaderForm.Close();
                MessageBox.Show("Expense updated successfully.");
                Close();
            }
        }

        private void txtDate_MouseHover(object sender, EventArgs e)
        {
            resMsg.Text = "";
        }
    }
}
