# Raindrops

## Task
Write a function that takes as its input a number (n) and converts it to a string, the contents of which depend on the numbers factors

- if the number has a factor of **3**, output **'Pling'**
- if the number has a factor of **5**, output **'Plang'**
- if the number has a factor of **7**, output **'Plong'**
- if the number has **none** of the above factors return **numbers digits**

## Examples

- 28's factors are 1, 2, 4, 7, 14 and 28: this would be a simple 'Plong'
- 30's factors are 1, 2, 3, 5, 6, 10, 15, 30: this would be a 'PlingPlang'
- 34 has four factors: 1, 2, 17, and 34: this would be '34'

## TDD approach
I used a TDD approach to testing where:
1. I wrote the test so that it would fail.
2. Then wrote the code that would make the test pass .
3. I repeated the first 2 steps until I had covered all the tests while doing a little refactoring along the way.

In commit 9 I did most of the refactoring just tidying up the code so it could be easily readable
switching from if-else statements to ternary operators.

## Test Basis
I used the above task requirements and examples as a test basis for testing.

## Test Condition
The factors 3, 5, 7 mentioned above are being tested against a number n to see if it returns the expected string using the FactorResults method.

## Test Case / Coverage
I ensured the tests covered the outputs for the individual factors of 3, 5, 7 and none of the factors.
Then looking at the example of 3 which had a combination of 2 factors 3 and 5, I created tests around the different possible combinations
of factors the number n can have:
3 & 5
3 & 7
5 & 7
3 & 5 & 7

Traceability can be seen between the task, test cases and the test condition.

## Test Data
In terms of the test data I used 2 test pieces of information for each scenario the input (number n) and the output (expected string). 
I have used 2 examples for each test case ensuring to assure that they would provide the same output for that specific scenario.
