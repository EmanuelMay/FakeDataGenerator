# Gerador de Dados Falsos - Fake Data Generator

## 📋 Descrição

O **Fake Data Generator** é uma aplicação console em C# (.NET 10.0) desenvolvida para gerar dados fictícios de identidade brasileira de forma rápida e confiável. É ideal para fins de desenvolvimento, testes automatizados, prototipagem de sistemas e ambientes de homologação onde dados reais não podem ser utilizados.

## ✨ Características Principais

- **Geração de Identidades Completas**: Cria perfis fictícios com dados brasileiros autênticos e validados
- **Validação de Documentos**: Gera CPF e RG válidos de acordo com as regras de validação brasileiras
- **Dados Realistas**: Integra lista de nomes brasileiros reais para maior autenticidade
- **Armazenamento Local**: Persiste os dados gerados em arquivos locais para consulta posterior
- **Interface Console Intuitiva**: Menu interativo e fácil de usar
- **Arquitetura Limpa**: Implementa padrões de design profissionais (Clean Architecture, SOLID)

## 🎯 Funcionalidades

### Geração de Dados

- **Nome Completo**: Nomes brasileiros reais
- **Data de Nascimento**: Datas válidas com cálculo automático de idade
- **CPF**: Números de CPF válidos com dígitos verificadores corretos
- **RG**: Números de RG autênticos
- **Nome da Mãe**: Sobrenomes femininos para completar o perfil

## 🏗️ Arquitetura

A aplicação segue o padrão **Clean Architecture** com separação clara de responsabilidades:

```
src/
├── Domain/           # Entidades, interfaces e regras de negócio
├── Application/      # Casos de uso e lógica da aplicação
├── Infrastructure/   # Implementações de repositórios, geradores e provedores
└── Presentation/     # Interface com usuário (console)
```

### Padrões Implementados

- **Repository Pattern**: Abstração para persistência de dados
- **Dependency Injection**: Injeção de dependências na inicialização
- **Interface Segregation**: Interfaces específicas para cada gerador
- **Single Responsibility**: Cada classe com única responsabilidade

## 🛠️ Tecnologias

- **Linguagem**: C#
- **Framework**: .NET 10.0 e .NET 8.0 (multi-target)
- **Paradigma**: Orientado a Objetos com princípios SOLID
- **Padrão Arquitetural**: Clean Architecture

## 📦 Pré-requisitos

- .NET 10.0 SDK instalado
- Sistema Operacional: Windows, Linux ou macOS

## 🚀 Como Usar

### 1. Compilar o Projeto

```bash
dotnet build src/GeneratorFakeData.csproj
```

### 2. Executar a Aplicação

```bash
dotnet run --project src/GeneratorFakeData.csproj
```

### 3. Interface de Usuário

Ao iniciar, a aplicação exibe um menu principal:

```
===== MENU PRINCIPAL =====
1 - Gerar Identidades
0 - Sair

Option: _
```

Selecione a opção **1** para gerar dados fictícios e escolha a quantidade desejada.

## 💾 Saída de Dados

Os dados gerados são armazenados em um arquivo de texto na pasta `Users/` com o seguinte formato:

```
Nome: João Silva
Data de Nascimento: 15/03/1990
Idade: 34
CPF: 123.456.789-00
RG: 12.345.678-9
Mãe: Maria dos Santos
---
```

## 📂 Estrutura do Projeto

```
src/
├── Program.cs                          # Ponto de entrada e inicialização
├── Domain/
│   ├── Interfaces/
│   │   ├── Generators/                # Interfaces para geração de dados
│   │   ├── Providers/                 # Interfaces de provedores de dados
│   │   └── Repository/                # Interface de repositório
│   └── Models/
│       └── UserData.cs                # Entidade de dados de usuário
├── Application/
│   ├── Common/
│   │   └── Result.cs                  # Classe de resposta da aplicação
│   └── UseCase/
│       └── GenerateIdentityUseCase.cs # Caso de uso principal
├── Infrastructure/
│   ├── Generators/                    # Implementações dos geradores
│   │   ├── CPFGenerator.cs
│   │   ├── DateTimeGenerator.cs
│   │   ├── NameGenerator.cs
│   │   └── RGGenerator.cs
│   ├── Providers/                     # Implementações de provedores
│   │   └── NameProvider.cs
│   └── Repository/                    # Implementações de repositório
│       └── UserRepository.cs
└── Presentation/
    ├── Console/
    │   └── ConsoleIO.cs               # I/O de console
    ├── Input/
    │   └── InputParser.cs             # Parser de entrada do usuário
    └── MainMenu/
        ├── DisplayMainMenu.cs         # Exibição do menu
        └── Options/                   # Opções do menu
```

## 🔧 Componentes Principais

| Componente | Responsabilidade |
|---|---|
| `GenerateIdentityUseCase` | Orquestra a geração de identidades completas |
| `NameGenerator` | Gera nomes e sobrenomes autênticos |
| `CPFGenerator` | Cria CPF válido com dígitos verificadores |
| `RGGenerator` | Gera números de RG realistas |
| `DateTimeGenerator` | Produz datas de nascimento válidas |
| `UserRepository` | Persiste dados em arquivo local |

## 📈 Casos de Uso

- ✅ Testes automatizados de sistemas
- ✅ Desenvolvimento de aplicações
- ✅ Prototipagem de funcionalidades
- ✅ Ambiente de homologação
- ✅ Demonstrações de produto
- ✅ Treinamentos e workshops

## ⚠️ Informações Importantes

- Os dados gerados são **completamente fictícios** e não representam pessoas reais
- A aplicação respeita as regras de validação de documentos brasileiros
- Adequada apenas para fins de desenvolvimento e teste
- Não deve ser utilizada para fins fraudulentos ou ilegais

## 📝 Licença

Este projeto é fornecido como está. Utilize livremente para fins educacionais e de desenvolvimento.

## 👨‍💻 Desenvolvedor

Desenvolvido como exemplo de aplicação em C# seguindo boas práticas de arquitetura de software.

---

**Versão**: 1.0.0  
**Atualizado**: 2026
