package io.github.kerusmighos.object_pool_experiments;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.zaxxer.hikari.HikariDataSource;

@RestController
@RequestMapping("/benchmark")
public class BenchmarkController {

    @Autowired
    private HikariDataSource dataSource;
    
    @Autowired
    private BenchmarkService benchmarkService;

    @GetMapping
    public ResponseEntity<Void> benchmark() {
        benchmarkService.benchmarkQuery(Long.valueOf('1'));
        return ResponseEntity.ok().build();
    }
}