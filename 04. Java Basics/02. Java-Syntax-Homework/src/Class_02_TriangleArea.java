import java.util.Locale;
import java.util.Scanner;

/*
 * Write a program that enters 3 points in the plane (as integer x and y coordinates),
 * calculates and prints the area of the triangle composed by these 3 points.
 * Round the result to a whole number. In case the three points do not form a triangle,
 * print "0" as result.
 */

public class Class_02_TriangleArea {

    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);

        Scanner scanner = new Scanner(System.in);

        int aX = scanner.nextInt();
        int aY = scanner.nextInt();
        int bX = scanner.nextInt();
        int bY = scanner.nextInt();
        int cX = scanner.nextInt();
        int cY = scanner.nextInt();
        int area = calculateAreaTriangle(aX, aY, bX, bY, cX, cY);
        System.out.println("The area of a unit triangle is " + area);

    }
    private static int calculateAreaTriangle(int aX, int aY, int bX, int bY, int cX, int cY) {
        int area = Math.abs((aX*(bY - cY) + bX*(cY - aY) + cX*(aY - bY))/2);
        return area;
    }
}
