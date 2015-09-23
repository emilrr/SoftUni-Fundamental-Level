import java.util.Scanner;

/*
 * Write a program to count how many sequences of two equal bits ("00" or "11")
 * can be found in the binary representation of given integer number n (with overlapping).
 */

public class Class_08_CountOfEqualBitPairs {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int number = scan.nextInt();
        char[] numberBinary = Integer.toBinaryString(number).toCharArray();
        int count = 0;

        for (int i = 0; i < numberBinary.length - 1; i++) {
            if (numberBinary[i] == numberBinary[i + 1]) {
                count++;
            }
        }

        System.out.println(String.format("Number %d has %d sequences of two equal bits .", number, count));
    }
}
