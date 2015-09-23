import java.util.ArrayList;
import java.util.Scanner;

public class Class_10_ExtractAllUniqueWords {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        String array[] = scanner.nextLine().split("[\\W]+");
        ArrayList<String> text = new ArrayList<String>();
        String firstWordInArray = array[0].toLowerCase();
        text.add(firstWordInArray);

        for (int i = 1; i < array.length; i++) {
            String word = array[i].toLowerCase();
            if(!text.contains(word)){
                text.add(word);
            }
        }

        java.util.Collections.sort(text);

        System.out.println(text);
    }
}
