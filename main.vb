Imports System
Imports System.Threading

Module Program
    Sub Main(ByVal args() As String)
        Console.Title = "SimpleSaaS (www.devinternals.vercel.app)"
        Console.ForegroundColor = ConsoleColor.DarkGray
        print("Loading...")
        Thread.Sleep(3000)
        Try
            Console.ForegroundColor = ConsoleColor.DarkGreen
            print("Creating service...")
            Console.ForegroundColor = ConsoleColor.Red
            Shell("""sc"" create" + " " + ControlChars.Quote +  args(0) + ControlChars.Quote + " " + "binPath=" +  ControlChars.Quote + args(1) + ControlChars.Quote)
            Thread.Sleep(2000)
            Console.ForegroundColor = ConsoleColor.White
        Catch
            Console.ForegroundColor = ConsoleColor.Red
            print("Failed")
            Console.ForegroundColor = ConsoleColor.White
        End Try
    End Sub

    Sub print(text As String)
        Console.WriteLine(text)
    End Sub
End Module