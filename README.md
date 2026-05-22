# ReWind 🌪️♻️

O ReWind é uma plataforma focada no ciclo de vida da energia eólica no Brasil, auxiliando empresas no monitoramento de parques eólicos, estimativa de risco de descomissionamento, cálculo de geração de resíduos e conexão com indústrias interessadas no reaproveitamento de materiais de turbinas.

A plataforma centraliza dados operacionais, ambientais e comerciais para impulsionar a economia circular no setor de energia renovável.

---

# 🚀 Funcionalidades

- 📍 Visualização de parques eólicos em mapa interativo
- ⚠️ Estimativa de risco de descomissionamento
- ♻️ Previsão de geração de resíduos
- 🏭 Conexão entre empresas e recicladoras
- 🚚 Sugestão de rotas para centros de reciclagem
- 🌱 Estimativa de redução de CO₂ e créditos de carbono
- 📊 Integração com dados da ANEEL
- 🏢 Integração com dados de empresas e CNPJ
- 🔎 Documentação via Swagger/OpenAPI

---

# 🧱 Arquitetura

O projeto segue os princípios de Clean Architecture, utilizando separação por camadas:

```txt
ReWind.sln
│
├── src/
│   ├── ReWind.API/
│   ├── ReWind.Application/
│   ├── ReWind.Core/
│   └── ReWind.Infrastructure/
│
├── docker-compose.yml
└── README.md
```

## Camadas

| Camada | Responsabilidade |
|---|---|
| ReWind.Core | Entidades, enums e regras de domínio |
| ReWind.Application | Casos de uso, commands, queries e handlers |
| ReWind.Infrastructure | Entity Framework, PostgreSQL e integrações externas |
| ReWind.API | Controllers, Swagger e injeção de dependência |

---

# 🛠️ Stack Tecnológica

## Backend
- ASP.NET Core (.NET 10)
- Entity Framework Core
- MediatR
- PostgreSQL
- Npgsql
- Swagger/OpenAPI

## Frontend
- React
- Vite
- ArcGIS SDK
- TailwindCSS
- shadcn/ui

## Infraestrutura
- Docker
- Docker Compose
- Vercel (frontend)

---

# 🐳 Executando com Docker

## Pré-requisitos

- Docker
- Docker Compose

## Executando o projeto

```bash
docker compose up --build
```

A API estará disponível em:

```txt
http://localhost:8080
```

Swagger:

```txt
http://localhost:8080/swagger
```

---


# 🗄️ Banco de Dados

Banco utilizado: PostgreSQL 17

Nome padrão:

```txt
ReWind
```

O projeto utiliza:
- Migrations com Entity Framework Core
- Provider Npgsql
- Grandes volumes de dados energéticos da ANEEL

---

# 📦 Serviços Docker

## API
- Serviço: rewind.api
- Porta: 8080

## PostgreSQL
- Serviço: postgres
- Porta: 5432

---

# 🔄 Padrões Utilizados

- Clean Architecture
- CQRS
- MediatR
- Dependency Injection
- Repository Pattern
- Split Queries para otimização de performance
- DTO Projections

---

# 📈 Melhorias Futuras

- Autenticação e autorização
- Analytics em tempo real
- IA preditiva para vida útil de turbinas
- Marketplace de materiais recicláveis
- Marketplace de créditos de carbono
- Sistema de notificações
- Otimização GIS

---

# 🌎 Visão do Projeto

O ReWind busca conectar:
- Empresas de energia renovável
- Indústrias de reciclagem
- Iniciativas ambientais
- Projetos de economia circular
- Politicos

Tudo isso reduzindo impactos ambientais e criando novas oportunidades econômicas a partir do descomissionamento de turbinas eólicas.

---

# 👨‍💻 Autores

API desenvolvida por Matheus Grego.

---

# 📄 Licença

Este projeto está licenciado sob a licença MIT.
