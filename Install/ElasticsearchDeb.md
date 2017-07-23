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


* 초기화 스크립트 파일 확인
```
sudo cat /etc/init.d/elasticsearch
```