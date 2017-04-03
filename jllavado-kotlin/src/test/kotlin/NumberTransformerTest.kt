import NumberTransformer.Transformation
import org.junit.Assert.*
import org.junit.Test

class NumberTransformerTest {
    val DIVISIBLE_3 : String = "DIVISIBLE_3"
    val DIVISIBLE_5 : String = "DIVISIBLE_5"
    val DIVISIBLE_3_5 : String = "DIVISIBLE_3_5"

    @Test
    fun transform() {
        val transformer: NumberTransformer = NumberTransformer(listOf(
                Transformation({ it % 3 == 0  && it % 5 == 0}, DIVISIBLE_3_5),
                Transformation({ it % 3 == 0 }, DIVISIBLE_3),
                Transformation({ it % 5 == 0 }, DIVISIBLE_5)
        ))

        assertEquals(transformer.transform(3), DIVISIBLE_3)
        assertEquals(transformer.transform(5), DIVISIBLE_5)
        assertEquals(transformer.transform(15), DIVISIBLE_3_5)
    }
}