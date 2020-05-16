 # This is the Bolo Project Integrated with sheets api from Google in c#
Projects Open Source Community

I'll describe all the layers of the application and what they do, like layer domain, processors and initializers.

in this project solution, i'll have the layer responsible for input the data on sheet.

# Google.Sheets.Application.Core

:ManipulateSheets
* here we have all the classes that implements the logic of the program to input data on sheets, segregated with your responsabilities.

:FileUserCredential
* Was necessary get Google Credential e download a path in .JSON, that this file carry the ID for the user manipulate the sheets.. 
 

# Google.Sheets.Application.Initializer

:ExecuteSheetProcessor
* Layer where the application with your dependencies is started

