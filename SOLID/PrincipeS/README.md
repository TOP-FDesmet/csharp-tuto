##Single Responsibility Principle (SRP)
The SRP states that a class should have only one reason to change, meaning it should have only one responsibility. This promotes modularization and makes the code easier to understand and maintain.

Key Idea: A class should do only one thing, and it should do it well.

Real-Time Example: Think of a chef who only focuses on cooking, not managing the restaurant or delivering food.

#Before applying for SRP:

public class Report
{
public void GenerateReport() { }
public void SaveToFile() { }
}
In this scenario, theReport class has two responsibilities: generating a report and saving it to a file. This violates the SRP.

#After applying SRP:

public class Report
{
public void GenerateReport() { }
}

public class ReportSaver
{
public void SaveToFile() { }
}

Now, theReport class is responsible only for generating reports, while the ReportSaver class is responsible for saving reports. Each class has a single responsibility.

Explanation: According to SRP, one class should take one responsibility hence to overcome this problem we should write another class to save the report functionality. If you make any changes to theReport class will not affect the ReportSaver class.
