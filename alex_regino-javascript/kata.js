function Kata() {
};

Kata.prototype.error = 'Error';
Kata.prototype.noDivisible = 'Error no divisible by any number';

function isDivisibleBy(num, div) {
    return num % div === 0;
}

function containsNum(num, contains) {
    return num.toString().indexOf(contains) > -1;
}

function getFizz(num) {
    return (isDivisibleBy(num, 3) || containsNum(num, '3')) && 'Fizz';
}

function getBuzz(num) {
    return (isDivisibleBy(num, 5) || containsNum(num, '5')) && 'Buzz';
}

function isDivisible3and5(num) {
    return isDivisibleBy(num, 3) && isDivisibleBy(num, 5);
}

function contains3and5(num) {
    return containsNum(num, '3') && containsNum(num, '5');
}

function getFizzBuzz(num) {
    return (isDivisible3and5(num) || contains3and5(num)) && 'FizzBuzz';
}

function getDisivibleText(num) {
    return getFizzBuzz(num) || getBuzz(num) || getFizz(num);
}

function isValidNumber(num) {
    return (typeof num === 'number') && num <= 100;
}

Kata.prototype.getFizzBuzz = function (number) {
    return isValidNumber(number)
        ? (getDisivibleText(number) || this.noDivisible)
        : this.error;
};