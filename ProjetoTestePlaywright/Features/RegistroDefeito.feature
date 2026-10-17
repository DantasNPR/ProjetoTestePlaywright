# language: pt

Funcionalidade: Registro de defeitos

  @TelaRegistroDefeito
  Cenário: Registrar defeito no módulo Login com severidade baixa e prioridade P1 em produção
    Dado que o usuário está na aba "Playground QA" com o formulário de registro de defeitos disponível
    Quando preenche o campo Título do defeito com "Defeito de exemplo"
    E seleciona o módulo afetado "Login"
    E seleciona a severidade "Baixa"
    E seleciona o ambiente "Produção"
    E preenche o campo E-mail de quem reportou com "voce@empresa.com"
    E informa a data de deteccao "01/01/2023"
    E informa "1" no campo Ocorrencias
    E seleciona a prioridade "P1"
    E preenche o campo Passos para reproduzir com:
      """
      1. Acessar a tela X
      2. Preencher o campo Y
      3. Observar o resultado Z
      """
    E marca a confirmacao de que o relato nao contém informacoes sensíveis
    E clica no botao "Registrar defeito"
    Então deve visualizar a mensagem 'Defeito registrado com sucesso. Ele já aparece na aba "Tabela de defeitos".'