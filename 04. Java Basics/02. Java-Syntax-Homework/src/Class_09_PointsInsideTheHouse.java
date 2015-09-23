import java.util.Locale;
import java.util.Scanner;

/*
 * Write a program to check whether a point is inside or outside the house below.
 * The point is given as a pair of floating-point numbers, separated by a space.
 * Your program should print "Inside" or "Outside".
 */

public class Class_09_PointsInsideTheHouse {
    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);

        double x = scanner.nextDouble();
        double y = scanner.nextDouble();
        boolean result = run(x, y);

        System.out.println(String.format("Is Point: %s, %s inside the figure? %s",x,y, result ? "Inside" : "Outside"));
    }

    public static boolean run(double x, double y){
        boolean inside = isInQuadrant(x, y) || isInRectangle(x, y) || isInTriangle(x, y);

        return inside;
    }

    private static boolean isInQuadrant(double x,double y){
        if (x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5) {
            return true;
        }

        return false;
    }

    private static boolean isInRectangle(double x,double y){
        if (x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5) {
            return true;
        }

        return false;
    }

    private static boolean isInTriangle(double x ,double y){
        double x1 = 12.5;
        double x2 = 8.5;
        double x3 = 22.5;
        double y1 = 8.5;
        double y2 = 17.5;
        double y3 = 3.5;

        double ABC = Math.abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        double ABP = Math.abs(x1 * (y2 - y) + x2 * (y - y1) + x * (y1 - y2));
        double APC = Math.abs(x1 * (y - y3) + x * (y3 - y1) + x3 * (y1 - y));
        double PBC = Math.abs(x * (y2 - y3) + x2 * (y3 - y) + x3 * (y - y2));

        if(ABP + APC + PBC == ABC){
            return true;
        }

        return false;
    }
}
