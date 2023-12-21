using MusicCast.Shared.Service.Response;
using MusicCast.Shared.Utils;

namespace MusicCast.Shared.Service;
public class AppService : BaseService
{
    public AppService()
    {

    }
    //dựa theo cấu hình app
    public string UrLBase = Constants.apiPathRadio;

    List<ResponseTrend> DataTrend;
    List<ResponseTrend> DataPopup;
    List<ResponseTrend> DataSlide;
    ResponseDataLastUppdate DataLastuppdate;
    //home request
    ResponseDataDocument DataDocument;
    public async Task<List<ResponseTrend>> GetDataTrend()
    {
        var response = await GetDataAsync($"{UrLBase}{EndPoint.homeTrend}");
        if (response.IsSuccessStatusCode)
        {
            // Read response content
            var content = await response.Content.ReadAsStringAsync();
            // Deserialize 
            DataTrend = Deserialize<List<ResponseTrend>>(content);

        }

        //// Fetch
        //using var stream = await FileSystem.OpenAppPackageFileAsync("trend.json");
        //using var reader = new StreamReader(stream);
        //var contents = await reader.ReadToEndAsync();
        //DataTrend = JsonSerializer.Deserialize(contents, ResponseTrendContext.Default.ResponseTrend);

        return DataTrend;
    }
    public async Task<List<ResponseTrend>> GetDataPopup()
    {
        var response = await GetDataAsync($"{UrLBase}{EndPoint.homePopular}");
        if (response.IsSuccessStatusCode)
        {
            // Read response content
            var content = await response.Content.ReadAsStringAsync();
            // Deserialize 
            DataPopup = Deserialize<List<ResponseTrend>>(content);

        }

        return DataPopup;
    }
    public async Task<List<ResponseTrend>> GetDataSlide()
    {
        var response = await GetDataAsync($"{UrLBase}{EndPoint.homeSlide}");
        if (response.IsSuccessStatusCode)
        {
            // Read response content
            var content = await response.Content.ReadAsStringAsync();
            // Deserialize 
            DataSlide = Deserialize<List<ResponseTrend>>(content);
        }

        return DataSlide;
    }
    public async Task<ResponseDataLastUppdate> GetDataLastUpdate(int? page)
    {
        string _page = page != null ? page.ToString() : "0";
        var response = await GetDataAsync($"{UrLBase}{EndPoint.homeLastUpdate}{_page}");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            // Deserialize 
            DataLastuppdate = Deserialize<ResponseDataLastUppdate>(content);
        }
        return DataLastuppdate;
    }

   // Info manga
    public async Task<ResponseDataDocument> GetDataInfo(string idmanga)
    {
        var response = await GetDataAsync($"{UrLBase}{EndPoint.infoManga}{idmanga}");
        if (response.IsSuccessStatusCode)
        {

            var content = await response.Content.ReadAsStringAsync();
            // Deserialize 
            DataDocument = Deserialize<ResponseDataDocument>(content);
        }

        return DataDocument;
    }
    ////chapter manga
    //public async Task<ResponseDataChapter> GetChapterInfo(string idmanga, string page, string idetail, string sort)
    //{
    //    int _page = 0;
    //    if (!string.IsNullOrEmpty(page))
    //        _page = int.Parse(page);
    //    string _idetail = "all";
    //    if (!string.IsNullOrEmpty(idetail))
    //        _idetail = idetail;
    //    string _sort = "ASC";
    //    if (!string.IsNullOrEmpty(sort))
    //        _sort = sort;
    //    var response = await GetDataAsync($"{UrLBase}{EndPoint.infoChapter}{idmanga}/16/{_page}/{_idetail}/{_sort}");
    //    if (response.IsSuccessStatusCode)
    //    {
    //        //string _key = await response.Content.ReadAsStringAsync();
    //        DataChapter = await response.Content.ReadFromJsonAsync(ResponseDataChapterContext.Default.ResponseDataChapter);
    //    }
    //    return DataChapter;
    //}

    ////view manga
    //public async Task<ResponseViewChapter> GetViewManga(string idmanga, string idchapter)
    //{
    //    var response = await GetDataAsync($"{UrLBase}{EndPoint.viewmanga}{idmanga}/{idchapter}");
    //    if (response.IsSuccessStatusCode)
    //    {
    //        string _key = await response.Content.ReadAsStringAsync();
    //        DataView = await response.Content.ReadFromJsonAsync(ResponseViewChapterContext.Default.ResponseViewChapter);
    //    }

    //    return DataView;
    //}
}
