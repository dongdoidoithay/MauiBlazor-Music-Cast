using MusicCast.Shared.Utils;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MusicCast.Shared.Service;
public class BaseService
{
    HttpClient httpClient;
    public BaseService()
    {
        this.httpClient = new HttpClient();
    }

    protected async Task<HttpResponseMessage> GetDataAsync(string urlBase)
    {
        string _date = DateTime.Now.ToString();
        string _hashgen = CommonUtils.StringToMD5(Constants.Slate + Constants.Domain + _date);
        string _path_sec = urlBase.Replace(Constants.UrlApi, "");
        string _hashPath = CommonUtils.StringToMD5(Constants.Slate + Constants.Domain + _date + _path_sec);
        // add type
        //httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
        //clear 
        httpClient.DefaultRequestHeaders.Clear();
        // add type
        httpClient.DefaultRequestHeaders.Add("_domain", Constants.Domain);
        httpClient.DefaultRequestHeaders.Add("_date", _date);
        httpClient.DefaultRequestHeaders.Add("_tranId", _hashPath);
        httpClient.DefaultRequestHeaders.Add("_hash", _hashgen);
        httpClient.DefaultRequestHeaders.Add("_path", _path_sec);

        //call api
        var response = await httpClient.GetAsync(urlBase);


        return response;
    }

    protected async Task<byte[]> ByteArrayAsync(string urlBase)
    {
        //call api
        return await httpClient.GetByteArrayAsync(urlBase);
    }
    public T Deserialize<T>(string json)
    {
        var options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        return JsonSerializer.Deserialize<T>(json, options);
    }
}
