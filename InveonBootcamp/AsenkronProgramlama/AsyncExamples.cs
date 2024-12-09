namespace InveonBootcamp.AsenkronProgramlama;

public class AsyncExamples
{
    public void LongRunningOperationSync()
    {
        Console.WriteLine("Senkron İŞlem Başladı");
        Thread.Sleep(5000);
        Console.WriteLine("Senkron işlem bitti");
    }

    public async Task LongRunningOperationAsync()
    {
        Console.WriteLine("Asenkron işlem başladı");
        await Task.Delay(5000);
        Console.WriteLine("Asenkron işlem bitti");
    }

}