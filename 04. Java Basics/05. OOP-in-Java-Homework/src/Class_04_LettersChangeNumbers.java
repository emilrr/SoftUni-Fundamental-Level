import java.util.Scanner;

public class Class_04_LettersChangeNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split("\\s+");
        double totalSum = 0.0;

        for (int i = 0; i < input.length; i++) {
            int lenghtOfCurrentWord = input[i].length();
            String numberAsString = input[i].substring(1, lenghtOfCurrentWord - 1);
            double number = Double.parseDouble(numberAsString);
            double sumOfExpression = 0.0;

            int firstLetter = (int) input[i].charAt(0);
            int lastLetter = (int) input[i].charAt(lenghtOfCurrentWord - 1);;

            if (firstLetter > 64 && firstLetter < 91) {
                int possitionFirst = firstLetter - 64;
                sumOfExpression = number / possitionFirst;

            } else {
                int possitionFirst = firstLetter - 96;
                sumOfExpression = number * possitionFirst;
            }

            if (lastLetter > 64 && lastLetter < 91) {
                int possitionLast = lastLetter - 64;
                sumOfExpression = sumOfExpression - possitionLast;
            } else {
                int possitionLast = lastLetter - 96;
                sumOfExpression = sumOfExpression + possitionLast;
            }
            totalSum += sumOfExpression;
        }
        System.out.printf("%.2f", totalSum);
    }
}
