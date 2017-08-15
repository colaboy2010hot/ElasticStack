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

* mecab-ko 라이브러리 설치
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