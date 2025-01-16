# Practice_Inheritance
This project demonstrates the basics of object-oriented programming (OOP) in C#, particularly focusing on **inheritance** and **method overriding**. 

## Overview
The application contains a base class `BaseKisi` and two derived classes: `Student` and `Teacher`. Each class showcases properties and methods, demonstrating how child classes can extend and override the behavior of a parent class.

## Classes

### 1. `BaseKisi`
The base class contains common properties and methods for all individuals:
- **Properties**:
  - `FirstName`: Represents the first name of a person.
  - `LastName`: Represents the last name of a person.
- **Methods**:
  - `Introduce()`: A virtual method that displays the full name.

### 2. `Student`
Derived from `BaseKisi`, this class adds additional properties and methods specific to students:
- **Properties**:
  - `StudentNumber`: Represents the unique number assigned to a student.
- **Methods**:
  - `Introduce()`: Overrides the base class method to include the student's number.

### 3. `Teacher`
Derived from `BaseKisi`, this class adds teacher-specific attributes and behavior:
- **Properties**:
  - `TeacherSalary`: Represents the salary of a teacher.
- **Methods**:
  - `Introduce()`: Overrides the base class method to include the teacher's salary.

## Example Output
![image](https://github.com/user-attachments/assets/47a93d1b-90f4-46c4-9c9a-10eb08147056)
