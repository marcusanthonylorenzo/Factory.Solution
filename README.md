# Engineer and Machine Database Management Tool

#### By _**Marcus Lorenzo**_
---


| **_Overview_:** |
|---|

Still a work in progress.

---

| **_Setup & Installation_:** |
|---|

|   via CLI   |
|---|
| Download install Git Bash (Windows), use the terminal in your text editor, or open Terminal(Mac) 
| Open Git Bash or Terminal and type: `cd desktop` 
| Next, clone `[https://github.com/marcusanthonylorenzo/](https://github.com/marcusanthonylorenzo/Factory.Solution)` 
| Once completed, open this new directory in your text editor
| In the root directory, create a file called `appsettings.json`.
| Inside this file write:
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=marcus_lorenzo;uid=root;pwd=epicodus;"
  }
}
```
**Save and you are ready to go!**

 
|  MySQL Setup  |
|---|
| In your MySQL Workbench, click Connect to Database, Stored Connection:  Local instance 3306
**Must match the `Port=3306;` in the `"DefaultConnection"` query inside your `appsettings.json` file.**
| In **Schemas Navigator** in the Navigator bar on the left, right-click and select "Create Schema".
| The name of the new Schema **must match the `database=eau_claire;` in the `"DefaultConnection"` query inside your `appsettings.json` file.**
| Once loaded, go to your new Schema tree in the Navigator bar on the left, click down to Tables, right click "Create Table".
| Your details should look like this:

[Image of applied tables here]

#### Running Tests:
- To view tests via MSTest, in your CLI type `dotnet test`.

#### Known Bugs:
* Cannot get Clients to add to database/page. Need to get a Client Summary in order to attach Stylists to Clients.

---

---
| **_License_:** |
|---|

[MIT]()

Copyright (c) 2022 _Marcus Lorenzo_


#### Thanks for viewing!
