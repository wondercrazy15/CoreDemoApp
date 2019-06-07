# CoreDemoApp

```bash
# DemoApp Architecture :
In this App I have used separate class library for entities, service/interface, model and web Project.
```

>Project structure
![image](https://user-images.githubusercontent.com/30141700/59111982-c1554480-895f-11e9-92ba-b21144bcdfe3.png)

In this app I have used .Net Core 2.2 Frontend with code first approach and MS Sql for backend.

# DemoApp functionality:
When user run this project below default landing page will be displayed.

![image](https://user-images.githubusercontent.com/30141700/59112129-06797680-8960-11e9-852e-41fa15fd25af.png)


When User click on Register link, Register page will be open. On this page user can register their self. Or if user want to login by facebook or google he has to click on facebook/google button which available on login page.

![image](https://user-images.githubusercontent.com/30141700/59112223-358fe800-8960-11e9-9fbc-55a33878c0fd.png)

After successfully login user will redirect to home page. And user info link will be appear at top left side.

![image](https://user-images.githubusercontent.com/30141700/59112262-46d8f480-8960-11e9-965b-e32544a8aa23.png)

When user will click on userinfo link, he will be able to see all user info with their album and their photo counts in grid.

![image](https://user-images.githubusercontent.com/30141700/59112284-55271080-8960-11e9-8143-f549cca2a649.png)

   
```bash
# scheduler :
For scheduler I have used HangFire
# Install HangFire From Nuget
Install-Package HangFire.Core -Version 1.7.3
```
Register HangFire in Startup.cs file

![image](https://user-images.githubusercontent.com/30141700/59111147-0f694880-895e-11e9-84e1-a6de605ac327.png)

![image](https://user-images.githubusercontent.com/30141700/59111486-c1087980-895e-11e9-9b0d-aebc9ca57cec.png)

!
