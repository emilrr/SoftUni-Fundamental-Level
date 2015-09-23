import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Class_05_CountAllWords {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text[] = scanner.nextLine().split("([a-zA-Z]+)");
        System.out.println(text.length - 1);

        scanner.close();
    }
}
