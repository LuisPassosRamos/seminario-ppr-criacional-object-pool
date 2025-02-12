package com.example;

import com.example.implementations.simple.SimplePool;
import com.example.interfaces.PoolInterface;

public class Main {
    public static void main(String[] args) {
        Long start = System.currentTimeMillis();

        System.out.println("100 loop without pool");

        System.out.println("Start on " + System.currentTimeMillis());

        for (int i = 0; i < 100; i++) {
            CheapObject cheapObject = new CheapObject();
            cheapObject.doSomething();
        }

        System.out.println("End on " + System.currentTimeMillis());
        System.out.println("Total time: " + (System.currentTimeMillis() - start));

        System.err.println("====================================");

        System.out.println("100 loop with pool");
        start = System.currentTimeMillis();
        System.out.println("Start on " + System.currentTimeMillis());

        PoolInterface<CheapObject> pool = new SimplePool<CheapObject>(1, new CheapObjectFactory());

        for (int i = 0; i < 100; i++) {
            CheapObject cheapObject = pool.acquire();
            cheapObject.doSomething();
            pool.release(cheapObject);
        }
        
        System.out.println("End on " + System.currentTimeMillis());
        System.out.println("Total time: " + (System.currentTimeMillis() - start));
    } 
}