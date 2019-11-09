# Bootstrapping FSharp scripting experience


## One time globally

1. install dotnet core 3.0+ (with sdk)

## Once per new project folder

```shell
dotnet new tool-manifest
dotnet tool install fake-cli
dotnet tool install paket
```

5. Then in your build.sh: (assumes you use git bash)

```bash
#!/bin/bash
dotnet tool restore
dotnet paket restore
dotnet fake build "$@"
```

## Create your project

Create (example) build.fsx: 

```fsharp
#r @"paket:
nuget XPlot.GoogleCharts
"

open XPlot.GoogleCharts

let histo = [| [(100.0,100.0) ; (200.0,100.0) ; (300.0,150.0)] |]

histo
    |> Seq.ofArray
    |> Chart.Combo
    |> Chart.WithOptions 
         (Options(title = "My plot"))
    |> Chart.WithLabels ["Woo"]
    |> Chart.WithLegend false
    |> Chart.WithSize (600, 250)
    |> Chart.Show
```
## Compile and run

`./build.sh run`


