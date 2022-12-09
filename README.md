# MAUI Templates

Little repository to keep some project and item templates that I use for MAUI development.

The TemplateZipper.csproj is a console app that I'm using to zip the template folders up so I can make changes. No idea if this is how it should be done.

## Templates

|Name|Type|Description|
|---|--|
|BaseMAUIMVVM |Project |Contains a fully wired up MVVM MAUI Shell app</br></br>- Extensions to register pages and services</br>- BaseViewModelPage which wires up some lifecycle events to an injected view model</br>- BaseViewModel with some observable properties using MAUI community toolkit
|ViewModelPage|Item|Creates a page which inherits from BasePageViewModel and creates and wires up a view model to it
