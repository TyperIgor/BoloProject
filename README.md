# ProjetoBolo
Projects Open Source Community

# This is the Bolo Project integrated with sheets api from Google in C#.

I'll describe all the layers of the application and what they do, like layer domain, processors and initializers.

in this project solution, i'll have the layer responsible for input the data on sheet.

# Google Application

 
### Google.Sheets.Application.Initializer
 - Layer where all the applications with your dependencies is started.


### Google.Sheets.Application.Core 
 - Here we have all the classes that implements the logic of the program to input data on sheets, segregated with your responsabilities.
 - Was necessary get Google Credential e download a path in .JSON, that this file carry the ID for the user manipulate the sheets. 
 
 

# Google Integration 
- This layer is responsible to create the bolo logic program

### Bolo.Integration.Initializer
- Layer where just the bolo logic program is started, he create a local spreadsheet in excel in your machine.

### Bolo.Integration.Core 

- Layer with all the necessary implementations, for run the program. With methods where it's taken the dates, the order the collection of name from the file using bubble sort and
- the excel spreadsheets. 

### Bolo.Integration.Domain



