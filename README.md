# CryptocurrencyAPI
A very basic REST Web API for getting and adding Cryptocurrencies

In order to setup the database, do the following:

1. In the appsetting.json (inside CryptoCurrencyAPI.Api project), set the DBConnection value (under ConnectionStrings) 
to your SQLServer instance.

2. Open NuGet Package Manager -> Package Manage Console and, after selecting the default project to be CryptoCurrencyAPI.DataLayer, 
run update-database
