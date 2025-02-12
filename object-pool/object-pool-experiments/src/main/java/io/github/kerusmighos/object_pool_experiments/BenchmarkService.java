package io.github.kerusmighos.object_pool_experiments;

import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Isolation;
import org.springframework.transaction.annotation.Transactional;

@Service
public class BenchmarkService {
    private BenchmarkRepository benchmarkRepository;

    public BenchmarkService(BenchmarkRepository benchmarkRepository) {
        this.benchmarkRepository = benchmarkRepository;
    }

    public Benchmark benchmarkQuery(Long id) {

        return benchmarkRepository.findById(id).orElse(null);
    }
}
