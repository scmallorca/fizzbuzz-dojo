Fizzbuzz Coding Dojo
=========================

## Dojo Solutions:
Please, perform a Pull Request to add your team solution:
* Clone this project.
* Create a folder like "nameA-nameB" or just "nameA" if you are a solo developer in the root of this project.
* Create a pull-request over this repository.

## Extra challenges for home
* Add "Bang" as other output for values multiples of 7.
* Use substitutions sequences to allow any kind of input:
    * Example test (pseudo code):
    ```    
    // arrange
    var substitutions = [ Sub(3, Fizz), 
                          Sub(5, Buzz),
                          Sub(8, Rest),
                          Sub(10, Boom) ]                          
    var kata = FizzBuzz()

    // act
    var result = kata.Validate(40, substitutions)

    // assert
    // 40 is multiple of 5, 8 and 10
    assertEqual(40, "BuzzRestBoom")
    ```            

* Resolve original problem (FizzBuzz) without the use of module or division.
* Resolve original problem (FizzBuzz) without module or basic aritmethic operations (addition, subtraction, division and multiplication).
