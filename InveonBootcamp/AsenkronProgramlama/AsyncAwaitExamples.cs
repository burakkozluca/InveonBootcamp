namespace InveonBootcamp.AsenkronProgramlama;

public class AsyncAwaitExamples
{
    public async Task FetchDataAsync()
    {
        try
        {
            using var httpClient = new HttpClient();
            Console.WriteLine("deneme jsona istek atılıyor");
            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
                
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine("istek başarılı");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}