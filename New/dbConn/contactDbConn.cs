using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{

    class contactDbConn: dbConn
    {
        public void createContact(string conFName, string conLName, string conEmail, string conTelNum, string conAddress, string conCity, string conPostCode, string conType)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `contacts` (`conID`, `conFName`, `conLName`, `conEmail`, `conTelNum`, `conAddress`, `conCity`, `conPostCode`, `conType`) VALUES (NULL,@conFName, @conLName, @conEmail, @conTelNum, @conAddress, @conCity, @conPostCode, @conType);";
            comm.Parameters.AddWithValue("@conFName", conFName);
            comm.Parameters.AddWithValue("@conLName", conLName);
            comm.Parameters.AddWithValue("@conEmail", conEmail);
            comm.Parameters.AddWithValue("@conTelNum", conTelNum);
            comm.Parameters.AddWithValue("@conAddress", conAddress);
            comm.Parameters.AddWithValue("@conCity", conCity);
            comm.Parameters.AddWithValue("@conPostCode", conPostCode);
            comm.Parameters.AddWithValue("@conType", conType);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void updateContact(string conID, string conFName, string conLName, string conEmail, string conTelNum, string conAddress, string conCity, string conPostCode, string conType)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `contacts` SET `conFName`=@conFName,`conLName`=@conLName,`conEmail`=@conEmail, `conTelNum`=@conTelNum, `conAddress`=@conAddress, `conCity`=@conCity, `conPostCode`=@conPostCode, `conType`=@conType WHERE conID=@ConID";
            comm.Parameters.AddWithValue("@conID", conID);
            comm.Parameters.AddWithValue("@conFName", conFName);
            comm.Parameters.AddWithValue("@conLName", conLName);
            comm.Parameters.AddWithValue("@conEmail", conEmail);
            comm.Parameters.AddWithValue("@conTelNum", conTelNum);
            comm.Parameters.AddWithValue("@conAddress", conAddress);
            comm.Parameters.AddWithValue("@conCity", conCity);
            comm.Parameters.AddWithValue("@conPostCode", conPostCode);
            comm.Parameters.AddWithValue("@conType", conType);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void deleteContact(string conID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `contacts` WHERE conID = @conID";
            comm.Parameters.AddWithValue("@conID", conID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
