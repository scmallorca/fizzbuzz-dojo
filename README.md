Fizzbuzz Coding Dojo
=========================

## Dojo Solutions:
Please, perform a pull request over this repository to add your team solution:
* Fork the repository to your github account.
* Clone the forked repository:
```
$ git clone https://github.com/your_username/fizzbuzz-dojo.git
```    
* Access the repository
```
$ cd fizzbuzz-dojo
```
* Create a new branch and move to it:
```
$ git checkout -b team_name-branch
```
* Create a folder like "nameA-nameB" or just "nameA" if you are a solo developer in the root of this repository and add your solution:
```
$ mkdir team_name_java
$ cp -r ../MyKata ./team_name_java
```
* Add changes to git and commit
```
$ git add -A
$ git commit -m "Added team_name solution in java"
```
* Push your changes to your remote repository
```
$ git push --set-upstream origin team_name-branch
```
* Create a pull-request from your forked and updated repository on github:
   * Select as "base fork" the "cmallorca/fizzbuzz-dojo" master branch
   * Select as "head fork" your "your_name/fizzbuzz-dojo" team_name branch 

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
    var kata = SubstitutionsKata()

    // act
    var result = kata.Validate(40, substitutions)

    // assert
    // 40 is multiple of 5, 8 and 10
    assertEqual(40, "BuzzRestBoom")
    ```            

* Resolve original problem (FizzBuzz) without the use of module or division.
* Resolve original problem (FizzBuzz) without module or basic aritmethic operations (addition, subtraction, division and multiplication).
