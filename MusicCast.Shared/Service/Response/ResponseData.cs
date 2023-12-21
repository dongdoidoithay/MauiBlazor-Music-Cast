using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace MusicCast.Shared.Service.Response;


public class ResponseTrend
{
    [JsonPropertyName("idDocTrend")]
    public string IdDocTrend { get; set; }
    [JsonPropertyName("idDoc")]
    public string IdDoc { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }
    [JsonPropertyName("document")]
    public Document DocumentData { get; set; }
    [JsonPropertyName("platform")]
    public string Platform { get; set; }
}

public class ResponseDataLastUppdate
{
    [JsonPropertyName("totalRecode")]
    public int? TotalRecode { get; set; }
    [JsonPropertyName("currentPage")]
    public string CurrentPage { get; set; }
    [JsonPropertyName("totalPage")]
    public int? TotalPage { get; set; }
    [JsonPropertyName("nextPage")]
    public string NextPage { get; set; }
    [JsonPropertyName("platform")]
    public string Platform { get; set; }

    [JsonPropertyName("data")]
    public List<Document> Data { get; set; }
}

public class ResponseDataDocument
{
    [JsonPropertyName("idDoc")]
    public string idDoc { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("nameOther")]
    public string nameOther { get; set; }

    [JsonPropertyName("nameSeo")]
    public string nameSeo { get; set; }

    [JsonPropertyName("image")]
    public string image { get; set; }

    [JsonPropertyName("desc")]
    public string desc { get; set; }

    [JsonPropertyName("year")]
    public string year { get; set; }

    [JsonPropertyName("view")]
    public int view { get; set; }

    [JsonPropertyName("date")]
    public DateTime date { get; set; }

    [JsonPropertyName("tags")]
    public string tags { get; set; }

    [JsonPropertyName("lsgenres")]
    public List<LObject> lsgenres { get; set; }

    [JsonPropertyName("lsarts")]
    public List<LObject> lsarts { get; set; }

    [JsonPropertyName("lsauths")]
    public List<LObject> lsauths { get; set; }

    [JsonPropertyName("lsscans")]
    public List<LObject> lsscans { get; set; }

    [JsonPropertyName("lsstatus")]
    public List<LObject> lsstatus { get; set; }

    [JsonPropertyName("lstypes")]
    public List<LObject> lstypes { get; set; }

    [JsonPropertyName("rate")]
    public double rate { get; set; }

    [JsonPropertyName("lsdetail")]
    public List<Lsdetail> lsdetail { get; set; }
}
public class Lsdetail
{
    [JsonPropertyName("slug")]
    public string slug { get; set; }

    [JsonPropertyName("idDoc")]
    public string idDoc { get; set; }

    [JsonPropertyName("idDetail")]
    public string idDetail { get; set; }

    [JsonPropertyName("nameChapter")]
    public string nameChapter { get; set; }

    [JsonPropertyName("nameDoc")]
    public string nameDoc { get; set; }

    [JsonPropertyName("nameSeoChapter")]
    public string nameSeoChapter { get; set; }

    [JsonPropertyName("date")]
    public DateTime date { get; set; }

    [JsonPropertyName("source")]
    public string source { get; set; }
}

public class LObject
{
    [JsonPropertyName("id")]
    public string id { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }
}



public class Document
{
    [JsonPropertyName("idDoc")]
    public string IdDoc { get; set; }
    [JsonPropertyName("nameOther")]
    public string NameOther { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("nameSeo")]
    public string NameSeo { get; set; }
    [JsonPropertyName("image")]
    public string Image { get; set; }
    [JsonPropertyName("desc")]
    public string Desc { get; set; }
    [JsonPropertyName("genres")]
    public string Genres { get; set; }
    [JsonPropertyName("year")]
    public string Year { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("auth")]
    public string Auth { get; set; }
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("art")]
    public string Art { get; set; }

    [JsonPropertyName("view")]
    public int? View { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
    [JsonPropertyName("tags")]
    public string Tags { get; set; }
    [JsonPropertyName("rate")]
    public string Rate { get; set; }
    [JsonPropertyName("postedBy")]
    public string PostedBy { get; set; }
    [JsonPropertyName("serialization")]
    public string Serialization { get; set; }
    [JsonPropertyName("detail_documents")]
    public List<DetailDocument> DetailDocuments { get; set; }
}


public class DetailDocument
{
    [JsonPropertyName("slug")]
    public string Slug { get; set; }
    [JsonPropertyName("idDoc")]
    public string IdDoc { get; set; }
    [JsonPropertyName("idDetail")]
    public string IdDetail { get; set; }
    [JsonPropertyName("nameChapter")]
    public string NameChapter { get; set; }
    [JsonPropertyName("nameDoc")]
    public string NameDoc { get; set; }
    [JsonPropertyName("nameSeoChapter")]
    public string NameSeoChapter { get; set; }
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }
}