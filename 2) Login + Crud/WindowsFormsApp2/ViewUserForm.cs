using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class ViewUserForm : Form
    {
        private DatabaseEntities _entity = new DatabaseEntities();
        private int pageNumber = 1, pageSize = 10, totalCount = 0, filteredCount = 0;
        private string sortOrder = "Asc", sortColumnName = "", searchKey = "";
        
        private User loggedinUser = Program.loggedinUser;

        public ViewUserForm()
        {
            InitializeComponent();
            rows.SelectedIndex = 0;

            LoadData();
        }

        private void LoadData()
        {
            userDataGrid.Columns.Clear();

            List<User> uList = _entity.Users.Where(x=> x.IsActive == 1 && x.Id != loggedinUser.Id).ToList();

            totalCount = uList.Count;
            if (!string.IsNullOrEmpty(sortColumnName))
            {
                if (sortOrder == "Asc")
                {
                    sortOrder = "Desc";
                    uList = uList.OrderBy(x => x.GetType().GetProperty(sortColumnName).GetValue(x)).ToList();
                }
                else if (sortOrder == "Desc")
                {
                    sortOrder = "Asc";
                    uList = uList.OrderByDescending(x => x.GetType().GetProperty(sortColumnName).GetValue(x)).ToList();
                }
            }


            if (!string.IsNullOrEmpty(searchKey))
            {
                uList = uList.Where(x=> x.Name.ToLower().Contains(searchKey.ToLower()) ||
                        x.Email.ToLower().Contains(searchKey.ToLower()) ||
                        x.Contact.ToLower().Contains(searchKey.ToLower()) ||
                        x.Address.ToLower().Contains(searchKey.ToLower()) ||
                        x.Gender.ToLower().Contains(searchKey.ToLower()) ).ToList();
            }

            
            if (pageSize != -1)
            {
                uList = uList.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            }

            filteredCount = uList.Count;

            List<UserDto> dtoList = new List<UserDto>();
            foreach (User u in uList)
            {
                UserDto obj = new UserDto()
                {
                    Id = u.Id,
                    Name = u.Name,
                    Contact = u.Contact,
                    Email = u.Email,
                    Address = u.Address,
                    Gender = u.Gender,
                    Role = u.Role == 1 ? "Admin" : u.Role == 2 ? "Manager" : "Employee",
                };

                dtoList.Add(obj);
            }

            userDataGrid.DataSource = dtoList;
            userDataGrid.ReadOnly = true;
            userDataGrid.Columns[0].Visible = false;
            userDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //set column width dynamic

            pageNo.Text = pageNumber.ToString();
            rowCount.Text = filteredCount + " out of " + totalCount;

            #region working code
            //inserting link
            //DataGridViewLinkColumn dgvLink = new DataGridViewLinkColumn();
            //dgvLink.UseColumnTextForLinkValue = true;
            //dgvLink.LinkBehavior = LinkBehavior.SystemDefault;
            //dgvLink.HeaderText = "Link Data";
            //dgvLink.Name = "SiteName";
            //dgvLink.LinkColor = Color.Blue;
            //dgvLink.TrackVisitedState = true;
            //dgvLink.Text = "http://www.c-sharpcorner.com";
            //dgvLink.UseColumnTextForLinkValue = true;
            //userDataGrid.Columns.Add(dgvLink);

            //inserting Edit button
            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //btn.HeaderText = "";
            //btn.Text = "Edit";
            //btn.Name = "btnEdit";
            //btn.FlatStyle = FlatStyle.System;
            //btn.InheritedStyle.BackColor = Color.LightGreen;
            //btn.UseColumnTextForButtonValue = true;
            //userDataGrid.Columns.Add(btn);


            //inserting delete button
            //DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            //btn2.HeaderText = "";
            //btn2.Text = "Delete";
            //btn2.Name = "btnDelete";
            //btn2.FlatStyle = FlatStyle.System;
            //btn2.InheritedStyle.BackColor = Color.OrangeRed;
            //btn2.UseColumnTextForButtonValue = true;
            //userDataGrid.Columns.Add(btn2);

            //setting event click listeners
            //userDataGrid.CellClick +=
            //new DataGridViewCellEventHandler(userDataGrid_CellClick);
            #endregion
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (userDataGrid.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete selected user from record.", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in userDataGrid.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells[0].Value);
                        DeleteUser(id);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select some rows to delete.");
            }
        }

        private void DeleteUser(int id)
        {
            User user = _entity.Users.FirstOrDefault(x => x.Id == id);
            user.IsActive = 0;
            _entity.Entry(user).State = System.Data.Entity.EntityState.Modified;
            _entity.SaveChanges();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (userDataGrid.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(userDataGrid.SelectedRows[0].Cells[0].Value);
                User u = _entity.Users.FirstOrDefault(x => x.IsActive == 1 && x.Id == id);
                if(u == null)
                {
                    MessageBox.Show("No record found.");
                }
                AddUserForm addUserForm = new AddUserForm(u, 2);
                addUserForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(null, 3);
            addUserForm.Show();
            this.Hide();
        }

        //sorting table from table header
        private void userDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                switch (e.ColumnIndex)
                {
                    case 1:
                        sortColumnName = "Name";
                        break;
                    case 2:
                        sortColumnName = "Contact";
                        break;
                    case 3:
                        sortColumnName = "Email";
                        break;
                    case 4:
                        sortColumnName = "Address";
                        break;
                    case 5:
                        sortColumnName = "Gender";
                        break;
                    case 6:
                        sortColumnName = "Role";
                        break;
                }

                LoadData();
            }
        }
                
        private void btnUpload_Click(object sender, EventArgs e)
        {
            int count = 0;
            int successCount = 0;

            string[] read;
            char[] seperators = { ',' };

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.csv"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                string path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    string data = reader.ReadLine();
                    while ((data = reader.ReadLine()) != null)
                    {
                        read = data.Split(seperators, StringSplitOptions.None);
                        User obj = new User()
                        {
                            Name = read[0],
                            Contact= read[1],
                            Email= read[2],
                            Address= read[3],
                            Gender= read[4],
                            Password= read[5],
                            Role = 3,
                            Terms = 1,
                            IsActive = 1,
                            CreatedAt = DateTime.Now
                        };

                        if (read[6].ToLower() == "admin")
                        {
                            obj.Role = 1;
                        }
                        else if(read[6].ToLower() == "manager")
                        {
                            obj.Role = 2;
                        }

                        if(!string.IsNullOrEmpty(obj.Name) && !string.IsNullOrEmpty(obj.Email) &&
                            !string.IsNullOrEmpty(obj.Gender) && !string.IsNullOrEmpty(obj.Password))
                        {
                            _entity.Users.Add(obj);
                            _entity.SaveChanges();

                            successCount++;
                        }

                        count++;
                    }
                }
                LoadData();
                MessageBox.Show(successCount + " rows uploaded successfully out of " + count);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<User> uList = _entity.Users.Where(x => x.IsActive == 1 && x.IsLoggedIn != 1).ToList();

            string csv = string.Empty;
            csv = "Name,Contact,Email,Address,Gender,Password,Role\r\n";
            foreach(User u in uList)
            {
                string Role = u.Role == 1 ? "Admin" : u.Role == 2 ? "Manager" : "Employee";
                csv += u.Name + "," + u.Contact + "," + u.Email + "," + u.Address +
                    "," + u.Gender + "," + u.Password + "," + Role + "\r\n";
            }
            //int c1 = 0;
            //foreach (DataGridViewColumn column in userDataGrid.Columns)
            //{
            //    if(c1 > 0)
            //        csv += column.HeaderText + ',';
                
            //    c1++;
            //}

            //csv += "\r\n";

            //foreach (DataGridViewRow row in userDataGrid.Rows)
            //{
            //    c1 = 0;
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        if (c1 > 0)
            //            csv += cell.Value.ToString().Replace(",", ";") + ',';

            //        c1++;
            //    }

            //    csv += "\r\n";
            //}

            string folderPath = "D:\\CSV\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            folderPath += "User_Record_" + DateTime.Now.Ticks + ".csv";

            File.WriteAllText(folderPath, csv);

            MessageBox.Show("File saved at " + folderPath);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int maxPageNumber = (int)Math.Ceiling((float)totalCount / (float)filteredCount);
            if (pageNumber < maxPageNumber && filteredCount == pageSize)
            {
                pageNumber = pageNumber + 1;
                LoadData();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber = pageNumber - 1;

                LoadData();
            }
        }

        //handle page size
        private void rows_SelectedIndexChanged(object sender, EventArgs e)
        {
            pageNumber = 1;
            string opt = rows.Text;
            if(opt == "All")
            {
                pageSize = -1;
            }
            else
            {
                pageSize = Convert.ToInt16(opt);
            }

            LoadData();
        }

        //handle search filter
        private void search_TextChanged(object sender, EventArgs e)
        {
            searchKey = search.Text.Trim();
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            pageSize = 10;
            sortOrder = "Asc";
            sortColumnName = "";
            searchKey = "";

            rows.SelectedIndex = 0;
            search.Text = "";

            LoadData();
        }


        //private void userDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    MessageBox.Show(userDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
        //}
    }
}
