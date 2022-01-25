
<h1 align="center">
  <img style="font-size: 14px;" src="https://www.clipartmax.com/png/full/422-4223441_important-clipart-todo-list-task-icon-mac.png" width="26" height="26" />
  Todo App
</h1>

<p align="center">API pada gerenciamento de To Do com .Net 6. Utilizando DI, EF, Sqlite e MVC.</p>

<p align="center">
  <img src="https://img.shields.io/badge/license-MIT-green" /> 
  <img src="https://img.shields.io/badge/build-passing-brightgreen" />
  <img src="https://img.shields.io/badge/dotnet--version-net6.0-orange" /> 
  <img src="https://img.shields.io/badge/Progresso-100%25-blue" />
</p>
<hr />

## Features
  <input id="cadastro" checked="checked" type="checkbox" /> 
  <label for="cadastro">Cadastro de To Do</label> <br />
  
  <input id="edicao" checked="checked" type="checkbox" />
  <label for="edicao">Atualiza&ccedil;&atilde;o de To Do</label> <br />
  
  <input id="busca_todos" checked="checked" type="checkbox" /> 
  <label for="busca_todos">Busca de todos os To Do</label> <br />
  
  <input id="busca_id" checked="checked" type="checkbox" /> 
  <label for="busca_id">Busca de To Do por Id</label> <br />
  
  <input id="excluir" checked="checked" type="checkbox" /> 
  <label for="excluir">Exclus&atilde;o de To Do</label>
<hr />

## Pré-Requisitos
<p>Antes de come&ccedil;ar, voc&ecirc; vai precisar ter instalado em sua m&aacute;quina as seguintes feramentas: <a href="https://dotnet.microsoft.com/en-us/download/dotnet/6.0">Runtime ou SDK .Net 6.0.1.</a> Al&eacute;m disto &eacute; bom ter um editor para trabalhar com o c&oacute;digo como <a href="https://code.visualstudio.com/">VSCode.</a> E instalar a extens&atilde;o do C# <strong>ms-dotnettools.csharp</strong>. Para realizar o envio das requisi&ccedil;&otilde;es pode ser utilizado o <a href="https://www.postman.com/">Postman</a> ou algum outra maneira de seu gosto.</p>
<h4>🎲 Rodando o Back End (servidor)</h4>
<p># Clone este reposit&oacute;rio</p>
<p>git clone <a href="mailto:git@github.com:PerezVitor/Todo_App.git">git@github.com:PerezVitor/Todo_App.git</a></p>
<p># Acesse a pasta do projeto no terminal/cmd</p>
<p>cd Todo_App</p>
<p>#Execute o projeto</p>
<p>dotnet run</p>
<p>#Verifique a url para realizar o envio das requisi&ccedil;&otilde;es</p>
<p>Ex: https://localhost:7195</p>
<p>#Cole no Postman e realize o envio</p>
<h5>Para realizar os envios devem ser feitos conforme exemplo abaixo</h5>
<ol>
  <li><strong>Buscar por todos os To Do</strong>- GET | https://localhost:7195</li>
  <li><strong>Buscar To Do por Id</strong> - GET | https://localhost:7195/1</li>
  <li><strong>Inserir novo To Do</strong> - POST | https://localhost:7195/1 | Body { id: 35, title: "Ir ao mercado", done: false, createdAt: "2022-01-25T14:50" }</li>
  <li><strong>Atualizar um To Do</strong> - PUT | https://localhost:7195 | Body { id: 35, title: "Ir ao mercado", done: false }</li>
  <li><strong>Excluir um To Do</strong> - DELETE | https://localhost:7195/1</li>
</ol>
<hr />

## 🛠 Tecnologias
<ul style="list-style-type: circle;">
<li>.Net 6.0</li>
<li>Sqlite</li>
<li>C#</li>
</ul>
<hr />

## Autor
Feito Por Vitor Perez

[![Linkedin Badge](https://img.shields.io/badge/-Vitor%20Perez-blue?style=flat-square&amp;logo=Linkedin&amp;logoColor=white&amp;link=https://www.linkedin.com/in/vitor-perez-524b8787/)](https://www.linkedin.com/in/vitor-perez-524b8787)
[![Hotmail Badge](https://img.shields.io/badge/-Hotmail-0078D4?style=flat-square&amp;logo=microsoft-outlook&amp;logoColor=white&amp;link=mailto:perez.vitor@outlook.com)](mailto:perez.vitor@outlook.com)

<hr/>
## :memo: License
[LICENSE](https://github.com/PerezVitor/Todo_App/blob/main/LICENSE) for more information.
