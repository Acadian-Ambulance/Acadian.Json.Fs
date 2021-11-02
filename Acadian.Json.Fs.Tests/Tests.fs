module Tests

open Expecto
open Expecto.Flip
open Acadian.Json.Fs.JsonConverters
open Newtonsoft.Json

type Item = {
  Id: int
  Desc: string option
}

[<Tests>]
let tests = testList "Tests" [
  testList "JsonConverters.OptionConverter" [
    test "Test converting a list of items with optional members to json" {
      let items = [{ Id = 1; Desc = None }; { Id = 2; Desc = Some "stuff" } ]
      let jsons = JsonConvert.SerializeObject(items, OptionConverter())
      jsons |> Expect.equal "" "[{\"Id\":1,\"Desc\":null},{\"Id\":2,\"Desc\":\"stuff\"}]"
    }
    test "Test converting an item with None desc json" {
      let item = { Id = 1; Desc = None }
      let json = JsonConvert.SerializeObject(item, OptionConverter())
      json |> Expect.equal "" "{\"Id\":1,\"Desc\":null}"
    }
    test "Test converting an item with Some desc json" {
      let item = { Id = 1; Desc = Some "stuff" }
      let json = JsonConvert.SerializeObject(item, OptionConverter())
      json |> Expect.equal "" "{\"Id\":1,\"Desc\":\"stuff\"}"
    }
    test "Test converting an item that is None" {
      let item = None
      let json = JsonConvert.SerializeObject(item, OptionConverter())
      json |> Expect.equal "" "null"
    }
    test "Test converting an item list that is empty" {
      let item = []
      let json = JsonConvert.SerializeObject(item, OptionConverter())
      json |> Expect.equal "" "[]"
    }
    test "Test converting a list of optional items with optional members to json" {
      let items = [ Some { Id = 1; Desc = None }; Some { Id = 2; Desc = Some "stuff" }; None ]
      let jsons = JsonConvert.SerializeObject(items, OptionConverter())
      jsons |> Expect.equal "" "[{\"Id\":1,\"Desc\":null},{\"Id\":2,\"Desc\":\"stuff\"},null]"
    }
  ]
]
