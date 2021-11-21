# SaladBalanceCheck
Checks your balance on Salad.

## Usage
To use, you will need:
* A Salad account
* A PC that can run .NET 5 apps (and connect to the internet)

When you start the app, you will need 2 things: an sAccessToken and an sIdRefreshToken. You can find both of those by going to the tutorial [here](https://github.com/LITdevs/SaladBind#automatic-get-with-salad-auth-token).

## Building
To make working builds of SaladBalanceCheck, you will first have to download SaladAPI at https://github.com/thepwrtank18/SaladAPI. Follow the instructions there. I don't know why it doesn't include it automatically, but here you go.

After that, you need to download Newtonsoft.Json. You can search for it by right clicking the project, clicking "Manage NuGet Packages...", and browse for Newtonsoft.Json (let's be honest, it's gonna stay on the front page forever.)

After that, you have sucessfully made a working version of SaladBalanceCheck.
