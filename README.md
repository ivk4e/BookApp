# BookApp
## Description
BookApp is a Windows Forms application developed using C#, EntityFramework, and LINQ. It is designed to manage book orders and user profiles with different access levels such as administrator, worker, and ordinary user. The application is divided into layers based on user roles, each with its own set of functionalities and views. The database entities and relationships are created using the Code-First approach.

## Features
- **Registration:** Users can register into the system by filling out a registration form. Validation checks ensure that the entered data is correct and meets specified criteria such as name format, password length, and age requirement.
- **Login:** Registered users can log into the application using their credentials.
- **Administrator Panels:** Administrators have access to various functionalities including:
        - Changing user types from ordinary to worker or vice versa.
        - Reviewing customer orders and modifying their status.
        - Adding new books, authors, and genres.
- **Worker Panels:** Workers can:
        - Manage orders and change their status.
        - Add books, authors, and genres.
        - View their profile and purchase books.
- **Ordinary User Panels:** Ordinary users have limited functionalities such as:
        - Viewing purchased books.
        - Viewing catalogued.
        - Editing their profile.

## Usage
To use this project:

1. **Registration:** Click on "Registration" to fill out the registration form with valid information.
2. **Login:** Use registered credentials to log into the application.
3. **Navigation:** Depending on the user type, different functionalities and views will be available.
4. **Administrator Functions:** Administrators can manage users, orders, and catalogue items through dedicated panels.
5. **Worker Functions:** Workers can handle orders, catalogue items, and their profile information.
6. **Ordinary User Functions:** Ordinary users can view purchased books and edit their profiles.

## License
This project is licensed under the MIT License.
