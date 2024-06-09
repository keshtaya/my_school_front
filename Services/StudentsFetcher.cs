using RestSharp;
using System.Text.Json;
using my_school_front.Models;

namespace my_school_front.Service;

public class StudentsFetcher
{
    private readonly RestClient _restClient;

    public StudentsFetcher()
    {
        _restClient = new RestClient("http://localhost:5247/");
    }

    public async Task<List<Student>> FetchStudents()
    {
        var request = new RestRequest("/Students", Method.Get);
        var response = await _restClient.ExecuteAsync(request);
        var json = response.Content ?? "";

        var students = JsonSerializer.Deserialize<List<Student>>(json);
        return students ?? [];
    }
}