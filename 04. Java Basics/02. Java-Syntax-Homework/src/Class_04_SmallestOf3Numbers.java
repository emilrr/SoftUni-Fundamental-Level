import java.util.Locale;
import java.util.Scanner;

//Write a program that finds the smallest of three numbers.

public class Class_04_SmallestOf3Numbers {

    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);

        Scanner scanner = new Scanner(System.in);
        double a = scanner.nextDouble();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();
        double minNumber = Math.min(a,(Math.min(b, c)));

        System.out.println(String.format("The minimum number is : " + minNumber));
    }
}
