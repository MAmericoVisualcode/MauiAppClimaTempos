# MauiAppClimaTempos
Agenda07DS3

Um aplicativo .NET MAUI simples para exibir informações climáticas de uma cidade.

## Visão Geral

Este aplicativo permite que o usuário digite o nome de uma cidade e visualize informações climáticas como:

* Latitude e Longitude
* Descrição do clima
* Velocidade do vento
* Visibilidade
* Horário do nascer e pôr do sol
* Temperatura máxima e mínima

O aplicativo também implementa tratamento de erros para cenários como cidade não encontrada e falta de conexão com a internet, exibindo mensagens informativas para o usuário.

## Funcionalidades

* **Busca por Cidade:** Permite inserir o nome de uma cidade para obter informações climáticas.
* **Exibição Detalhada:** Mostra latitude, longitude, descrição do clima, velocidade do vento, visibilidade, horários do nascer e pôr do sol, e temperaturas máxima e mínima.
* **Tratamento de Erros:**
    * Exibe uma mensagem clara quando a cidade pesquisada não é encontrada.
    * Apresenta um alerta amigável quando não há conexão com a internet.
* **Interface de Usuário MAUI:** Construído com o framework .NET MAUI, permitindo a execução em diversas plataformas (Android, iOS, Windows, macOS - embora o foco atual possa ser Android e Windows).
* **Uso de API de Clima:** Utiliza um serviço web (através da classe `DataService`) para obter os dados climáticos.

## Pré-requisitos

Antes de executar o aplicativo, você precisará ter o seguinte instalado em sua máquina de desenvolvimento:

* **Visual Studio 2022 ou posterior:** Com as cargas de trabalho do .NET MAUI instaladas.
* **.NET SDK:** A versão correta do .NET SDK (atualmente .NET 9) deve estar instalada. O Visual Studio geralmente cuida disso durante a instalação das cargas de trabalho MAUI.
* **Emulador Android ou dispositivo físico Android/Windows:** Para testar o aplicativo.


## Contribuição

Contribuições são bem-vindas! Se você encontrar algum problema ou tiver sugestões de melhorias, sinta-se à vontade para abrir uma Issue ou enviar um Pull Request.

1.  Faça um Fork do projeto.
2.  Crie uma Branch para sua Feature (`git checkout -b feature/NovaFuncionalidade`).
3.  Faça o Commit de suas mudanças (`git commit -am 'Adiciona nova funcionalidade'`).
4.  Faça o Push para a Branch (`git push origin feature/NovaFuncionalidade`).
5.  Abra um Pull Request.

## Autor
MAmericoVisualCode
