var Kata = (function () {
    function Kata(fizzBuzzConverter, numberListSize) {
        this.fizzBuzzConverter = fizzBuzzConverter;
        this.numberListSize = numberListSize;
    }
    Kata.prototype.getFizzBuzzList = function () {
        var stringResult = '';
        for (var i = 1; i <= this.numberListSize; i++) {
            stringResult += this.fizzBuzzConverter.convert(i) + '\n';
        }
        return stringResult;
    };
    return Kata;
}());
var FizzBuzzConverter = (function () {
    function FizzBuzzConverter(calculator) {
        this.calculator = calculator;
    }
    FizzBuzzConverter.prototype.convert = function (value) {
        var printableResult = value.toString();
        if (this.calculator.isDivisibleBy(value, [3, 5])) {
            printableResult = 'FizzBuzz';
        }
        else if (this.calculator.isDivisibleBy(value, [3])) {
            printableResult = 'Fizz';
        }
        else if (this.calculator.isDivisibleBy(value, [5])) {
            printableResult = 'Buzz';
        }
        return printableResult;
    };
    return FizzBuzzConverter;
}());
var Calculator = (function () {
    function Calculator() {
    }
    Calculator.prototype.isDivisibleBy = function (value, divisors) {
        var divisible = true;
        for (var _i = 0, divisors_1 = divisors; _i < divisors_1.length; _i++) {
            var divisor = divisors_1[_i];
            divisible = divisible && (value % divisor == 0);
        }
        return divisible;
    };
    return Calculator;
}());
var fizzBuzzKata = new Kata(new FizzBuzzConverter(new Calculator()), 100);
console.log(fizzBuzzKata.getFizzBuzzList());
