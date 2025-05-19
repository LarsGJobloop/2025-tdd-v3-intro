## Setting up TDD using xUnit

1. `dotnet new xunit -n Calculator.Tests`: Generate project 
2. `dotnet sln add Calculator.Tests`: Add to Solution
3. `dotnet add Calculator.Tests reference Calculator`: Link in depencies
4. `dotnet test`: Verify that everything works
