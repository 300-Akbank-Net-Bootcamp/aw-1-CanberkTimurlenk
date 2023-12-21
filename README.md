# Objective

Converting existing Validation Attributes to FluentValidation Validations.

<hr>

The lines below are added to enable the usage of FluentValidation.

In `/Startup.cs`


To add FluentValidation to the pipeline, enable integration between Asp.Net Core Validation and FluentValidation
`services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();`

Register all validators from the executing assembly<br>
`services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());`

Validators could be found under the folder `/Validations`

* To validate phone number a regex was used and keep under Validations/RegularExpressions (Additional regular expressions may be added to that folder in the future.)
* Values like minSeniorHourlySalary, minJuniorHourlySalary or SeniorPromotionAge was thought and stored as constants could be found under `/Constants` folder.

<hr>


# Getting Started

Ensure that you have the .NET SDK installed on your computer.

1. Clone the repository:

```bash
git clone https://github.com/300-Akbank-Net-Bootcamp/aw-1-CanberkTimurlenk.git
```
2. Navigate to the project folder
```bash
cd aw-1-CanberkTimurlenk
```
3. Run the project
```bash
dotnet run
```

<br>

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/WZaiE2zH)
