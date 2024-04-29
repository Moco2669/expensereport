CPPFLAGS:=-MMD
CFLAGS:=-W -Wall -pedantic -Werror -O3

.PHONY: all
all: test

.PHONY: test
test: ExpenseReportTest
	faketime -f '2022-05-20 10:24:09' ./ExpenseReportTest >actual.txt
	diff expected.txt actual.txt

.PHONY: watch
watch:
	if which inotifywait ; then \
	    while true; do \
	        inotifywait $(wildcard *.c *.h); \
	        $(MAKE) test; \
	    done; \
	elif which fswatch ; then \
	    while true; do \
	        fswatch -1 $(wildcard *.c *.h); \
	        $(MAKE) test; \
	    done; \
	fi

ExpenseReportTest: ExpenseReportTest.o ExpenseReport.o Expense.o

.PHONY: clean
clean::
	$(RM) *.[adios] ExpenseReportTest

-include *.d
