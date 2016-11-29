Comparison Chain in C#
POC for sorting by multiple properties of a class
Using builder pattern to generate a sorted list
the builder pattern can set up to 3 sort options and generated a sorted list when calling getsortedlist


When setting sort options, the system use a factory pattern to return sort option instance
sort option instance has 2 methods 
	Preseort: allow adding extra logic, add, update the list before the sort operation.
	GetComparer: returns the sort option comparer that has the sort option compare logic
 