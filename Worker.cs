using Coravel.Invocable;

public class Worker : IInvocable
{



    public Worker()
    {
    }


    public async Task Invoke()
    {
		Console.WriteLine("Task Invoked!");
    }




}

//Soli Deo Gloria
