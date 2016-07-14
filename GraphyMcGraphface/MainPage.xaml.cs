using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GraphyMcGraphface
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            // Set the client id to the registered application Graphy McGraphface
            PublicClientApplication pca = new PublicClientApplication("ac8ce5fc-e6d8-437d-9254-6d4cba2e2d1f");

            // Define permission scope to read mail
            string[] scopes = new string[] { "Mail.Read" };

            // Graph request URL to get "my" messages
            string apiURL = "https://graph.microsoft.com/beta/me/messages";

            // Get the authorization token
            AuthenticationResult ar = await pca.AcquireTokenAsync(scopes);

            // Set up HTTP request
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, apiURL);

            // Add the authorization token to the HTTP header of the request
            message.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", ar.Token);

            // Make HTTP request and get the response
            HttpResponseMessage response = await client.SendAsync(message);

            // Display the response message in the text box.
            txtResults.Text = await response.Content.ReadAsStringAsync();

        }
    }
}
