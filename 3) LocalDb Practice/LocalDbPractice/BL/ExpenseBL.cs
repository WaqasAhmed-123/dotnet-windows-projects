using LocalDbPractice.DAL;
using LocalDbPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDbPractice.BL
{
    public class ExpenseBL
    {
        public List<Expense> GetActiveExpensesList(DatabaseEntities de)
        {
            return new ExpenseDAL().GetExpensesList(de);
        }

        public List<Expense> GetExpensesListByUserId(int id, DatabaseEntities de)
        {
            return new ExpenseDAL().GetExpensesListByUserId(id, de);
        }

        public Expense GetExpenseById(int id, DatabaseEntities de)
        {
            return new ExpenseDAL().GetExpenseById(id, de);
        }

        public bool AddExpense(Expense Expense, DatabaseEntities de)
        {
            if (Expense.Date == null || string.IsNullOrEmpty(Expense.TotalExpense))
            {
                return false;
            }
            else
            {
                return new ExpenseDAL().AddExpense(Expense, de);
            }
        }

        public bool UpdateExpense(Expense Expense, DatabaseEntities de)
        {
            if (Expense.Date == null || string.IsNullOrEmpty(Expense.TotalExpense))
            {
                return false;
            }
            else
            {
                return new ExpenseDAL().UpdateExpense(Expense, de);
            }
        }

        public bool DeactivateExpense(int id, DatabaseEntities de)
        {
            return new ExpenseDAL().DeactivateExpense(id, de);
        }

        public bool DeleteExpense(int id, DatabaseEntities de)
        {
            return new ExpenseDAL().DeleteExpense(id, de);
        }
    }
}
