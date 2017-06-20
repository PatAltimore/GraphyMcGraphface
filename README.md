# GraphyMcGraphface
Super simple Microsoft Graph API UWP app to illustrate basic requirements.

This sample is based on the demo highlighted in this video: https://channel9.msdn.com/Shows/Office-Dev-Show/Office-Dev-Show-Episode-27-Azure-AD-Converged-Authentication-and-the-Microsoft-Graph

## Suggested demo steps

### Registration 
1.	Show client id in the registration portal https://apps.dev.microsoft.com/#/appList  
1.	Show same tenet has the app registered in the management portal too. http://manage.windowsazure.com/
1.	Open Graphy app. 
1.   Show it uses the MSAL nuget package
1.	Show PublicClientApplication object created using client ID. 

### Permissions
1.	MSAL library and Azure AD V2 endpoint allows us to define the permission scopes programmatically.
1.	We can see that we only need the scope “Mail.Read”.  If I looked at the documentation, it would show me the permission scopes required for a request.

### Get token
1.	Use the PublicClientApplication object to acquire an access token.  
1.	We need the token to add it to the HTTP header of our request.

### Make  REST request
1.	Use .NET’s HTTP Client class to do a HTTP request & response.  This is our REST call to the endpoint.

### Run the code
1.	Use a test Office 365 account.
2.  Do something else that Pat really likes. 

