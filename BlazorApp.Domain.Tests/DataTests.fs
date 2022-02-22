namespace BlazorApp.Domain.Tests

open Xunit
open FsUnit.Xunit

open BlazorApp.Domain

module DataTests =

    [<Fact>]
    let ``create function should create new Item`` () =
        let expected = {
            Id = "id"
            Names = ["foo"; "bar"] |> Seq.ofList
        }

        let actual = Data.create "id" ["foo"; "bar"]

        actual |> should equal expected
