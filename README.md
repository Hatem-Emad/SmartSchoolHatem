# SmartSchoolServer
ASP.NET Core Web API - Angular
3-Tier application ( Data Access Layer - Business Logic Layer - Presentation Layer ) using 
 Identity server, Entity Framework Core, LINQ, Dependency Injection design pattern, data seeding, data annotation validation,
 Logic validation in services, MailKit and Sendgrid, Stripe API. Along with SQL Server for data storage.
 
School management system with 4 Roles ( Admin - Teacher - Parent - Student).

- Register on the web site by sending complete request from parent and the child to be enrolled in the school. After Admin accepting this request, 2 rows added to the identity table; 1 for Parent, 1 for Student.

- Admin manages Grade Years, Classrooms, Subjects, Teachers, Parents and Students
- Teacher takes students attendance, upload material ( videos - docs ), see their schedules and fill his students exam marks
- Parent can see his son's grade, Classroom, Schedule, Marks and Absence days. Send Email for complaints.
- Student checks his Schedule, Classroom, Marks and Absence days

- Every role can forget password, so an email is sent to reset their password. And change password if they are logged in
- Payment integration using Stripe API.
