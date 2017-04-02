/// <reference path="kata.ts"/>
describe("Test FizzBuzzConverter", function () {
    var fizzBuzzConverter;
    beforeEach(function () {
        fizzBuzzConverter = new FizzBuzzConverter(new Calculator());
    });
    it('should convert to Fizz if it\'s divisible by three', function () {
        expect('Fizz').toEqual(fizzBuzzConverter.convert(3));
    });
    it('should convert to Buzz if it\'s divisible by five', function () {
        expect('Buzz').toEqual(fizzBuzzConverter.convert(5));
    });
    it('should not convert if it\'s NOT divisible by five and NOT divisible by three', function () {
        expect('7').toEqual(fizzBuzzConverter.convert(7));
    });
    it('should convert to FizzBuzz if it\'s divisible by three and five', function () {
        expect('FizzBuzz').toEqual(fizzBuzzConverter.convert(15));
    });
});
describe("Test Kata functionality", function () {
    var kata;
    beforeEach(function () {
        kata = new Kata(new FizzBuzzConverter(new Calculator()), 100);
    });
    it('should contain some Fizz string', function () {
        expect(kata.getFizzBuzzList().indexOf('Fizz\n') >= 0).toBe(true);
    });
    it('should not contain any Dummy string', function () {
        expect(kata.getFizzBuzzList().indexOf('Dummy\n') >= 0).toBe(false);
    });
    it('should contain some Buzz string', function () {
        expect(kata.getFizzBuzzList().indexOf('Buzz\n') >= 0).toBe(true);
    });
    it('should not contain some 35 string', function () {
        expect(kata.getFizzBuzzList().indexOf('35\n') >= 0).toBe(false);
    });
    it('should contain some Buzz string', function () {
        expect(kata.getFizzBuzzList().indexOf('FizzBuzz\n') >= 0).toBe(true);
    });
});
