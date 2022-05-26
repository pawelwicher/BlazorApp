namespace BlazorApp.Domain

[<CLIMutable>]
type Person = {
    Id: int
    Name: string
}

module Person =
    
    let create id name =
        { Id = id; Name = name }

    let getPersons () =
        [
            create 1 "Bob"
            create 2 "Alice"
        ] |> Seq.ofList
