# the-yard-system
Project Prototype Specification for this project provided by Professor at MMU. 

The Yard Venue Management System
The Yard is a multi-purpose office and events venue in Manchester, they would like to run more evening events and are commissioning a system which digitises some of their currently manual tasks. You will create a console prototype using C# which implements the essential and desirable features listed below. 

Essential Features - The prototype must implement ALL the following:
EF 1: The prototype displays a welcome message when it starts.
EF 2: After the welcome message, user will be prompted to key in the combination of the following two credentials before gaining access to the main menu. Username: admin, Password: pw. If the login credentials do not match, user will be prompted to try again. After three fail attempts, the prototype will display an error message and then exit entirely.
EF 3: The prototype must include a main menu from which user can select to execute the desirable features that you have implemented in the prototype. The main menu should also have an Exit option to allow user to exit the prototype entirely.
EF 4: When user completes the execution of any feature, they should be able to return to the main menu.

Desirable Features - The prototype must implement at least TWO of the following:
DF 1: Entry cost calculator
Standard entry cost for individual attendees is £7.50 (children) and £12.00 (adult). There is a 2 for 1 offer which is available for adult attendees only. Create a calculator function that will calculate a total to charge attendees based on the number of attendees in a group (children and/or adult) and take into account the 2 for 1 offer.

DF 2: Attendance monitoring
The venue would like to record the number of people in the events space. Each time a customer enters the venue the receptionist can add to a running total of attendees. The receptionist can also remove from the total number of attendees when someone leaves. The events space has a total capacity of 300. Each time the total number of attendees is updated the prototype displays at what percentage of capacity the venue is currently at (for this prototype the running total can be cleared when the prototype exits and is resets when next run).

DF 3: Open the following commonly used URL’s
Allow user to open the following links using their browser:
•	Open the website for the venue - https://theyardmcr.com/
•	Open a Google search results page for a word entered within the prototype 

DF 4: Attendee registration
The venue would like to allow the receptionist to record attendees’ details so that they could be contacted with offers and deals in the future. You should enable user to enter the attendees’ following details:
•	Name
•	Phone
•	Age
The feature should allow user to display a list of all attendees including their details registered whilst the prototype has been running (for this prototype the attendees’ details can be cleared when the prototype exits and is unavailable when next run).

DF 5: Incident reporting
For security purposes user should be able to select from the main menu the option to log an incident at the venue. An incident is anything unusual (e.g. a fight, customer requiring first aid or a blocked toilet). This option will generate a text file saved to user’s hard drive, the incident report must include.
•	Automatically store the time and date of the incident
•	The severity of the incident (minor or major)
•	Allows user to enter a short message detailing the nature of the incident
