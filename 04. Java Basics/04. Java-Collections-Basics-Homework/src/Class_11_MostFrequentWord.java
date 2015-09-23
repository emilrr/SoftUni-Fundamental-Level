import java.util.*;

public class Class_11_MostFrequentWord {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split("[\\W]+");

        Map<String, Integer> wordsByCount = new TreeMap<>();
        for (String word : input) {
            Integer count = wordsByCount.get(word);
            if (count == null) {
                count = 0;
            }
            wordsByCount.put(word.toLowerCase(), count + 1);
        }

        int maxValue = 0;
        for (Integer integer : wordsByCount.values()) {
            if (integer > maxValue) {
                maxValue = integer;
            }
        }

        for (Map.Entry<String, Integer> stringIntegerEntry : wordsByCount.entrySet()) {
            if (stringIntegerEntry.getValue() == maxValue) {
                System.out.println(stringIntegerEntry.getKey() + " -> " + maxValue + " times");
            }
        }
    }
}
