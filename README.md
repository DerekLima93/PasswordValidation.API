# PasswordValidation.API

O projeto trata-se de uma API que realiza validações pré-estabelecidas para uma senha digitada ser válida ou não.

## Detalhes

Para um senha(texto) ser válida, ela deverá ter um retorno verdadeiro para todas as validações abaixo:

* A quantidade de caracteres é maior que 8.
* Existe ao menos um dígito.
* Existe ao menos uma letra minúscula
* Existe ao menos uma letra maiúscula
* Existe ao menos um dos caracteres especiais definidos: !@#$%^&*()-+
* Não existe caracteres repetidos

Caso a senha digitada não se enquadre em todas as validações o retorno será falso

## Ambiente de Desenvolvimento

 * [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/)


## Pré-requisitos

* [.Net 5](https://dotnet.microsoft.com/download/dotnet/5.0)

## Teste

Hospedado para teste da aplicação. A requisição deve ser feita como exemplo abaixo:

dereklima93-001-site1.etempurl.com/password/{password}

Exemplo prático:
http://dereklima93-001-site1.etempurl.com/password/123Testand@

## Autor

* **Derek Lima**


## Data

* **04/10/2021**
