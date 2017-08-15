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

#### mecab-ko 라이브러리 설치
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

#### mecab-ko-dic 사전 설치
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
* 사전 확인
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

#### mecab-java 설치

```
cd /elastic
wget https://bitbucket.org/eunjeon/mecab-java/downloads/mecab-java-0.996.tar.gz
tar zxvf mecab-java-0.996.tar.gz
cd mecab-java-0.996
vi Makefile
```


#### elasticsearch-analysis-mecab-ko 플러그인 설치
```
cd /elastic
wget https://bitbucket.org/eunjeon/mecab-ko-lucene-analyzer/issues/attachments/9/eunjeon/mecab-ko-lucene-analyzer/1500357175.91/9/elasticsearch-analysis-mecab-ko-5.5.0.0.zip
sudo /usr/share/elasticsearch/bin/elasticsearch-plugin install file:///elastic/elasticsearch-analysis-mecab-ko-5.5.0.0.zip
```
* 또는
```
sudo /usr/share/elasticsearch/bin/elasticsearch-plugin install https://bitbucket.org/eunjeon/mecab-ko-lucene-analyzer/issues/attachments/9/eunjeon/mecab-ko-lucene-analyzer/1500357175.91/9/elasticsearch-analysis-mecab-ko-5.5.0.0.zip
```

* mecab-java 재 컴파일
```
```

* [참고 1](http://www.popit.kr/%EC%9D%80%EC%A0%84%ED%95%9C%EB%8B%A2-%EC%84%A4%EC%B9%98-%EC%99%84%EC%A0%84%EC%A0%95%EB%B3%B5/)
* [참고 2](http://guruble.com/?p=416)