import java.util.Scanner;

public class Problem_02_MagicCard {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] cardsArray = scanner.nextLine().split(" ");
        String oddOrEven = scanner.nextLine();
        String magicCard = scanner.nextLine();

        String magicCardFace = magicCard.substring(0, magicCard.length() - 1);
        String magicCardSuit = magicCard.substring(magicCard.length() - 1, magicCard.length());

        int sum = 0;
        int startPosition = oddOrEven.equals("odd") ? 1 : 0;

        for (int i = startPosition; i < cardsArray.length; i += 2) {
            String cardFace = cardsArray[i].substring(0, cardsArray[i].length() - 1);
            String cardSuit = cardsArray[i].substring(cardsArray[i].length() - 1, cardsArray[i].length());

            int value = returnValueOfCard(cardFace);

            if (magicCardFace.equals(cardFace)) {
                sum += value * 3;
            } else if (magicCardSuit.equals(cardSuit)) {
                sum += value * 2;
            } else {
                sum += value;
            }

        }

        System.out.println(sum);

    }

    private static int returnValueOfCard(String cardFace) {
        switch (cardFace) {
            case "1":
                return 10;
            case "2":
                return 20;
            case "3":
                return 30;
            case "4":
                return 40;
            case "5":
                return 50;
            case "6":
                return 60;
            case "7":
                return 70;
            case "8":
                return 80;
            case "9":
                return 90;
            case "10":
                return 100;
            case "J":
                return 120;
            case "Q":
                return 130;
            case "K":
                return 140;
            case "A":
                return 150;
        }

        return 0;
    }
}
