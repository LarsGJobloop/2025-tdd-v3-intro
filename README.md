## Setting up TDD using xUnit

1. `dotnet new classlib -n Caculator`: Generat Class
2. `dotnet sln add Calculator`: Add to solution
3. `dotnet new xunit -n Calculator.Tests`: Generate project 
4. `dotnet sln add Calculator.Tests`: Add to Solution
5. `dotnet add Calculator.Tests reference Calculator`: Link in depencies
6. `dotnet test`: Verify that everything works

## Sketches

![sketches](/docs/2025-tdd-v3.png)
