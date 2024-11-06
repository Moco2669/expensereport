using System;
using System.Collections.Generic;
using System.Text;

namespace expensereport_csharp
{
    public class MealExpense : Expense
    {
        private bool _mealOverExpenses
        {
            get
            {
                return (Type == ExpenseType.DINNER && Amount > 5000 ||
                        Type == ExpenseType.BREAKFAST && Amount > 1000);
            }
        }

        public override string ToString()
        {
            return base.ToString() + (_mealOverExpenses ? "X" : " ");
        }
    }
}
