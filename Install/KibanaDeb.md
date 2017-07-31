## [Elastic Stack](https://github.com/colaboy2010hot/ElasticStack/blob/master/README.md) > [Elastic Stack 설치](https://github.com/colaboy2010hot/ElasticStack/blob/master/Install/README.md) > Kibana(Debian package) 설치

### Kibana 설치

 * Elastic 디렉터리로 이동
```
cd ~/elastic
```

* 패키지 색인 업데이트
```
sudo apt-get update
```

* Kibana 5.5.0 다운로드
```
wget https://artifacts.elastic.co/downloads/kibana/kibana-5.5.0-amd64.deb
```

* Kibana 5.5.0 패키지 설치
```
sudo dpkg -i kibana-5.5.0-amd64.deb
```

* kibana.yml 설정 (ubuntu)
```
sudo vi /etc/kibana/kibana.yml
```