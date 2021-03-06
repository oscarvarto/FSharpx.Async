﻿// First version copied from the F# Power Pack 
// https://raw.github.com/fsharp/powerpack/master/src/FSharp.PowerPack/AsyncWorker.fsi

// (c) Microsoft Corporation 2005-2009.
namespace FSharpx.Control

    open System
    open System.Threading
    open Microsoft.FSharp.Control

    type AsyncWorker<'T> =
        new : Async<'T> * ?asyncGroup: CancellationToken -> AsyncWorker<'T>
        member ProgressChanged : IEvent<int> 
        member Error : IEvent<exn> 
        member Completed : IEvent<'T> 
        member Canceled : IEvent<OperationCanceledException> 
        member RunAsync : unit -> bool
        member ReportProgress : int -> unit
        member CancelAsync : ?message:string -> unit