package com.example;

import com.example.interfaces.PooledObjectFactory;

public class CheapObjectFactory implements PooledObjectFactory<CheapObject>{

    public CheapObjectFactory() {
    }

    @Override
    public CheapObject create() {
        return new CheapObject();
    }

	@Override
	public void destroy(CheapObject obj) {
		// Implement the destroy method
	}
}
