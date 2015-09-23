import java.util.Scanner;

public class Class_15_SumCards {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input[] = scanner.nextLine().split(" ");
        String cards[] = new String[input.length];

        int count = 1;
        int countedTwice = 1;
        int sum = 0;

        for (int i = 0; i < input.length; i++) {
            input[i] = input[i].substring(0, input[i].length() - 1);
            cards[i] = input[i];
        }

        for (int i = 0; i < cards.length; i++) {

            while ((i < input.length - 1) && (input[i + 1].equals(input[i]))) {
                countedTwice = 2;
                count++;
                i++;
            }

            sum += getCardValue(input[i]) * count * countedTwice;
            count = 1;
            countedTwice = 1;
        }

        System.out.println(sum);
        scanner.close();

    }

    private static int getCardValue(String card) {
        switch (card) {
            case "1":
                return 1;
            case "2":
                return 2;
            case "3":
                return 3;
            case "4":
                return 4;
            case "5":
                return 5;
            case "6":
                return 6;
            case "7":
                return 7;
            case "8":
                return 8;
            case "9":
                return 9;
            case "10":
                return 10;
            case "J":
                return 12;
            case "Q":
                return 13;
            case "K":
                return 14;
            case "A":
                return 15;
        }
        throw new IllegalArgumentException("Invalid card: " + card);
    }
}
