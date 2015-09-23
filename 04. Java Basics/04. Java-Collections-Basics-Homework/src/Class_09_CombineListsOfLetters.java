import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.concurrent.ScheduledExecutorService;

public class Class_09_CombineListsOfLetters {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        char[] charArrayFirstLine = scanner.nextLine().replace(" ","").toCharArray();
        List<Character> listOfFirstLine = new ArrayList<Character>();
        for (char c : charArrayFirstLine) {
            listOfFirstLine.add(c);
        }

        char[] charArraySecondLine = scanner.nextLine().replace(" ","").toCharArray();
        ArrayList<Character> listOfSecondLine = new ArrayList<Character>();
        for (char c : charArraySecondLine) {
            listOfSecondLine.add(c);
        }

        listOfSecondLine.removeAll(listOfFirstLine);

        listOfFirstLine.addAll(listOfSecondLine);
        System.out.println(listOfFirstLine);
        scanner.close();
    }
}
