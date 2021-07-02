namespace FSharp.Control.Tasks.V2.ContextInsensitive

open System.Threading.Tasks

module Task =
  let bind f (t: Task<_>) =
    task {
      let! a = t
      return! f a
    }

  let map f (t: Task<_>) =
    task {
      let! a = t
      return f a
    }

  let inline ignore t = map ignore t
