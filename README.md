# CodingChallenges

A collection of **Codewars-style coding challenges** completed in C#, showcasing problem-solving skills and unit testing.

---

## Table of Contents

- [Overview](#overview)  
- [Features](#features)  
- [Architecture & Approach](#architecture--approach)  
- [Getting Started](#getting-started)  
  - [Prerequisites](#prerequisites)  
  - [Setup & Run](#setup--run)

---

## Overview

This repository contains a series of programming challenges implemented in C#. Each entry reflects a unique coding problem—likely inspired by or from **Codewars**—that highlights algorithmic thinking and clean implementation style.

---

## Features

- **Diverse problem coverage** — includes algorithmic and logical puzzles with varying complexity.
- **Test-driven development (TDD)** — each solution is accompanied by robust unit tests (e.g., `CodingChallengesTests`).
- **C# (.NET)** stack—showcases proficiency in core .NET tooling and best practices.

---

## Architecture & Approach

The project is structured to emphasize clarity, testing, and maintainability:

- **Solution project (`CodingChallenges`)** — contains the implementation of challenge solutions.
- **Test project (`CodingChallengesTests` or similar)** — includes unit tests for each challenge—great for verifying correctness and debugging.
- Likely follows conventions such as one class per challenge and descriptive method names to keep things readable and modular.

---

## Getting Started

### Prerequisites

- [.NET SDK (e.g., .NET 6 or .NET 7)](https://dotnet.microsoft.com/download)  
- Integrated development environment like Visual Studio, Visual Studio Code, or Rider (optional)

### Setup & Run

1. **Clone the repository**:
    ```bash
    git clone https://github.com/putdownpanda/CodingChallenges.git
    cd CodingChallenges
    ```

2. **Restore dependencies**:
    ```bash
    dotnet restore
    ```

3. **Run the tests**:
    ```bash
    dotnet test
    ```
   This will build and execute all unit tests to ensure your challenge solutions are passing.
