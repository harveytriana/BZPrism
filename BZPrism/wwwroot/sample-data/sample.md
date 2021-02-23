# Reactividad en Blazor

Blazor es nativamente reactivo. En este sencillo ejemplo emulamos una suma reactiva. Los cambios en las cajas de entrada actualizan el resultado de la suma. Un ejemplo a continuación.

#### Marcado Razor:
```html
@page "/reative-sum"
@foreach (var c in cells) {
    <input value="@c.Value" @onchange="(e => GetSum(c, e.Value.ToString()))">
    <br /><br />
}
<h4>Result: @result</h4>
```

#### Código:
```cs
@code {
    // reactive result
    int result;

    void GetSum(Cell cell, string value)
    {
        cell.Value = int.Parse(value);
        result = cells.Sum(x => x.Value);
    }

    class Cell
    {
        public int Index { get; set; }
        public int Value { get; set; }
    }

    List<Cell> cells = new List<Cell> {
            new Cell{ Index = 0 , Value = 7 },
            new Cell{ Index = 1 , Value = 17 },
            new Cell{ Index = 2 , Value = 11 },
            new Cell{ Index = 3 , Value = -7 },
    };
}
```
_Definí una clase simple para emular las celdas activas. El evento **onchange** hace una retro llamada al método C# para que este actualice le valor de la celda, y recalcule la formula._

----
### Author: Luis Harvey Triana Vega