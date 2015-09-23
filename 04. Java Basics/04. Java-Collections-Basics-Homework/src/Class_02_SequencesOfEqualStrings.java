import java.util.Scanner;

public class Class_02_SequencesOfEqualStrings {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String input[] = scanner.nextLine().split(" ");

        System.out.print(input[0]);
        for (int i = 1; i < input.length; i++) {
            if (input[i].equals(input[i - 1])) {
                System.out.printf(" %s", input[i]);
            } else {
                System.out.printf("\n%s", input[i]);
            }
        }
        scanner.close();
    }
}
