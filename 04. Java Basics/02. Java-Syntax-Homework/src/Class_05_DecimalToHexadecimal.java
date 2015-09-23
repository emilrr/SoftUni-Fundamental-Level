import java.util.Scanner;

/*
 * Write a program that enters a positive integer number num and converts and prints it
 * in hexadecimal form. You may use some built-in method from the standard Java libraries.
 */

public class Class_05_DecimalToHexadecimal {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a decimal number: ");
        int number = scanner.nextInt();

        System.out.println(
                String.format("Integer %s in decimal is %s in hexadecimal."
                        , number
                        , Integer.toHexString(number).toUpperCase()));
    }
}
