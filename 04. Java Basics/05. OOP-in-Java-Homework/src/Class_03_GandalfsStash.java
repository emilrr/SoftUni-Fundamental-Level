import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Class_03_GandalfsStash {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int startPoints = Integer.parseInt(scanner.nextLine());
        String line = scanner.nextLine();

        String pat = "([A-Za-z]+)";
        Pattern pattern = Pattern.compile(pat);
        Matcher matcher = pattern.matcher(line);
        
        int sumOfPoints = startPoints;

        while (matcher.find()) {
            int point = calculatePointsOfHappiness(matcher.group().toLowerCase());
            sumOfPoints += point;
        }

        String gandalfMoods = findGandalfMoods(sumOfPoints);

        System.out.printf("%d\n%s", sumOfPoints, gandalfMoods);
        scanner.close();

    }

    private static int calculatePointsOfHappiness(String food) {
        switch (food) {
            case "cram":
                return 2;
            case "lembas":
                return 3;
            case "apple":
                return 1;
            case "melon":
                return 1;
            case "honeycake":
                return 5;
            case "mushrooms":
                return -10;
        }

        return -1;
    }

    private static String findGandalfMoods(int sumOfPoints) {

        if (sumOfPoints < -5) {
            return "Angry";
        } else if (sumOfPoints >= -5 && sumOfPoints < 0) {
            return "Sad";
        } else if (sumOfPoints >= 0 && sumOfPoints < 15) {
            return "Happy";
        }

        return "Special JavaScript mood";
    }
}
