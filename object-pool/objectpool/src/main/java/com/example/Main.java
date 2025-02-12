package com.example;

import java.time.Duration;
import java.time.Instant;

import com.example.implementations.simple.SimplePool;
import com.example.interfaces.PoolInterface;

public class Main {
    public static void main(String[] args) {
        Instant start = Instant.now();

        System.out.println("100 loop without pool");
        System.out.println("Start on " + start);

        for (int i = 0; i < 100; i++) {
            ExpensiveObject cheapObject = new ExpensiveObject();
            cheapObject.doSomething();
        }

        Instant end = Instant.now();
        System.out.println("End on " + end);
        System.out.println("Total time: " + Duration.between(start, end).toMillis() + " ms");

        System.err.println("====================================");

        System.out.println("100 loop with pool");
        start = Instant.now();
        System.out.println("Start on " + start);

        PoolInterface<ExpensiveObject> pool = new SimplePool<>(1, new ExpensiveObjectFactory());

        for (int i = 0; i < 100; i++) {
            ExpensiveObject cheapObject = pool.acquire();
            cheapObject.doSomething();
            pool.release(cheapObject);
        }
        
        end = Instant.now();
        System.out.println("End on " + end);
        System.out.println("Total time: " + Duration.between(start, end).toMillis() + " ms");
    }
}
