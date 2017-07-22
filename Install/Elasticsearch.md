## [Elastic Stack](https://github.com/colaboy2010/ElasticStack/blob/master/README.md) > [Elastic Stack 설치](https://github.com/colaboy2010/ElasticStack/blob/master/Install/README.md) > Elasticsearch 설치

### Elasticsearch 설치

* Elastic 디렉터리 생성
```
mkdir ~/elastic
```
 * Elastic 디렉터리로 이동
```
cd ~/elastic
```
* Elasticsearch 압축 파일 다운로드
```
wget https://artifacts.elastic.co/downloads/elasticsearch/elasticsearch-5.5.0.tar.gz
```
* 다운로드 한 Elasticsearch 압축 파일 해제 
```
tar xvfz elasticsearch-5.5.0.tar.gz
```

* 심볼릭 링크 설정
```
ln -s elasticsearch-5.5.0 elasticsearch
```

### Elasticsearch 실행

* Elasticsearch 디렉터리로 이동
```
cd ~/elastic/elasticsearch
```
* 데몬 모드로 실행
* 옵션 -d를 빼면 터미널 접속해 있는 동안만 실행
```
bin/elasticsearch -d
```
* 실행 확인
```
curl localhost:9200
```
```
{
  "name" : "SceohFr",
  "cluster_name" : "elasticsearch",
  "cluster_uuid" : "dgfoOEEcRmCj91cHb_PXwQ",
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