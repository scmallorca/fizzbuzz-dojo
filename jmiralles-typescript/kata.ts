class Kata {
    numberListSize: number;
    private fizzBuzzConverter: FizzBuzzConverter;
    constructor(fizzBuzzConverter: FizzBuzzConverter, numberListSize: number) {
        this.fizzBuzzConverter = fizzBuzzConverter;
        this.numberListSize = numberListSize;
    }

	getFizzBuzzList() {
        let stringResult = '';
        for (let i = 1; i <= this.numberListSize; i++) {
            stringResult += this.fizzBuzzConverter.convert(i) + '\n';
        }
        return stringResult;
	}

}

class FizzBuzzConverter {
    private calculator: Calculator;
    constructor(calculator: Calculator) {
        this.calculator = calculator;
    }

    convert(value: number) {
        let printableResult: string = value.toString();
        if (this.calculator.isDivisibleBy(value, [3, 5])) {
            printableResult = 'FizzBuzz';
        } else if (this.calculator.isDivisibleBy(value, [3])) {
            printableResult = 'Fizz';
        } else if (this.calculator.isDivisibleBy(value, [5])) {
            printableResult = 'Buzz';
        }
        return printableResult;
    }

}

class Calculator {
    isDivisibleBy(value: number, divisors: number[]) {
        let divisible = true;
        for (let divisor of divisors) {
            divisible = divisible && (value % divisor == 0);
        }
        return divisible;
    }
}

let fizzBuzzKata = new Kata(new FizzBuzzConverter(new Calculator()), 100);
console.log(fizzBuzzKata.getFizzBuzzList());