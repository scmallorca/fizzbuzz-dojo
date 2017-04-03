class NumberTransformer(val transformations: List<Transformation>) {

    class Transformation(val predicate: (Int) -> Boolean, val value: String)

    fun transform(x: Int): String {
        return transformations.firstOrNull { it.predicate(x) }?.value ?: x.toString()
    }
}