# Sistema de Gerenciamento de Clientes e Vendas

## Descrição do Projeto

Este sistema foi desenvolvido como parte da disciplina **"Interação Humano Computador"** sob a orientação do professor [**Fabio Eduardo Florencio**](https://github.com/fabio-florencio). O objetivo principal deste projeto é fornecer uma solução eficiente e intuitiva para o gerenciamento de **clientes**, **funcionários**, **produtos**, **itens de venda** e **vendas**.

O sistema foi desenvolvido como um **CRUD completo** utilizando **ASP.NET MVC** e **Entity Framework**. A aplicação oferece uma interface prática e funcional para facilitar a administração de dados essenciais de uma empresa, proporcionando um gerenciamento fluido e simplificado de informações importantes.

## Funcionalidades Principais

### 1. **Cadastro de Clientes**
Permite gerenciar as informações dos clientes, como:
- Nome
- E-mail
- Telefone
- Endereço

O sistema oferece funcionalidades para **criar**, **editar** e **excluir** registros de clientes, garantindo uma gestão ágil e organizada.

### 2. **Cadastro de Funcionários**
Facilita o gerenciamento de funcionários, incluindo:
- Cargo
- Salário
- Status de trabalho (ativo ou inativo)

O cadastro de funcionários é essencial para a administração do pessoal da empresa, permitindo que o gestor tenha o controle de cada colaborador e suas respectivas funções.

### 3. **Cadastro de Produtos**
Permite o registro e atualização de produtos no estoque, com dados como:
- Nome do produto
- Preço
- Quantidade disponível
- Descrição

Esta funcionalidade visa otimizar o controle sobre os itens que estão à venda e garantir que a empresa tenha sempre um estoque atualizado.

### 4. **Itens da Venda**
Registra os produtos associados a uma venda, permitindo o controle detalhado de cada transação. Cada item da venda é vinculado a um produto específico, facilitando a gestão de estoque e a organização de cada venda realizada.

### 5. **Vendas**
Gerencia o processo completo de vendas, desde o **registro** até a **conclusão** da transação. A funcionalidade integra todos os dados necessários, como informações do cliente, produtos vendidos e itens de venda, proporcionando um processo de venda eficiente e organizado.

## Heurísticas de Desenvolvimento

O projeto foi desenvolvido com base nas heurísticas de usabilidade e interação humano-computador, visando oferecer uma interface intuitiva e eficiente. Algumas das principais heurísticas seguidas são:

### 1. **Visibilidade do Status do Sistema**
O sistema fornece **feedback constante** ao usuário, como mensagens de **sucesso** ou **erro**, durante a realização de cadastros e edições de dados. O objetivo é manter o usuário informado sobre o estado atual da ação executada.

### 2. **Consistência e Padrões**
A interface segue **padrões consistentes**, permitindo que o usuário reconheça rapidamente os elementos de navegação e interação. Isso facilita a utilização do sistema, proporcionando uma experiência de uso mais intuitiva e agradável.

### 3. **Controle e Liberdade do Usuário**
O sistema oferece a possibilidade de **desfazer** ou **corrigir** ações facilmente. O usuário tem controle sobre suas escolhas e pode voltar a qualquer momento para corrigir eventuais erros, proporcionando mais liberdade e flexibilidade.

### 4. **Prevenção de Erros**
Validações são realizadas para evitar a inserção de **dados inválidos** ou **incompletos**, prevenindo erros comuns que possam comprometer o funcionamento do sistema ou gerar informações incorretas.

## Tecnologias Utilizadas

- **ASP.NET MVC**: Framework para construção da aplicação web.
- **Entity Framework**: Ferramenta de mapeamento objeto-relacional para gerenciamento de dados no banco de dados.
- **C#**: Linguagem de programação utilizada para a lógica do sistema.

## Como Executar o Projeto

1. Clone o repositório do projeto.
2. Abra a solução no Visual Studio.
3. Configure o banco de dados no arquivo `appsettings.json`.
4. Execute o projeto pressionando **F5** ou clicando em **Run**.

## Contribuições

Este projeto foi desenvolvido para fins acadêmicos e está disponível para aprimoramentos e contribuições. Caso deseje contribuir ou sugerir melhorias, sinta-se à vontade para abrir **issues** ou **pull requests**.
