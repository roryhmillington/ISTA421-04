ISTA421-04 c# Homework Chapter 20

Rory H Millington

27 Apr 2018

Discussion Questions

1. What is a delegate? Explain delegates in terms of pointers and reference types.

	A delegate is a form of type-safe function pointer used by the Common Language Infrastructure (CLI). Delegates specify a method to call and optionally an object to call the method on. Delegates are used, among other things, to implement callbacks and event listeners. A delegate object encapsulates a reference to a method.

2. How do you declare a delegate? Include a discussion of types, return values, names, and parameters.

	A delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. You can invoke (or call) the method through the delegate instance. 

	Delegates are used to pass methods as arguments to other methods. Event handlers are nothing more than methods that are invoked through delegates.


3. How do you create instances of delegates and assign values to the instance? What are the values?

	A delegate is a type that safely encapsulates a method, similar to a function pointer in C and C++. Unlike C function pointers, delegates are object-oriented, type safe, and secure. The type of a delegate is defined by the name of the delegate

4. How do you invoke a method that has been added to a delegate?

	A delegate object is normally constructed by providing the name of the method the delegate will wrap, or with an anonymous Method. Once a delegate is instantiated, a method call made to the delegate will be passed by the delegate to that method. The parameters passed to the delegate by the caller are passed to the method, and the return value, if any, from the method is returned to the caller by the delegate. This is known as invoking the delegate. An instantiated delegate can be invoked as if it were the wrapped method itself. 

	// Create a method for a delegate.
	public static void DelegateMethod(string message)
	{
	    System.Console.WriteLine(message);
	}
	C#
	Copy
	// Instantiate the delegate.
	Del handler = DelegateMethod;
	
	// Call the delegate.
	handler("Hello World");
	

5. What is an event? Why do we have events?

	Events enable a class or object to notify other classes or objects when something of interest occurs. The class that sends (or raises) the event is called the publisher and the classes that receive (or handle) the event are called subscribers. 


6. How do you declare events?

	An event is declared like a delegate type variable, except that the keyword event precedes the event declaration.

	In a typical C# Windows Forms or Web application, you subscribe to events raised by controls such as buttons and list boxes. You can use the Visual C# integrated development environment (IDE) to browse the events that a control publishes and select the ones that you want to handle. The IDE automatically adds an empty event handler method and the code to subscribe to the event. 


7. How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?

	Define an event handler method whose signature matches the delegate signature for the event.

	Use the addition assignment operator (+=) to attach your event handler to the event.

	Note that the previous syntax is new in C# 2.0. It is exactly equivalent to the C# 1.0 syntax in which the encapsulating delegate must be explicitly created by using the new keyword: 

	An event handler can also be added by using a lambda expression: 

	If you will not have to unsubscribe to an event later, you can use the addition assignment operator (+=) to attach an anonymous method to the event. 

	To prevent your event handler from being invoked when the event is raised, unsubscribe from the event. In order to prevent resource leaks, you should unsubscribe from events before you dispose of a subscriber object. Until you unsubscribe from an event, the multicast delegate that underlies the event in the publishing object has a reference to the delegate that encapsulates the subscriber's event handler. As long as the publishing object holds that reference, garbage collection will not delete your subscriber object. 

	Use the subtraction assignment operator (-=) to unsubscribe from an event: 
8. How do you raise an event? How do you declare code that raises an event?

	public class Foo
{
  public event EventHandler FooEvent = new EventHandler((e, a) => { });
  public Foo()
  {
    
  }      
  public void Execute()
  {
    //Do the work
    FooEvent(this, new EventArgs());
    //Continue the work
  }
}  

public static class EventHelper
{
  public static void Raise(this EventHandler eventHandler, object sender,EventArgs args)
  {
    if (eventHandler == null)
      return;
    eventHandler(sender, args);
  }
}

public class Foo
{
  public event EventHandler FooEvent;
  public Foo()
  {
    
  }      
  public void Execute()
  {
    //Do the work
    FooEvent.Raise(this, new EventArgs());
    //Continue the work
  }
}

9. Explain with specificity what happens when an event fire's and that event has been attached to a delegate.

	The delegate defines the parameters sent to the event handlers. Thus any class that wants to handle this event must have a handler method which has the same return type and argument list as this delegate
