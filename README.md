# buscampregos
Projeto Web em ASPN.NET MVC | Criado para a matéria de Programação Web da Faculdade

## Sobre o projeto
O sistema permite navegar pelas vagas existentes e cadastrar novas vagas. A persistência existe, pois criamos um banco de dados que armazena todos esses itens.

## Grupo
- Alisson Felipe Lima Santos 
- Kledyson Henrique Goes dos Santos
- Matheus Gonçalves Ferreira Barreto 
- Natan Nascimento Oliveira Matos
- Pablo vinicius chaves cortes
- Vitor Luan Brito santos

## Configurar BD
Para utilizar um banco de dados local ou externo é necessário acessar o arquivo appsettings.json e alterar o valor dos itens:
Server, User Id e Password (conforme configuração)

### Criar tabelas
Após configurar o banco, basta executar o seguinte comando no Package Manager Console do Visual Studio:
`Update-Database -Context BancoContext`
Este comando irá criar as tabelas necessárias para funcionamento do sistema, com base nos arquivos da pasta Migrations deste projeto.

* Caso você seja meu professor: não precisa criar um banco de dados, pois junto com os arquivos enviamos o endereço e usuário para acesso remoto ao BD que criamos para esse projeto.