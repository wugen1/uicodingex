#This project is for coding exercise for UI FBIS job application.
#Assume your team is working on developing a web app that is used by university employees. In real-
world, your team will have a set of documents before implementation. However, for this coding
exercise, you don’t need to consider peripheral requirements because you are not going to implement a
full-fledged application. Please only focus on basic functionalities.
Your task is to implement a feature which allows an employee to submit a receipt for reimbursement.
To demonstrate the feature, you need to build a minimal app, which includes a front-end web interface
and a back-end API service.
The web page has a form that allows an employee to submit required information for a purchase. The
employee is required to fill in the date, the amount, and a description of the purchase, and upload a file
that contains a receipt. A successful form submission will send information to the backend.
The API service should accept requests and correctly parse the data. You are not required to implement
features related to data persistence.
If you think some reasonable business rules would help your implementation, or some coding practice
would benefit your solution, please feel free to put into action. When it happens, please document them
(such as your assumptions, highlight of your practice, and so on), and report to us.
For this coding exercise, you are allowed to use your favorite programming languages, frameworks, and
tools.
#the project is created by .net core 3.1 and rezor pages
#you can run the project by download all the project files and load the project in your visual studio 2019 development environment.
after lunch the project, there will be a web page let you enter you purchasing receipt information that will be save in databse where you submit.
Database will only saved the image file name, the image file itself will be saved in the application server fold under wwwroot/images.
