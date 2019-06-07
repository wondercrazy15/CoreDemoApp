# CoreDemoApp

```bash
# DemoApp Architecture :
In this App I have used separate class library for entities, service/interface, model and web Project.
```

>Project structure
![alt text]()

In this app I have used .Net Core 2.2 Frontend with code first approach and MS Sql for backend.

# DemoApp functionality:
When user run this project below default landing page will be displayed.

>Project structure
![alt text]()

When User click on Register link, Register page will be open. On this page user can register their self. Or if user want to login by facebook or google he has to click on facebook/google button which available on login page.

>Project structure
![alt text]()

After successfully login user will redirect to home page. And user info link will be appear at top left side.

>Project structure
![alt text]()

When user will click on userinfo link, he will be able to see all user info with their album and their photo counts in grid.

   
```bash
# scheduler :
For scheduler I have used HangFire
# Install HangFire From Nuget
Install-Package HangFire.Core -Version 1.7.3
```
>Register HangFire in Startup.cs file
![alt text](![hang01](https://user-images.githubusercontent.com/30141700/59111147-0f694880-895e-11e9-84e1-a6de605ac327.png))
![alt text]()

