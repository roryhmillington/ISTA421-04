ISTA421-4 HomeWork Chapter 21

Rory H Millington

05 May 2018


1. What is the diﬀerence in the purposes of SQL and LINQ? \In other words, why do we need two diﬀerent query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?

	LINQ provides syntax and semantics very reminiscent of SQL and with many of the same advantages. You can change the underlying structure of the data being queried without needing to change the code that actually performs the queries. You should be aware that although LINQ looks similar to SQL, it is far more flexible and can handle a wider variety of logical data structures. For example, LINQ can handle data organized hierarchically, such as that found in an XML document. However, this chapter concentrates on using LINQ in a relational manner.

2. What is the one essential requirement for the datastructures used with LNQ? Why is this requirement important?

	LINQ requires the data to be stored in a data structure that implements the IEnumerable or IEnumerable<T> interface, as described in Chapter 19, “Enumerating collections.” It does not matter what structure you use (an array, a HashSet<T>, a Queue<T>, or any of the other collection types, or even one that you define yourself) as long as it is enumerable.

3. Were does the LINQ Select() method live?

	The Select method does not actually retrieve the data at this time; it simply returns an enumerable object that will fetch the data identified by the Select method when you iterate over it later.

4. (Select) Explain, token by token, each token in this line of code:
IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);

	Interface creating a string object. Variable name. Object, dot assigns, select is the method. 

5. (Filter) Explain, token by token, each token in this line of code:
IEnumerable<string> usCompanies = addresses.Where(addr => String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);

	Declaring Us companies of a type IEnum, assigning a type. Parameter passed in is returning addr, 

6. (OrderBy) Explain, token by token, each token in this line of code:
IEnumerable<string> companyNames = addresses.OrderBy(addr => addr.CompanyName).Select(comp => comp.CompanyName);

	

7. (Group) Explain, token by token, each token in this line of code:
var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);

	Iterated thru addr country, lambda, list entire record by assigned country. 

8. (Distinct) Explain, token by token, each token in this line of code:
int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();

data type, variable name, data structure, addr each record from country, using distinct method, no duplicates. count of unique countries. 

9. (Join) Explain, token by token, each token in this line of code:

var companiesAndCustomers = customers.Select(c => new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs => custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) => new {custs.FirstName, custs.LastName, addrs.Country });

	type varible, name, assign, data structure, select method, c is every value intern, new ennomious oblect consisting of first name, last name, company name, join customers and address files, customer name. 3 objects list of names of what country they reside. 


10. Explain the diﬀerence between a deferred collection and a staticn, cached collection.

	cached returned all at once. 