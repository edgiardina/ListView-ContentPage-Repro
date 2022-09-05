using ListView_ContentPage_Repro.Models;
using System.Reflection;
using System.Text.Json;

namespace ListView_ContentPage_Repro;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        var a = Assembly.GetExecutingAssembly();
        using var stream = a.GetManifestResourceStream("ListView_ContentPage_Repro.Models.tournamentresults.json");
        var result = JsonSerializer.DeserializeAsync<List<TournamentResult>>(stream, 
            new JsonSerializerOptions { 
                NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString                
            }
            ).Result;

        MyListView.ItemsSource = result;
    }

}

