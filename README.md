# Premiere Pro Project Setup

This application helps in setting up a new project structure for Adobe Premiere Pro. 
<p>Here's how it works:</p>
<p>1. Enter the project name in the Project Name text input field.</p>
<p>2. Click the Create button or the Enter Key</p>
<p>3. The application creates a new set of project folders with the project name prefixed by the current date.  So even if you reuse the same project name the new project will be unqiue to the day.</p>
<p>4. The application copies the contents of the ProjectTemplate folder to the new project folder.</p>
<p>5. Any files in the ProjectTemplate folder are copied into the new project.
- Your logo file into the graphics folder
- Some default music for use while you are editing
- Default project files. An Instagram project is included. 
</p>
<p>6. Any files in the ProjectTemplate folder with the _Default in the name they will be renamed replacing the _Default with the project name.</p>

## Initialization

When the application starts, it initializes its components and sets up an event handler for the `KeyDown` event of the `textBoxProjectName` input field.

## Project Creation

When the `Create` button is clicked, the application calls the `CreateProjectStructureFromTemplate` method, waits for a second, and then closes the form.

## Project Structure Creation

The `CreateProjectStructureFromTemplate` method creates a new project structure by copying the folders and files from a template. It performs the following steps:

- Checks if the project name entered in `textBoxProjectName` is not empty.
- Constructs the project folder path using the project name and the current date.
- Checks if the project folder already exists. If it does, it asks the user if they want to delete the existing project. If the user agrees, it deletes the existing project.
- Checks if the project template exists. If it doesn't, it creates the template and its subfolders.
- Copies the template into the new project folder.

<p>The program expects to find a <em>ProjectTemplate</em> folder which contains your default organization structure for the project and any files you want to include in all your projects; including a <em>DefaultProject.prproj</em></p>
<p>Structure is based upon recommendations by Valentina Vee https://www.threads.net/@valentina.vee?xmt=AQGzAioU2TNgoeELymKkbXGXYUUrclPiOZTRH6y-JIU6i4s from her getting started course.</p>
Change them however you want.


## Template Checking

The `CheckTemplate` method checks if a template with the given name exists. If it doesn't, it creates the template and its subfolders.

## Enter Key Handling

The application also handles the `Enter` key press in the `textBoxProjectName` input field. If the `Enter` key is pressed, it calls the `CreateProjectStructureFromTemplate` method, waits for a second, and then closes the form.

## Auto-Closing Message Box

The application uses a custom `AutoClosingMessageBox` form that displays a message and automatically closes after a specified timeout. It's used to show a message to the user that the project has been created.

## Coding modifications
Line 5 of the Form1.cs file has the Path to Premiere Pro Root Directory on my machine E:\Adobe\PremierePro
