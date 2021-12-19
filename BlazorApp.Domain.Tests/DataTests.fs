namespace BlazorApp.Domain.Tests

open Xunit
open FsUnit.Xunit

open BlazorApp.Domain

module DataTests =

    [<Fact>]
    let ``Items should be collection with some elements`` () =
        let expected = true
        let actual = Data.Items |> Seq.length |> (<) 0
        actual |> should equal expected
