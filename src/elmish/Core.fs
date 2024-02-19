namespace Elmish

module Core =

    open Feliz
    open Elmish

    [<RequireQualifiedAccess>]
    type Msg =
        | Increment
        | Decrement

    type Model =
        {
            Count : int
        }

    let init () =
        {
            Count = 0
        },
        Cmd.none

    let update (msg : Msg) (model : Model) =
        match msg with
        | Msg.Increment ->
            { model with Count = model.Count + 1 }, Cmd.none
        | Msg.Decrement ->
            { model with Count = model.Count - 1 }, Cmd.none

    #if DEBUG
    open Elmish.Debug
    open Elmish.HMR
    #endif

    let store : ElmishStore<Model, Msg> =
        // A placeholder function for view is used because it isn't needed
        Program.mkProgram init update (fun _ _ -> Html.none)
        // https://github.com/elmish/elmish/blob/40d38cc5c44d58c842385ed6d608e8d97c2ef399/src/program.fs#L144
        |> Program.map
            (fun init -> init)
            (fun update -> update)
            (fun _ -> (fun _ _ -> ())) // map `Fable.React.ReactElement` to `unit`
            (fun setState -> setState)
            (fun subscribe -> subscribe)
            (fun termination -> termination)
        |> ElmishStore.createStore "core"

    [<Hook>]
    let useSelector (selector : Model -> 'a) =
        React.useElmishStore (store, selector)

    [<Hook>]
    let useSelectorMemoized (memoizedSelector : Model -> 'a) =
        React.useElmishStoreMemoized (store, memoizedSelector)

    let dispatch = store.Dispatch
