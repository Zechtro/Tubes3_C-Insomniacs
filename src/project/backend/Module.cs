using System.Collections.Generic;
using System;


// public class DataContext : DbContext
// {
//     public DbSet<Biodata> Biodata {get; set;}

//     protected override void onConfiguring(DbContextOptionsBuider option){

//     }
// }

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
            // using (StreamWriter writer = new StreamWriter("log.txt"))
            //         {
            //             Console.SetOut(writer); // Redirect output to the file
            //             Console.WriteLine("This message will be written to log.txt");
            //             Console.WriteLine(encoding);
            //         }
     
            var output = connection.Query<SidikJari>("SELECT * FROM sidik_jari").ToList();
            return output;
        }
    }

        public List<SidikJari> GetBiodata()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            var output = connection.Query<SidikJari>("SELECT * FROM biodata").ToList();
            return output;
        }
    }
}

public class SidikJari
{   

    public string? berkas_citra { get; set; }
    public string? nama { get; set; }

}

public class Biodata
{
    public string? NIK { get; set; }
    public string? Nama { get; set; }
    public string? TempatLahir { get; set; }
    public string? TanggalLahir { get; set; }
    public string? JenisKelamin { get; set; }
    public string? GolonganDarah { get; set; }
    public string? Alamat { get; set; }
    public string? Agama { get; set; }
    public string? StatusPerkawinan { get; set; }
    public string? Pekerjaan { get; set; }
    public string? Kewarganegaraan { get; set; }
}