# frituur-twiel

Bij het deployen van de Web App had ik een probleem. Wanneer ik in VS Code rechtsklikte op de .Api-folder en "Deploy to Web App" gebruikte, werd enkel de inhoud van die specifieke map gezipt. Omdat mijn Shared-project in een andere map staat (src/Shared) en via een project-referentie gebruikt wordt door de API, werd dit niet meegenomen in de deployment, waardoor de build op Azure faalde met "referenced project does not exist".

De oplossing was om de applicatie zelf lokaal te builden en publiceren met dotnet publish, zodat alle project-referenties correct worden meegenomen in de output:

dotnet publish src\Products\FrituurTWiel.Products.Api\FrituurTWiel.Products.Api.csproj -c Release -o .\publish

Vervolgens deploy ik de publish-map naar Azure. Omdat deze map al kant-en-klare, gebouwde bestanden bevat (geen broncode), heb ik in de Azure Web App-configuratie ook SCM_DO_BUILD_DURING_DEPLOYMENT op false gezet, zodat Azure geen eigen (foutieve) build-poging meer doet op de reeds gepublishte bestanden.
