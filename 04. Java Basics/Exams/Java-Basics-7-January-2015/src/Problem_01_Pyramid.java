import java.util.*;
import java.util.stream.Collectors;

public class Problem_01_Pyramid {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        String firstLine = scanner.nextLine().replaceAll("\\s+", "");
        int top = Integer.parseInt(firstLine);

        ArrayList<Integer> sequence = new ArrayList<>();
        sequence.add(top);
        int previousNumber = top;

        for (int i = 0; i < n - 1; i++) {
            boolean isFound = false;

            List<Integer> numbers =
                    Arrays.asList(scanner.nextLine().trim()
                            .split("\\s+"))
                            .stream()
                            .map(x -> Integer.parseInt(x))
                            .sorted()
                            .collect(Collectors.toList());

            for (int j = 0; j < numbers.size(); j++) {
                int currentNumber = numbers.get(j);

                if (currentNumber > previousNumber) {
                    sequence.add(currentNumber);
                    previousNumber = sequence.get(sequence.size() - 1);
                    isFound = true;
                    break;
                }
            }

            if (!isFound) {
                previousNumber++;
            }
        }

        for (int i = 0; i < sequence.size(); i++) {
            if (i == sequence.size() - 1) {
                System.out.printf("%d", sequence.get(i));
            } else {
                System.out.printf("%d, ", sequence.get(i));
            }
        }
    }
}
