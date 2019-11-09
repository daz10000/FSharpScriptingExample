#r @"paket:
nuget XPlot.GoogleCharts
"

open XPlot.GoogleCharts

printfn "Hello world"

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


