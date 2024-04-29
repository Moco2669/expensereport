#include "Expense.h"

#include <limits.h>

struct ExpenseType {
    const char *const name;
    const int limit;
    const bool isMeal;
};

const struct ExpenseType
    *const DINNER     = &(const struct ExpenseType) { "Dinner",        5000, true },
    *const BREAKFAST  = &(const struct ExpenseType) { "Breakfast",     1000, true },
    *const CAR_RENTAL = &(const struct ExpenseType) { "Car Rental", INT_MAX, false },
    *const LUNCH      = &(const struct ExpenseType) { "Lunch",         2000, true };

const char *Expense_getName(const struct Expense *expense) {
    return expense->type->name;
}

bool Expense_isOverLimit(const struct Expense *expense) {
    return expense->amount > expense->type->limit;
}

bool Expense_isMeal(const struct Expense *expense) {
    return expense->type->isMeal;
}
