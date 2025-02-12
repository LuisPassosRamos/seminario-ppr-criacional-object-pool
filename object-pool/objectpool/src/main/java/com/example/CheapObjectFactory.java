package com.example;

import com.example.interfaces.PooledObjectFactory;

public class CheapObjectFactory implements PooledObjectFactory<ExpensiveObject>{

    public CheapObjectFactory() {
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
