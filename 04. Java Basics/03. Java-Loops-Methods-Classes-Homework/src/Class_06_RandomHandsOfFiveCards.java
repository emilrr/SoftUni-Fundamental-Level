import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class Class_06_RandomHandsOfFiveCards {
    public static void main(String[] args) {

        Random rand = new Random();
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter the number of hands you want:");
        int n = scanner.nextInt();

        String[] faces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        String[] suits = {"♣", "♦", "♥", "♠"};

        for (int i = 0; i < n; i++) {
            List<String> hand = new ArrayList<>();

            for (int j = 0; j < 5; j++) {
                String face = faces[rand.nextInt(faces.length)];
                String suit = suits[rand.nextInt(suits.length)];

                hand.add(face + suit);
            }

            for (String card : hand) {
                System.out.print(card + " ");
            }
            System.out.println();

        }
    }
}
