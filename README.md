# Teste técnico - Função Sistemas
Esse projeto foi desenvolvido como parte do processo seletivo para vaga de Desenvolver .NET FullStack na [Função Sistemas](https://www.funcao.com.br/)

## Projeto
A solicitação do teste foi a partir de um [projeto existente](https://github.com/Alanssrv/teste-funcao-sistemas/tree/6f86215352a6f9565fa882d52562ceac66aee9bf) de cadastro de clientes adicionar dois pontos:
- Vincular a tela de cadastro de clientes e a entidade Cliente no banco de dados um CPF, garantindo que um CPF é único para cada cliente e que ele é válido segundo a Receita Federal
- Adicionar uma lista de beneficiários a cada cada Cliente, contendo Nome e CPF, garantido o vinculo de 1 para n entre Cliente e Beneficiario
  - Adicionar modal para controle de Beneficiários na tela de Clientes
  - Criar estrutura de entidades e scripts de banco de dados para tabela e procedures

## Features adicionadas
- Adição do CPF à entidade e tela de Cliente com máscara respeitando a formatação do CPF
- Botão e Modal de gerenciamento de Beneficiários de um Cliente, na criação e alteração de registro
- Entidades de código e banco de dados para Beneficiário

## Melhorias implementadas
- Visualização de CPF a lista de Clientes
- Ação de remoção de Clientes e Beneficiários vinculados na lista de Clientes

## Pendências e novas features
- Adicionar máscara para número de telefone
- Utilizar lista dinâmica para UF e Cidade, remover valores fixos do HTML
