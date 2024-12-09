namespace InveonBootcamp.AsenkronProgramlama;

public class TaskExamples
{
    public void RunExample()
    {
        Task.Run(() => Console.WriteLine("Task running..."));
    }

    public async Task WhenAllExample()
    {
        var tasks = new List<Task>
        {
            Task.Delay(2000),
            Task.Delay(1000),
            Task.Delay(3000)
        };

        Console.WriteLine("Tüm taskların bitmesi bekleniyor...");
        await Task.WhenAll(tasks);
        Console.WriteLine("Tüm tasklar bitti.");
    }

    public Task<int> FromResultExample()
    {
        return Task.FromResult(1); 
    }
}