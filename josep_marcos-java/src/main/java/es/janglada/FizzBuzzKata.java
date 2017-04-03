package es.janglada;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.stream.IntStream;

public class FizzBuzzKata {

    private static final String BUZZ = "Buzz";
    private static final String FIZZ = "Fizz";

    public static void main(String[] args) {
        IntStream.range(1, 100)
                .forEach(i -> System.out.println(FizzBuzzKata.getText(i)));
    }

    private static final Map<FizzBuzzMatcher, String> MATCHERS = new LinkedHashMap<FizzBuzzMatcher, String>() {{
        put(new DivisibleByThreeAndFiveMatcher(), FIZZ + BUZZ);
        put(new DivisibleByThreeMatcher(), FIZZ);
        put(new DivisibleByFiveMatcher(), BUZZ);
    }};


    public static String getText(int i) {
        return MATCHERS.entrySet().stream()
                .filter(entry -> entry.getKey().applies(i))
                .map(Map.Entry::getValue)
                .findFirst()
                .orElse(String.valueOf(i));
    }
}
