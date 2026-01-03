# Useful Info
To minify your `summary` comments in VS Code, use `Ctrl + h` to bring up the **Find and Replace** feature, enable *Regex expressions* using the UI button to the right, then use the following expression in the **find** input:
`^(\s*)/// <summary>\s*\n(?:\s*///\s*(.*?)\s*\n)*?^\s*/// </summary>`
Then, use the following expression in the **Replace** input:
`$1/// summary: $2`

To replace only the `false` condition block, that is returning `string.Empty`, of a ternary statement that has a true condition including a `? new Func<string>` code block, use the following expression in the **find** input:
`^(\s*)(\?\s*new\s+Func<string>\s*\n\s*\(\(\)\s*=>\s*\n\s*\{\s*\n(?:.*\n)*?\s*\}\)\(\)\s*\n\s*:)\s*string\.Empty(.*$)`
Then, use the following expression in the **Replace** input:
`$1$2 Your_false_condition$3`

# Extensions + Versions
- **Name:** C#
**Id:** ms-dotnettools.csharp
**Description:** Base language support for C#
Version: 2.72.27
Publisher: Microsoft
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp

- **Name:** C# Dev Kit
**Id:** ms-dotnettools.csdevkit
**Description:** Official C# extension from Microsoft
Version: 1.30.4
Publisher: Microsoft
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit


- **Name:** .NET Install Tool
**Id:** ms-dotnettools.vscode-dotnet-runtime
**Description:** This extension installs and manages different versions of the .NET SDK and Runtime.
Version: 2.3.5
Publisher: Microsoft
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-runtime

- **Name:** GitHub Copilot
**Id:** GitHub.copilot
**Description:** Your AI pair programmer
Version: 1.330.1610
Publisher: GitHub
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=GitHub.copilot

- **Name:** GitHub Copilot Chat
**Id:** GitHub.copilot-chat
**Description:** AI chat features powered by Copilot
Version: 0.28.2025060602
Publisher: GitHub
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=GitHub.copilot-chat

- **Name:** IntelliCode for C# Dev Kit
**Id:** ms-dotnettools.vscodeintellicode-csharp
**Description:** AI-assisted development for C# Dev Kit
Version: 2.2.3
Publisher: Microsoft
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscodeintellicode-csharp

- **Name:** Android
**Id:** adelphes.android-dev-ext
**Description:** Android debugging support for VS Code
Version: 1.4.0
Publisher: adelphes
VS Marketplace Link: https://marketplace.visualstudio.com/items?itemName=adelphes.android-dev-ext