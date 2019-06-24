First of all i would like to apoligise. In order to provide a working project i've worked with a single JSON object
for example :

{
"Name": "Luka Doncic",
"PlayingSince": 2018,
"Position": "SG",
"Rating": 87
}

I tried Converting my Player model into a List<Player> but i got some errors which i couldn't fix.
Also for the initial loading of the project i had to create the .json file manually in my bin/debug folder.
I didn't want to ask for help i did my best on my own so im providing this project instead.

All in all i've developed a console app using OOP which reads the
path to a JSON file. After that i parse it using Newton.json Deserialization. I store the data in a model called Player. 
I've build services for code reusing. Seperated the different classes in class libraries then connected them with 
refferences.Developed some filters in the InputPlayerDataService which manipulate the input data from LoadJson().
The input for the years should be : the number of years - has to be for example 10 and if the player has played in the NBA less years
he would be returned.
The input for the rating should be : the rating - has to be for example 20 and if the player has more rating he would
be returned.

Thank you for your time !
