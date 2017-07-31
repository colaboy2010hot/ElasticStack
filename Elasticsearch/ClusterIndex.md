## [Elastic Stack](https://github.com/colaboy2010hot/ElasticStack/blob/master/README.md) > [Elasticsearch](https://github.com/colaboy2010hot/ElasticStack/blob/master/Elasticsearch/README.md) > 클러스터 및 인덱스

* Elasticsearch 형식
```
[REST Verb] /[Index]/[Type]/[ID]
```


* 클러스터 상태 조회
```
GET _cat/health?v
```
```
epoch      timestamp cluster       status node.total node.data shards pri relo init unassign pending_tasks max_task_wait_time active_shards_percent
1499876615 01:23:35  elasticsearch yellow          1         1      1   1    0    0        1             0                  -                 50.0%
```

* 노드 정보 조회
```
GET _cat/nodes?v
```
```
ip        heap.percent ram.percent cpu load_1m load_5m load_15m node.role master name
127.0.0.1           21          39   6                          mdi       *      COLABOY-NOTE
```

* 인덱스 목록 조회
```
GET _cat/indices?v
```
```
health status index   uuid                   pri rep docs.count docs.deleted store.size pri.store.size
yellow open   .kibana 0DLHQp3kTxqIhyJaCD2Xhw   1   1          1            0      3.1kb          3.1kb
```

* customer 인덱스 생성
```
PUT customer
```
```
{
  "acknowledged": true,
  "shards_acknowledged": true
}
```

* 인덱스 확인
```
GET _cat/indices?v
```
```
health status index    uuid                   pri rep docs.count docs.deleted store.size pri.store.size
yellow open   customer 4rVY5J7OSHmvbJHCSvnuUA   5   1          0            0       810b           810b
yellow open   .kibana  0DLHQp3kTxqIhyJaCD2Xhw   1   1          1            0      3.2kb          3.2kb
```

* customer 인덱스에 ID가 1인 external 타입을 색인
```
PUT /customer/external/1
{
  "name": "홍 길동"
}
```
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "1",
  "_version": 1,
  "result": "created",
  "_shards": {
    "total": 2,
    "successful": 1,
    "failed": 0
  },
  "created": true
}
```

* customer 인덱스에서 ID가 1인 external 타입의 문서 조회
```
GET customer/external/1
```
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "1",
  "_version": 1,
  "found": true,
  "_source": {
    "name": "홍 길동"
  }
}
```


* customer 인덱스 삭제
```
DELETE /customer
```
```
{
  "acknowledged": true
}
```

* 클러스터 복제 설정
```
POST /_cluster/reroute
{
    "commands" : [
        {
          "allocate_replica" : {
                "index" : "art_collection", "shard" : 0,
                "node" : "COLABOY-UBUNTU1"
          }
        }
    ]
}
```

* 샤드 상태 확인
```
GET /_cat/shards?v
```