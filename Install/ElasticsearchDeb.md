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

* 설치 경로 확인
```
colaboy@ubuntu1:~$ cd /usr/share/elasticsearch/
colaboy@ubuntu1:/usr/share/elasticsearch$ ll
total 228
drwxr-xr-x   6 root root   4096 Jul 22 00:58 ./
drwxr-xr-x 126 root root   4096 Jul 22 00:58 ../
drwxr-xr-x   2 root root   4096 Jul 22 00:58 bin/
drwxr-xr-x   2 root root   4096 Jul 22 00:58 lib/
drwxr-xr-x  13 root root   4096 Jul 22 00:58 modules/
-rw-r--r--   1 root root 194187 Jul  1 08:20 NOTICE.txt
drwxr-xr-x   2 root root   4096 Jul  1 08:20 plugins/
-rw-r--r--   1 root root   9548 Jul  1 08:20 README.textile

```
