using Dapper;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

public class EncryptDatabase
{
    public static void encryptDatabase(){
        var connection = new SqliteConnection("Data Source=..\\project\\backend\\database\\data.db;");
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "SELECT nama, NIK, tempat_lahir, tanggal_lahir, jenis_kelamin, golongan_darah, alamat, agama, status_perkawinan, pekerjaan, kewarganegaraan FROM biodata";

        SqliteDataReader reader = command.ExecuteReader();
        List<(String nama, String NIK, String tempat_lahir, String tanggal_lahir, String jenis_kelamin, String golongan_darah, String alamat, String agama, String status_perkawinan, String pekerjaan, String kewarganegaraan)> rowsToUpdate = new List<(String nama, String NIK, String tempat_lahir, String tanggal_lahir, String jenis_kelamin, String golongan_darah, String alamat, String agama, String status_perkawinan, String pekerjaan, String kewarganegaraan)>();
        while (reader.Read())
        {
            String nama = reader.GetString(0);
            String NIK = reader.GetString(1);
            String tempat_lahir = reader.GetString(2);
            String tanggal_lahir = reader.GetString(3);
            String jenis_kelamin = reader.GetString(4);
            String golongan_darah = reader.GetString(5);
            String alamat = reader.GetString(6);
            String agama = reader.GetString(7);
            String status_perkawinan = reader.GetString(8);
            String pekerjaan = reader.GetString(9);
            String kewarganegaraan = reader.GetString(10);

            rowsToUpdate.Add((nama, NIK, tempat_lahir, tanggal_lahir, jenis_kelamin, golongan_darah, alamat, agama, status_perkawinan, pekerjaan, kewarganegaraan));
        }

        var updateCommand = connection.CreateCommand();
        updateCommand.CommandText = 
            @"UPDATE biodata 
            SET NIK = @newNIK, tempat_lahir = @newTempatLahir, tanggal_lahir = @newTanggalLahir, jenis_kelamin = @newJenisKelamin, golongan_darah = @newGolonganDarah, alamat = @newAlamat, agama = @newAgama, status_perkawinan = @newStatusPerkawinan, pekerjaan = @newPekerjaan, kewarganegaraan = @newKewarganegaraan
            WHERE nama = @nama";

        foreach ((String nama, String NIK, String tempat_lahir, String tanggal_lahir, String jenis_kelamin, String golongan_darah, String alamat, String agama, String status_perkawinan, String pekerjaan, String kewarganegaraan) in rowsToUpdate)
        {
            String newNIK = encrypt(NIK);
            String newTempatLahir = encrypt(tempat_lahir);
            String newTanggalLahir = encrypt(tanggal_lahir);
            String newJenisKelamin = encrypt(jenis_kelamin);
            String newGolonganDarah = encrypt(golongan_darah);
            String newAlamat = encrypt(alamat);
            String newAgama = encrypt(agama);
            String newStatusPerkawinan = encrypt(status_perkawinan);
            String newPekerjaan = encrypt(pekerjaan);
            String newKewarganegaraan = encrypt(kewarganegaraan);

            updateCommand.Parameters.AddWithValue("@nama", nama);
            updateCommand.Parameters.AddWithValue("@newNIK", newNIK);
            updateCommand.Parameters.AddWithValue("@newTempatLahir", newTempatLahir);
            updateCommand.Parameters.AddWithValue("@newTanggalLahir", newTanggalLahir);
            updateCommand.Parameters.AddWithValue("@newJenisKelamin", newJenisKelamin);
            updateCommand.Parameters.AddWithValue("@newGolonganDarah", newGolonganDarah);
            updateCommand.Parameters.AddWithValue("@newAlamat", newAlamat);
            updateCommand.Parameters.AddWithValue("@newAgama", newAgama);
            updateCommand.Parameters.AddWithValue("@newStatusPerkawinan", newStatusPerkawinan);
            updateCommand.Parameters.AddWithValue("@newPekerjaan", newPekerjaan);
            updateCommand.Parameters.AddWithValue("@newKewarganegaraan", newKewarganegaraan);
            updateCommand.ExecuteNonQuery();

            updateCommand.Parameters.Clear();
        }

        connection.Close();
    }

    private static String encrypt(String oldValue)
    {
        return Encrypt.encrypt(oldValue); 
    }
}

