import java.util.Scanner;

public class Class_02_GenerateThreeLetterWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();

        for (int a = 0; a < input.length(); a++) {
            for (int b = 0; b < input.length(); b++) {
                for (int c = 0; c < input.length(); c++) {

                    System.out.printf("%c%c%c ", input.charAt(a), input.charAt(b), input.charAt(c));
                }
            }
        }
    }
}
