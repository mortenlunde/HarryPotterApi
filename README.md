# Blazor WebApplication with API Connection

**Exam Subject 6**  
*Author: Morten Lunde @ 2024*

---

## Overview

This project is a Blazor-based web application built as part of an examination. It connects to a Harry Potter API and 
displays its data on different pages. The application incorporates magical-themed effects, including a wand cursor, 
themed background music, custom fonts, and glowing effects to enhance the user experience.

---

## Features

### **Main Layout**
- An audio HTML component with JavaScript toggles background music, seamlessly transitioning across pages.
- Breadcrumb navigation is included on all pages except the homepage.

### **Home Page**
- Displays options to explore **characters** and **spells** from the Harry Potter universe.
- Includes a link to a **video presentation** about the project.

### **Characters Page**
- Fetches and displays characters from the API as styled **cards**.
- Features **pagination** to show 5 cards at a time.
- Includes a **search function** with dynamic filtering by:
    - Name
    - House
    - Actor
    - Species

### **Details Page**
- Clicking "Details" on the Characters page navigates to a new page showing **complete details** about the character.

### **Spells Page**
- Displays spells retrieved from the API in a **book-style layout** with two pages visible at once.
- Pagination is implemented for seamless navigation.

---

## Technologies

- **Framework**: .NET 9 (Blazor Server WebApplication in C#)
- **API**: [Harry Potter API](https://hp-api.herokuapp.com)
- **Styling**: Blazor Bootstrap and custom CSS
- **Languages**: C#, HTML, CSS, and JavaScript