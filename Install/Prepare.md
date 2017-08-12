## [Elastic Stack](https://github.com/colaboy2010hot/ElasticStack/blob/master/README.md) > [Elastic Stack 설치](https://github.com/colaboy2010hot/ElasticStack/blob/master/Install/README.md) > 사전 설치 및 설정

### nginx 설치

* kibana를 기본 인증 및 80 Port로 서비스
* nginx 설치
```
sudo apt-get install nginx
```
* nginx 서비스 시작
```
sudo service nginx start
```
* nginx 동작 확인
```
curl -i http://localhost
```
* nginx 로그 디렉터리 및 nginx 루트 디렉터리의 소유자 및 소유 그룹 설정
```
sudo chown -R colaboy:colaboy /var/log/nginx /usr/share/nginx/html
```
* nginx 루트 디렉터리에 샘플 html 파일 생성
```
echo "<h1>Hello World</h1>" > /usr/share/nginx/html/hello.html
```

### Oracle Java 1.8 설치

* Java 1.8 설치
```
sudo add-apt-repository ppa:webupd8team/java
sudo apt-get update
sudo apt-get install oracle-java8-installer
sudo apt-get install oracle-java8-set-default
```

* Java 버전 확인
```
java -version
```
```
java version "1.8.0_131"
Java(TM) SE Runtime Environment (build 1.8.0_131-b11)
Java HotSpot(TM) 64-Bit Server VM (build 25.131-b11, mixed mode)

```

### Open Java 1.8 설치

* Java 1.8 설치
```
sudo add-apt-repository ppa:openjdk-r/ppa
sudo apt-get update
sudo apt-get install openjdk-8-jdk
```

* Java 버전 확인
```
java -version
```
```
openjdk version "1.8.0_131"
OpenJDK Runtime Environment (build 1.8.0_131-8u131-b11-2ubuntu1.16.04.3-b11)
OpenJDK 64-Bit Server VM (build 25.131-b11, mixed mode)

```

### 시스템 제한 설정

* 시스템 제한 확인
```
ulimit -a
```
```
core file size          (blocks, -c) 0
data seg size           (kbytes, -d) unlimited
scheduling priority             (-e) 0
file size               (blocks, -f) unlimited
pending signals                 (-i) 3623
max locked memory       (kbytes, -l) 64
max memory size         (kbytes, -m) unlimited
open files                      (-n) 1024
pipe size            (512 bytes, -p) 8
POSIX message queues     (bytes, -q) 819200
real-time priority              (-r) 0
stack size              (kbytes, -s) 8192
cpu time               (seconds, -t) unlimited
max user processes              (-u) 3623
virtual memory          (kbytes, -v) unlimited
file locks                      (-x) unlimited

```

* 시스템 제한 설정 파일 수정
* 최대 오픈 파일 수 및 최대 실행 프로세스 수를 설정
* limits.conf의 마지막에 추가
```
sudo vi /etc/security/limits.conf
```
```
colaboy hard nofile 65536
colaboy soft nofile 65536
colaboy hard nproc 65536
colaboy soft nproc 65536
```

* 시작 실행 파일 설정
* Windows의 AUTOEXEC.BAT와 유사한 역할
* rc.local의 마지막에 추가
```
sudo vi /etc/rc.local
```
```
echo 1048575 > /proc/sys/vm/max_map_count
```

* 최대 파일 수 설정 및 확인
```
sudo sysctl -w fs.file-max=65536
```
```
cat /proc/sys/fs/file-max
```

* 시스템 재시작
```
sudo reboot
```

* 시스템 제한 재확인
```
ulimit -a
```
```
core file size          (blocks, -c) 0
data seg size           (kbytes, -d) unlimited
scheduling priority             (-e) 0
file size               (blocks, -f) unlimited
pending signals                 (-i) 3623
max locked memory       (kbytes, -l) 64
max memory size         (kbytes, -m) unlimited
open files                      (-n) 65536
pipe size            (512 bytes, -p) 8
POSIX message queues     (bytes, -q) 819200
real-time priority              (-r) 0
stack size              (kbytes, -s) 8192
cpu time               (seconds, -t) unlimited
max user processes              (-u) 65536
virtual memory          (kbytes, -v) unlimited
file locks                      (-x) unlimited

```