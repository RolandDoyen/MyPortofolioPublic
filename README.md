# My Portfolio
This site presents my projects, resume, and technical skills through a modern, responsive, and minimalist interface.

> **Note:** This public repository is a polished version of the project for showcase purposes. Development and automated CI/CD pipelines to Azure are managed through a private repository, which explains the simplified commit history here.

## 📌 Table of Contents
- [My Portfolio](#my-portfolio)
  - [📌 Table of Contents](#-table-of-contents)
  - [🚀 Live Demo](#-live-demo)
  - [🛠️ Tech Stack](#️-tech-stack)
  - [✨ Key Features](#-key-features)
  - [🏛️ Architecture \& Philosophy](#️-architecture--philosophy)
  - [📂 Project Structure](#-project-structure)
  - [📡 Project Content](#-project-content)
  - [🚀 Deployment](#-deployment)
  - [⚙️ Installation \& Local Setup](#️-installation--local-setup)


## 🚀 Live Demo
The portfolio is deployed and accessible here:  
**[👉 Visit Portfolio](https://portofolio-rd.azurewebsites.net)**


## 🛠️ Tech Stack
- **Backend:** .NET 8 (ASP.NET Core) for robust server-side logic and request management.
- **Frontend:** Blazor (Server/WebAssembly) leveraging C# for an interactive and reactive user interface.
- **Styling:** Bootstrap for a modern and fully responsive design.
- **Localization:** ASP.NET Core Localization (Resource files) for seamless multi-language support.
- **DevOps:** GitHub Actions for automated CI/CD pipelines and continuous deployment.


## ✨ Key Features
- **Full Localization:** Dynamic multi-language support (English/French) via ASP.NET Core Resource files.
- **Dual Blazor Hosting:** Hybrid implementation using both Blazor Server and WebAssembly.
- **Professional UI/UX:** Clean, minimalist design focusing on accessibility and readability.
- **Automated CI/CD:** Live deployment workflow ensuring the site is updated via GitHub Actions.


## 🏛️ Architecture & Philosophy
The project follows a clean **MVC / Component-based** approach to ensure maintainability:
- **Separation of Concerns:** Clear distinction between views, static assets, and localization resources.
- **Minimalist Design:** Focus on performance and readability to highlight professional content.
- **Dynamic Localization:** Using a dedicated controller to handle culture switching seamlessly.


## 📂 Project Structure
The solution is organized to manage localized content and static assets efficiently:

- **Controllers/**: Logic for navigation and culture management.
  - `CultureController.cs`: Handles language switching.
  - `HomeController.cs`: Manages main page routing.
- **Views/**: Razor views for the UI.
  - `Home/`: Page-specific views (Index, Projects, CV).
  - `Shared/`: Layouts and reusable partials (Language Switch).
- **Resources/**: `.resx` files containing translations for FR and EN.
- **wwwroot/**:
  - `css/`: Modular stylesheets for specific sections.
  - `files/`: Hosted PDF resumes in multiple languages.


## 📡 Project Content
1. **Main Pages:**
   - `/`: Home page with a professional summary.
   - `/Projects`: Detailed showcase of projects with tech stacks and links.
   - `/CV`: Integrated viewer and download options for resumes.
2. **Static Assets:**
   - Resumes are stored in `wwwroot/files` for direct access.
   - Custom styles are split into `cv.css`, `projects.css`, and `site.css` for better maintenance.


## 🚀 Deployment
- **Platform**: Hosted on **Azure App Service (Windows/Linux)**.
- **CI/CD**: Fully automated deployment via **GitHub Actions** (triggered on push) for seamless integration.


## ⚙️ Installation & Local Setup
**Prerequisites:** .NET 8 SDK

1. **Clone the repository:**
  ```bash
  git clone https://github.com/RolandDoyen/MyPortofolioPublic.git
  ```

2. **Restore NuGet packages:**
  ```bash
  dotnet restore
  ```

3. **Run the application:**
  ```bash
  dotnet run
  ```

The browser will open at `https://localhost:XXXX`.