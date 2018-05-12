ISTA421-4 T-SQL_Chapter 10

Rory H Millington

08 May 2018


1. What is the purpose of transactions? Why do we use transactions in SQL scripts?

	A transaction is a unit of work that might include multiple activities that query and modify data and that can also change the data definition.

	To define transaction boundaries either explicitly or implicitly.

2. Briefly describe each of the ACID properties.

	Atomicity A transaction is an atomic unit of work. Either all changes in the transaction take place or none do.

	Consistency The term consistency refers to the state of the data that the relational database management system (RDBMS) gives you access to as concurrent transactions modify and query it.

	
3. What do we mean when we talk about the granularity of locks?
	
	Lock granularity consists of TABLE, PAGE and ROW locks. If you have a clustered index on the table then instead of a ROW lock you have a KEY lock. Locking on the lower level increases concurrency, but if a lot of locks are taken consumes more memory and vice versa for the higher levels. So granularity simply means the level at which the SQL Server locks data.
	
4. What do we mean when we talk about the modes of locks?
	
	If granted, the exclusive lock is held until the end of the transaction.For single-statement transactions, this means that the lock is held until the statement completes. For multistatement transactions, this means that the lock is held until all statements complete and the transaction is ended

	This lock mode is called “shared” because multiple transactions can hold shared locks on the same data resource simultaneously. Although you cannot change the lock mode and duration required when you’re modifying data, you can control the way locking is handled when you’re reading data by changing your isolation level.

5. In your own words, describe blocking, and give an example.

	Blocking is normal in a system as long as requests are satisfied within a reasonable amount of time. However, if some requests end up waiting too long, you might need to troubleshoot the blocking situation and see whether you can do something to prevent such long latencies.


6. What are the properties of locks? That is, list the column name and column type of the ﬁelds in sys.dm tran locks.

	resource_type

	This tells us what resource in the database the locks are being taken on. It can be one of these values: DATABASE, FILE, OBJECT, PAGE, KEY, EXTENT, RID, APPLICATION, METADATA, HOBT, ALLOCATION_UNIT.
	request_mode

	This tells us the mode of our lock.
	resource_description

	This shows a brief description of the resource. Usually holds the id of the page, object, file, row, etc. It isn't populated for every type of lock
	

7. What are the properties of sessions? That is, list the column name and column type of the ﬁelds in sys.dm exec connections.


8. What are the requests of sessions? That is, list the column name and column type of the ﬁelds in sys.dm exec requests.
	
	Session is a key-based collection; you put a value in with a key, and you retrieve the same value with a key.

9. What is an isolation level? Give an example of the operation of an isolation level.

	SQL Server also supports two transaction isolation levels that use row versioning. One is a new implementation of read committed isolation, and one is a new transaction isolation level, snapshot.

10. (Not in the book.) What do we mean when we say that an object is serializable?

	Serialization (C# ). Serialization is the process of converting an object into a stream of bytes in order to store the object or transmit it to memory, a database, or a file. Its main purpose is to save the state of an object in order to be able to recreate it when needed. The reverse process is called deserialization.


11. What is an deadlock? Give an example of a deadlock?

	A SQL deadlock arises when two or more tasks block one another by both having a lock on a resource which the other tasks are attempting to lock. There are a few different resources that can lead to a SQL Server deadlock such as locks and memory.