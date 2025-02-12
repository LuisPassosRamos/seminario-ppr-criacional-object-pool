package com.example.interfaces;

public interface  PoolInterface<T> {
    public abstract T acquire();
    public abstract void release(T t);

    public abstract void destroyAll();
}
