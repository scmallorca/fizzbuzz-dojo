package es.janglada;

public abstract class DivisibleOperations {

    static boolean isDivisible(int number, int byNumber) {
        return number % byNumber == 0;
    }
}