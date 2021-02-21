using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace RMS_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string Insert(InsertOrder order)
        {
            string msg;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Res_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Res_Tab (O_Name, O_Desc, O_Price, O_Type, O_Stat, O_Cate) values (@O_Name, @O_Desc, @O_Price, @O_Type, @O_Stat, @O_Cate)", con);
            cmd.Parameters.AddWithValue("@O_Name", order.O_Name ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Desc", order.O_Desc ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Price", order.O_Price ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Type", order.O_Type ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Stat", order.O_Stat ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Cate", order.O_Cate ?? (object)DBNull.Value);

            int g = cmd.ExecuteNonQuery();
            if (g == 1)
            {
                msg = "Successfully inserted.";
            }
            else
            {
                msg = "Failed to insert.";
            }

            return msg;
        }

        public  getdata GetOI() {
            getdata g = new getdata();
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Res_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Res_Tab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("mytab");
            da.Fill(dt);
            g.Res_Tab = dt;
            return g;
        }

        public string Update(UpdateOI o) {
            string Message = "";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Res_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Res_Tab set O_Name = @O_Name, O_Desc = @O_Desc, O_Price = @O_Price, O_Type = @O_Type, O_Stat = @O_Stat, O_Cate = @O_Cate WHERE O_ID = @O_ID", con);
            cmd.Parameters.AddWithValue("@O_ID", o.O_ID);
            cmd.Parameters.AddWithValue("@O_Name", o.O_Name ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Desc", o.O_Desc ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Price", o.O_Price ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Type", o.O_Type ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Stat", o.O_Stat ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@O_Cate", o.O_Cate ?? (object)DBNull.Value);
            int res = cmd.ExecuteNonQuery();
            if (res == 1)
            {
                Message = "Successfully updated.";
            }
            else
            {
                Message = "Failed to update.";
            }

            return Message;
        }

        public string Delete(DeleteOI d) {
            string msg = "";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Res_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Res_Tab where O_ID = @O_ID", con);
            cmd.Parameters.AddWithValue("@O_ID", d.O_ID);
            int res = cmd.ExecuteNonQuery();
            if (res == 1)
            {
                msg = "Deleted Successfully.";
                
            }
            else
            {
                msg = "Failed to delete.";
            }

            return msg;

        }

    }
}
