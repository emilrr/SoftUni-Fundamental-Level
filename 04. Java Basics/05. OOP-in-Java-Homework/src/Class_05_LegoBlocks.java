import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Class_05_LegoBlocks {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numberRows = scanner.nextInt();
        scanner.nextLine();

        ArrayList<ArrayList<Integer>> firstMatrix = new ArrayList<ArrayList<Integer>>();
        ArrayList<ArrayList<Integer>> secondMatrix = new ArrayList<ArrayList<Integer>>();

        fillMatrix(scanner, numberRows, firstMatrix);
        fillMatrix(scanner,numberRows, secondMatrix);

        mergeMatrices(numberRows, firstMatrix, secondMatrix);

        boolean isRectangle = false;

        for (int i = 1; i < numberRows; i++) {
            int lenght = firstMatrix.get(0).size();

            if (firstMatrix.get(i).size() == lenght) {
                isRectangle = true;
            } else {
                isRectangle = false;
                break;
            }
        }

        if (isRectangle) {
            for (ArrayList<Integer> integers : firstMatrix) {
                System.out.println(integers);
            }
        } else {
            int counter = 0;

            for (ArrayList<Integer> integers : firstMatrix) {
                counter += integers.size();
            }
            System.out.printf("The total number of cells is: %d", counter);
        }
    }

    private static void fillMatrix(Scanner scanner, int numberRows, ArrayList<ArrayList<Integer>> matrix) {
        for (int i = 0; i < numberRows; i++) {
            matrix.add(new ArrayList<>());
            String[] lineArray = scanner.nextLine().trim().split("\\s+");
            for (String number : lineArray) {
                matrix.get(i).add(Integer.parseInt(number));
            }
        }
    }

    private static void mergeMatrices(int rows, ArrayList<ArrayList<Integer>> firstMatrix, ArrayList<ArrayList<Integer>> secondMatrix) {
        for (int i = 0; i < rows; i++) {
            Collections.reverse(secondMatrix.get(i));
            firstMatrix.get(i).addAll(secondMatrix.get(i));
        }
    }
}
