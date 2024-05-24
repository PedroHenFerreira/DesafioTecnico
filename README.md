<h1>Desafio técnico</h1>
<!-- <h2>Sobre:</h2> -->
<p>O desafio consiste nas seguintes etapas resumidamente:</p>
<li>Consumir a API Random User Generator para gerar novos usuários;</li>
<li>Criar uma tabela no PostgreSQL para armazenar os dados gerados pela API;</li>
<li>Criar uma página HTML para mostrar um relatório com todos os usuários que constam no banco de dados.</li>

<h2>Índice:</h2>
<ol>
  <a href="#autor"><li>Autor</li></a>
  <a href="#stack"><li>Linguagens/Frameworks</li></a>
  <a href="#descricao"><li>Descrição</li></a>
  <a href="#instalacao"><li>Instalação</li></a>
  <a href="#configuracao"><li>Configuração</li></a>
  <a href="#uso"><li>Uso</li></a>
</ol>

<h2 id="autor">Autor:</h2>
<li>Pedro Ferreira</li>

<h2 id="stack">Linguagens/Frameworks:</h2>
<h3>Back-end:</h3>
<li>C#/.NET</li>
<h3>Front-end:</h3>
<li>React JS</li>

<h2 id="descricao">Descrição:</h2>
<p>A aplicação está dividida em três pastas: Back, DesafioApi e Front. Na pasta Back, encontra-se toda a parte dedicada à consumir a API Random User Generator e criar tal instância no banco de dados.</p>
<p>Na pasta DesafioApi, encontra-se toda a parte dedicada à criação da model, controller e rotas da tabela criada no PostgreSQL.</p>
<p>Na pasta front, encontra-se toda a parte dedicada à criação e integração da página de relatório dos usuários.</p>

<h2 id="instalacao">Instalação:</h2>
<p>Após clonar este projeto em seu computador e tendo todos os pré-requisitos instalados, faremos o setup em cada uma das pastas.</p>
<h3>Pasta <i>Back</i>:</h3>
<p>Nesta pasta, rode os seguintes comandos através do terminal:</p>
<pre><code>dotnet add package Newtonsoft.Json</code></pre>
<p><b>IMPORTANTE!</b> É necessário instalar a versão 106.11.7 do RestSharp para evitar erros no código.</p>
<pre><code>dotnet add package RestSharp --version 106.11.7</code></pre>
<h3>Pasta <i>DesafioApi</i>:</h3>
<p>Nesta pasta, rode os seguintes comandos através do terminal:</p>
<pre><code>dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL</code></pre>
<pre><code>dotnet add package Microsoft.EntityFrameworkCore.Design</code></pre>
<pre><code>dotnet add package Microsoft.AspNetCore.Cors</code></pre>
<h3>Pasta <i>front</i>:</h3>
<p>Nesta pasta, rode os seguintes comandos através do terminal:</p>
<pre><code>npm install</code></pre>

<h2 id="configuracao">Configuração:</h2>
<h3>Pasta <i>Back</i>:</h3>
<p>No arquivo <i>Program.cs</i>, talvez possa ser necessário que a porta usada na url da linha 16 seja diferente. Essa mudança pode ocorrer devido à configuração da sua máquina.</p>
<h3>Pasta <i>DesafioApi</i>:</h3>
<p>Execute o seguinte comando para realizar a migração da tabela Users no banco de dados PostgreSQL:</p>
<pre><code>dotnet ef migrations add UsersMigration</code></pre>
<p>Em seguida, execute o seguinte comando para atualizar a tabela:</p>
<pre><code>dotnet ef database update</code></pre>
<p><b>Obs:</b> No arquivo <i>appsettings.json</i>, deve-se ajustar os parâmetros para conexão com o banco de dados, na linha 3, de acordo com as credenciais da sua máquina e conta PostgresSQL.</p>

<h2 id="uso">Uso:</h2>
<h3>Pasta <i>Back</i>:</h3>
<p>Execute o seguinte comando para executar todo o código. Atente-se que esse conteúdo consome a API Random User Generator e criar novos registros na tabela Users no PostgreSQL.</p>
<pre><code>dotnet run</code></pre>
<h3>Pasta <i>DesafioApi</i>:</h3>
<p>Execute o seguinte comando para servir a API relacionada à tabela Users no banco de dados PostgreSQL. Atente-se que o terminal deverá ficar ativo durante o uso da aplicação:</p>
<pre><code>dotnet run</code></pre>
<h3>Pasta <i>front</i>:</h3>
<p>Execute o seguinte comando para servir a o front-end da aplicação. Atente-se que o terminal deverá ficar ativo durante o uso da aplicação:</p>
<pre><code>npm start</code></pre>
