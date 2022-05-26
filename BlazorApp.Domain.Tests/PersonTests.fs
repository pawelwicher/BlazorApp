namespace BlazorApp.Domain.Tests

open Xunit
open FsUnit.Xunit

open BlazorApp.Domain

module PersonTests =

    [<Fact>]
    let ``create function should create new Person`` () =
        let expected = {
            Id = 1
            Name = "Bob"
        }

        let actual = Person.create 1 "Bob"

        actual |> should equal expected
