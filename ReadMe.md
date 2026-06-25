# CyberGuard

## Advanced Cybersecurity Awareness Chatbot

## Project Overview

**CyberGuard** is a professional cybersecurity awareness chatbot developed using **C#**, **Windows Forms**, **MySQL**, and **Visual Studio**. The application is designed to educate users about common cybersecurity threats through an interactive and user-friendly conversational experience.

The system provides cybersecurity guidance, task management, quiz-based learning, sentiment-aware interactions, activity tracking, and Natural Language Processing (NLP) functionality to help users improve their understanding of online safety and digital security.

# Core Features

### Cybersecurity Awareness Support

Provides users with educational guidance on key cybersecurity topics, helping promote safer online behaviour and cybersecurity awareness.

### Interactive Chat Experience

Users can communicate with the chatbot through a modern graphical user interface designed for ease of use and accessibility.

### Personalized User Memory

The application remembers user preferences and favourite cybersecurity topics to create a more personalized experience.

### Sentiment Recognition

Detects user emotions such as concern, curiosity, and frustration, allowing the chatbot to provide more context-aware responses.

### Natural Language Processing (NLP)

Simulates NLP capabilities by identifying user intentions and automatically performing actions such as:

* Starting quizzes
* Creating tasks
* Viewing activity logs
* Responding to cybersecurity questions

### Cybersecurity Task Assistant

Allows users to manage cybersecurity-related tasks including:

* Creating tasks
* Setting reminders
* Marking tasks as complete
* Tracking cybersecurity activities

### MySQL Database Integration

Stores cybersecurity tasks permanently using a MySQL database.

Database functionality includes:

* Add Tasks
* View Tasks
* Complete Tasks
* Delete Tasks
* Store Reminder Dates

### Cybersecurity Quiz

Includes an interactive cybersecurity quiz that tests user knowledge on topics such as:

* Password Security
* Phishing
* Malware
* Privacy
* Safe Browsing
* Social Engineering

The quiz provides:

* Multiple-choice questions
* Score tracking
* Immediate feedback
* Performance summaries

### Activity Logging

Records important user activities such as:

* Quiz attempts
* Task creation
* Task completion
* User interactions

### Live Interaction Statistics

Displays useful session information including:

* Number of questions asked
* User name
* Favourite topic
* Last discussed topic
* Current detected mood

### Audio Greeting Functionality

Plays a welcome audio greeting when the application launches to enhance the user experience.

### Professional User Interface

Built using Windows Forms with a clean cybersecurity-themed layout that includes:

* Chat interface
* User profile dashboard
* Task management panel
* Quiz section
* Activity log viewer

---

# Business Value & Purpose

CyberGuard was developed to address the growing need for cybersecurity awareness in today's digital world. Many users remain vulnerable to cyber threats due to limited cybersecurity knowledge and poor security practices.

This application helps bridge that gap by providing cybersecurity education in a simple, interactive, and engaging format.

### Key Benefits

* Encourages safer online behaviour
* Improves cybersecurity awareness
* Supports educational environments
* Provides beginner-friendly cybersecurity guidance
* Promotes proactive cybersecurity habits
* Enhances user engagement through quizzes and personalization

CyberGuard is suitable for:

* Educational institutions
* Cybersecurity awareness campaigns
* Beginner IT training programs
* Small business awareness initiatives
* Personal cybersecurity learning

---

# Technologies Used

| Technology                            | Purpose                                |
| ------------------------------------- | -------------------------------------- |
| **C#**                                | Core application development           |
| **Windows Forms**                     | Graphical user interface               |
| **MySQL**                             | Database storage                       |
| **MySQL Connector/NET**               | Database connectivity                  |
| **Visual Studio**                     | Development environment                |
| **Object-Oriented Programming (OOP)** | Application architecture and structure |

---

# System Components

| Component              | Description                                           |
| ---------------------- | ----------------------------------------------------- |
| `ChatBot.cs`           | Handles chatbot interactions and greeting audio       |
| `ResponseSystem.cs`    | Manages cybersecurity responses and topic recognition |
| `SentimentAnalyzer.cs` | Detects user sentiment and mood                       |
| `MemoryManager.cs`     | Stores and recalls user preferences                   |
| `NLPProcessor.cs`      | Detects user intentions                               |
| `ActivityLog.cs`       | Records user activity                                 |
| `QuizManager.cs`       | Manages quiz functionality                            |
| `QuizQuestion.cs`      | Stores quiz questions                                 |
| `CyberTask.cs`         | Represents cybersecurity tasks                        |
| `DatabaseHelper.cs`    | Handles MySQL database operations                     |
| `User.cs`              | Maintains user profile information                    |
| `MainForm.cs`          | Main application interface                            |
| `Program.cs`           | Application entry point                               |

---

# How to Launch the Application

## Step 1 — Open the Project

1. Launch **Visual Studio**.
2. Select **Open Project/Solution**.
3. Open the CyberGuard solution file (`.sln`).

## Step 2 — Configure MySQL

1. Create the database named:

```sql
CyberGuardDB
```

2. Create the Tasks table.

3. Update the connection string in:

```csharp
DatabaseHelper.cs
```

## Step 3 — Build the Application

1. Navigate to the top menu.
2. Select:

```text
Build → Build Solution
```

## Step 4 — Run the Application

Press one of the following:

* `F5` → Run with debugging
* `Ctrl + F5` → Run without debugging

The CyberGuard application window will launch automatically.

## Step 5 — Start Using CyberGuard

1. Enter your name.
2. Ask a cybersecurity question.
3. Create cybersecurity tasks.
4. Take the cybersecurity quiz.
5. View your activity history.

### Example Questions

* “How can I create a strong password?”
* “What is phishing?”
* “Tell me about malware.”
* “How do I stay safe online?”
* “Start quiz.”
* “Remind me to enable two-factor authentication.”

---

# Prerequisites

Ensure the following software is installed before running the project:

* Microsoft Visual Studio
* .NET Framework / Windows Forms Support
* MySQL Server
* MySQL Connector/NET
* C# Development Tools
* Windows Operating System

### Optional

* `greeting.wav` audio file placed in the project directory for startup greeting functionality.

---

# Future Enhancements

Potential future improvements include:

* AI-powered conversational responses
* Voice recognition support
* User authentication system
* Email reminder notifications
* Dark mode support
* Expanded cybersecurity knowledge base
* Cloud database integration
* Multi-language support
* Mobile application version

---

# Conclusion

CyberGuard demonstrates the practical application of cybersecurity education through interactive software development. By combining chatbot interaction, task management, database integration, quiz-based learning, sentiment analysis, and Natural Language Processing, the project delivers an engaging solution focused on improving digital safety and cybersecurity awareness.

The application also showcases strong implementation of Object-Oriented Programming principles, Windows Forms development, database management, and user-centered software design.

