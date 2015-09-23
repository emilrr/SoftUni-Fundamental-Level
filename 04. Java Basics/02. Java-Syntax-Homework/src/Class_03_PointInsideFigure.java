import java.text.NumberFormat;
import java.util.Locale;
import java.util.Scanner;

/*
 * Write a program to check whether a point is inside or outside of the figure below.
 * The point is given as a pair of floating-point numbers, separated by a space.
 * Your program should print "Inside" or "Outside".
 */

public class Class_03_PointInsideFigure {

    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        Scanner scanner = new Scanner(System.in);

        double x = scanner.nextDouble();
        double y = scanner.nextDouble();
        boolean result = run(x, y);

        System.out.println(String.format("Is Point: %s, %s inside the figure? %s",x,y, result ? "Inside" : "Outside"));
    }

    public static boolean run(double x, double y){
        boolean inside = isInFirstRect(x, y) || isInSecondRect(x, y) || isInThirdRect(x, y);

      return inside;
    }

    private static boolean isInFirstRect(double x,double y){
        if (x >= 12.5 && x <= 22.5d && y >= 6 && y <= 8.5) {
            return true;
        }

        return false;
    }

    private static boolean isInSecondRect(double x,double y){
        if (x >= 12.5 && x <= 17.5 && y >= 8.5 && y <= 13.5) {
            return true;
        }

        return false;
    }

    private static boolean isInThirdRect(double x,double y){
        if (x >= 20 && x <= 22.5 && y >= 8.5 && y <= 13.5) {
            return true;
        }

        return false;
    }
}
