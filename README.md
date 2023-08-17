# Projeto base para Calculadora.Console

**Calculadora.Console** é um modelo inicial para o segundo projeto PDI jr.

## Scripts DB

 - Criar tabela OperacoesHistorico
 ```
 CREATE TABLE OperacoesHistorico (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NomeOperacao NVARCHAR(100),
    Resultado VARCHAR(11),
    DataOperacao DATE
);
 ```