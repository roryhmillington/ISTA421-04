Homework ISTA421-4 ASP.Net MVC 5

Rory H Millington

25 Apr 2018

1.What is a Visual Studio Solution? How do you create them?

	A solution is a container for projects, and tracks dependencies between projects

	A solution is like a house, a project like a room. Each room provides a piece of functionality whereas the house, a container of rooms, provides the means to link the rooms together and organize them appropriately.

	On the File menu, click New and then click New Project.  
	
	In the left pane, select Installed, select Other Project Types, and then select Visual Studio Solutions from the expanded list.  
  
	In the middle pane, select Blank Solution.  
  
	Set the Name and Location values for your solution, then click OK. 

2.Why would you use an Empty project instead of a completed template? What are the advantages of an empty project, are there disadvantages with creating a project from a template? 

	Use this project template when you do not require the functionality built into the standard template. 	
	
 
3.What is Nuget? Describe how you use it and why? 

	For .NET (including .NET Core), the Microsoft-supported mechanism for sharing code is NuGet, which defines how packages for .NET are created, hosted, and consumed, and provides the tools for each of those roles.

	Put simply, a NuGet package is a single ZIP file with the .nupkg extension that contains compiled code (DLLs), other files related to that code, and a descriptive manifest that includes information like the package's version number. Developers with code to share create packages and publish them to a public or private host. Package consumers obtain those packages from suitable hosts, add them to their projects, and then call a package's functionality in their project code. NuGet itself then handles all of the intermediate details.

4.Explain what a Reference is, what is it used for? How you would add or remove one? 

	An assembly is a "unit of deployment" for .NET, almost always a .exe or .dll. In C# terms, it's basically a single C# project. It states: "Assemblies are the building blocks of .NET Framework applications; they form the fundamental unit of deployment, version control, reuse, activation scoping, and security permissions.

	 In the Project Designer, click the References tab.
  
	Click the Add button to open the Add Reference dialog box.  

	In the Add Reference dialog box, select the tab indicating the type of component you want to reference.  
  
	Select the components you want to reference, and then click OK. Tip 

5.What is a DI Container? In this book they reference Ninject as the software being used, are there other software products that can be used for DI in Visual Studio? 

	A DI Container is a framework to create dependencies and inject them automatically when required. It automatically creates objects based on request and inject them when required. DI Container helps us to manage dependencies with in the application in a simple and easy way.

	Castle Windsor
	Structure Map
	Spring.Net
	Autofac
	Unity
	Puzzle.NFactory
	S2Container.Net
	PicoContainer.Net
	LinFu
	
	 
6.What is a domain model and how is it used? What is a view model and how is it used? 

	The model, often referred to as a domain model, contains the C# objects (known as domain objects) that make up the universe of the application and the methods that manipulate them. The views and controllers expose the domain to the clients in a consistent manner and a well-designed MVC application starts with a well-designed model, which is then the focal point as controllers and views are added.

	Models, which contain or represent the data that users work with. These can be simple view models, which just represent data being transferred between views and controllers; or they can be domain models, which contain the data in a business domain as well as the operations, transformations, and rules for manipulating that data.


7.What is meant by the term Repository Pattern? How is it used?

	The Repository pattern decouples your ASP.NET MVC application and shields it from changes by creating a boundary between your data access code and the other parts of your application. 

	In MVC, it is important to think of the repository pattern so that if the Model layers needs some breaking changes, then it should have minimum or no maintenance impact on the controller layer. 


 
8.What software development strategy is the term Mock Repository referring to? Why would you create a Mock repository? 

	Now that I have defined an abstract interface, I could implement the persistence mechanism and hook it up to a database, but I want to add some of the other parts of the application first. In order to do this, I am going to create a mock implementation of the IProductRepository interface that will stand in until I return to the topic of data storage.

	Unit Testing 
 
9.Describe the role played by a Controller in this chapter, what is a View as explained in this chapter? 

	Holds the controllers and views; acts as the UI for the SportsStore application.

10.What is a default route and what purpose does it serve? In what way does having readable Urls impact the website? 
 
	In computer networking, the default route is a setting on a computer that defines the packet forwarding rule to use when no specific route can be determined for a given Internet Protocol (IP) destination address. All packets for destinations not established in the routing table are sent via the default route.

	It should come as no surprise that the easier a URL is to read for humans, the better it is for search engines. Accessibility has always been a part of SEO, but never more so than today, when engines can leverage advanced user and usage data signals to determine what people are engaging with vs. not. 

11.What is ORM? Are we employing this technique? If so how? 
 
	An ORM framework presents the tables, columns, and rows of a relational database through regular C# objects. 

	I am using the Entity Framework for a several reasons: it is simple and easy to get it up and working; the integration with LINQ is first rate (and I like using LINQ); and it is good. The earlier releases were a bit hit-and-miss, but the current versions are elegant and feature-rich.

12.How many ways can you add Database support to your solution? Name at least one way. 

	This is an area where you can choose from a wide range of tools and technologies. Not only are there different relational databases available, but you can also work with object repositories, document stores, and some esoteric alternatives. There are other .NET ORM frameworks as well, each of which takes a slightly different approach: variations that may give you a better fit for your projects.

13.What is a context class? Be specific. 

	The Context class is the root class for all managed code responses. It is used to access or create most of the other types of objects found in the Microsoft.EnterpriseManagement.Mom.Runtime namespace, such as alerts, events, and performance data.

14.How are optional parameters used within this chapter, give examples. 

	I have added an optional parameter to the List method. This means that if I call the method without a parameter (List()), my call is treated as though I had supplied the value specified in the parameter definition (List( 1)). The effect is that the action method displays the first page of products when the MVC Framework invokes it without an argument. Within the body of the action method, I get the Product objects, order them by the primary key, skip over the products that occur before the start of the current page, and take the number of products specified by the PageSize field.

15.What do TDD mean? 

	With test-driven development (TDD), you use unit tests to help design your code. This can be an odd concept if you are used to testing after you have finished coding, but there is a lot of sense in this approach. The key concept is a development workflow called red-green-refactor. It works like this: 




16.What method is used in TDD to verify the success or failure of the code? 

	Determine that you need to add a new feature or method to your application. 

	Write the test that will validate the behavior of the new feature when it is written.

	Run the test and get a red light. 

	Write the code that implements the new feature. 

	Run the test again and correct the code until you get a green light.
 
	Refactor the code if required. 

	For example, reorganize the statements, rename the variables, and so on.

	Run the test to confirm that your changes have not changed the behavior of your additions.

17.What are Html Helpers? 

	An HTML Helper is just a method that returns a string. The string can represent any type of content that you want. For example, you can use HTML Helpers to render standard HTML tags like HTML <input> and <img> tags.
 
18.Breakdown this expression: a. @Html.PageLinks(Model.PagingInfo, x => Url.Action("List", new { page = x })) b. What does MvcHtmlString represent? How is it used? 

19.What is Bootstrap? What is it used for?

	Bootstrap is a free and open-source front-end library for designing websites and web applications. It contains HTML- and CSS-based design templates for typography, forms, buttons, navigation and other interface components, as well as optional JavaScript extensions. Unlike many web frameworks, it concerns itself with front-end development only.