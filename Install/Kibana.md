## [Elastic Stack](https://github.com/colaboy2010hot/ElasticStack/blob/master/README.md) > [Elastic Stack 설치](https://github.com/colaboy2010hot/ElasticStack/blob/master/Install/README.md) > Kibana 설치

### Kibana 설치

* Elastic 디렉터리로 이동
```
cd ~/elastic
```
* Kibana 압축 파일 다운로드
```
wget https://artifacts.elastic.co/downloads/kibana/kibana-5.5.0-linux-x86_64.tar.gz
```
* 다운로드 한 Kibana 압축 파일 해제 
```
tar xvfz kibana-5.5.0-linux-x86_64.tar.gz
```
* 심볼릭 링크 설정
```
ln -s kibana-5.5.0-linux-x86_64 kibana
```

### Kibana 실행

* Kibana 디렉터리로 이동
```
cd ~/elastic/kibana
```
* Kibana 실행
```
bin/kibana
```
* Kibana 백그라운드 실행
```
nohup bin/kibana &
```

* Kibana 실행 확인
```
curl localhost:5601
```
```
<script>var hashRoute = '/app/kibana';
var defaultRoute = '/app/kibana';

var hash = window.location.hash;
if (hash.length) {
  window.location = hashRoute + hash;
} else {
  window.location = defaultRoute;
}</script>
```