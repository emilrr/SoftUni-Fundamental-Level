import java.util.Locale;
import java.util.Scanner;

public class Class_05_AngleUnitConverter {
    public static void main(String[] args) {

        Locale.setDefault(Locale.ROOT);
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        for (int i = 0; i < n; i++) {
            double radiansOrDegrees = sc.nextDouble();
            String measure = sc.next().trim();

            if(measure.equals("deg")){
                convertDegreesToRadians(radiansOrDegrees);
            }
            else{
                convertRadiansToDegrees(radiansOrDegrees);
            }
        }
    }

    private static void convertRadiansToDegrees(double radiansOrDegrees) {
        double degrees = radiansOrDegrees * ( 180 / Math.PI);
        System.out.printf("%.6f deg", degrees);
        System.out.println();
    }

    private static void convertDegreesToRadians(double radiansOrDegrees) {
        double radias = radiansOrDegrees * (Math.PI / 180);
        System.out.printf("%.6f rad", radias);
        System.out.println();
    }
}
