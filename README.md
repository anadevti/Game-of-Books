# **Game-Of-Bookss 📖**

Um sistema de gerenciamento de biblioteca simples e interativo desenvolvido em C# utilizando o padrão MVC. Este projeto permite gerenciar livros, realizar empréstimos e organizar devoluções em uma aplicação de console.

![image](https://github.com/user-attachments/assets/21d7cdc3-cc20-482c-bb85-25c723752086)

---

## **Funcionalidades**
- Listar livros disponíveis na biblioteca.
- Adicionar novos livros.
- Realizar empréstimos de livros para usuários.
- Registrar devoluções de livros.
- Visualizar lista de empréstimos.

---

## **Tecnologias Utilizadas**
- [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/) (8.0 ou superior)
- [.NET](https://learn.microsoft.com/pt-br/dotnet/) (8.0)
- [JetBrains Rider](https://www.jetbrains.com/rider/) (IDE utilizada para o desenvolvimento)

---

## **Estrutura do Projeto**
O projeto segue o padrão **MVC** (Model-View-Controller) da seguinte forma:

```bash
Game-Of-Bookss/
├── Controllers/
│   ├── LibraryController.cs   # Controlador principal da aplicação
├── Models/
│   ├── Book.cs                # Representa os dados de um livro
│   ├── User.cs                # Representa os dados de um usuário
│   ├── Loan.cs                # Representa os dados de um empréstimo
├── Views/
│   ├── ConsoleView.cs         # Gerencia as interações com o console
├── Program.cs                 # Ponto de entrada da aplicação

```

---

## **Como Executar o Projeto**

### **Pré-requisitos**
1. Certifique-se de ter o [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.
2. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/Game-Of-Bookss.git
   cd Game-Of-Bookss
   ```

### **Execução**
Restaure as dependencias do projeto:
```bash
dotnet restore
   ```
Compile o projeto:
```bash
dotnet build
```
Execute a aplicação:
```bash
dotnet run
```
