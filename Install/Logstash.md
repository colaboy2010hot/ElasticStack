## [Elastic Stack](https://github.com/colaboy2010hot/ElasticStack/blob/master/README.md) > [Elastic Stack 설치](https://github.com/colaboy2010hot/ElasticStack/blob/master/Install/README.md) > Logstash 설치

### Logstash 설치

* Elastic 디렉터리로 이동
```
cd ~/elastic
```

* Logstash 압축 파일 다운로드
```
wget https://artifacts.elastic.co/downloads/logstash/logstash-5.5.0.tar.gz
```

* 다운로드 한 Logstash 압축 파일 해제 
```
tar xvfz logstash-5.5.0.tar.gz
```

* 심볼릭 링크 설정
```
ln -s logstash-5.5.0 logstash
```

### Logstash 로그 수집 설정

* Logstash 디렉터리로 이동
```
cd ~/elastic/logstash
```

* Logstash 로그 수집 설정 디렉터리 생성
```
mkdir logconf
```

* Logstash 로그 수집 설정 파일 생성 (nginx 접속 로그를 elasticsearch로 수집)
```
vi logconf/nginx.conf
```
```
input {
    file {
        path => "/var/log/nginx/access.log"
        start_position => beginning
    }
}
filter {
    grok {
        match => { "message" => "%{COMBINEDAPACHELOG}"}
    }
    geoip {
        source => "clientip"
    }
}
output {
    elasticsearch {}
}
```

* Logstash 로그 수집 설정 파일 테스트
```
bin/logstash -f logconf/nginx.conf -t
```

### Logstash 실행

* Logstash 디렉터리로 이동
```
cd ~/elastic/logstash
```
* Logstash 실행
```
bin/logstash -f logconf/nginx.conf
```

* Logstash 백그라운드 실행
```
nohup bin/logstash -f logconf/nginx.conf &
```


