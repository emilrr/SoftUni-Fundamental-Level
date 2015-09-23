import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;

public class Class_01_SortArrayOfNumbers {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();

        Integer array[] = new Integer[n];

        for (int i = 0; i < n; i++) {
            int number = scanner.nextInt();
            array[i] = number;
        }

        Arrays.sort(array, new Comparator<Integer>() {
            @Override
            public int compare(Integer x, Integer y) {
                return x - y;
            }
        });

        System.out.println(Arrays.toString(array));
        scanner.close();
    }
}
