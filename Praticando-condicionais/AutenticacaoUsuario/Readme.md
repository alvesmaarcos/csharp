Você é responsável por implementar o sistema de autenticação de um aplicativo corporativo. O sistema precisa diferenciar entre administradores, usuários cadastrados e visitantes, garantindo o acesso adequado a cada perfil.

Crie um programa que:

Solicite que o usuário digite seu nome

- Verifique se o nome corresponde ao do administrador (ex: "Admin")
- Caso não seja o administrador, exibir uma mensagem de "Usuário não cadastrado" e apresentar um menu com opções:
    - Cadastrar novo usuário
    - Acessar como convidado
    - Sair do sistema

## Exemplo de entrada:

Sistema de Autenticação

Digite seu nome de usuário: Arthur Dent

## Saída esperada:

### Caso a opção escolhida seja cadastrar novo usuário:

Usuário não cadastrado.

Opções disponíveis:

[1] Cadastrar novo usuário

[2] Acessar como convidado

[3] Sair

1

Novo usuário 'Arthur Dent' cadastrado com sucesso!

### Caso a opção escolhida seja entrar como convidado:

Usuário não cadastrado.

Opções disponíveis:

[1] Cadastrar novo usuário

[2] Acessar como convidado

[3] Sair

2

Acesso concedido como convidado.

### Caso o usuário esteja cadastrado:

Bem-vindo, Arthur Dent!