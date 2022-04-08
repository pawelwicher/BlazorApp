namespace BlazorApp.Domain

[<CLIMutable>]
type Item = {
    Id: string
    Names: string seq
}

// foo

module Data =
    
    let create id names =
        { Id = id; Names = names |> Seq.ofList }

    let private entry_2022_02_20 =
        create
            "2022_02_20"
            [
              "go_with_the_flow"
              "klamstwo_to_nowa_prawda"
              "klamstwo_to_nowa_prawda_2"
            ]

    let private entry_2022_01_16 =
        create
            "2022_01_16"
            [
              "last_caress"
            ]

    let private entry_2022_01_09 =
        create
            "2022_01_09"
            [
              "all_my_friends_are_dead"
              "tata_dilera"
              "wyrocznia"
            ]

    let private entry_2021_12_12 =
        create
            "2021_12_12"
            [
              "go_with_the_flow"
              "breaking_the_law"
              "longview"
              "self_esteem"
            ]

    let private entry_2021_11_07 =
        create
            "2021_11_07"
            [
              "paranoid"
              "marchewkowe_pole"
              "all_my_friends_are_dead"
            ]

    let private entry_2021_06_13 =
        create
            "2021_06_13"
            [
              "go_with_the_flow"
              "little_sister"
              "zostac_swirem"
            ]

    let private entry_2021_06_06 =
        create
            "2021_06_06"
            [
              "basket_case"
              "little_sister"
              "all_my_friends_are_dead"
              "screamager"
              "wyrocznia"
              "paranoid"
            ]

    let private entry_2021_05_17 =
        create
            "2021_05_17"
            [
              "all_my_friends_are_dead"
            ]

    let private entry_2021_05_09 =
        create
            "2021_05_09"
            [
              "song_2"
              "all_my_friends_are_dead"
              "another_brick"
              "breaking_the_law"
              "rozmowy_o_muzyce"
              "screamager"
              "basket_case"
              "cocaine"
            ]

    let private entry_2021_05_01 =
        create
            "2021_05_01"
            [
              "basket_case"
              "breed"
              "all_my_friends_are_dead"
            ]

    let private entry_2021_04_25 =
        create
            "2021_04_25"
            [
              "little_sister"
              "wyrzutek"
              "wyrocznia"
            ]

    let private entry_2021_04_18 =
        create
            "2021_04_18"
            [
              "tata_dilera"
              "breaking_the_law"
              "all_my_friends_are_dead"
            ]

    let private entry_2021_04_11 =
        create
            "2021_04_11"
            [
              "cocaine"
              "god_save"
              "last_caress"
            ]

    let private entry_2021_02_20 =
        create
            "2021_02_20"
            [
              "breaking_the_law"
              "rape_me"
              "seven_nation_army"
            ]

    let private entry_2021_02_14 =
        create
            "2021_02_14"
            [
              "breaking_the_law"
              "cocaine"
              "little_sister"
              "paranoid"
              "screamager"
              "wyrzutek"
            ]

    let private entry_2021_02_06 =
        create
            "2021_02_06"
            [
              "screamager"
              "kids_are_not_alright"
              "zostac_swirem"
              "song_2"
            ]

    let private entry_2021_01_31 =
        create
            "2021_01_31"
            [
              "last_caress"
              "breaking_the_law"
              "sic"
            ]

    let private entry_2021_01_24 =
        create
            "2021_01_24"
            [
              "last_caress"
              "kids_are_not_alright"
              "another_brick"
            ]

    let private entry_2021_01_17 =
        create
            "2021_01_17"
            [
              "another_brick"
            ]

    let private entry_2021_01_10 =
        create
            "2021_01_10"
            [
              "basket_case"
              "go_with_the_flow"
              "kids_are_not_alright"
            ]

    let private entry_2021_01_03 =
        create
            "2021_01_03"
            [
              "paranoid"
              "rape_me"
              "tata_dilera"
              "where_is_my_mind"
              "wyrocznia"
              "wyrzutek"
            ]

    let private entry_2020_12_27 =
        create
            "2020_12_27"
            [
              "breed"
              "jingle_bells"
              "little_sister"
              "rape_me"
              "screamager"
              "song_2"
              "to_co_czujesz"
              "wyrocznia"
            ]

    let private entry_2020_12_18 =
        create
            "2020_12_18"
            [
              "basket_case"
              "breaking_the_law"
              "kiedy_bylem"
              "paranoid"
            ]

    let private entry_2020_12_13 =
        create
            "2020_12_13"
            [
              "breaking_the_law"
              "where_is_my_mind"
              "zostac_swirem"
            ]

    let private entry_2020_12_06 =
        create
            "2020_12_06"
            [
              "basket_case"
              "breed"
              "god_save"
              "kiedy_bylem"
              "seven_nation_army"
              "sic"
              "tata_dilera"
            ]

    let Items =
        [
            entry_2022_02_20
            entry_2022_01_16
            entry_2022_01_09
            entry_2021_12_12
            entry_2021_11_07
            entry_2021_06_13
            entry_2021_06_06
            entry_2021_05_17
            entry_2021_05_09
            entry_2021_05_01
            entry_2021_04_25
            entry_2021_04_18
            entry_2021_04_11
            entry_2021_02_20
            entry_2021_02_14
            entry_2021_02_06
            entry_2021_01_31
            entry_2021_01_24
            entry_2021_01_17
            entry_2021_01_10
            entry_2021_01_03
            entry_2020_12_27
            entry_2020_12_18
            entry_2020_12_13
            entry_2020_12_06
        ] |> Seq.ofList
