package GetLabelModule;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Set<String> result = new HashSet<>();

        List<String> line = Arrays.stream(reader.readLine().split(","))
                .map(x -> x.substring(1,4))
                .distinct()
                .collect(Collectors.toList());

        System.out.println(line);


    }
}
