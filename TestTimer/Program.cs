System.Timers.Timer timer = new System.Timers.Timer(2000);

timer.Elapsed += Timer_Elapsed;

void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
{
    Console.WriteLine("youpi ! {0}", e.SignalTime);
}

timer.Start();

Console.ReadLine();