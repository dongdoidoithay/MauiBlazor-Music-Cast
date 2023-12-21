namespace MusicCast.Shared.Utils;

public static class Constants
{
    public const string Slate = "8e0550790c94d6abc71d738959a88d209690dc86";
    public const string Domain = "AppMangaUS";
    public const string UrlApi = "https://api.unionmanga.xyz";

    public const string RootApi = "https://api.unionmanga.xyz/api";
    //add tmp 
    public const string apiPathRadio = RootApi + "/radio";
    public const string apiPathScans = RootApi + "/kumascans";
    public const string apiPathRaw = RootApi + "/kumaraw";
    public const string apiPathNovel = RootApi + "/novels";
    public const string apiPathDc = RootApi + "/v3/en-dc";
    public const string apiPathEnHwa = RootApi + "/v3/en-hwa";
    public const string apiPathPo = RootApi + "/v3/po";
    public const string apiPathPoHwa = RootApi + "/v3/br-hwa";
    public const string apiPathAnime = RootApi + "/en/anime";
    public const string apiPathItaly = RootApi + "/italy";
    public const string apiPathIndo = RootApi + "/indonesia";

    public const string apiPathRuManga = RootApi + "/ru-manga";
    public const string apiPathRuHentai = RootApi + "/ru-hentai";
    public const string apiPathRuVideo = RootApi + "/ru-hentai-video";
    public const string apiPathRuYaoi = RootApi + "/ru";
}

public static class EndPoint
{

    public const string ITEM_SLIDE = "10";
    public const string ITEM_TREND = "2";
    public const string ITEM_POPULAR = "6";
    public const string ITEM_SERIES = "6";

    public const string ITEM_HOME_COUNT = "12";
    public const string ITEM_PAGE_COUNT = "12";

    public const string homeSlide = $"/MangaTrend/{ITEM_SLIDE}/0/slide";
    public const string homeTrend = $"/MangaTrend/{ITEM_TREND}/0/trend";
    public const string homeLastUpdate = $"/MangaHomeUpdate/{ITEM_PAGE_COUNT}/";
    public const string homePopular = $"/MangaTrend/{ITEM_POPULAR}/0/popular";
    public const string homeSeriesPopular = $"/GetListTopViewHome/{ITEM_SERIES}/0";
    public const string infoManga = $"/GetInfoManga/";
    public const string infoChapter = $"/GetChapterListFilter/";
    public const string randomManga = $"/getRandomManga";
    public const string viewmanga = $"/GetImageChapter/";
    public const string genres = $"/AllGenres";
    public const string mangaGenres = $"/getGenresMangas/{ITEM_PAGE_COUNT}/";
    public const string mangaYear = $"/getYearsMangas/{ITEM_PAGE_COUNT}/";
    public const string mangaStatus = $"/getStatusMangas/{ITEM_PAGE_COUNT}/";
    public const string mangaAuth = $"/getAuthMangas/{ITEM_PAGE_COUNT}/";
    public const string mangaArt = $"/getArtsMangas/{ITEM_PAGE_COUNT}/";
    public const string mangaType = $"/getTypeMangas/{ITEM_PAGE_COUNT}/";
    public const string mangaAlpha = $"/getAlphaberMangas/{ITEM_PAGE_COUNT}/";
    public const string sitemapDoc = $"/AutoSiteMapDoc/";
    public const string sitemapAll = $"/SiteMapDoc/";
    public const string mangaQuickSearch = $"/searchterm/";
    public const string mangaListSearch = $"/searchforms/{ITEM_SERIES}/";
    public const string mangaAdvanceSearch = $"/advanceSearch";

    public const string configAddcomment = $"/addCommentsDomain";
    public const string configGetAllDomain = $"/alldomain";
    public const string configGetTopComment = $"/TopCommentsDomain/{ITEM_SERIES}/";
    public const string newtags = $"/AllTag";
    public const string listtags = $"/getTagsMangas/{ITEM_PAGE_COUNT}/";

    public const string checkTrend = $"/CheckMangaTrend/";
    public const string addTrend = $"/addTrend";
}