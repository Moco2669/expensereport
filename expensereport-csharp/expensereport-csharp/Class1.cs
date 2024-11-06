using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace expensereport_csharp
{
    public class ExpenseReport
    {
        public void PrintReport(List<Expense> expenses)
        {
            int totalExpenses = CalculateExpenses(expenses);
            int mealExpenses = CalculateExpenses(expenses.OfType<MealExpense>().ToList<Expense>());

            Console.WriteLine("Expenses " + DateTime.Now);
            
            foreach (Expense expense in expenses)
            {
                Console.WriteLine(expense.ToString());
            }

            Console.WriteLine("Meal expenses: " + mealExpenses);
            Console.WriteLine("Total expenses: " + totalExpenses);
        }

        private int CalculateExpenses(List<Expense> expenses)
        {
            int totalExpenses = 0;
            foreach (Expense expense in expenses)
            {
                totalExpenses += expense.Amount;
            }
            return totalExpenses;
        }
    }

    public enum ExpenseType
    {
        [Description("Dinner")]
        DINNER,

        [Description("Breakfast")]
        BREAKFAST,

        [Description("Car Rental")]
        CAR_RENTAL
    }
}