# SaladBalanceCheck
Checks your balance on Salad.

## Usage
To use, you will need:
* A Salad account
* A PC that can run .NET 5 apps (and connect to the internet)

When you start the app, you will need 2 things: an sAccessToken and an sIdRefreshToken. You can find both of those by going to the tutorial [here](https://github.com/LITdevs/SaladBind#automatic-get-with-salad-auth-token).

For security reasons, these tokens are not saved on your device. Also, I'm not stealing your balance. Would you think the source code would be open if it did?

After that, you can set the decimal places. So if you had $69.42012345678901, and you said to only put in 2 decimal places, it would round to $69.42. 3 is $69.420, 4 is $69.4201, etc. Note that rounding does happen here. Minimum 1, max 14, default 2.

After that, you can finally start it! Every 5 seconds, it will report to Salad's API the current balance (better than Salad's default 5 minutes). When you stop it, it will stop after doing 1 last refresh.

## Building
To make working builds of SaladBalanceCheck, you will first have to download SaladAPI at https://github.com/thepwrtank18/SaladAPI. Follow the instructions there. I don't know why it doesn't include it automatically, but here you go.

After that, you need to download Newtonsoft.Json. You can search for it by right clicking the project, clicking "Manage NuGet Packages...", and browse for Newtonsoft.Json (let's be honest, it's gonna stay on the front page forever.)

After that, you have sucessfully made a working version of SaladBalanceCheck.
