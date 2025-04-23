using ConsoleApp1;

Log log = new Log();

ErrorLog errorLog = new ErrorLog();
errorLog.Write("Dit is een error message");

ActivityLog activityLog = new ActivityLog();
activityLog.Write("Dit is een activity log");

log.DisplayLog();

Console.ReadLine();