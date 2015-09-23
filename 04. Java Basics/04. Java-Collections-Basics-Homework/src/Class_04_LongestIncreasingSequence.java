import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Class_04_LongestIncreasingSequence {

    private static List<Integer> longestSequence = new ArrayList<>();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String numberString[] = scanner.nextLine().split(" ");
        Integer numberInt[] = new Integer[numberString.length];

        for (int i = 0; i < numberString.length; i++) {
            numberInt[i] = Integer.parseInt(numberString[i]);
        }

        for (int i = 0; i < numberInt.length - 1; i++) {
            List<Integer> list = new ArrayList<>();
            list.add(numberInt[i]);

            while ((i < numberInt.length - 1) && (numberInt[i] < numberInt[i + 1])) {
                list.add(numberInt[i + 1]);
                i++;
            }

            System.out.println(list);

            if (list.size() > longestSequence.size()) {
                longestSequence.clear();
                longestSequence.addAll(list);
            }
        }
        System.out.printf("Longest: %s", longestSequence);
        scanner.close();
    }
}
