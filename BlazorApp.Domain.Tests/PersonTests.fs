namespace BlazorApp.Domain.Tests

open Xunit
open FsUnit.Xunit

open BlazorApp.Domain

module DataTests =

    [<Fact>]
    let ``create function should create new Item`` () =
        let expected = {
            Id = 1
            Name = "Bob"
        }

        let actual = Person.create 1 "FOO"

        actual |> should equal expected
