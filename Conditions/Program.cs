using Switches;

var currentStatus = PrintingStatus.Idle;

while (true)
{
    switch (currentStatus)
    {
        case PrintingStatus.Idle:
            currentStatus = PrintingStatus.Starting;
            Console.WriteLine("Printer is starting up");
            break;
        case PrintingStatus.Starting:
            currentStatus = PrintingStatus.Loading;
            Console.WriteLine("Printer is loading paper");
            break;
        case PrintingStatus.Loading:
            currentStatus = PrintingStatus.Printing;
            Console.WriteLine("Printer is printing");
            break;
        case PrintingStatus.Printing:
            currentStatus = PrintingStatus.Cleaning;
            Console.WriteLine("Printer is cleaning headers");
            break;
        case PrintingStatus.Cleaning:
            currentStatus = PrintingStatus.Stopping;
            Console.WriteLine("Printer is finishing print");
            break;
        case PrintingStatus.Stopping:
            currentStatus = PrintingStatus.Idle;
            Console.WriteLine("Printer is in stand by mode");
            break;
    }
    Thread.Sleep(2000);
}
