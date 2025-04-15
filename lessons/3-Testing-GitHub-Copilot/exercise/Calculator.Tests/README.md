**CalculatorTests Documentation**

**Overview**

The `CalculatorTests` class provides a comprehensive set of unit tests for the `Calculator` class, ensuring correctness and robustness of its mathematical operations. These tests are implemented using the xUnit testing framework and cover typical use cases as well as important edge cases.

**Test Methods**

**Add_ShouldReturnCorrectSum**

**Purpose:**  
Verifies that the `Add` method correctly calculates the sum of two numbers.

**Test Cases:**  
- Adding two positive numbers: `2 + 3 = 5`  
- Adding a positive and a negative number: `2 + (-3) = -1`

**Subtract_ShouldReturnCorrectDifference**

**Purpose:**  
Ensures the `Subtract` method correctly computes the difference between two numbers.

**Test Cases:**  
- Subtracting a larger number from a smaller one: `2 - 3 = -1`  
- Subtracting a negative number: `2 - (-3) = 5`

**Multiply_ShouldReturnCorrectProduct**

**Purpose:**  
Confirms the `Multiply` method accurately calculates the product of two numbers.

**Test Cases:**  
- Multiplying two positive numbers: `2 * 3 = 6`  
- Multiplying a positive and a negative number: `2 * (-3) = -6`

**Modulus_ShouldReturnCorrectRemainder**

**Purpose:**  
Checks that the `Modulus` method returns the correct remainder after division.

**Test Cases:**  
- Calculating the remainder of `10` divided by `3`: `10 % 3 = 1`

**Modulus_ShouldThrowDivideByZeroException_WhenDivisorIsZero**

**Purpose:**  
Validates that the `Modulus` method correctly handles division by zero by throwing a `DivideByZeroException`.

**Test Cases:**  
- Attempting modulus operation with divisor zero: `10 % 0`

**SquareRoot_ShouldReturnCorrectResult**

**Purpose:**  
Ensures the `SquareRoot` method correctly calculates the square root of a positive number.

**Test Cases:**  
- Calculating the square root of `16`: `√16 = 4`

**SquareRoot_ShouldThrowArgumentException_WhenInputIsNegative**

**Purpose:**  
Verifies that the `SquareRoot` method throws an `ArgumentException` when provided with a negative input.

**Test Cases:**  
- Attempting to calculate the square root of `-4`

**IsPrime_ShouldReturnCorrectResult**

**Purpose:**  
Tests the `IsPrime` method to accurately determine whether a given integer is prime.

**Test Cases:**  
- Prime numbers: `2`, `3`, `17`  
- Non-prime numbers: `4`, `18`  
- Edge cases: `1`, `0`, negative numbers (`-5`)

**Power_ShouldReturnCorrectResult**

**Purpose:**  
Confirms the `Power` method correctly computes the result of raising a base number to a given exponent.

**Test Cases:**  
- Positive exponent: `2^3 = 8`  
- Negative exponent: `2^-2 = 0.25`  
- Zero exponent: `5^0 = 1`

**Summary**

These tests collectively ensure that the `Calculator` class methods behave correctly under normal conditions and handle exceptional scenarios gracefully. The test suite provides clear documentation of expected behaviors, facilitating easier maintenance and future enhancements.