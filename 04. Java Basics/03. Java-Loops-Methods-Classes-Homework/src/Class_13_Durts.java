import java.util.Locale;
import java.util.Scanner;

public class Class_13_Durts {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int cX = scanner.nextInt();
        int cY = scanner.nextInt();
        int r = scanner.nextInt();
        int n = scanner.nextInt();

        for (int i = 0; i < n; i++) {
            int x = scanner.nextInt();
            int y = scanner.nextInt();

            if(isInTheFigure(x, y, cX, cY, r)){
                System.out.println("yes");
            }
            else{
                System.out.println("no");
            }
        }


    }

    public static boolean isInTheFigure(int x, int y, int cX, int cY, int r) {
        boolean inside = isInFirstRect(x, y, cX, cY, r) || isInSecondRect(x, y, cX, cY, r);

        return inside;
    }

    private static boolean isInFirstRect(int x, int y, int cX, int cY, int r) {
        if (x >= cX - r && x <= cX + r && y >= cY - (0.5 * r) && y <= cY + (0.5 * r)) {
            return true;
        }

        return false;
    }

    private static boolean isInSecondRect(int x, int y, int cX, int cY, int r) {
        if (x >= cX - (0.5 * r) && x <= cX + (0.5 * r) && y >= cY - r && y <= cY + r) {
            return true;
        }

        return false;
    }
}

