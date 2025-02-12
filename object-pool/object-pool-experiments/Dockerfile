# Estágio de build: Usar Maven com JDK 17 para construir o JAR
FROM maven:3.9.9-eclipse-temurin-17-alpine AS build

# Definir o diretório de trabalho
WORKDIR /app

# Copiar o arquivo pom.xml e baixar as dependências
COPY pom.xml .
RUN mvn dependency:go-offline -B

# Copiar o código fonte para o contêiner
COPY src/ /app/src/

# Construir o JAR com Maven
RUN mvn clean package -DskipTests

# Estágio final: Usar JDK 17 para executar o JAR
FROM eclipse-temurin:17-alpine

# Definir o diretório de trabalho no contêiner
WORKDIR /app

# Copiar o JAR gerado do estágio de build
COPY --from=build /app/target/*.jar app.jar

# Expor a porta padrão da aplicação Spring Boot
EXPOSE 8080

# Comando para executar a aplicação
CMD ["java", "-jar", "app.jar"]
