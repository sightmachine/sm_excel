## Getting Started
### Projects
- SightMahine.ExcelAddIn - Main Project which exists AddIn ribbon configuration, forms, business logic, exception classes, validators, HTTP clients.
- SightMachine.ExcelAddIn.Test - Consists of Unit and Integration tests.
- SightMachine.Installer - Build and Packaging configuration project, this is used to generate the installers with .EXE and .MSI formats.

## How to generate .EXE or .MSI installable
### Prerequisites
- Visual Studio 2019 or later version
- .Net Framework 4.8 or later
- Install Visual Studio extention [Windows Installer](https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects)
 
### Steps to Build the project
- Open [SightMachine.ExcelAddIn.sln](https://github.com/sightmachine/sm_excel/blob/main/SightMachine.ExcelAddIn/SightMachine.ExcelAddIn.sln)
- In Visual Studio, select Build -> Build Solution, or click Ctrl + Shift + B

### Generating installer
- Navigate to Solution Explorer and select SightMachine.Installer project
- Right click on SightMachine.Installer project and click Rebuild.
- This will build the installer and produce .EXE and .MSI files at location - sm_excel\SightMachine.Installer\Release
