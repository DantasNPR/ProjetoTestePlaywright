# Projeto de Automação de Testes com Playwright



Projeto de automação de testes web desenvolvido com **C#**, **Playwright**, **xUnit**, **Reqnroll** e **BDD (Gherkin)**.



O objetivo deste projeto é aplicar boas práticas de automação de testes utilizando Playwright, organização com Page Objects e cenários escritos em BDD.



Este projeto também representa uma evolução do cenário anteriormente desenvolvido com Selenium, permitindo explorar na prática as diferenças entre as duas ferramentas.



## Tecnologias utilizadas



- C#

- .NET 10

- Microsoft Playwright

- xUnit

- Reqnroll

- BDD / Gherkin

- Page Object Model



## Cenário automatizado



```gherkin

# language: pt



Funcionalidade: Registro de defeitos



&#x20; @TelaRegistroDefeito

&#x20; Cenário: Registrar defeito no módulo Login com severidade baixa e prioridade P1 em produção

&#x20;   Dado que o usuário está na aba "Playground QA" com o formulário de registro de defeitos disponível

&#x20;   Quando preenche o campo Título do defeito com "Defeito de exemplo"

&#x20;   E seleciona o módulo afetado "Login"

&#x20;   E seleciona a severidade "Baixa"

&#x20;   E seleciona o ambiente "Produção"

&#x20;   E preenche o campo E-mail de quem reportou com "voce@empresa.com"

&#x20;   E informa a data de deteccao "01/01/2023"

&#x20;   E informa "1" no campo Ocorrencias

&#x20;   E seleciona a prioridade "P1"

&#x20;   E preenche o campo Passos para reproduzir com:

&#x20;     """

&#x20;     1. Acessar a tela X

&#x20;     2. Preencher o campo Y

&#x20;     3. Observar o resultado Z

&#x20;     """

&#x20;   E marca a confirmacao de que o relato nao contém informacoes sensíveis

&#x20;   E clica no botao "Registrar defeito"

&#x20;   Então deve visualizar a mensagem 'Defeito registrado com sucesso. Ele já aparece na aba "Tabela de defeitos".'

```

## Estrutura do projeto



```text

ProjetoTestePlaywright

│

├── Config

│   ├── appsettings.json

│   ├── ConfigurationManager.cs

│   └── TestSettings.cs

│

├── Drivers

│   └── PlaywrightDriver.cs

│

├── Features

│   └── RegistroDefeito.feature

│

├── Fixtures

│   └── PlaywrightFixture.cs

│

├── Hooks

│   └── PlaywrightHooks.cs

│

├── PageObjects

│   ├── AComunidadePageObjects

│   └── PlaygroundQaPageObjects

│

└── Steps

&#x20;   ├── AComunidadeStepDefinition.cs

&#x20;   └── PlaygroundQaStepDefinition.cs

```



## Arquitetura



O projeto foi estruturado separando as responsabilidades da automação:



**Features** → cenários escritos em Gherkin.



**Steps** → ligação entre os cenários BDD e as ações da automação.



**PageObjects** → elementos e ações realizadas nas páginas.



**Hooks** → preparação e finalização de cada cenário.



**Fixtures** → gerenciamento do ciclo de vida do Playwright.



**Drivers** → inicialização e configuração do navegador.



**Config** → configurações de execução, como URL, navegador, timeout e modo Headless.



Fluxo principal:



```text

Feature

&#x20;  ↓

Step Definition

&#x20;  ↓

Actions

&#x20;  ↓

Elements Map

&#x20;  ↓

IPage

&#x20;  ↓

Playwright

&#x20;  ↓

Browser

```



## Executando o projeto



### Pré-requisitos



- .NET SDK 10

- Git



Clone o repositório:



```bash

git clone https://github.com/DantasNPR/ProjetoTestePlaywright.git

```



Acesse a pasta:



```bash

cd ProjetoTestePlaywright

```



Restaure as dependências:



```bash

dotnet restore

```



Compile o projeto:



```bash

dotnet build

```



Instale os navegadores do Playwright no Windows PowerShell:



```powershell

.ProjetoTestePlaywrightbinDebugnet10.0playwright.ps1 install

```



Execute os testes:



```bash

dotnet test

```



## Execução Headless



O projeto permite configurar a execução do navegador através do arquivo:



```text

Config/appsettings.json

```



Para executar visualizando o navegador:



```json

"Headless": false

```



Para executar sem interface gráfica:



```json

"Headless": true

```



## Autor



**Angelo Daniel Dantas**



GitHub: DantasNPR

