# Premiere Pro Project Setup

This application helps in setting up a new project structure for Adobe Premiere Pro. It is based upon recommendations by Valentina Vee https://www.threads.net/@valentina.vee?xmt=AQGzAioU2TNgoeELymKkbXGXYUUrclPiOZTRH6y-JIU6i4s from her getting started course.
<p>Here's how it works:</p>

## Initialization

When the application starts, it initializes its components and sets up an event handler for the `KeyDown` event of the `textBoxProjectName` input field.

## Project Creation

When the `Create` button is clicked, the application calls the `CreateProjectStructureFromTemplate` method, waits for a second, and then closes the form.

## Project Structure Creation

The `CreateProjectStructureFromTemplate` method creates a new project structure based on a template. It performs the following steps:

- Checks if the project name entered in `textBoxProjectName` is not empty.
- Constructs the project folder path using the project name and the current date.
- Checks if the project folder already exists. If it does, it asks the user if they want to delete the existing project. If the user agrees, it deletes the existing project.
- Checks if the project template exists. If it doesn't, it creates the template and its subfolders.
- Copies the template into the new project folder.

## Template Checking

The `CheckTemplate` method checks if a template with the given name exists. If it doesn't, it creates the template and its subfolders.

## Enter Key Handling

The application also handles the `Enter` key press in the `textBoxProjectName` input field. If the `Enter` key is pressed, it calls the `CreateProjectStructureFromTemplate` method, waits for a second, and then closes the form.

## Auto-Closing Message Box

The application uses a custom `AutoClosingMessageBox` form that displays a message and automatically closes after a specified timeout. It's used to show a message to the user that the project has been created.
