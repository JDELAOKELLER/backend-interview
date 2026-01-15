# Interview Questions Project

This project contains a series of coding challenges designed to test fundamental programming skills. Each function in the `Questions.cs` file needs to be implemented to pass the corresponding unit tests.

## Prerequisites

### Windows

1. **Visual Studio 2019 or later** (Community Edition is free)
   - Download from: https://visualstudio.microsoft.com/downloads/
   - During installation, select the ".NET desktop development" workload

**OR**

1. **.NET SDK 6.0 or later**
   - Download from: https://dotnet.microsoft.com/download
2. **Visual Studio Code** (optional, for lighter-weight IDE)
   - Download from: https://code.visualstudio.com/

### macOS

1. **Visual Studio for Mac** (if you prefer an IDE)
   - Download from: https://visualstudio.microsoft.com/vs/mac/
   - Select ".NET" workload during installation

**OR**

1. **.NET SDK 6.0 or later**
   - Download from: https://dotnet.microsoft.com/download
   - Install using Homebrew: `brew install dotnet`
2. **Visual Studio Code** (optional)
   - Download from: https://code.visualstudio.com/
   - Install C# extension from the marketplace

## Building the Project

### Using Visual Studio (Windows/Mac)

1. Open `InterviewQuestions.sln` in Visual Studio
2. Build the solution: `Build` → `Build Solution` (or press `Ctrl+Shift+B` on Windows, `Cmd+B` on Mac)

### Using Command Line

1. Navigate to the project root directory (where `InterviewQuestions.sln` is located)
2. Run the following command:
   ```bash
   dotnet build
   ```

## Running Tests

### Using Visual Studio

1. Open Test Explorer: `Test` → `Test Explorer`
2. Click "Run All" to execute all tests
3. View results in the Test Explorer window

### Using Command Line

1. Navigate to the project root directory
2. Run all tests:
   ```bash
   dotnet test
   ```

### Running Tests for a Specific Function

```bash
dotnet test --filter "FullyQualifiedName~PalindromeTests"
dotnet test --filter "FullyQualifiedName~FibonacciTests"
dotnet test --filter "FullyQualifiedName~AngleTests"
dotnet test --filter "FullyQualifiedName~ChangeTests"
dotnet test --filter "FullyQualifiedName~RomanTests"
```

## Running the Interactive Console

### Using Visual Studio

1. Set `InterviewQuestions` as the startup project (right-click → "Set as Startup Project")
2. Press `F5` or click the "Start" button
3. Follow the prompts to test individual functions

### Using Command Line

1. Navigate to the `InterviewQuestions` directory
2. Run:
   ```bash
   dotnet run
   ```

## Challenge Functions

The following functions need to be implemented in [`InterviewQuestions/Questions.cs`](InterviewQuestions/Questions.cs):

1. **[`isPalindrome`](InterviewQuestions/Questions.cs)** - Determine if a string is a palindrome
2. **[`nthFib`](InterviewQuestions/Questions.cs)** - Calculate the nth Fibonacci number
3. **[`computeAngleBetweenNumbersOnClock`](InterviewQuestions/Questions.cs)** - Calculate the angle between two numbers on a clock face
4. **[`calculateChange`](InterviewQuestions/Questions.cs)** - Calculate minimal coins needed using 2¢, 3¢, and 4¢ denominations
5. **[`romanNumeraltoNumber`](InterviewQuestions/Questions.cs)** - Convert Roman numerals to decimal numbers

## Project Structure

```
InterviewQuestions/           # Main project with function stubs
  Questions.cs                # File containing functions to implement
  Program.cs                  # Console application for manual testing
InterviewQuestionsTests/      # Unit tests
  InterviewQuestionsTests.cs  # Test cases for all functions
```

## Verification

To verify your development environment is set up correctly:

1. Build the solution (should succeed with no errors)
2. Run the tests (all tests will initially fail - this is expected)
3. Implement one function and verify its tests pass

## Tips

- Read the comments in [`Questions.cs`](InterviewQuestions/Questions.cs) carefully for each function's requirements
- Test cases can be found in [`InterviewQuestionsTests.cs`](InterviewQuestionsTests/InterviewQuestionsTests.cs)
- You can use the interactive console to test your implementations manually
- Focus on correctness first, then optimize if needed

## Troubleshooting

**"dotnet: command not found"**
- Ensure the .NET SDK is installed and added to your PATH
- Restart your terminal/command prompt after installation

**Build errors about missing dependencies**
- Run `dotnet restore` in the project root directory

**Tests not appearing in Visual Studio**
- Rebuild the solution
- Close and reopen Test Explorer

## Questions?

If you encounter any setup issues, please contact ask the interviewer.