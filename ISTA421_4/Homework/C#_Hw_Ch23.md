ISTA421-4 Chapter 23 C#

Rory H Millington

19 May 2018

1 List two reasons for multitasking, and explain the rationale for them.

	To improve responsiveness
	To improve scalability

	In both of these cases, it does not make sense to have a program burn CPU cycles waiting for the operation to complete when the program could be doing something more useful instead (such as responding to user input).

	 A developer can determine which operations include tasks that can be performed in parallel and arrange for these elements to be run concurrently. As more computing resources are added, more instances of these tasks can be run in parallel.

2 Explain Moore’s law. What does Moore’s law have to do with multitasking?

	Moore’s Law concerning the miniaturization of electronic components still holds, even half a century later. However, physics has started to intervene. A limit occurs when it is not possible to transmit signals between transistors on a single chip any faster, no matter how small or densely packed they are. To a software developer, the most noticeable result of this limitation is that processors have stopped getting faster. Ten years ago, a fast processor ran at 3 GHz. Today, a fast processor still runs at 3 GHz.

3 In UWP, what namespace is used as the container for the multitasking methods?

	Microsoft provides the Task class and a collection of associated types in the System.Threading.Tasks namespace to help address these issues.

4 What is the diﬀerence between tasks and threads? Explain.
	
	WinRT optimizes the number of threads required to implement a set of concurrent tasks and schedules them efficiently according to the number of available processors. It implements a queuing mechanism to distribute the workload across a set of threads allocated to a thread pool (implemented by using a ThreadPool object). When a program creates a Task object, the task is added to a global queue. When a thread becomes available, the task is removed from the global queue and is executed by that thread. .

5 What is the ThreadPool?

	The ThreadPool class implements a number of optimizations and uses a work-stealing algorithm to ensure that threads are scheduled efficiently

6 What parameters does the Task() constructor take?

	You can create Task objects by using the Task constructor. The Task constructor is overloaded, but all versions expect you to provide an Action delegate as a parameter. Task object invokes this delegate when it is scheduled to run.

	The default Action type references a method that takes no parameters. Other overloads of the Task constructor take an Action<object> parameter representing a delegate that refers to a method that takes a single object parameter. With these overloads, you can pass data into the method run by the task.

7 How do you start a thread?

	Internally, the Windows Runtime (WinRT) implements tasks and schedules them for execution by using Thread objects and the ThreadPool class. Multithreading and thread pools have been available with the .NET Framework since version 1.0, and if you are building traditional desktop applications, you can use the Thread class in the System.Threading namespace directly in your code. However, the Thread class is not available for Universal Windows Platform (UWP) apps; instead, you use the Task class.

8 What is the diﬀerence between the Start() and Run() methods?
	
	The Start method is overloaded, and you can optionally specify a TaskCreationOptions object to provide hints about how to schedule and run the task.
 
	The Run method takes an Action delegate specifying the operation to perform (like the Task constructor), but starts the task running immediately. It returns a reference to the Task object.
 


9 What is the diﬀerence between creating independent tasks with Tasks and paralleliztion with Parallel? Explain.

	The purpose of the Parallel class is to parallelize CPU-bound, independent areas of your code. If you are not running CPU-bound code, parallelizing it might not improve performance.

10 Explain how manual cancellation works using a cancellation token.

	Cooperative cancellation is based on the notion of a cancellation token. A cancellation token is a structure that represents a request to cancel one or more tasks. The method that a task runs should include a System.Threading.CancellationToken parameter. An application that wants to cancel the task sets the Boolean IsCancellationRequested property of this parameter to true. The method running in the task can query this property at various points during its processing. If this property is set to true at any point, it knows that the application has requested that the task be canceled. Also, the method knows what work it has done so far, so it can undo any changes if necessary and then finish.
