using System;
using System.Data;
using System.Data.SqlClient;

static string connectionString = "Data Source=DZAKNERZ\\DATABASEABY;Initial Catalog=DBAkademikADO;Integrated Security=True";
1 reference
public string GetConnectionString()
{
    return connectionString;
}

SqlConnection conn = new SqlConnection(connectionString);

SqlDataAdapter da;
DataTable dtMahasiswa;
DataTable dtProdi;
2 references
public int CountMhs()
{
    if (conn.State == ConnectionState.Closed)
    {
        conn.Open();
    }

    SqlCommand cmd = new SqlCommand("sp_CountMahasiswa", conn);
    cmd.CommandType = CommandType.StoredProcedure;

    SqlParameter outputParam = new SqlParameter("@pCount", SqlDbType.Int);
    outputParam.Direction = ParameterDirection.Output;

    cmd.Parameters.Add(outputParam);

    cmd.ExecuteNonQuery();

    return Convert.ToInt32(outputParam.Value);
}

public DataTable GetMhs()
{
    if (conn.State == ConnectionState.Closed)
    {
        conn.Open();
    }

    SqlCommand cmd = new SqlCommand("sp_GetMahasiswa", conn);
    cmd.CommandType = CommandType.StoredProcedure;

    da = new SqlDataAdapter(cmd);

    dtMahasiswa = new DataTable();
    da.Fill(dtMahasiswa);

    return dtMahasiswa;
}