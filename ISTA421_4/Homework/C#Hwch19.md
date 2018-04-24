ISTA421-4 Homework C# Chapter 19

Rory H Millington

23 April 2018

Readings

Read chapter 19, pages 423 – 438 in the C# Step by Step book.

Discussion Questions

1. What is an enumerable collection?

	The quick answer is that it is a collection that implements the System.Collections.IEnumerable interface.

	Remember that all arrays in C# are actually instances of the System.Array class. The System.Array class is a collection class that implements the IEnumerable interface.



2. What properties and methods does the IEnumerable interface contain?

	The IEnumerable interface contains a single method called GetEnumerator.


3. What properties and methods does the IEnumerator interface contain?

	object Current { get; }
	bool MoveNext();
	void Reset();

4. What values does the MoveNext() method return? What does it do?

	It is important to keep in mind that MoveNext does not actually return data items—that is the purpose of the Current property. All MoveNext does is update the internal state in the enumerator (that is, the value of the currentItem variable is set to the data item extracted from the queue) for use by the Current property, returning true if there is a next value and false otherwise.

	You call the MoveNext method to move the pointer down to the next (first) item in the list; the MoveNext method should return true if there actually is another item and false if there isn’t.

5. What values does the Reset() method return? What does it do?

	The Reset method to return the pointer back to before the first item in the list.


6. Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?

	Current property of the IEnumerator interface exhibits non-type-safe behavior in that it returns an object rather than a specific type.

	However, you should be pleased to know that the Microsoft .NET Framework class library also provides the generic IEnumerator<T> interface, which has a Current property that returns a T instead. 

	Likewise, there is also an IEnumerable<T> interface containing a GetEnumerator method that returns an Enumerator<T> object. 

	Both of these interfaces are defined in the System.Collections.Generic namespace, and if you are building applications for the .NET Framework version 2.0 or later, you should make use of these generic interfaces rather than the nongeneric versions when you define enumerable collections.

7. Why don’t recursive methods retain state when used with data structures like binary trees?

	Recursive algorithms, such as that used when walking a binary tree, do not lend themselves to maintaining state information between method calls in an easily accessible manner. For this reason, you will first preprocess the data in the binary tree into a more amenable data structure (a queue) and actually enumerate this data structure instead. Of course, this deviousness is hidden from the user iterating through the elements of the binary tree!

8. How do you define an enumerator?

	By using the foreach statement.

9. What is an iterator?

	 An iterator is an object that enables a programmer to traverse a container, particularly list

	The code in the GetEnumerator method defines an iterator. The compiler uses this code to generate an implementation of the IEnumerator<T> class containing a Current method and a MoveNext method.


10. What does yield do?

	The yield keyword indicates the value that should be returned by each iteration. If it helps, you can think of the yield statement as calling a temporary halt to the method, passing back a value to the caller. When the caller needs the next value, the GetEnumerator method continues at the point at which it left off, looping around and then yielding the next value. Eventually, the data is exhausted, the loop finishes, and the GetEnumerator method terminates. At this point, the iteration is complete.

 