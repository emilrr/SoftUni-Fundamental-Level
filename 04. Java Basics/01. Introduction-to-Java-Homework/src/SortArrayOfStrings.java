import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Scanner;

public class SortArrayOfStrings {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        int numberWords = input.nextInt();

        String[] array = new String[numberWords];
        for (int i = 0; i < numberWords; i++) {
            array[i] = input.next();
        }

        for (int i = 0; i < array.length - 1; i++) {
            for (int j = i + 1; j < array.length; j++) {
                int compare = array[i].compareTo(array[j]);
                if (compare > 0) {
                    String temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        System.out.println(String.join(", ", array));
    }
}
