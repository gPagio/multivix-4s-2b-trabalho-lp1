<!-- Título -->
<h1 align="center">Trabalho Linguagem de Programação 1 - Professor André Bessa</h1>

<!-- Descrição -->
<p align="center">Este é o trabalho de Linguagem de Programação 1, no 2º Bimestre do 4º Semestre, a qual foi ministrada pelo <a href="https://github.com/bessax">Professor André Bessa</a></p>

<p align="center">
  <img src="https://github.com/gPagio/4s-1b-trabalho-lp1/blob/main/docs/banner.png?raw=true" alt="Cadastrando">
</p>

# Sobre
Esse é um sistema de cadastro de cadastro de blocos, idealizado em cima de empresas do ramo de mármore e granito. Construido pela interface de console, o mesmo busca apenas mostrar as funcionalidades mais básicas, sem se preocupar com estética ou interfaces GUI. O mesmo contempla 4 funções:

<p align="center">
  <img src="https://github.com/gPagio/4s-1b-trabalho-lp1/blob/main/docs/menu.png?raw=true" alt="Menu">
</p>

# Como Executar o Programa
Entre no diretório raiz do projeto e execute o comando **`dotnet run`**:
``````
multivix-4s-2b-trabalho-lp1\
``````
``````
dotnet run
``````

## 1 - Cadastrar Bloco
Essa opção do sistema recebe os dados do bloco a serem cadastrados para para posteriormente serem processados de acordo com a necessidade do usuario.
<p align="center">
  <img src="https://github.com/gPagio/4s-1b-trabalho-lp1/blob/main/docs/cadastrarBloco.png?raw=true" alt="Cadastrando">
</p>

## 2 - Listar Blocos
Essa opção do sistema lista todos os blocos cadastrados no sistema. Caso não exista nenhum bloco cadastrado o sistema informa que não existem blocos cadastrados e retorna ao menu principal para escolher uma nova opção. Ao final do cadastro do primeiro bloco um arquivo `.txt` é criado no diretório abaixo com cada bloco recém cadastrado, onde o mesmo é usado para guardar os demais blocos cadastrados em sequencia, funcionando como uma lista.
``````
multivix-4s-2b-trabalho-lp1\txt\blocos.txt
``````
<p align="center">
  <img src="https://github.com/gPagio/4s-1b-trabalho-lp1/blob/main/docs/listarBlocos.png?raw=true" alt="Listando Todos">
</p>

## 3 - Buscar Bloco por Código
Essa opção do sistema busca um bloco pelo código informado pelo usuário, caso não exista bloco com o código digitado o sistema informa que não existem blocos com o código digitado e retorna ao menu principal para escolher uma nova opção.
<p align="center">
  <img src="https://github.com/gPagio/4s-1b-trabalho-lp1/blob/main/docs/buscarPorCodigo.png?raw=true" alt="Listar por Codigo">
  <img src="https://github.com/gPagio/4s-1b-trabalho-lp1/blob/main/docs/listarComParametro.png?raw=true" alt="Listando por Codigo">
</p>

## 4 - Listar Blocos por Pedreira
Essa opção do sistema lista todos os blocos que vieram da pedreira informada pelo usuário, caso não exista bloco originado de determinada pedreira, o sistema informa que não existem blocos da pedreira digitada e retorna ao menu principal para escolher uma nova opção.
<p align="center">
  <img src="https://github.com/gPagio/4s-1b-trabalho-lp1/blob/main/docs/buscar%E1%B9%94orPedreira.png?raw=true" alt="Listar por Pedreira">
  <img src="https://github.com/gPagio/4s-1b-trabalho-lp1/blob/main/docs/listarComParametro.png?raw=true" alt="Listando por Pedreira">
</p>

# Exceções Tratadas

Adicionamos algumas validações contra exceções do programa, segue uma lista abaixo:

- **CodigoNaoExisteException:** valida caso o código informado na opção de buscar bloco por código não pertença a algum bloco.

- **ListaDeBlocosVaziaException:** valida caso ao tentar listar os blocos por alguma opção que realize tal ação e não exista blocos cadastrados no sistema.

- **PedreiraNaoListadaException:** valida caso a pedreira informada na opção de buscar bloco por pedreira não pertença a algum bloco.

Essas validações foram as principais falhas identificadas em nosso sistema e foram criadas para previnir tais erros.