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
    public partial class UserHome : Form
    {
        private DatabaseEntities _entity = new DatabaseEntities();

        public UserHome()
        {
            InitializeComponent();
            profileLink.Text = Program.loggedinUser.Name;

            var entries = new ExpenseBL().GetExpensesListByUserId(Program.loggedinUser.Id, _entity);

            GetTodayExpense(entries);
            GenerateCoulmnChat(entries);
            GenerateLineChart(entries);
        }

        private void GetTodayExpense(List<Expense> eList)
        {
            eList = eList.Where(x => Convert.ToDateTime(x.Date).Date == DateTime.Now.Date).ToList();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Date", 100);
            listView1.Columns.Add("Expense", 70);
            listView1.Columns.Add("Note", 120);

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            foreach (var i in eList)
            {
                arr[0] = i.Date.Value.ToString("dd-MM-yyyy");
                arr[1] = i.TotalExpense;
                arr[2] = i.Notes;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }

            arr[0] = "Total";
            arr[1] = eList.Sum(x => Convert.ToInt32(x.TotalExpense)).ToString();
            arr[2] = "PKR/_";
            itm = new ListViewItem(arr);
            itm.BackColor = Color.Pink;
            itm.Font = new Font(itm.Font,itm.Font.Style | FontStyle.Bold);
            listView1.Items.Add(itm);
        }

        private void GenerateCoulmnChat(List<Expense> eList)
        {
            DateTime dt = DateTime.Now.AddDays(-7);
            eList = eList.Where(x=> Convert.ToDateTime(x.Date).Date <= DateTime.Now.Date && Convert.ToDateTime(x.Date).Date >= dt.Date).ToList();
            
            columnChart.Titles.Add("Last 7 Days");

            int i = 0;
            foreach(var e in eList)
            {
                columnChart.Series["Expense"].Points.AddXY(e.Date.Value.ToString("dd-MM-yyyy"), e.TotalExpense);
                columnChart.Series["Expense"].Points[i].ToolTip = "("+e.Date.Value.ToString("dd-MM-yyyy") + ")" + e.Notes;
                i++;
            }
            
            columnChart.Series["Expense"].IsValueShownAsLabel = true; // value will be show as label
        }

        private void GenerateLineChart(List<Expense> eList)
        {
            lineChart.Titles.Add("This month");

            foreach (var e in eList)
            {
                lineChart.Series["Expense"].Points.AddXY(e.Date.Value.ToString("dd-MM-yyyy"), e.TotalExpense);
            }
            
        }

        private void addExpenseLink_Click(object sender, EventArgs e)
        {
            AddExpense obj = new AddExpense("add");
            obj.Show();
        }

        private void viewExpenseLink_Click(object sender, EventArgs e)
        {
            ViewExpense obj = new ViewExpense();
            obj.Show();
        }

        private void updateProfileLink_Click(object sender, EventArgs e)
        {
            Hide();
            ManageUser obj = new ManageUser("updateprofile");
            obj.Show();
        }

        private void logoutLink_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
            if (Program.loggedinUser.IsLoggedin == 1)
            {
                User obj = new UserBL().GetUserById(Program.loggedinUser.Id, _entity);
                obj.IsLoggedin = 0;

                new UserBL().UpdateUser(obj, _entity);
            }

            Close();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
