# Projeto de Estudos


## Instalar o Scanner
```sh 
    dotnet tool install --global dotnet-sonarscanner
``` 

## Executar o Scanner
```sh
dotnet sonarscanner begin /k:"Controle-Financeiro" /d:sonar.host.url="http://localhost:9999"  /d:sonar.login="sqp_b71c7e6f7679dc300ec05523ae393df14d9b4812"
```

```sh
    dotnet build ControleFinanceiro
```

```sh
dotnet sonarscanner end /d:sonar.login="sqp_b71c7e6f7679dc300ec05523ae393df14d9b4812"
```

# Anotações
- Credenciais Sonar:
    - user: admin
    - password: admin


# Referências

- https://docs.sonarqube.org/latest/analysis/scan/sonarscanner-for-msbuild/
- https://medium.com/@thiagoloureiro/code-analysis-with-sonarqube-docker-net-core-aee521ee8931
- https://imasters.com.br/back-end/analise-de-codigo-com-sonarqube-docker-net-core
- https://hub.docker.com/r/bitnami/sonarqube/#:~:text=sonarqube%20%5C%0A%20%20bitnami/sonarqube%3Alatest-,Configuration,-Environment%20variables
- https://www.mytechramblings.com/posts/running-a-sonarqube-scan-when-building-docker-image/
- https://dev.to/chindara/sonarqube-docker-net-core-code-analysis-44
- https://developer.okta.com/blog/2021/09/08/sonar-qube-dotnet
- https://docs.sonarqube.org/latest/analysis/test-coverage/dotnet-test-coverage/
- https://stackoverflow.com/questions/47939122/how-to-make-sonarqube-exclude-a-net-c-project-from-coverage-measures
- https://docs.sonarcloud.io/advanced-setup/analysis-scope/#restrict-the-scope-of-analysis-in-general
- https://docs.microsoft.com/pt-br/dotnet/api/system.diagnostics.codeanalysis.excludefromcodecoverageattribute?view=net-6.0