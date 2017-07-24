## [Elastic Stack](https://github.com/colaboy2010hot/ElasticStack/blob/master/README.md) > [Elastic Stack 설치](https://github.com/colaboy2010hot/ElasticStack/blob/master/Install/README.md) > Elasticsearch(Debian package) 설치

### Elasticsearch 설치

 * Elastic 디렉터리로 이동
```
cd ~/elastic
```

* 패키지 색인 업데이트
```
sudo apt-get update
```

* Elasticsearch 5.5.0 다운로드
```
wget https://artifacts.elastic.co/downloads/elasticsearch/elasticsearch-5.5.0.deb
```

* Elasticsearch 5.5.0 패키지 설치
```
sudo dpkg -i elasticsearch-5.5.0.deb
```

* 사용자 소속 그룹 확인
```
groups
```
```
colaboy adm cdrom sudo dip plugdev lxd lpadmin sambashare
```
* elasticsearch 그룹에 사용자 추가 
```
sudo usermod -a -G elasticsearch colaboy
exit
```
* 사용자 소속 그룹 재확인
```
groups
```
```
colaboy adm cdrom sudo dip plugdev lxd lpadmin sambashare elasticsearch
```

* Elasticsearch 주요 위치 및 파일
```
설치 디렉터리: /usr/share/elasticsearch/
설정 디렉터리: /etc/elasticsearch
초기화 스크립트 파일: /etc/init.d/elasticsearch.
```

* 설치 디렉터리 확인
```
cd /usr/share/elasticsearch/
ll
```
```
total 228
drwxr-xr-x   6 root root   4096 Jul 23 16:07 ./
drwxr-xr-x 110 root root   4096 Jul 23 16:07 ../
drwxr-xr-x   2 root root   4096 Jul 23 16:07 bin/
drwxr-xr-x   2 root root   4096 Jul 23 16:07 lib/
drwxr-xr-x  13 root root   4096 Jul 23 16:07 modules/
-rw-r--r--   1 root root 194187 Jul  1 08:20 NOTICE.txt
drwxr-xr-x   2 root root   4096 Jul  1 08:20 plugins/
-rw-r--r--   1 root root   9548 Jul  1 08:20 README.textile
```

* 설정 디렉터리 확인
```
cd /etc/elasticsearch
ll
```
```
total 28
drwxr-x---  3 root elasticsearch 4096 Jul 23 16:07 ./
drwxr-xr-x 90 root root          4096 Jul 23 16:14 ../
-rw-rw----  1 root elasticsearch 2854 Jul  1 08:20 elasticsearch.yml
-rw-rw----  1 root elasticsearch 3117 Jul  1 08:20 jvm.options
-rw-rw----  1 root elasticsearch 4456 Jul  1 08:20 log4j2.properties
drwxr-x---  2 root elasticsearch 4096 Jul  1 08:20 scripts/
```

* 서비스 초기화 스크립트 파일 확인
```
sudo cat /etc/init.d/elasticsearch
```

* 서비스 자동 실행 설정
```
sudo systemctl enable elasticsearch.service
```

* 서비스 재시작
```
sudo systemctl restart elasticsearch.service
```

* 서비스 상태 확인
```
sudo systemctl status elasticsearch.service
```
```
● elasticsearch.service - Elasticsearch
   Loaded: loaded (/usr/lib/systemd/system/elasticsearch.service; enabled; vendor preset: enabled)
   Active: active (running) since Sun 2017-07-23 16:38:12 KST; 8s ago
     Docs: http://www.elastic.co
  Process: 3530 ExecStartPre=/usr/share/elasticsearch/bin/elasticsearch-systemd-pre-exec (code=exited, status=0/SUCCESS)
 Main PID: 3534 (java)
    Tasks: 37
   Memory: 1.9G
      CPU: 10.683s
   CGroup: /system.slice/elasticsearch.service
           └─3534 /usr/bin/java -Xms2g -Xmx2g -XX:+UseConcMarkSweepGC -XX:CMSInitiatingOccupancyFraction=75 -XX:+UseCMSInitiatingOccupancyOnly -XX:+Di

Jul 23 16:38:12 ubuntu1 systemd[1]: Starting Elasticsearch...
Jul 23 16:38:12 ubuntu1 systemd[1]: Started Elasticsearch.
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

변수명       | 명칭              | 설명   
------------ | ----------------- | ---------  
node.name    | 노드(서버) 이름   | 기본값은 Droplet 호스트명으로 자동으로 설정
cluster.name | 클러스터 이름     | 기본값은 "elasticsearch", 클러스터 이름이 같으면 노드들이 동일한 클러스터로 구성된다.
node.master  | 마스터 노드 여부  |                        


* elasticsearch.yml 설정
```
sudo vi elasticsearch.yml
```
```
cluster.name: elasticsearch-colaboy
node.name: colaboy-node-1
node.master: true
```

* 서비스 재시작
```
systemctl restart elasticsearch.service
```

* 서비스 확인
```
curl localhost:9200
```
```
{
  "name" : "colaboy-node-1",
  "cluster_name" : "elasticsearch-colaboy",
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
