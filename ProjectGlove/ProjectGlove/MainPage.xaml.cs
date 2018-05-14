using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjectGlove
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            // Creating an async main function for all the asynchronous calls.
            //new MainPage().MainAsync().GetAwaiter().GetResult();
		}

        //public async Task MainAsync()
        //{
        //    var client = new DiscordSocketClient();

        //    client.Log += Log;

        //    string token = ""; // This is meant to be a private. Remember to move this elsewhere
        //    await client.LoginAsync(TokenType.Bot, token);
        //    await client.StartAsync();

        //    // Block this task until the program is closed
        //    await Task.Delay(-1);
        //}

        //private Task Log(LogMessage msg)
        //{
        //    Console.WriteLine(msg.ToString());
        //    return Task.CompletedTask;
        //}
	}
}
