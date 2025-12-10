## Portfolio
Ce site présente mes projets, mon CV et mes compétences techniques avec une interface moderne, responsive et minimaliste.

## Table des matières
- [Portfolio](#portfolio)
- [Table des matières](#table-des-matieres)
- [Technologies](#technologies)
- [Installation et exécution](#installation-et-execution)
- [Structure du projet](#structure-du-projet)
- [Contenu du projet](#contenu-du-projet)
- [Fonctionnalités](#fonctionnalites)

## Technologies
- Backend : C#, ASP.NET Core 
- Frontend : Blazor, HTML5, CSS3, Bootstrap

## Installation et exécution
1. Clonez le repository
```html
git clone https://github.com/RolandDoyen/MyPortofolioPublic.git
cd ClanManager
```
3. Restaurez les packages NuGet si nécessaire
```html
dotnet restore
```
4. Lancez l'application
```html
dotnet run
```
5. Accédez à l'application
```html
https://localhost:44342/
```

## Structure du projet
- wwwroot
  - css
    - cv.css
    - projects.css
    - site.css
  - files
    - Roland_Doyen_CV_EN.pdf
    - Roland_Doyen_CV_FR.pdf
- Controllers
  - CultureController.cs
  - HomeController.cs
- Resources
  - Resources.en.resx
  - Resources.fr.resx
  - Resources.resx
- Views
  - Home
    - CV_EN.cshtml
    - CV_FR.cshtml
    - Index.cshtml
    - Projects.cshtml
  - Shared
    - _LanguageSwitch.cshtml
    - _Layout.cshtml
    - _ValidationScriptsPartial.cshtml
    - Error.cshtml
  - _ViewImports.cshtml
  - _ViewStart.cshtml
- appsetting.json
- Program.cs  

## Contenu du projet
1. Pages principales :
  - `/` : Accueil avec présentation et liens vers projets et CV
  - `/Projects` : Liste des projets avec description, technologies, lien site et GitHub
  - `/CV` : Consultation et téléchargement du CV en PDF (FR/EN)
2. Fichiers statiques :  
  - `wwwroot/files` : PDF des CV  
  - `wwwroot/css` : Styles
3. Ressources :  
  - `Resources.resx` : Textes multilingues  
  - `Resources.Designer.cs` : Lien automatique des ressources au code

##  Fonctionnalités
- Le site est disponible en Français (FR) et en Anglais (EN -> English)
- Les fichiers PDF du CV changent automatiquement selon la langue sélectionnée