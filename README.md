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

## Como Executar

Siga estes passos para executar o aplicativo:

1.  **Clone o repositório:** Se você ainda não clonou este projeto do GitHub, faça isso usando o comando:
    ```bash
    git clone <URL_DO_SEU_REPOSITORIO>
    ```
2.  **Abra a solução no Visual Studio:** Navegue até a pasta do projeto (`MauiAppClimaTempos`) e abra o arquivo de solução (`.sln`).
3.  **Selecione o destino:** Na barra de ferramentas do Visual Studio, selecione o dispositivo ou emulador para o qual você deseja executar o aplicativo (por exemplo, um emulador Android ou "Desktop" para Windows).
4.  **Execute o aplicativo:** Pressione o botão "Play" (geralmente um triângulo verde) ou vá em "Debug" > "Start Debugging" (Depurar > Iniciar Depuração).

## Estrutura do Projeto
MauiAppClimaTempos/
├── .git/
├── .gitignore
├── MauiAppClimaTempos/
│   ├── App.xaml
│   ├── App.xaml.cs
│   ├── Controls/
│   │   └── ... (seus controles personalizados)
│   ├── MainPage.xaml
│   ├── MainPage.xaml.cs
│   ├── Models/
│   │   ├── Category.cs
│   │   ├── CategoryChartData.cs
│   │   └── Tempo.cs
│   ├── PageModels/
│   │   └── ... (seus PageModels, se utilizando MVVM)
│   ├── Pages/
│   │   └── ... (suas outras páginas)
│   ├── Platform/
│   │   ├── Android/
│   │   └── iOS/
│   ├── Resources/
│   │   ├── ... (imagens, fontes, estilos)
│   ├── Services/
│   │   └── DataService.cs
│   ├── MauiAppClimaTempos.csproj
│   └── ... (outros arquivos)
├── MauiAppClimaTempos.sln
└── README.md

## Contribuição

Contribuições são bem-vindas! Se você encontrar algum problema ou tiver sugestões de melhorias, sinta-se à vontade para abrir uma Issue ou enviar um Pull Request.

1.  Faça um Fork do projeto.
2.  Crie uma Branch para sua Feature (`git checkout -b feature/NovaFuncionalidade`).
3.  Faça o Commit de suas mudanças (`git commit -am 'Adiciona nova funcionalidade'`).
4.  Faça o Push para a Branch (`git push origin feature/NovaFuncionalidade`).
5.  Abra um Pull Request.

## Autor
MAmericoVisualCode
