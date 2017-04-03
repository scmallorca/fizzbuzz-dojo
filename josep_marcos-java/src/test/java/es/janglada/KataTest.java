package es.janglada;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {


    @Test
    public void esdivisiblePor3() {
        assertEquals("Fizz", FizzBuzzKata.getText(3));
    }

    @Test
    public void esdivisiblePor5() {
        assertEquals("Buzz", FizzBuzzKata.getText(5));
    }

    @Test
    public void esdivisiblePor5Y3() {
        assertEquals("FizzBuzz", FizzBuzzKata.getText(15));
    }

    @Test
    public void noesDivisibleniPor3Ni5() throws Exception {
        assertEquals("1", FizzBuzzKata.getText(1));
    }
}