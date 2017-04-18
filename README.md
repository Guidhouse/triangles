# Triangles.Service
Trying out Triangles.Service on dotnet core

It is assumed that dotnet core 1.0.1 is installed.

There are two projects.
Service is a service-endpoint with two nancy-modules: Home in the root and triangles/a/b/c for requesting analysis of triangles. http://localhost:5000/ (if the service is run locally) gives a brief instruction on how to use the service.

On bigger solutions swagger would be the obvious choise for documenting a service for third party clients.

Service.test is a Xunit project for testing the underlying bussiness logic.

After pulling from this repository, go to 'Service' and write 'dotnet restore' / 'dotnet run' to see if the basics works.

In Service.test run the following commands 'dotnet restore' / 'dotnet test'. Hopefully all tests passes.

For testing the endpoint, run the service , start postman and import the postman collection from the root-folder.

I made it as a service, since it makes the seperation of concern more obvious, thus easier to split the tests in unit-tests and integration tests.this also makes it clear where to make in

The reason for choosing Nancy is that it is lightweight and the code is succinct and easy to read. 
