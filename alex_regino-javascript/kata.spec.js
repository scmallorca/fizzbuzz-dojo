describe("Kata", function() {
	var kata;
	
	beforeEach(function() {
		kata = new Kata();
	});
	
	it('should value be a Number', function() {
		expect(kata.getFizzBuzz('hola')).toEqual('Error');
	});

	it('should value be number less than 100', function() {
		expect(kata.getFizzBuzz(102)).toEqual('Error');
	});
	
	it('should value be divisible by 3 return Fizz', function() {
		expect(kata.getFizzBuzz(3)).toEqual('Fizz');
	});

	it('should value be contains 3 return Fizz', function() {
		expect(kata.getFizzBuzz(13)).toEqual('Fizz');
	});

	it('should value be no divisible by 3 return Error', function() {
		expect(kata.getFizzBuzz(4)).toEqual('Error no divisible by any number');
	});

	it('should value be divisible by 5 return Buzz', function() {
		expect(kata.getFizzBuzz(5)).toEqual('Buzz');
	});

	it('should value be contains 5 return Fizz', function() {
		expect(kata.getFizzBuzz(52)).toEqual('Buzz');
	});

	it('should value be divisible by 5 and 3 return FizzBuzz', function() {
		expect(kata.getFizzBuzz(15)).toEqual('FizzBuzz');
	});

	it('should value be contains 35 return FizzBuzz', function() {
		expect(kata.getFizzBuzz(35)).toEqual('FizzBuzz');
	});

	it('should value be contains 53 return FizzBuzz', function() {
		expect(kata.getFizzBuzz(53)).toEqual('FizzBuzz');
	});
});