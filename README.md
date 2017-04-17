# Triangles.Service
Trying out Triangles.Service on dotnet core
It is assumed that dotnet core 1.0.1 is installed.

There are two projects.
Service is a service-endpoint with two nancy-modules: Home in the root and triangles/a/b/c for requesting analysis of triangles.
Service.test is a Xunit project for testing the underlying bussiness logic.

After pulling from this repository, go to 'Service' and write 'dotnet restore' / 'dotnet run' to see if the basics works.

In Service.test run the following commands 'dotnet restore' / 'dotnet test'. Hopefully all tests passes.
