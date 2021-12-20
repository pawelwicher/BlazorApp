namespace BlazorApp.Domain

[<CLIMutable>]
type Item = {
    id: string
    names: string seq
}

module Data =
    
    let create id names =
        { id = id; names = names |> Seq.ofList }
    
    let Items =
        [
            create "1" ["foo"; "bar"]
            create "1" ["foo"; "bar"]
            create "1" ["foo"; "bar"]
        ] |> Seq.ofList
