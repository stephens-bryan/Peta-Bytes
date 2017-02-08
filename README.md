# Peta-Bytes
###Group work and assignments

There are two branches in this repo: master and HTTP5204. Once we start working more with the requirement documents in Bernie's class, I'll create a branch for that as well. 

For the assignments, let me know if you run into any issues with downloading the files onto your computer. Github wasn't found of the an entire project being uploaded at once, so I had to do it in segments. There is a chance I missed something, just let me know if that is the case.

####Word of warning
If you are having build errors, here are some things to keep in mind:
- Check the the connectionString in web.Config is routed to your machine. "AttachDBFileName = |DataDirectory|\Patients.mdf" is how it should be set up
- If Visual studio is telling you that 'there are no elements in sequence', it means your LINQ isn't able to find any records to query through. Ensure that PatientContext.cs is set up correctly.
- Naming is important: ensure that your properties in your model align with the columns in your database

For the files we worked on as a group on Februrary 7, I also put comments on all classes, methods, attributes and using statements that are worth knowing. I want to stress that some might seem a little abrstact or confusing. They were all taken from the Microsoft Offical Documentation on ASP.NET and Entity Framework. I did my best to reword when possible, but some comments are verbose as Microsoft describes them.
