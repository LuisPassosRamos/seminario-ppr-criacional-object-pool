package com.example;

public class CheapObject {

    public CheapObject() {
        try {
            Thread.sleep(10);
        } catch (InterruptedException e) {
            System.out.println("erro");

        }
    }

    public void doSomething() {
        try {
            Thread.sleep(10);
        } catch (InterruptedException ex) {
            System.out.println("erro");
        }
    }

}
