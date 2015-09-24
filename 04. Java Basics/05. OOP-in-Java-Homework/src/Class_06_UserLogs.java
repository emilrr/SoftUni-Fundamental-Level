import java.util.Scanner;
import java.util.TreeMap;

public class Class_06_UserLogs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeMap<String, TreeMap<String, Integer>> logs = new TreeMap<>();

        String input = scanner.nextLine();
        while (!input.equals("end")) {
            String[] array = input.split("([a-zA-z]+\\=)");

            String ip = array[1].trim();
            String user = array[3].trim();
            int count = 1;

            insertData(logs, ip, user, count);

            input = scanner.nextLine();
        }

        printData(logs);
    }

    private static void insertData(TreeMap<String, TreeMap<String, Integer>> logs, String ip, String user, int count) {
        if (!logs.containsKey(user)) {
            logs.put(user, new TreeMap<>());
        }

        if (!logs.get(user).containsKey(ip)) {
            logs.get(user).put(ip, 0);
        }

        Integer prevLog = logs.get(user).get(ip);
        logs.get(user).put(ip, prevLog + count);
    }

    private static void printData(TreeMap<String, TreeMap<String, Integer>> logs) {
        for (String user : logs.keySet()) {
            System.out.printf("%s: \n", user);
            String ipOutput = "";
            for (String ip : logs.get(user).keySet()) {
                ipOutput += String.format("%s => %d, ", ip, logs.get(user).get(ip));
            }
            ipOutput = ipOutput.substring(0, ipOutput.length() - 2) + '.';
            System.out.println(ipOutput);
        }
    }
}
