using LocalDbPractice.Models;
using System.Collections.Generic;
using System.Linq;

namespace LocalDbPractice.DAL
{
    public class ExpenseDAL
    {
        public List<Expense> GetExpensesList(DatabaseEntities de)
        {
            return de.Expenses.Where(x => x.IsActive == 1).ToList();
        }
        
        public List<Expense> GetExpensesListByUserId(int id, DatabaseEntities de)
        {
            return de.Expenses.Where(x => x.IsActive == 1 && x.UserId == id).ToList();
        }

        public Expense GetExpenseById(int id, DatabaseEntities de)
        {
            return de.Expenses.Where(x => x.Id == id).FirstOrDefault(x => x.IsActive == 1);
        }

        public bool AddExpense(Expense Expense, DatabaseEntities de)
        {
            try
            {
                de.Expenses.Add(Expense);
                de.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateExpense(Expense Expense, DatabaseEntities de)
        {
            try
            {
                de.Entry(Expense).State = System.Data.Entity.EntityState.Modified;
                de.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeactivateExpense(int id, DatabaseEntities de)
        {
            try
            {
                Expense u = GetExpenseById(id, de);
                u.IsActive = 0;

                return UpdateExpense(u, de);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteExpense(int id, DatabaseEntities de)
        {
            try
            {
                de.Expenses.Remove(de.Expenses.Where(x => x.Id == id).FirstOrDefault());
                de.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
