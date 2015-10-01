import java.util.Scanner;

public class Problem_03_FireTheArrows {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);

        int n = Integer.parseInt(scn.nextLine());
        char[][] matrix = new char[n][];

        for (int i = 0; i < n; i++) {
            matrix[i] = scn.nextLine().toCharArray();
        }

        while (n> 0) {
            for (int row = 0; row < matrix.length; row++) {
                for (int col = 0; col < matrix[row].length; col++) {
                    char currentChar = matrix[row][col];

                    if (currentChar == '>') {
                        if (col + 1 <= matrix[row].length - 1 &&
                                matrix[row][col + 1] == 'o') {
                            matrix[row][col] = 'o';
                            matrix[row][col + 1] = '>';
                        }

                    } else if (currentChar == '<') {
                        if (col - 1 >= 0 &&
                                matrix[row][col - 1] == 'o') {
                            matrix[row][col] = 'o';
                            matrix[row][col - 1] = '<';
                        }
                    } else if (currentChar == 'v') {
                        if (row + 1 <= matrix.length - 1 &&
                                matrix[row + 1][col] == 'o') {
                            matrix[row][col] = 'o';
                            matrix[row + 1][col] = 'v';
                        }

                    } else if (currentChar == '^') {
                        if (row - 1 >= 0 &&
                                matrix[row - 1][col] == 'o') {
                            matrix[row][col] = 'o';
                            matrix[row - 1][col] = '^';
                        }
                    }
                }
            }
             n--;
        }

        printMatrix(matrix);

    }

    private static void printMatrix(char[][] matrix) {
        for (char[] chars : matrix) {
            for (char aChar : chars) {
                System.out.print(aChar);
            }
            System.out.println();
        }
    }
}
