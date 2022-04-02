### Projeto login e register 
Abra o visual studio code e no terminal siga os passos: <br/>
1° dotnet new webapp <br/>
2° instalar os pacotes <br/>
    <p align="center">
        <img src="wwwroot/assets/inicio.png"/> <br/>
    </p>
    <p>
        Adicione os pacotes necessários para a utilização do banco de dados sqlserver.
    </p>
    <p padding= 10px>
        <font color="green"> dotnet add package Microsoft.EntityFrameworkCore.Tools</font><br/>
        <font color="green"> dotnet add package Microsoft.EntityFrameworkCore.</font><br/>
        <font color="green">dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore</font>
    </p>
  
###	SqlServer e string de conexão
Confira nesse link como criar uma string de conexão [String de Conexao](https://www.youtube.com/watch?v=fZnEVPdjcic)

## Migrações
<p>dotnet ef migrations add InitialCreate</p>
<p>dotnet ef database update</p>