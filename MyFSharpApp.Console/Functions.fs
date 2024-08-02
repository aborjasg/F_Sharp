module Functions
    let EventLog (message:string) = 
        let now = System.DateTime.Now
        printfn "%s %s" (now.ToString "yyyy-MM-dd HH:mm:ss:ffff") message
