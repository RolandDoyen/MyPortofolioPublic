# Mon Portfolio
Ce site présente mes projets, mon CV et mes compétences techniques à travers une interface moderne, réactive et minimaliste.

> **Note :** Ce dépôt public est une version finalisée du projet destinée à mon portfolio. Le développement et les pipelines CI/CD vers Azure sont gérés via un dépôt privé, ce qui explique l'historique simplifié des commits ici.

## 📌 Table des matières
- [Mon Portfolio](#mon-portfolio)
  - [📌 Table des matières](#-table-des-matières)
  - [🚀 Démo en direct](#-démo-en-direct)
  - [🛠️ Stack Technique](#️-stack-technique)
  - [🏛️ Architecture \& Philosophie](#️-architecture--philosophie)
  - [📂 Structure du projet](#-structure-du-projet)
  - [📡 Contenu du projet](#-contenu-du-projet)
  - [✨ Fonctionnalités](#-fonctionnalités)
  - [🚀 Déploiement](#-déploiement)
  - [⚙️ Installation \& Configuration locale](#️-installation--configuration-locale)


## 🚀 Démo en direct
Le portfolio est déployé et accessible ici :  
**[👉 Visiter le Portfolio](https://rolanddoyen.com)** *(Remplacez par votre lien réel)*


## 🛠️ Stack Technique
- **Backend :** C# / ASP.NET Core
- **Frontend :** Blazor Server / WebAssembly, HTML5, CSS3
- **Design :** Bootstrap pour un rendu responsive et "mobile-first".
- **Localisation :** ASP.NET Core Localization (fichiers de ressources) pour le support multilingue.


## 🏛️ Architecture & Philosophie
Le projet suit une approche **MVC / Composants** propre pour garantir la maintenabilité :
- **Séparation des préoccupations :** Distinction claire entre les vues, les ressources statiques et les ressources de localisation.
- **Design Minimaliste :** Priorité à la performance et à la lisibilité pour mettre en valeur le contenu professionnel.
- **Localisation Dynamique :** Utilisation d'un contrôleur dédié pour gérer le changement de langue de manière fluide.


## 📂 Structure du projet
La solution est organisée pour gérer efficacement le contenu localisé et les fichiers statiques :

- **Controllers/** : Logique pour la navigation et la gestion de la culture.
  - `CultureController.cs` : Gère le basculement de langue.
  - `HomeController.cs` : Gère le routage des pages principales.
- **Views/** : Vues Razor pour l'interface utilisateur.
  - `Home/` : Vues spécifiques aux pages (Index, Projets, CV).
  - `Shared/` : Layouts et vues partielles réutilisables (sélecteur de langue).
- **Resources/** : Fichiers `.resx` contenant les traductions FR et EN.
- **wwwroot/** :
  - `css/` : Feuilles de style modulaires pour des sections spécifiques.
  - `files/` : CV au format PDF hébergés en plusieurs langues.


## 📡 Contenu du projet
1. **Pages principales :**
   - `/` : Page d'accueil avec un résumé professionnel.
   - `/Projects` : Présentation détaillée des projets avec stacks techniques et liens.
   - `/CV` : Visionneuse intégrée et options de téléchargement pour les CV.
2. **Ressources statiques :**
   - Les CV sont stockés dans `wwwroot/files` pour un accès direct.
   - Les styles personnalisés sont divisés en `cv.css`, `projects.css` et `site.css` pour une meilleure maintenance.


## ✨ Fonctionnalités
- **Support multilingue :** Site entièrement disponible en français (FR) et en anglais (EN).
- **CV Adaptatif :** La visionneuse de CV et les liens de téléchargement se mettent à jour automatiquement selon la langue sélectionnée.
- **Interface Responsive :** Optimisée pour les ordinateurs, tablettes et appareils mobiles.


## 🚀 Déploiement
- **Plateforme** : Hébergé sur **Azure App Service (Windows/Linux)**.
- **CI/CD** : Déploiement entièrement automatisé via **GitHub Actions** (déclenché au push) pour une intégration continue.


## ⚙️ Installation & Configuration locale
Suivez ces étapes pour exécuter le portfolio localement.

**Prérequis**
* **SDK .NET 8**
* **Visual Studio 2022** ou **VS Code**

**Étapes**
1. **Cloner le dépôt :**
  ```bash
  git clone https://github.com/RolandDoyen/MyPortofolioPublic.git
  cd MyPortofolioPublic
  ```

2. **Restaurer les packages NuGet :**
  ```bash
  dotnet restore
  ```

3. **Lancer l'application :**
  ```bash
  dotnet run
  ```

4. **Accéder au site :**
Ouvrez votre navigateur et allez sur `https://localhost:XXXX/`.