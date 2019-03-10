Building to .jar
------------
1. mvn package
2. mvn clean compile assembly:single

RUN
------------
java -jar target/<artifactId-version>.jar