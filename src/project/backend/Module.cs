using Dapper;
using System.Data.SQLite;

public class SQLiteDataAccess
{
    private const string ConnectionString = "Data Source=backend\\database\\data.db;";

    public List<SidikJari> GetSidikJari()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            var encoding = connection.QuerySingle<String>("PRAGMA encoding");
            var output = connection.Query<SidikJari>("SELECT * FROM sidik_jari").ToList();
            return output;
        }
    }

    public List<Biodata> GetBiodata()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            var output = connection.Query<Biodata>("SELECT * FROM biodata").ToList();
            return output;
        }
    }

    public Biodata? searchForBiodata(SidikJari source)
    {
        if (source.Nama == null)
        {
            throw new ArgumentException("Source name cannot be null", nameof(source.Nama));
        }

        List<Biodata> allBiodata = this.GetBiodata();

        // Generate regex pattern matching
        RegexAlayPattern regex = new RegexAlayPattern();
        regex.GeneratePattern(source.Nama); // Generate pattern for regex

        // iterate all biodata
        foreach (Biodata bio in allBiodata)
        {
            if (string.IsNullOrEmpty(bio.Nama))
            {
                continue;
            }
            if (regex.IsMatch(bio.Nama))
            {
                return bio;
            }
        }

        // situation where an exact match of biodata name cannot be found
        // use LCS 
        int lcsScore = 0;
        Biodata? bestMatch = null;
        LongestCommonSubsequence lcs = new LongestCommonSubsequence(source.Nama.ToLower());
        foreach (Biodata bio in allBiodata)
        {
            if (string.IsNullOrEmpty(bio.Nama))
            {
                continue;
            }
            else
            {
                // normalize 
                string normalizeName = regex.Normalize(bio.Nama.ToLower());
                int tempScore = lcs.Search(normalizeName);
                if (tempScore > lcsScore)
                {
                    lcsScore = tempScore;
                    bestMatch = bio;
                }
            }
        }

        // change the name in sidik jari
        if (bestMatch != null)
        {
            return bestMatch;

        }

        return null;
    }
}

public class SidikJari
{

    public string? Berkas_citra { get; set; }
    public string? Nama { get; set; }

    public SidikJari()
    {
        this.Berkas_citra = "";
        this.Nama = "";
    }

}

public class Biodata
{
    public string? NIK { get; set; }
    public string? Nama { get; set; }
    public string? Tempat_lahir { get; set; }
    public string? Tanggal_lahir { get; set; }
    public string? Jenis_kelamin { get; set; }
    public string? Golongan_darah { get; set; }
    public string? Alamat { get; set; }
    public string? Agama { get; set; }
    public string? Status_perkawinan { get; set; }
    public string? Pekerjaan { get; set; }
    public string? Kewarganegaraan { get; set; }
    public string? Algoritma { get; set; }
    public double? Presentase { get; set; }
    public long? TimeTaken { get; set; }
}