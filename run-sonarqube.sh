#!/bin/bash

dotnet sonarscanner begin /k:"Controle-Financeiro" /d:sonar.host.url="http://localhost:9999"  /d:sonar.login="sqp_e3c71aa7e8b99d9ac3fcdfc78e26a4875d673a80" /d:sonar.cs.vscoveragexml.reportsPaths=coverage.xml

dotnet build src --no-incremental

dotnet-coverage collect 'dotnet test ControleFinanceiro.sln' -f xml  -o 'coverage.xml'

dotnet sonarscanner end /d:sonar.login="sqp_e3c71aa7e8b99d9ac3fcdfc78e26a4875d673a80"