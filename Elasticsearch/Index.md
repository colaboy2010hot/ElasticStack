# Index

#### 자동 인덱스 생성
```
PUT /get-together/new-events/1
{
  "name": "Late Night with Elasticsearch",
  "date": "2013-10-25T19:00"
}
```

* 매핑 조회
```
GET /get-together/_mapping/new-events
```
* 자동으로 "keyword" 타입의 확장 필드가 추가된다.
```
{
  "get-together": {
    "mappings": {
      "new-events": {
        "properties": {
          "date": {
            "type": "date"
          },
          "name": {
            "type": "text",
            "fields": {
              "keyword": {
                "type": "keyword",
                "ignore_above": 256
              }
            }
          }
        }
      }
    }
  }
}
```

#### 다중 필드의 정렬을 이용한 검색
```
GET /get-together/new-events/_search
{
    "sort" : [
        { "name.keyword" : {"order" : "asc"}},
        "_score"
    ],
    "query" : {
        "term" : { "name" : "late" }
    }
}
```
```
{
  "took": 3,
  "timed_out": false,
  "_shards": {
    "total": 5,
    "successful": 5,
    "failed": 0
  },
  "hits": {
    "total": 1,
    "max_score": null,
    "hits": [
      {
        "_index": "get-together",
        "_type": "new-events",
        "_id": "1",
        "_score": 0.2876821,
        "_source": {
          "name": "Late Night with Elasticsearch",
          "date": "2013-10-25T19:00"
        },
        "sort": [
          "Late Night with Elasticsearch",
          0.2876821
        ]
      }
    ]
  }
}
```

#### 매핑 추가
```
PUT /get-together/_mapping/new-events
{
  "new-events" : {
    "properties" : {
      "host": {
        "type" : "text"
      }
    }
  }
}
```
```
GET /get-together/_mapping/new-events
```
```
{
  "get-together": {
    "mappings": {
      "new-events": {
        "properties": {
          "date": {
            "type": "date"
          },
          "host": {
            "type": "text"
          },
          "name": {
            "type": "text",
            "fields": {
              "keyword": {
                "type": "keyword",
                "ignore_above": 256
              }
            }
          }
        }
      }
    }
  }
}
```

#### 기존 매핑의 타입 수정

* long 타입으로 수정
```
PUT /get-together/_mapping/new-events
{
  "new-events" : {
    "properties" : {
      "host": {
        "type" : "long"
      }
    }
  }
} 
```
* 타입 수정 불가
```
{
  "error": {
    "root_cause": [
      {
        "type": "illegal_argument_exception",
        "reason": "mapper [host] of different type, current_type [text], merged_type [long]"
      }
    ],
    "type": "illegal_argument_exception",
    "reason": "mapper [host] of different type, current_type [text], merged_type [long]"
  },
  "status": 400
}
```

* 인텍스를 사용하지 않는 필드 매핑 추가
```
PUT /get-together/_mapping/new-events
{
  "new-events" : {
    "properties" : {
      "title": {
        "type" : "text",
        "index" : false
      }
    }
  }
```
* 문서 추가
```
PUT /get-together/new-events/2
{
  "name": "Late Night with Elasticsearch 2",
  "date": "2013-10-26T19:00",
  "title": "hello"
}
```
* 검색
```
GET /get-together/new-events/_search
{
  "query": {
    "query_string": {
      "query": "hello"
    }
  }
}
```
* 검색이 안된다.
```
{
  "took": 2,
  "timed_out": false,
  "_shards": {
    "total": 5,
    "successful": 5,
    "failed": 0
  },
  "hits": {
    "total": 0,
    "max_score": null,
    "hits": []
  }
}
```

#### 날짜형

* 포맷 사용
```
PUT /get-together/_mapping/weekly-events
{
  "properties": {
    "next_event": {
      "type": "date",
      "format": "MMM DD YYYY"
    }
  }
}
```
```
GET /get-together/_mapping/weekly-events
```
```
{
  "get-together": {
    "mappings": {
      "weekly-events": {
        "properties": {
          "next_event": {
            "type": "date",
            "format": "MMM DD YYYY"
          }
        }
      }
    }
  }
}
```
```
PUT /get-together/weekly-events/1
{
  "name": "Elasticsearch News",
  "first_occurence": "2011-04-03",
  "next_event": "Oct 25 2013"
}
```
```
GET /get-together/weekly-events/1
```
```
{
  "_index": "get-together",
  "_type": "weekly-events",
  "_id": "1",
  "_version": 1,
  "found": true,
  "_source": {
    "name": "Elasticsearch News",
    "first_occurence": "2011-04-03",
    "next_event": "Oct 25 2013"
  }
}
```

#### 불리언 형
```
PUT /get-together/new-events/1
{
  "name": "Broadcasted Elasticsearch News",
  "downloadable": true
}
```
```
GET /get-together/_mapping/new-events
```
```
{
  "get-together": {
    "mappings": {
      "new-events": {
        "properties": {
          "date": {
            "type": "date"
          },
          "downloadable": {
            "type": "boolean"
          },
          "name": {
            "type": "text",
            "fields": {
              "keyword": {
                "type": "keyword",
                "ignore_above": 256
              }
            }
          }
        }
      }
    }
  }
}
```

#### 배열
```
PUT /blog/posts/1
{
  "tags": ["first", "initial"]
}
```
```
GET /blog/_mapping/posts
```
```
{
  "blog": {
    "mappings": {
      "posts": {
        "properties": {
          "tags": {
            "type": "text",
            "fields": {
              "keyword": {
                "type": "keyword",
                "ignore_above": 256
              }
            }
          }
        }
      }
    }
  }
}
```

#### 다중 필드

```
PUT /blog/_mapping/posts
{
  "posts" : {
    "properties" : {
      "tags" : {
        "type": "text",
        "index": "true",
        "fields": {
          "verbatim": {
            "type": "text",
            "index": "false"
          }
        }
      }
    }
  }
}
```
```
GET /blog/_mapping/posts
```
```
{
  "blog": {
    "mappings": {
      "posts": {
        "properties": {
          "tags": {
            "type": "text",
            "fields": {
              "keyword": {
                "type": "keyword",
                "ignore_above": 256
              },
              "verbatim": {
                "type": "text",
                "index": false
              }
            }
          }
        }
      }
    }
  }
}
```

#### 메타 필드
