Feature: FizzBuzz Kata
	In order to resolve the kata
	As a software craftsman
	I want to be told the result (Fizz, Buzz, FizzBuzz or number) for any input number

@fizzbuzz_simple
Scenario: FizzBuzz simple case
	Given the input number 1
	When FizzBuzzKata is invoked with the given input 1
	Then the result should be equal to 1

Scenario Outline: Verify FizzBuzz using the following
	Given the input number <value>
	When FizzBuzzKata is invoked with the input <value>
	Then the result should be equal to <expected>

	Examples: 
	| value | expected |
	| 1     | 1        |
	| 2     | 2        |
	| 3     | Fizz     |
	| 4     | 4        |
	| 5     | Buzz     |
	| 6     | Fizz     |
	| 7     | 7        |	
	| 9     | Fizz     |
	| 10    | Buzz     |
	| 11    | 11       |
	| 12    | Fizz     |
	| 13    | 13       |	
	| 15    | FizzBuzz |
	| 30    | FizzBuzz |
