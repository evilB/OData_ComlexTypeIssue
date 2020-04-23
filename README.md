# OData_ComlexTypeIssue
Demonstration of complextype odata issue

I've created a github repository with the simplest possible reproduction, a asp.net webapi with two classes TestModel & LocalizedString. An index.html page loads the jasmine tests and executes them.
````
    public class TestModel
    {
        [Key]
        public int Id { get; set; }

        public LocalizedString Description { get; set; }
    }

    [ComplexType]
    public class LocalizedString
    {
        public  string Fr { get; set; }
        public  string En { get; set; }
        public  string De { get; set; }
        public  string Nl { get; set; }
    }
````
- clone project on master branch to see it succeed, clone project on 7.6.4 branch to see it fail, 
- restore nuget packages and 
- execute update-database to initialise the database
- Start the project. The index.html page loads jasmine tests (you may need to reload the page if application startup takes too long).

- to see the results on of 7.5.4 check out the master branch
