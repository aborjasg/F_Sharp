module Functions
open Microsoft.Extensions.Logging
    
let configureLogging () =    
    // Create a logger factory
    let loggerFactory = LoggerFactory.Create(fun builder ->
        builder
            .AddConsole()
            .SetMinimumLevel(LogLevel.Information)
        |> ignore
    )

    // Create a logger instance
    let logger = loggerFactory.CreateLogger("MyApp")
    logger


let EventLogInfo(message:string) =
    let logger = configureLogging ()        
    logger.LogInformation(message)

let EventLogWarning(message:string) =
    let logger = configureLogging ()        
    logger.LogWarning(message)

let EventLogError(message:string) =
    let logger = configureLogging ()        
    logger.LogError(message)

let EventLog (message:string) = 
    let now = System.DateTime.Now
    printfn "[%s] %s" (now.ToString "yyyy-MM-dd HH:mm:ss:ffff") message
