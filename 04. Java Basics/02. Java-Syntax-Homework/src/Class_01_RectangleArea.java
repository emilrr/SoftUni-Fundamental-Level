import java.util.Scanner;

/*
 * Write a program that enters the sides of a rectangle (two integers a and b)
 * and calculates and prints the rectangle's area.
 */

public class Class_01_RectangleArea {

    public static void main(String[] args) {

        Scanner console = new Scanner(System.in);
        System.out.print("Please enter the length and the width of the rectangle: ");
        int length = console.nextInt();
        int width = console.nextInt();
        //Integer.parseInt(console.next());

        int rectangleArea = calculateAreaRectangle(length, width);
        System.out.println("The area of a unit rectangle is " + rectangleArea);
    }

    private static int calculateAreaRectangle(int l, int w) {
        int area = l * w;
        return area;
    }
}