import java.util.Arrays;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Class_12_CardsFrequencies {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String[] cards = scanner.nextLine().split(" ");
        LinkedHashMap<String, Long> cardFaces = Arrays.asList(cards)
                .stream()
                .collect(Collectors.groupingBy(w -> w.substring(0, w.length() - 1), LinkedHashMap::new, Collectors.counting()));

        for (Map.Entry<String, Long> entry : cardFaces.entrySet()) {
            double percentage = (entry.getValue()/(double)cards.length) * 100;

            System.out.printf("%s ->%.2f%%\n", entry.getKey(), percentage);
        }
    }
}

