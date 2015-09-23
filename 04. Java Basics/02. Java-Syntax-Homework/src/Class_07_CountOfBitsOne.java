import java.util.Scanner;

/*
 * Write a program to calculate the count of bits 1 in the binary representation
 * of given integer number n.
 */

public class Class_07_CountOfBitsOne {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int number = scan.nextInt();
        int temp = number;
        int count = 0;

        for (int i = 0; i < 16; i++) {
            if((temp & 1) != 0){
                count++;
            }

            temp = temp >> 1;
        }

        //System.out.println(Integer.bitCount(a));
        System.out.println(String.format("Number %d has %d turned on bits.", number, count));
    }
}

