dotnet new sln -n BlazorBloggingApp

dotnet new classlib -n BlazorBloggingApp.Shared
dotnet new blazorserver -n BlazorBloggingApp.ServerSide
dotnet new blazorwasm -n BlazorBloggingApp.WebAssembly

dotnet sln BlazorBloggingApp.sln add BlazorBloggingApp.Shared/BlazorBloggingApp.Shared.csproj
dotnet sln BlazorBloggingApp.sln add BlazorBloggingApp.ServerSide/BlazorBloggingApp.ServerSide.csproj
dotnet sln BlazorBloggingApp.sln add BlazorBloggingApp.WebAssembly/BlazorBloggingApp.WebAssembly.csproj

dotnet add BlazorBloggingApp.ServerSide/BlazorBloggingApp.ServerSide.csproj reference BlazorBloggingApp.Shared/BlazorBloggingApp.Shared.csproj
dotnet add BlazorBloggingApp.WebAssembly/BlazorBloggingApp.WebAssembly.csproj reference BlazorBloggingApp.Shared/BlazorBloggingApp.Shared.csproj
