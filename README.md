# ChallengeMottu API

RM558640 - Caio Amarante

RM556325 - Felipe Camargo

RM555997 - Caio Marques

## Descrição
A **ChallengeMottu API** é uma API RESTful construída em .NET para gerir motos, funcionários e filiais da Mottu. Ela oferece operações CRUD completas nas entidades Moto, Funcionário e Filial.

## Tecnologias
- .NET 7
- Entity Framework Core 7
- Oracle Managed Data Access
- Swagger (OpenAPI)

## Configuração

1. **String de Conexão**  
   No arquivo `appsettings.json`, ajuste a seção `ConnectionStrings`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "User Id=SEU_USUARIO;Password=SUA_SENHA;Data Source=oracle.fiap.com.br:1521/orcl;"
     }
   }
   ```

2. **Dependências**  
   No terminal, execute:
   ```bash
   dotnet tool install --global dotnet-ef
   dotnet add package Microsoft.EntityFrameworkCore.Design
   dotnet add package Oracle.EntityFrameworkCore
   ```

3. **Migrations**  
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

4. **Executar a API**  
   ```bash
   dotnet run
   ```

## Endpoints

Base URL: `http://localhost:5030/api`

### Motos

| Método | Rota            | Descrição                  | Body (JSON)                                                       |
|--------|-----------------|----------------------------|-------------------------------------------------------------------|
| GET    | `/moto`         | Lista todas as motos       | —                                                                 |
| GET    | `/moto/{id}`    | Retorna moto por ID        | —                                                                 |
| POST   | `/moto`         | Cria uma nova moto         | `{ "modelo": "Mottu Sport", "anoFabricacao": 2021, "placa": "ABC1234", "categoria": "Esportiva", "idFilial": 2 }` |
| PUT    | `/moto/{id}`    | Atualiza moto existente    | Mesmo schema do POST                                              |
| DELETE | `/moto/{id}`    | Remove uma moto            | —                                                                 |

### Funcionários

| Método | Rota                      | Descrição                          | Body (JSON)                                                                                                 |
|--------|---------------------------|------------------------------------|-------------------------------------------------------------------------------------------------------------|
| GET    | `/funcionario`            | Lista todos os funcionários        | —                                                                                                           |
| GET    | `/funcionario/{id}`       | Retorna funcionário por ID         | —                                                                                                           |
| POST   | `/funcionario`            | Cria um novo funcionário           | `{ "nome": "João Silva", "email": "joao@ex.com", "tipoAcesso": "Admin", "funcaoUsuario": "Gestor", "codFilial": 1 }` |
| PUT    | `/funcionario/{id}`       | Atualiza funcionário existente     | Mesmo schema do POST                                                                                        |
| DELETE | `/funcionario/{id}`       | Remove um funcionário              | —                                                                                                           |

### Filiais

| Método | Rota            | Descrição                   | Body (JSON)                                             |
|--------|-----------------|-----------------------------|---------------------------------------------------------|
| GET    | `/filial`       | Lista todas as filiais     | —                                                       |
| GET    | `/filial/{id}`  | Retorna filial por ID      | —                                                       |
| POST   | `/filial`       | Cria uma nova filial       | `{ "nomeFilial": "Filial Teste", "codCidade": 5, "tamanhoPatio": 300.0 }` |
| PUT    | `/filial/{id}`  | Atualiza filial existente  | Mesmo schema do POST                                    |
| DELETE | `/filial/{id}`  | Remove uma filial          | —                                                       |

## Testes

- Acesse o Swagger UI em `http://localhost:5030/swagger` para testar interativamente todos os endpoints.

---
