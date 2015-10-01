import java.util.Map;
import java.util.Scanner;
import java.util.SortedMap;
import java.util.TreeMap;

public class Problem_04_Weightlifting {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeMap<String, TreeMap<String, Long>> collector = new TreeMap<>();
        int n = Integer.parseInt(scanner.nextLine());

        while (n > 0) {
            String[] line = scanner.nextLine().split(" ");
            String player = line[0];
            String exercise = line[1];
            Long weight = Long.parseLong(line[2]);

            if (!collector.containsKey(player)) {
                collector.put(player, new TreeMap<>());
            }
            if (!collector.get(player).containsKey(exercise)) {
                collector.get(player).put(exercise, 0L);
            }

            long prevWeight = collector.get(player).get(exercise);
            collector.get(player).put(exercise, prevWeight + weight);

            n--;
        }

        printData(collector);

    }

    private static void printData(TreeMap<String, TreeMap<String, Long>> collector) {
        for (String player : collector.keySet()) {
            System.out.printf("%s : ", player);
            String ipOutput = "";
            for (String exercise : collector.get(player).keySet()) {
                ipOutput += String.format("%s - %d kg, ", exercise, collector.get(player).get(exercise));
            }
            ipOutput = ipOutput.substring(0, ipOutput.length() - 2) + ' ';
            System.out.println(ipOutput);
        }
    }
}
