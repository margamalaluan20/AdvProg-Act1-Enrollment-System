# AdvProg Act 1 - Enrollment System

A simple Windows Forms application for capturing and reviewing student enrollment information. This project is built with C# and .NET using a graphical user interface for data entry and summary display.

## Overview

This enrollment system allows users to input:

- Student personal information
- Academic details
- Enrollment subjects
- Health and emergency information
- Contact person details

The application automatically calculates the student age from the selected date of birth and updates the enrollment summary in a readable output section.

## Features

- Student registration form with personal details
- Automatic age calculation
- Track and strand selection
- Year level selection
- Subject selection using a checklist
- Blood type and accessibility needs input
- Emergency contact information
- Clear form feature for resetting entries
- Final enrollment summary display

## Tech Stack

- C#
- .NET 10 Windows Forms
- Visual Studio / .NET SDK

## Project Structure

```text
AdvProg-Act1-Enrollment-System/
├── AdvProg-Act1-Enrollment-System/
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   ├── Program.cs
│   ├── AdvProg-Act1-Enrollment-System.csproj
│   └── Properties/
├── .gitignore
├── .gitattributes
├── AdvProg-Act1-Enrollment-System.slnx
├── LICENSE.txt
├── README.md
└── .github/
```

## Prerequisites

Before running this project, make sure you have:

- Windows operating system
- Visual Studio 2022 or later
- .NET 10 SDK
- Windows Desktop development workload

## How to Run

1. Clone the repository.
2. Open the solution file (`AdvProg-Act1-Enrollment-System.slnx`) in Visual Studio.
3. Restore NuGet packages if needed.
4. Build the project.
5. Press `F5` to run the application.

## Usage

- Fill out the enrollment form with the student information.
- Select the appropriate track, strand, and year level.
- Choose the required subjects and other relevant details.
- Click `Submit` to generate the enrollment summary.
- Click `Clear` to reset the form.

## License

This project is licensed under the Apache License 2.0. See the `LICENSE.txt` file for details.

