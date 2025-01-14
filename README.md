# Mantel Group GitHub Copilot Workshop

Welcome to the GitHub Copilot Workshop! In this deep-dive workshop into GitHub Copilot, we will teach you how you can use GitHub Copilot to improve your productivity when writing code, in an interactive and collaborative session.

In this workshop, we will cover the following areas:

1. **Introduction to GitHub Copilot** - We start by introducing the key aspects of GitHub Copilot, including the main features as well as covering important features such as data privacy.
2. **Generating Code with GitHub Copilot** - In this lesson, we learn how we can use GitHub Copilot to generate code for us based on our prompts, as well as covering the basics of Chat view, code line completions, and smart actions.
3. **Developing unit tests using GitHub Copilot** - In this lesson, we're going to learn how we can use GitHub Copilot and GitHub Copilot Chat to generate unit tests
4. **Improving our code using GitHub Copilot** - In this lesson, we'll learn how we can use GitHub Copilot Chat to implement code improvements.
5. **Generating documentation using GitHub Copilot** - In this module, we'll learn how we can explain and document our code using the GitHub Copilot.

## Prerequisites

Please ensure that you have the following tools installed on your workstation before the workshop:

- Visual Studio Code or Visual Studio 2022 (*version 17.8 or later*)
- An active subscription to GitHub Copilot
- .NET 8
- Node.js
- Git

**If you want to complete the workshop with Visual Studio Code, please ensure that you have the following extensions installed**

- [GitHub Copilot](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot)
- [GitHub Copilot Chat](https://marketplace.visualstudio.com/items?itemName=GitHub.copilot-chat)
- *Optional* - [VS Code Speech extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vscode-speech).

**If you want to complete the workshop with Visual Studio 2022, please ensure that you have the following extensions installed**

- If you're using Visual Studio versions 17.9 or earlier, install [this GitHub Copilot extension](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-install-and-states?view=vs-2022#install-github-copilot-chat).
- If you're using Visual Studio version 17.10 or later, install [this extension](https://learn.microsoft.com/en-us/visualstudio/ide/visual-studio-github-copilot-install-and-states?view=vs-2022#get-github-copilot-for-visual-studio-2022-version-1710-or-later). It is usually installed by default with all workloads, unless you choose to exclude it during installation.

## Workshop Contents

| Chapter | Exercise Files | 
| ------- | -------------- | 
| [Introduction to GitHub Copilot](./lessons/1-Introduction-to-GitHub-Copilot/README.md) | N/A | 
| [Developing Code with GitHub Copilot](./lessons/2-Develop-Code/README.md) | [Files](./lessons/2-Develop-Code/exercise/) | 
| [Writing Tests with GitHub Copilot](./lessons/3-Testing-GitHub-Copilot/README.md) | [Files](./lessons/3-Testing-GitHub-Copilot/) |
| [Improving your code with GitHub Copilot](./lessons/4-Code-Improvements-GitHub-Copilot/README.md) | [Files](./lessons/4-Code-Improvements-GitHub-Copilot/) |
| [Documentation with GitHub Copilot](./lessons/5-Documentation-GitHub-Copilot/README.md) | [Files](./lessons/5-Documentation-GitHub-Copilot/) |

## GitHub Copilot Cheat Sheet

We will teach you how to use GitHub Copilot within Visual Studio Code, but here are some commonly used commands that you'll use when asking GitHub Copilot questions.

| **Command** | **Usage** |
| ----------- | --------- |
| `/doc` | Adds comments for specified or selected code |
| `/explain` | Gets code explanations for the selected code |
| `/fix` | Gets a proposed fix for problems in the selected code |
| `/generate` | Generates code to answer a specified question |
| `/help` | Gets help on using Copilot Chat |
| `/optimize` | Analyzes and improves the running time of the selected code |
| `/tests` | Creates/Suggests unit tests for the selected code |

To further help Copilot give you more relevant answers, you can indicate the scope and intent of your question using *chat participants*.

| **Chat Participants** | **Usage** |
| --------------------- | --------- |
| `@workspace` | This has context about the code in your workspace and can help you navigate it, finding relevant files or classes. |
| `@vscode` | This knows about commands and features in the VS Code editor itself, and can help you use them. *(VS Code only)* |
| `@terminal` | This has context about the integrated terminal shell and its contents. |

You can also use shortcuts to specify the context in your codebase, providing a more refined scope for GitHub Copilot to use when responding to your questions:

| **Chat context** | **Usage** |
| ---------------- | --------- |
| `#codebase` | This analyzes the contents of the current workspace. Includes information about the files and folders in your workspace. |
| `#editor` | Analyzes the code in the active area. The editor content is implicitly included in the Chat view context. |
| `#file` | Includes a specified file in your workspace as context |
| `#git` | Includes information about the current git repository, such as the workspace folder, branch name, remotes, and more. |
| `#selection` | The visible source code in the active editor |
| `#terminalLastCommand` | The active terminal's last run command |
| `#terminalSelection` | The active terminal's selection | 
| `#solution` | The current solution open in the IDE |