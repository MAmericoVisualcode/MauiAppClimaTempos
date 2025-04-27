using MauiAppClimaTempos.Models;
using MauiAppClimaTempos.Services;
using Microsoft.Maui.Controls;

namespace MauiAppClimaTempos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_cidade.Text))
                {
                    Tempo? t = await DataService.GetPrevisao(txt_cidade.Text);

                    if (t != null)
                    {
                        string dados_previsao = "";

                        dados_previsao = $"Latitude: {t.lat} \n" +
                                         $"Longitude: {t.lon} \n" +
                                         $"Descrição: {t.description} \n" +
                                         $"Velocidade do Vento: {t.speed} m/s \n" +
                                         $"Visibilidade: {t.visibility} metros \n" +
                                         $"Nascer do Sol: {t.sunrise} \n" +
                                         $"Por do Sol: {t.sunset} \n" +
                                         $"Temp Máx: {t.temp_max} °C \n" +
                                         $"Temp Min: {t.temp_min} °C \n";

                        lbl_res.Text = dados_previsao;

                    }
                    else
                    {
                        lbl_res.Text = "Cidade não encontrada. Verifique o nome.";
                    }

                }
                else
                {
                    lbl_res.Text = "Preencha a cidade.";
                }

            }
            catch (System.Net.Http.HttpRequestException ex) when (ex.Message.Contains("No such host is known") || ex.Message.Contains("Unable to connect to the remote server"))
            {
                await DisplayAlert("Erro de Conexão", "Verifique sua conexão com a internet.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}