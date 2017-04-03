package es.janglada;

/**
 * Created by janglada on 1/04/17.
 */
public class DivisibleByThreeMatcher implements FizzBuzzMatcher {

    @Override
    public boolean applies(int number) {
        return DivisibleOperations.isDivisible(number, 3);
    }

}
