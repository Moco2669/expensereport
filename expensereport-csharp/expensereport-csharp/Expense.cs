using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace expensereport_csharp
{
    public abstract class Expense
    {
        public ExpenseType Type;
        public int Amount;
        public string Name
        {
            get
            {
                var type = Type.GetType().GetField(Type.ToString());
                var attribute = Attribute.GetCustomAttribute(type, typeof(ExpenseType)) as DescriptionAttribute;
                return attribute?.Description ?? Type.ToString();
            }
        }
        public override string ToString()
        {
            return Name + "\t" + Amount + "\t";
        }
    }
}
