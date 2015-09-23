import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        System.out.print("Please insert first number: ");
        int firstNum = input.nextInt();

        System.out.print("Please insert second number: ");
        int secondNum = input.nextInt();
        long sum = firstNum + secondNum;

        System.out.print("Sum: ");
        System.out.println(sum);

    }
}

