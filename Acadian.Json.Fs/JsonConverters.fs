namespace Acadian.Json.Fs

module JsonConverters =

  open System
  open Microsoft.FSharp.Reflection
  open Newtonsoft.Json

  type OptionConverter() =
    inherit JsonConverter()

    override x.CanConvert(t) = t.IsGenericType && t.GetGenericTypeDefinition() = typedefof<option<_>>

    override x.WriteJson(writer, value, serializer) =
      let value =
        if isNull value then
          null
        else
          let _, fields = FSharpValue.GetUnionFields(value, value.GetType())
          fields.[0]
      serializer.Serialize(writer, value)

    override x.ReadJson(reader, t, existingValue, serializer) =
      let innerType = t.GetGenericArguments().[0]
      let innerType =
        if innerType.IsValueType then (typedefof<Nullable<_>>).MakeGenericType([| innerType |]) else innerType
      let value = serializer.Deserialize(reader, innerType)
      let cases = FSharpType.GetUnionCases(t)
      if isNull value then FSharpValue.MakeUnion(cases.[0], [||]) else FSharpValue.MakeUnion(cases.[1], [| value |])
