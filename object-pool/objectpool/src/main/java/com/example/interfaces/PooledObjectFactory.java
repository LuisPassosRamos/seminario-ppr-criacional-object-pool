package com.example.interfaces;

public interface  PooledObjectFactory<T> {
    public T create();
    public void destroy(T t);
}
