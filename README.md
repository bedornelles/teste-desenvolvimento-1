# Cadastro de Produtos – Teste de Desenvolvimento

Este projeto foi desenvolvido como parte de um **teste de desenvolvimento**, consistindo em uma aplicação **Windows Forms (.NET)** para cadastro e gerenciamento de produtos, utilizando **PostgreSQL** como banco de dados.

---

## 📌 Funcionalidades

- Listagem de produtos cadastrados
- Inclusão de novos produtos
- Atualização de produtos existentes
- Exclusão de produtos
- Validações de entrada (campos obrigatórios e código > 0)
- Registro das operações no banco de dados

---

## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET (Windows Forms)**
- **PostgreSQL**
- **Npgsql**
- **Visual Studio**
- **Git / GitHub**

---

## 🗄️ Banco de Dados

O script SQL para criação do banco de dados está disponível na pasta "arquivo SQL"

O script inclui:
- Criação da tabela `produto`
- Criação da tabela `log_operacoes`
- Trigger para registrar automaticamente inserções, atualizações e exclusões

> Antes de executar a aplicação, é necessário criar o banco de dados e executar o script SQL.
>
> ## ⚙️ Configuração do Banco

A string de conexão está configurada no arquivo: App.config
Nela deve ser colocado as chaves do seu banco de dados.

## ▶️ Executável

O executável da aplicação já compilado está disponível na pasta "executavel"

Para executar:
1. Certifique-se de que o PostgreSQL está rodando
2. O banco e as tabelas já devem estar criados
3. Execute o arquivo `.exe`
