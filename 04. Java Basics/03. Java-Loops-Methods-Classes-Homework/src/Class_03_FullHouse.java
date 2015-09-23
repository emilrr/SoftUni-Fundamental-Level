import java.util.Scanner;

public class Class_03_FullHouse {
    public static void main(String[] args) {

       Scanner scanner = new Scanner(System.in);

        String[] suits = {"\u2660", "\u2665", "\u2666", "\u2663"};
        String[] faces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        int countOfFullHouses = 0;

        for (int suit1 = 0; suit1 < suits.length; suit1++) {
            for (int suit2 = suit1 + 1; suit2 < suits.length; suit2++) {
                for (int suit3 = suit2 + 1; suit3 < suits.length; suit3++) {
                    for (int suit1Second = 0; suit1Second < suits.length; suit1Second++) {
                        for (int suit2Second = suit1Second + 1; suit2Second < suits.length; suit2Second++) {
                            for (int faceFirst = 0; faceFirst < faces.length; faceFirst++) {
                                for (int faceSecond = 0; faceSecond < faces.length; faceSecond++) {

                                    if (faceFirst != faceSecond) {
                                        String fullHouse = "(" + faces[faceFirst] + suits[suit1] + " " +
                                                faces[faceFirst] + suits[suit2] + " " +
                                                faces[faceFirst] + suits[suit3] + " " +
                                                faces[faceSecond] + suits[suit1Second] + " " +
                                                faces[faceSecond] + suits[suit2Second] + ")";

                                        System.out.println(fullHouse);
                                        countOfFullHouses++;
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
}
