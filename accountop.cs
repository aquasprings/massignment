using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountBO;
using System.Data.SqlClient;
using System.Data;

namespace accountDAL
{
    public class Accountop
    {
        public int addaccount(account aobj)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718; password=tcstvm;database=DB09TMS101_1718");
            con.Open();
            SqlCommand cmd = new SqlCommand("update_details_acc", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cid", aobj.CusID);
            cmd.Parameters.AddWithValue("@amt", aobj.Amount);
            cmd.Parameters.AddWithValue("@atype", aobj.AccountType);
            cmd.Parameters.AddWithValue("@sdate", aobj.Sdate);
            cmd.Parameters.AddWithValue("@astatus", aobj.Status);

            cmd.Parameters.AddWithValue("@accid", 0);
            cmd.Parameters["@accid"].Direction = ParameterDirection.Output;
            int rowaffected = cmd.ExecuteNonQuery();
            if (rowaffected > 0)
            {
                int accountid = Convert.ToInt32(cmd.Parameters["@accid"].Value);
                return accountid;
            }
            else { return 0; }


            
        }
        public List<account> viewdata()
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");
            con.Open();

            SqlCommand cmd = new SqlCommand("viewaccountdetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            List<account> lstacc = new List<account>();
            while (reader.Read())
            {
                account s = new account();
                s.Customername = reader["name"].ToString();
                s.CusID =Convert.ToInt32( reader["customerid"]);
                s.Amount = Convert.ToInt32(reader["amount"]);
                s.AccountType = reader["acountType"].ToString();
                s.Sdate = Convert.ToDateTime(reader["startDate"]);
                s.Status = reader["astatus"].ToString();


                lstacc.Add(s);

            }

            return lstacc;
        }
        public int del(int id)
        {
            
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_del_stu", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cid", id);

            int rowaffected = cmd.ExecuteNonQuery();
            return rowaffected;

        }
    }
}
