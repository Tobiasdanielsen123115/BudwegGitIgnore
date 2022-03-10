﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace BudwegCo2.Model
{
  public class WareRepo
    {

        private List<Ware> Wares;

        // ADD
       public void SaveCo2(string date, int amount, double amountCo2Saved, int companyID)
        {


            using (SqlConnection con = new SqlConnection("Server=10.56.8.36;Database=P2DB09;User Id=P2-09;Password=OPENDB_09"))
            {
               
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Co2 (Amount, Date, TotalAmountSavedCo2, CompanyID)" +
                                                 "VALUES (@Amount, @Date, @TotalAmountSavedCo2, @CompanyID)", con);

                cmd.Parameters.Add(new SqlParameter("@Amount", amount));
                cmd.Parameters.Add(new SqlParameter("@Date", date));
                cmd.Parameters.Add(new SqlParameter("@TotalAmountSavedCo2", amountCo2Saved));
                cmd.Parameters.Add(new SqlParameter("@CompanyID", companyID));

                cmd.ExecuteNonQuery();

            }
       }
       public void GetAll(string date, int amount, double amountCo2Saved, int companyID)
       {
           {
               using(SqlConnection con = new SqlConnection("Server=10.56.8.36;Database=P2DB09;User Id=P2-09;Password=OPENDB_09"))
               {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Date, Amount, AmountCo2Saved, CompanyID FROM Co2", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Ware ware = new Ware();
                            ware.Amount =  Convert.ToInt32(dr["Amount"]);
                            ware.AmountCo2Saved = Convert.ToDouble(dr["AmountCo2Saved"]);
                            ware.Date = dr["Date"].ToString();
                            ware.CompanyID = Convert.ToInt32(dr["CompanyID"]);

                            Wares.Add(ware);
                        }

                    }
               }
           }
       }

        

    }
}
