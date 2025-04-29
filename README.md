# WebAPIExemple

![.NET 6.0](https://img.shields.io/badge/.NET-6.0-blue) ![ASP.NET Core Web API](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-green) ![Swashbuckle](https://img.shields.io/badge/Swagger-API%20Docs-brightgreen) ![C#](https://img.shields.io/badge/Language-C%23-blueviolet) ![MIT License](https://img.shields.io/badge/License-MIT-lightgrey)

> Exemplo de API RESTful em ASP.NET Core para geração e validação de CPF.

---

## 📚 Sumário

- [Sobre o Projeto](#sobre-o-projeto)
- [Tecnologias](#tecnologias)
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Configuração](#configuração)
- [Uso / Execução](#uso--execução)
- [Endpoints da API](#endpoints-da-api)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Contribuindo](#contribuindo)
- [Licença](#licença)

---

## 💡 Sobre o Projeto

Este projeto demonstra como criar uma **Web API** em **ASP.NET Core 6.0** para:

- Gerar CPFs válidos aleatórios.
- Validar CPFs existentes.
- Testar múltiplas gerações para verificar a consistência do algoritmo.

Inclui exemplo de injeção de dependência de um serviço (`CpfService`) com ciclo de vida Singleton e documentação via **Swagger**.

---

## 🚀 Tecnologias

| Componente         | Tecnologia                              |
|--------------------|-----------------------------------------|
| Framework          | ASP.NET Core 6.0                        |
| ORM / Data Layer   | — (nenhum banco de dados)               |
| Documentação API   | Swashbuckle.AspNetCore (Swagger) 6.x    |
| Linguagem          | C# 10                                   |

---

## ✅ Pré-requisitos

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Windows, Linux ou macOS (Kestrel)
- Editor de código / IDE (Visual Studio 2022, VS Code etc.)

---

## 🛠️ Instalação

```bash
# Clone o repositório
git clone https://github.com/pepes1234/WebAPIExemple.git
cd WebAPIExemple
```

---

## ⚙️ Configuração

- **appsettings.json**: configurações gerais (nenhuma configuração especial necessária para este exemplo).
- **appsettings.Development.json**: configurações de ambiente de desenvolvimento.

Caso queira alterar a porta ou endpoints, edite **Properties/launchSettings.json**.

---

## ▶️ Uso / Execução

```bash
# No diretório raiz do projeto
dotnet build

dotnet run
```

A API estará disponível em:

- `https://localhost:5001`
- `http://localhost:5000`

A interface interativa do Swagger estará em:

```
https://localhost:5001/swagger
```

---

## 📡 Endpoints da API

O projeto inclui um controller `CpfController` com as rotas abaixo:

| Método | Rota                     | Descrição                                       |
|--------|--------------------------|-------------------------------------------------|
| GET    | `/cpf/validate/{cpf}`    | Valida um CPF informado (formato `000.000.000-00`).<br>Retorna `true` ou `false`. |
| GET    | `/cpf/generate`          | Gera um CPF válido aleatório (formato `000.000.000-00`). |
| GET    | `/cpf/test/{count}`      | Gera e valida `count` CPFs, retornando resumo no formato:<br>`"Testes Corretos: X Testes Incorretos: Y"`. |

**Exemplos:**

```bash
# Validar CPF existente
curl https://localhost:5001/cpf/validate/123.456.789-09

# Gerar CPF aleatório
curl https://localhost:5001/cpf/generate

# Testar 100 gerações
curl https://localhost:5001/cpf/test/100
```

---

## 🗂️ Estrutura do Projeto

```plain
WebAPIExemple/
├── .vscode/                           # Configurações do VS Code
├── Controllers/                       # Controllers ASP.NET Core
│   └── CpfController.cs               # Endpoints para CPF
├── Properties/
│   └── launchSettings.json            # Configurações de execução/debug
├── Services/
│   └── CpfService.cs                  # Lógica de geração e validação de CPF
├── appsettings.json                   # Configurações gerais
├── appsettings.Development.json       # Configurações de dev
├── Program.cs                         # Configuração do WebApplication
├── WebAPIExemple.csproj               # Projeto .NET 6.0 Web
├── .gitignore
├── LICENSE
└── README.md                          # Este arquivo
```

---