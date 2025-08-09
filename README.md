# Pluralsight Blazor State Management Course

A comprehensive Blazor blogging application demonstrating state management concepts across different hosting models.

## Project Overview

This solution contains three projects showcasing Blazor applications with different hosting approaches:

- **BlazorBloggingApp.ServerSide** - Blazor Server implementation
- **BlazorBloggingApp.WebAssembly** - Blazor WebAssembly implementation
- **BlazorBloggingApp.Shared** - Shared components and utilities

## Features

### Core Functionality
- **Blog Post Management**: Create, read, and edit blog posts
- **Navigation**: Dynamic blog post listing and navigation
- **Responsive Design**: Bootstrap-based UI with collapsible navigation
- **State Management**: Demonstrates various state management patterns in Blazor

### Blog Post Features
- View individual blog posts with detailed content
- Edit existing posts with form validation
- In-memory data storage with sample blog posts
- Asynchronous data operations

## Getting Started

### Prerequisites
- .NET 8.0
- Visual Studio 2022 or Visual Studio Code

### Running the Application

#### Blazor WebAssembly Version
```bash
cd BlazorBloggingApp.WebAssembly
dotnet run
```

#### Blazor Server Version
```bash
cd BlazorBloggingApp.ServerSide
dotnet run
```

#### Build Entire Solution
```bash
dotnet build BlazorBloggingApp.sln
```

## Project Structure

### BlazorBloggingApp.WebAssembly
- `Models/BlogPost.cs` - Blog post data model
- `Services/BlogPostService.cs` - Blog post data service with CRUD operations
- `Pages/` - Razor pages for home, post details, and editing
- `Layout/` - Application layout components including navigation

### BlazorBloggingApp.ServerSide
- Standard Blazor Server template with weather forecast sample
- Shared components for layout and navigation

### Key Components
- **BlogList.razor** - Collapsible navigation showing all blog posts
- **PostDetail.razor** - Individual blog post display with edit functionality
- **EditPost.razor** - Form-based blog post editing interface

## Sample Data

The application includes three sample blog posts:
1. "Introduction to Blazor"
2. "State Management in Blazor"
3. "Building a Blog with Blazor"

## Learning Objectives

This project demonstrates:
- Component-based architecture in Blazor
- Service injection and dependency management
- Navigation and routing patterns
- Form handling and data binding
- Async/await patterns in Blazor
- State management across components
- Differences between Blazor Server and WebAssembly hosting models

## Course Context

This repository supports the Pluralsight course on Blazor state management, providing practical examples of state handling patterns and best practices in Blazor applications.