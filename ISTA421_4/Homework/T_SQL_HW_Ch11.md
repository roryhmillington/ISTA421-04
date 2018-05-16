ISTA420T-Sql Chapter 11

Rory Millington

14 May 2018

1. Why do we use variables in T-SQL? HOw do you declare and initialize T-SQL variables?]

	To temporarily store data values for later use in the same batch in which they were declared. Use a DECLARE statement to declare one or more variables, and use a SET statement to assign a value to a single variable.

2. Describe what is meant by a batch ﬁle in T-SQL? What is the diﬀerence between batches and transactions?

	A batch is one or more T-SQL statements sent by a client application to SQL Server for execution as a single unit. The batch undergoes parsing (syntax checking), resolution/binding (checking the existence of referenced objects and columns, permissions checking), and optimization as a unit.

	Don’t confuse transactions and batches. A transaction is an atomic unit of work. A batch can have multiple transactions, and a transaction can be submitted in parts as multiple batches. When a transaction is canceled or rolled back, SQL Server undoes the partial activity that has taken place since the beginning of the transaction, regardless of where the batch began.


3. What is the scope of variables with respect to T-SQL batches?

	A variable is local to the batch in which it’s defined. If you refer to a variable that was defined in another batch, you’ll get an error saying that the variable was not defined. For example, the following code declares a variable and prints its content in one batch, and then it tries to print its content from another batch:

4. Write a T-SQL code snippet that returns a data element stating whether the current person can legally purchase alcohol, that is, has reached his 21st birthday.

	Declare@i AS INT;
	Set @i=age
	From current person
	Where i>=21

5. (Not in book) Does T-SQL have a for loop construction?

	In SQL Server, there is no FOR LOOP. However, you simulate the FOR LOOP using the WHILE LOOP.

6. What is a cursor? What is the diﬀerence between a relation and a cursor?

	SQL and T-SQL also supports an object called cursor you can use to process rows from a result of a query one at a time and in a requested order.This is in contrast to using set-based queries—normal queries without a cursor for which you manipulate the set or multiset as a whole and cannot rely on order.

	First and foremost, when you use cursors you pretty much go against the relational model, which is based on set theory.

	Given a set-based query and cursor code that do similar physical processing behind the scenes, the cursor code is usually many times slower than the set-based code.

	With cursors, you write imperative solutions—in other words, you’re responsible for defining how to process the data (declaring the cursor, opening it, looping through the cursor records, closing the cursor, and deallocating the cursor). With set-based solutions, you write declarative code where you mainly focus on the logical aspects of the solution—in other words, on what to get instead of on how to get it.

 
7. How do you declare a temporary table? Why would you declare a temporary table?

	You create a local temporary table by naming it with a single pound sign as a prefix, such as #T1. All three kinds of temporary tables are created in the tempdb database.

8. What is the diﬀerence between a stored procedure, a user deﬁned function, and a trigger?

	If you want a global temporary table to be created every time SQL Server starts, and you don’t want SQL Server to try to destroy it automatically, you need to create the table from a stored procedure that is marked as a startup procedure.
 

9. Write a user deﬁned function that returns a Booleans as to whether a customer may purchase alcohol as of the instant that the function runs.


10. Write a trigger that places a customer in the OFF LIMITS table if he attempt to purchase alcohol when he is underage.

	Its an event. 

11. Write a stored procedure that deletes customers from the OFF LIMITS table when they have reached their 21st birthday.
