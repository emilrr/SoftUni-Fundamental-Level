import java.util.Scanner;

/*
 * Write a program that reads 3 numbers: an integer a (0 ? a ? 500), a floating-point b
 *  and a floating-point c and prints them in 4 virtual columns on the console.
 *  Each column should have a width of 10 characters. The number a should be printed
 *  in hexadecimal, left aligned; then the number a should be printed in binary form,
 *  padded with zeroes, then the number b should be printed with 2 digits after
 *  the decimal point, right aligned; the number c should be printed with 3 digits
 *  after the decimal point, left aligned.
 */

public class Class_06_FormattingNumbers {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        System.out.print("Enter a (an integer in range 0-500): ");
        int a = scan.nextInt();

        System.out.print("Enter b (floating point): ");
        double b = scan.nextDouble();

        System.out.print("Enter c (floating point): ");
        double c = scan.nextDouble();


        format(a, b, c);
    }

    public static void format(int a, double b, double c){
        String result = String.format("|%-10s|%-10s|%10.2f|%-10.3f",
                Integer.toHexString(a).toUpperCase(),
                binaryWithPadding(a),
                b,
                c);

        System.out.println(result);
    }

    private static String binaryWithPadding(int number){
        return String.format("%10s", Integer.toBinaryString(number)).replace(' ','0');
    }
}
