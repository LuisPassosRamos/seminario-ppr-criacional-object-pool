package com.example;

import com.example.interfaces.PooledObjectFactory;

public class ExpensiveObjectFactory implements PooledObjectFactory<ExpensiveObject>{

    public ExpensiveObjectFactory() {
    }

    @Override
    public ExpensiveObject create() {
        return new ExpensiveObject();
    }

	@Override
	public void destroy(ExpensiveObject obj) {
		// Implement the destroy method
	}
}
