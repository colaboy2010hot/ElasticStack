﻿## [Elastic Stack](https://github.com/colaboy2010hot/ElasticStack/blob/master/README.md) > [Elastic Stack 설치](https://github.com/colaboy2010hot/ElasticStack/blob/master/Install/README.md) > Elasticsearch(Debian package) 설치

### [Install Elasticsearch with Debian Package](https://www.elastic.co/guide/en/elasticsearch/reference/5.5/deb.html)


* 관리자 권한 전환 및 다운로드 디렉터리 생성
```
sudo su
cd /
mkdir elastic
cd /elastic
```

* Elasticsearch 5.5.0 다운로드
```
wget https://artifacts.elastic.co/downloads/elasticsearch/elasticsearch-5.5.0.deb
```

* Elasticsearch 5.5.0 패키지 설치
```
sudo dpkg -i elasticsearch-5.5.0.deb
```

### systemd 설정

* 부팅 시 자동 시작 설정
```
sudo systemctl daemon-reload
sudo systemctl enable elasticsearch.service
```

* 서비스 시작, 정지, 재시작
```
sudo systemctl start elasticsearch.service
sudo systemctl stop elasticsearch.service
sudo systemctl restart elasticsearch.service
```

* Elasticsearch 실행 확인
```
curl localhost:9200
```
```
{
  "name" : "3HPjWHY",
  "cluster_name" : "elasticsearch",
  "cluster_uuid" : "NbDRS5OKQBmDrkdGfSWgig",
  "version" : {
    "number" : "5.5.0",
    "build_hash" : "260387d",
    "build_date" : "2017-06-30T23:16:05.735Z",
    "build_snapshot" : false,
    "lucene_version" : "6.6.0"
  },
  "tagline" : "You Know, for Search"
}
```

### Elasticsearch 설정

* 설정 디렉터리 이동
```
cd /etc/elasticsearch
```

* Elasticsearch 서버 설정 파일 확인 - 로깅 옵션을 제외한 모든 옵션이 저장된다.
```
cat elasticsearch.yml
```

* 로깅 설정 파일 확인 - 기본 로깅 옵션을 사용하는 경우에는 파일이 존재하지 않는다.
```
cat logging.yml
```

* 로그 파일 디렉터리 확인
```
cd /var/log/elasticsearch
ll
```
```
total 16
drwxr-x--- 2 elasticsearch elasticsearch 4096 Jul 24 23:30 ./
drwxrwxr-x 9 root          syslog        4096 Jul 23 16:07 ../
-rw-r--r-- 1 elasticsearch elasticsearch 3913 Jul 23 18:22 elasticsearch-2017-07-23.log
-rw-r--r-- 1 elasticsearch elasticsearch    0 Jul 23 16:38 elasticsearch_deprecation.log
-rw-r--r-- 1 elasticsearch elasticsearch    0 Jul 23 16:38 elasticsearch_index_indexing_slowlog.log
-rw-r--r-- 1 elasticsearch elasticsearch    0 Jul 23 16:38 elasticsearch_index_search_slowlog.log
-rw-r--r-- 1 elasticsearch elasticsearch 3725 Jul 24 23:31 elasticsearch.log

```

* elasticsearch.yml 변수 

변수명                    | 명칭                  | 설명   
------------------------- | --------------------- | ----------------------------
cluster.name              | 클러스터 이름         | 기본값은 elasticsearch<br/>클러스터 이름이 같으면 노드들이 동일한 클러스터로 구성된다.
node.name                 | 노드(서버)<br/>이름   | 기본값은 Droplet 호스트명으로 자동으로 설정
node.master               | 마스터 노드<br/>여부  | 기본값은 true<br/>마스터 서버는 클러스터 상태 및 안정성을 담당한다. <br/>많은 클러스터 노드가 있는 대규모 배포에서는 둘 이상의 전용 마스터를<br/>사용하는 것이 좋다.<br/>일반적으로 전용 마스터는 데이터를 저장하거나 인덱스를 만들지 않고,<br/>클러스터의 성능을 위험에 빠뜨릴 수 있는 과부하가 없어야 한다.<br/>슬레이브 서버는 데이터 작업을 로드 할 수 있는 작업 도구로 사용된다.<br/>슬레이브 노드도 추가 노드를 수행할 다른 노드가 있다면, 과부하가<br/>없어야 한다.
node.data                 | 데이터 저장<br/>여부  | 기본값은 true<br/>데이터를 저장하지 않는 경우는 전용 마스터 인 경우와 노드에서 데이터를<br/>가져와 결과를 집계하는 데에만 사용되는 경우다.<br/>후자의 경우는 검색 부하 분산 장치로 작동한다.

* elasticsearch.yml 설정 (ubuntu)
```
sudo vi /etc/elasticsearch/elasticsearch.yml
```
```
cluster.name: elasticsearch
node.name: ubuntu1
bootstrap.memory_lock: true
network.host: 10.0.75.111
discovery.zen.ping.unicast.hosts: ["10.0.75.112"]
```

* systemd 설정
```
sudo vi /usr/lib/systemd/system/elasticsearch.service
```
```
LimitMEMLOCK=infinity
```

* 방화벽 설정
```
sudo ufw enable
sudo ufw allow 9200/tcp
sudo ufw allow 9300/tcp
```

* 서비스 재시작
```
sudo systemctl daemon-reload
sudo systemctl restart elasticsearch
```

* 서비스 확인
```
curl 10.0.75.111:9200
```
```
{
  "name" : "ubuntu1",
  "cluster_name" : "elasticsearch",
  "cluster_uuid" : "cLfZ-ylGR7KJc02Aj5vITQ",
  "version" : {
    "number" : "5.5.0",
    "build_hash" : "260387d",
    "build_date" : "2017-06-30T23:16:05.735Z",
    "build_snapshot" : false,
    "lucene_version" : "6.6.0"
  },
  "tagline" : "You Know, for Search"
}

```
