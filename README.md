## Portfolio
This site presents my projects, my resume and my technical skills with a modern, responsive and minimalist interface.

## Table of Contents
- [Portfolio](#portfolio)
- [Table of Contents](#table-of-contents)
- [Technologies](#technologies)
- [Installation and Execution](#installation-and-execution)
- [Project Structure](#project-structure)
- [Project Content](#project-content)
- [Features](#features)

## Technologies
- Backend: C#, ASP.NET Core
- Frontend: Blazor, HTML5, CSS3, Bootstrap

## Installation and Execution
1. Clone the repository
    ```html
    git clone https://github.com/RolandDoyen/MyPortofolioPublic.git
    cd ClanManager
    ```
2. Restore NuGet packages if necessary
    ```html
    dotnet restore
    ```
3. Run the application
    ```html
    dotnet run
    ```
4. Access the application:
    ```html
    https://localhost:44342/
    ```

## Project Structure
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

## Project Content
1. Main Pages :
  - `/` : Home page with presentation and links to projects and CV
  - `/Projects` : List of projects with description, technologies, live site link, and GitHub link
  - `/CV` : View and download the CV in PDF (FR/EN)
2. Static Files :  
  - `wwwroot/files` : CV PDFs
  - `wwwroot/css` : Styles
3. Resources :  
  - `Resources.resx` : Multilingual texts  
  - `Resources.Designer.cs` : Automatic resource binding in code

##  Features
- The site is available in French (FR) and English (EN)
- The CV PDF files automatically change according to the selected language