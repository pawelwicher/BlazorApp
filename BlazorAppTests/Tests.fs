namespace BlazorAppTests

open Xunit
open FsUnit.Xunit
open Swensen.Unquote

module Tests =

    [<Fact>]
    let ``Xunit assertion`` () =
        let expected = 1
        let actual = 1
        Assert.Equal(expected, actual)

    [<Fact>]
    let ``FsUnit assertion`` () =
        let expected = 1
        let actual = 1
        actual |> should equal expected

    [<Fact>]
    let ``Unquote assertion`` () =
        let expected = 1
        let actual = 1
        test <@ actual = expected @>
