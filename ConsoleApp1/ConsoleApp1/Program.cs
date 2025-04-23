using ConsoleApp1;

ErrorLog errorLog = new ErrorLog("ErrorLogs.txt");
errorLog.Write("Dit is een eerste error log");
errorLog.Write("Dit is een tweede error log");
errorLog.DisplayLog();

ActivityLog activityLog = new ActivityLog("ActivityLogs.txt");
activityLog.Write("Dit is een eerste activity log");
activityLog.Write("Dit is een tweede activity log");
activityLog.DisplayLog();

Console.ReadLine();