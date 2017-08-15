## [Elastic Stack](https://github.com/colaboy2010hot/ElasticStack/blob/master/README.md) > [Elastic Stack 설치](https://github.com/colaboy2010hot/ElasticStack/blob/master/Install/README.md) > 한글 형태소 분석기 설치

* 다운로드 디렉터리 이동
```
sudo su
cd /
mkdir elastic
cd /elastic
```

* 컴파일러 및 빌드 도구 설치
```
sudo apt-get install g++
sudo apt-get install make
```

### mecab-ko 라이브러리 설치
* 설치 위치: /usr/local/lib/
```
cd /elastic
wget https://bitbucket.org/eunjeon/mecab-ko/downloads/mecab-0.996-ko-0.9.2.tar.gz
tar -xvzf mecab-0.996-ko-0.9.2.tar.gz
cd mecab-0.996-ko-0.9.2
./configure
make
make check
sudo make install
sudo ldconfig
```
* 설치 확인
```
mecab --version
```
```
mecab of 0.996/ko-0.9.2
```

### mecab-ko-dic 사전 설치
* 설치 위치: /usr/local/lib/mecab/dic/mecab-ko-dic
```
cd /elastic
wget https://bitbucket.org/eunjeon/mecab-ko-dic/downloads/mecab-ko-dic-2.0.1-20150920.tar.gz
tar -xvzf mecab-ko-dic-2.0.1-20150920.tar.gz  
cd mecab-ko-dic-2.0.1-20150920
./configure
make
sudo make install
```
* 형태소 분석 테스트
```
mecab -d /usr/local/lib/mecab/dic/mecab-ko-dic
아버지가 방에 들어가신다.
```
```
아버지  NNG,*,F,아버지,*,*,*,*
가      JKS,*,F,가,*,*,*,*
방      NNG,*,T,방,*,*,*,*
에      JKB,*,F,에,*,*,*,*
들어가  VV,*,F,들어가,*,*,*,*
신다    EP+EF,*,F,신다,Inflect,EP,EF,시/EP/*+ᆫ다/EF/*
.       SF,*,*,*,*,*,*,*
EOS
```

### mecab-java 설치

```
cd /elastic
wget https://bitbucket.org/eunjeon/mecab-java/downloads/mecab-java-0.996.tar.gz
tar zxvf mecab-java-0.996.tar.gz
cd mecab-java-0.996
```
* Makefile 수정
```
sudo vi Makefile
```
* 수정된 내용
```
TARGET=MeCab
JAVAC=javac
JAVA=java
JAR=jar
CXX=c++
INCLUDE=/usr/lib/jvm/java-8-openjdk-amd64/include

PACKAGE=org/chasen/mecab

LIBS=`mecab-config --libs`
INC=`mecab-config --cflags` -I$(INCLUDE) -I$(INCLUDE)/linux

all:
        $(CXX) -O1 -c -fpic $(TARGET)_wrap.cxx  $(INC)
        $(CXX) -shared  $(TARGET)_wrap.o -o lib$(TARGET).so $(LIBS)
        $(JAVAC) $(PACKAGE)/*.java
        $(JAVAC) -cp . test.java
        $(JAR) cfv $(TARGET).jar $(PACKAGE)/*.class

test:
        env LD_LIBRARY_PATH=. $(JAVA) test

clean:
        rm -fr *.jar *.o *.so *.class $(PACKAGE)/*.class

cleanall:
        rm -fr $(TARGET).java *.cxx
```
* 빌드
```
export JAVA_TOOL_OPTIONS=-Dfile.encoding=UTF-8
make
```
* 라이브러리 복사, 소유자 및 그룹 수정
```
sudo cp libMeCab.so /usr/local/lib
sudo cp MeCab.jar /usr/local/lib
sudo chown -R elasticsearch:elasticsearch /usr/local/lib/libMeCab.so
sudo chown -R elasticsearch:elasticsearch /usr/local/lib/MeCab.jar
sudo chown -R elasticsearch:elasticsearch /usr/local/lib/*mecab*
```

### JVM options 설정 및 라이브러리 경로 설정

```
sudo vi /etc/elasticsearch/jvm.options
```
* 라이브러리 경로 추가
```
-Djava.library.path=/usr/local/lib
```
* 라이브러리 경로 설정
```
sudo vi /etc/ld.so.conf
```
* 라이브러리 경로 추가
```
include /etc/ld.so.conf.d/*.conf
/usr/local/lib
```

### elasticsearch-analysis-mecab-ko 플러그인 설치
```
cd /elastic
wget https://bitbucket.org/eunjeon/mecab-ko-lucene-analyzer/issues/attachments/9/eunjeon/mecab-ko-lucene-analyzer/1500357175.91/9/elasticsearch-analysis-mecab-ko-5.5.0.0.zip
sudo /usr/share/elasticsearch/bin/elasticsearch-plugin install file:///elastic/elasticsearch-analysis-mecab-ko-5.5.0.0.zip
```
* 또는
```
sudo /usr/share/elasticsearch/bin/elasticsearch-plugin install https://bitbucket.org/eunjeon/mecab-ko-lucene-analyzer/issues/attachments/9/eunjeon/mecab-ko-lucene-analyzer/1500357175.91/9/elasticsearch-analysis-mecab-ko-5.5.0.0.zip
```


### 형태소 분석기 테스트

* 재시작
```
sudo systemctl restart elasticsearch
```

* 인덱스 생성
```
PUT /seunjeon-idx/?pretty
{
  "settings" : {
    "index":{
      "analysis":{
        "analyzer":{
          "korean":{
            "type":"custom",
            "tokenizer":"seunjeon_default_tokenizer"
          }
        },
        "tokenizer": {
          "seunjeon_default_tokenizer": {
            "type": "mecab_ko_standard_tokenizer",
            "mecab_args": "/usr/local/lib/mecab/dic/mecab-ko-dic"
          }
        }
      }
    }
  }
}
```
* 형태소 분석
```
GET /seunjeon-idx/_analyze 
{
  "analyzer": "korean", 
  "text":     "아버지가 방에 들어가신다."
}
```

* 인덱스 생성 및 매핑
```
PUT /seoul_art_collection/?pretty
{
  "settings" : {
    "index":{
      "analysis":{
        "analyzer":{
          "korean":{
            "type":"custom",
            "tokenizer":"seunjeon_default_tokenizer"
          }
        },
        "tokenizer": {
          "seunjeon_default_tokenizer": {
            "type": "mecab_ko_standard_tokenizer",
            "mecab_args": "/usr/local/lib/mecab/dic/mecab-ko-dic"
          }
        }
      }
    }
  },
  "mappings": {
    "artcollecetion": {
      "properties": {
        "caption": {
          "type": "text",
          "analyzer": "korean", 
          "search_analyzer": "korean" 
        }
      }
    }
  }
}
```

* [참고 1](http://www.popit.kr/%EC%9D%80%EC%A0%84%ED%95%9C%EB%8B%A2-%EC%84%A4%EC%B9%98-%EC%99%84%EC%A0%84%EC%A0%95%EB%B3%B5/)
* [참고 2](http://guruble.com/?p=416)