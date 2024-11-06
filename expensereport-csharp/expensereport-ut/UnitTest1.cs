using expensereport_csharp;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private ExpenseReport _expenseReport;
        private List<Expense> _expenses;

        [SetUp]
        public void Setup()
        {
            _expenseReport = new ExpenseReport();
            _expenses = new List<Expense>();
            _expenses.Add(new CarExpense() { Amount = 500, Type = ExpenseType.CAR_RENTAL });
            _expenses.Add(new CarExpense() { Amount = 500, Type = ExpenseType.CAR_RENTAL });
            _expenses.Add(new CarExpense() { Amount = 500, Type = ExpenseType.CAR_RENTAL });
            _expenses.Add(new MealExpense() { Amount = 9000, Type = ExpenseType.DINNER });
            _expenses.Add(new MealExpense() { Amount = 300, Type=ExpenseType.BREAKFAST });

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}