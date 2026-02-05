# Mon Portfolio
Ce site présente mes projets, mon CV et mes compétences techniques à travers une interface moderne, réactive et minimaliste.

> **Note :** Ce dépôt public est une version finalisée du projet destinée à mon portfolio. Le développement et les pipelines CI/CD vers Azure sont gérés via un dépôt privé, ce qui explique l'historique simplifié des commits ici.

## 📌 Table des matières
- [Mon Portfolio](#mon-portfolio)
  - [📌 Table des matières](#-table-des-matières)
  - [🚀 Démo en direct](#-démo-en-direct)
  - [🛠️ Stack Technique](#️-stack-technique)
  - [✨ Fonctionnalités Principales](#-fonctionnalités-principales)
  - [🏛️ Architecture \& Philosophie](#️-architecture--philosophie)
  - [📂 Structure du projet](#-structure-du-projet)
  - [📡 Contenu du projet](#-contenu-du-projet)
  - [🚀 Déploiement](#-déploiement)
  - [⚙️ Installation \& Configuration locale](#️-installation--configuration-locale)


## 🚀 Démo en direct
Le portfolio est déployé et accessible ici :  
**[👉 Visiter le Portfolio](https://portofolio-rd.azurewebsites.net)**


## 🛠️ Stack Technique
- **Backend :** .NET 8 (ASP.NET Core) pour une logique serveur robuste et une gestion efficace des requêtes.
- **Frontend :** Blazor (Server/WebAssembly) exploitant le C# pour une interface utilisateur interactive et réactive.
- **Styling :** Bootstrap pour un design moderne et entièrement responsive.
- **Localisation :** Localisation ASP.NET Core (fichiers de ressources) pour une prise en charge multilingue fluide.
- **DevOps :** GitHub Actions pour des pipelines CI/CD automatisés et un déploiement continu.


## ✨ Fonctionnalités Principales
- **Localisation Complète :** Prise en charge dynamique multilingue (anglais/français) via les fichiers de ressources ASP.NET Core.
- **Hébergement Blazor Hybride :** Implémentation mixte utilisant à la fois Blazor Server et WebAssembly.
- **UI/UX Professionnelle :** Design épuré et minimaliste axé sur l’accessibilité et la lisibilité.
- **CI/CD Automatisée :** Workflow de déploiement continu assurant la mise à jour automatique du site via GitHub Actions.


## 🏛️ Architecture & Philosophie
Le projet suit une approche propre **MVC / Composants** pour garantir une maintenabilité optimale :
- **Séparation des Responsabilités :** Distinction claire entre les vues, les assets statiques et les ressources de localisation.
- **Design Minimaliste :** Priorité à la performance et à la lisibilité pour mettre en valeur le contenu professionnel.
- **Localisation Dynamique :** Utilisation d’un contrôleur dédié pour gérer le changement de culture de manière fluide.


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


## 🚀 Déploiement
- **Plateforme** : Hébergé sur **Azure App Service (Windows/Linux)**.
- **CI/CD** : Déploiement entièrement automatisé via **GitHub Actions** (déclenché au push) pour une intégration continue.


## ⚙️ Installation & Configuration locale
**Prérequis** .NET 8 SDK

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

Le navigateur s’ouvrira sur `https://localhost:XXXX`.