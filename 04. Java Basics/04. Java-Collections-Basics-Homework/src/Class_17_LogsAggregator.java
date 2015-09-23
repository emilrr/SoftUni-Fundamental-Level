import java.util.Scanner;
import java.util.TreeMap;

public class Class_17_LogsAggregator {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, TreeMap<String, Integer>> logs = new TreeMap<>();
        int n = scanner.nextInt();
        scanner.nextLine();

        for (int line = 0; line < n; line++) {
            String[] input = scanner.nextLine().split(" ");
            String IP = input[0];
            String user = input[1];
            int duration = Integer.parseInt(input[2]);

            if (!logs.containsKey(user)) {
                logs.put(user, new TreeMap<>());
            }

            if (!logs.get(user).containsKey(IP)) {
                logs.get(user).put(IP, 0);
            }

            Integer prevDuration = logs.get(user).get(IP);
            logs.get(user).put(IP, prevDuration + duration);

        }

        for (String user : logs.keySet()) {
            System.out.printf("%s: %d %s\n",
                    user,
                    logs.get(user).values().stream().mapToInt(Integer::intValue).sum(),
                    logs.get(user).keySet());
        }
    }
}
