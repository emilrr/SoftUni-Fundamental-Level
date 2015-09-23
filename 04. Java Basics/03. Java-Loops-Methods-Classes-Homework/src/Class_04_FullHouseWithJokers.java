import java.util.ArrayList;

public class Class_04_FullHouseWithJokers {

    private static int countOfFullHouses = 0;

    public static void main(String[] args) {

        String[] suits = {"\u2660", "\u2665", "\u2666", "\u2663"};
        String[] faces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        for (int suit1 = 0; suit1 < suits.length; suit1++) {
            for (int suit2 = suit1 + 1; suit2 < suits.length; suit2++) {
                for (int suit3 = suit2 + 1; suit3 < suits.length; suit3++) {
                    for (int suit1Second = 0; suit1Second < suits.length; suit1Second++) {
                        for (int suit2Second = suit1Second + 1; suit2Second < suits.length; suit2Second++) {
                            for (int faceFirst = 0; faceFirst < faces.length; faceFirst++) {
                                for (int faceSecond = 0; faceSecond < faces.length; faceSecond++) {
                                    if (faceFirst != faceSecond) {
                                        String firstCard = faces[faceFirst] + suits[suit1];
                                        String secondCard = faces[faceFirst] + suits[suit2];
                                        String thirdCard = faces[faceFirst] + suits[suit3];
                                        String fourthCard = faces[faceSecond] + suits[suit1Second];
                                        String fifthCard = faces[faceSecond] + suits[suit2Second];

                                        String[] hand = {firstCard, secondCard, thirdCard, fourthCard, fifthCard};

                                        ArrayList<String> temporary = new ArrayList<>();
                                        findFullHouses(0, hand, temporary);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        System.out.println(countOfFullHouses);
    }

    private static void findFullHouses(int index, String[] hand, ArrayList<String> temporary) {

        System.out.print(String.join(" ", temporary));
        int n = 5 - temporary.size();
        for (int i = 0; i < n; i++) {
            System.out.print("  * ");
        }
        countOfFullHouses++;
        System.out.println();
        for (int i = index; i < 5; i++) {
            temporary.add(hand[i]);
            findFullHouses(i + 1, hand, temporary);
            temporary.remove(temporary.size() - 1);
        }
    }
}
