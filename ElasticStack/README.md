## [Elastic Stack](https://github.com/colaboy2010/ElasticStack/blob/master/README.md) > Elastic Stack 개요

### ELK
* Elasticsearch + Logstash + Kibana
* Elasticsearch: 검색 엔진
* Logstash: 데이터 수집기
* Kibana: 시각화 도구

### Elastic Stack 
* Elasticsearch + Logstash + Kibana + Beats
* Beats: 데이터 수집 에이전트


### Elasticsearch
* 분산 시스템으로서 수평적인 확장성, 최고의 안정성 및 간편한 관리를 위해 설계된 JSON문서 기반의 검색 및 분석 엔진
* 데이터 검색
*  분석 및 저장 
* Apache Lucene 기반의 실시간 분산 검색 엔진

### Kibana
* 데이터를 시각화하고 Elastic Stack의 모든 기능을 구성 및 관리할 수 있는 확장 가능한 UI 도구
* 전체 Elastic Stack 탐색

### Logstash
* 확장 가능한 플러그인 에코시스템으로 구성된 동적 데이터 수집 파이프라인
* JRuby 만들어 짐
* Ruby가 Java로 Wrapping되어 무겁다
* 설정은 Ruby 포맷


### Beats
* 단말 장치의 데이터를 Logstash 및 Elasticsearch로 전송하는 경량 수집기용 플랫폼
* 독립적인 데이터 수집 에이전트
* Go로 만들어 짐


### elastic 사이트 
* [elastic](https://www.elastic.co/)

### Logstash 패턴
* https://github.com/logstash-plugins/logstash-patterns-core
---  
  
### 참고
#### GA: Google Analytics
* Javascript 기반
* API Gateway에서 사용할 수 없다.

#### DataViz: 넷플릭스에서 유행하는 단어 Data Visualization

#### 구글 트랜드 비교

* [Elasticsearch vs Apache Solr](https://trends.google.co.kr/trends/explore?q=elasticsearch,solr)

* [ELK Stack vs Splunk](https://trends.google.co.kr/trends/explore?date=all&q=elk%20stack,splunk)

* [ELK Stack vs Splunk vs Elasticsearch](https://trends.google.co.kr/trends/explore?date=all&q=elk%20stack,splunk,elasticsearch)
