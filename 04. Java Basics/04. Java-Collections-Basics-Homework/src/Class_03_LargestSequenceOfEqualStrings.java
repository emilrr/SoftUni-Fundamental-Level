import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Class_03_LargestSequenceOfEqualStrings {

    private static List<String> sequence = new ArrayList<>();

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String input[] = scanner.nextLine().split(" ");

        for (int i = 0; i < input.length - 1; i++) {
            List<String> list = new ArrayList<>();
            list.add(input[i]);

            while ((i < input.length - 1) && (input[i + 1].equals(input[i]))) {
                list.add(input[i + 1]);
                i++;
            }
            if (list.size() > sequence.size()) {
                sequence.clear();
                sequence.addAll(list);
            }
        }

        if (input.length == 1) {
            sequence.add(input[0]);
        }

        System.out.println(sequence);
    }
}
