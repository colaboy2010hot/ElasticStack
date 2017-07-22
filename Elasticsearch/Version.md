## [Elastic Stack](https://github.com/colaboy2010/ElasticStack/blob/master/README.md) > [Elasticsearch](https://github.com/colaboy2010/ElasticStack/blob/master/Elasticsearch/README.md) > 문서 버전

* ID가 1인 문서 색인 
```
PUT /customer/external/1
{
  "name": "홍길동"
}
```

* version: 1, result: created, created: true
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

* ID가 1인 문서 조회
```
GET customer/external/1
```
* version 1 
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "1",
  "_version": 1,
  "found": true,
  "_source": {
    "name": "홍길동"
  }
}
```

* ID가 1인 문서 색인 
```
PUT /customer/external/1
{
  "name": "홍길동"
}
```
* version: 2, result: updated, created: false
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "1",
  "_version": 2,
  "result": "updated",
  "_shards": {
    "total": 2,
    "successful": 1,
    "failed": 0
  },
  "created": false
}
```

* ID가 1인 문서 조회
```
GET customer/external/1
```
* version 2 
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "1",
  "_version": 2,
  "found": true,
  "_source": {
    "name": "홍길동"
  }
}
```

* ID가 1인 문서 색인 
```
PUT /customer/external/1
{
  "name": "이순신"
}
```
* version: 3, result: updated, created: false
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "1",
  "_version": 3,
  "result": "updated",
  "_shards": {
    "total": 2,
    "successful": 1,
    "failed": 0
  },
  "created": false
}
```
* ID가 1인 문서 조회
```
GET customer/external/1
```
* version 3 
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "1",
  "_version": 3,
  "found": true,
  "_source": {
    "name": "이순신"
  }
}
```

* ID를 입력하지 않고 색인 (POST)
```
POST /customer/external
{
  "name": "김유신"
}
```
* ID가 자동으로 부여된다. (ID: AV08ZshZcHbctci0gPfV)
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "AV08ZshZcHbctci0gPfV",
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

* ID가 AV08ZshZcHbctci0gPfV 인 문서 조회
```
GET customer/external/AV08ZshZcHbctci0gPfV
```
```
{
  "_index": "customer",
  "_type": "external",
  "_id": "AV08ZshZcHbctci0gPfV",
  "_version": 1,
  "found": true,
  "_source": {
    "name": "김유신"
  }
}
```