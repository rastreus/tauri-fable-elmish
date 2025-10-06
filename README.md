# Tauri + Fable (React) + Elmish

![Tauri Fable Elmish](./img/tauri-fable-elmish-dark.png#gh-dark-mode-only)
![Tauri Fable Elmish](./img/tauri-fable-elmish-light.png#gh-light-mode-only)

This template should help get you started developing with Tauri and Fable (React) in Vite.

**This template adds [Elmish](https://elmish.github.io/) to the [tauri-fable](https://github.com/rastreus/tauri-fable) template.**

To learn more about the structure of Elmish within this template see [elmish-store](https://github.com/SelectViewData/elmish-store) and its introductory article titled _"Optimizing F# and React Integration with Elmish Store: A Guide to Efficient State Management"_ ([link](https://dev.to/lkrzywizna/optimizing-f-and-react-integration-with-elmish-store-a-guide-to-efficient-state-management-316m)).

## Recommended IDE Setup

-   [VS Code](https://code.visualstudio.com/) + [Tauri](https://marketplace.visualstudio.com/items?itemName=tauri-apps.tauri-vscode) + [rust-analyzer](https://marketplace.visualstudio.com/items?itemName=rust-lang.rust-analyzer) + [Ionide for F#](https://marketplace.visualstudio.com/items?itemName=ionide.ionide-fsharp)

### Dependencies

-   [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
    -   [Fable](https://fable.io)
    -   [Paket](https://fsprojects.github.io/Paket/)
-   [Node.js (20.x LTS)](https://nodejs.org/en)
    -   [pnpm](https://pnpm.io)
-   [Rust](https://www.rust-lang.org)
-   Browser extension for Elmish
    -   [Elmish.Debugger](https://elmish.github.io/debugger/)
    -   [Redux DevTools](https://chromewebstore.google.com/detail/redux-devtools/lmhkpmbekcpmknklioeibfkpmmfibljd?pli=1)

### Development

-   Install .NET dependencies:
    -   `dotnet tool restore`
    -   `dotnet paket install`
-   Install JavaScript dependencies:
    -   `corepack enable`
    -   `corepack use pnpm@latest`
    -   `pnpm install`
-   Build: `dotnet build src/Src.fsproj`
-   Dev: `pnpm tauri dev`
