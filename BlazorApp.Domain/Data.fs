namespace BlazorApp.Domain

type Item = {
    id: int
    name: string
}

module Data =
    let Items =
        [
            { id = 1; name = "item 1" }
            { id = 2; name = "item 2" }
            { id = 3; name = "item 3" } 
        ] |> Seq.ofList
