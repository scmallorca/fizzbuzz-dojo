import NumberTransformer.*

fun main(args: Array<String>) {
    val transformer : NumberTransformer = NumberTransformer(listOf(
            Transformation({it % 3 == 0 && it % 5 == 0}, "FizzBuzz"),
            Transformation({it % 3 == 0}, "Fizz"),
            Transformation({it % 5 == 0}, "Buzz")
    ))
    for (x in 1..100) {
        print(transformer.transform(x) + "\n")
    }
}
