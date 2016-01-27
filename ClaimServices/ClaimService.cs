using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace ClaimServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClaimService" in both code and config file together.
    public class ClaimService : IClaimService
    {
        //Search Claim using Claim number
        public claimantData SearchClaim(string Id)
        {
            claimantData newClaimData = new claimantData();
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spSearchClaim", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                SqlParameter parameterClaimNumber = new SqlParameter();
                parameterClaimNumber.ParameterName = "@ClaimNumber";
                parameterClaimNumber.Value = Id;
                cmd.Parameters.Add(parameterClaimNumber);
                try
                {
                    con.Open();
                    //SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        newClaimData.claimNumber = reader["ClaimNumber"].ToString();
                        newClaimData.firstName = Convert.ToString(reader["FirstName"]);
                        newClaimData.lastName = reader["LastName"].ToString();
                        newClaimData.status = reader["ClaimStatus"].ToString();
                        newClaimData.lossDate = Convert.ToDateTime(reader["LossDate"]);
                        newClaimData.adjusterId = Convert.ToInt64(reader["AdjusterId"]);
                        return newClaimData;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    con.Close();
                    reader.Close();
                }
                return newClaimData;
            }
        }

        //Method to insert new claim.
        public void InsertClaim(claimantData newClaimantData)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spCreateClaim", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterClaimNumber = new SqlParameter
                {
                    ParameterName = "@ClaimNumber",
                    Value = newClaimantData.claimNumber
                };
                cmd.Parameters.Add(parameterClaimNumber);

                SqlParameter parameterFirstName = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    Value = newClaimantData.firstName
                };
                cmd.Parameters.Add(parameterFirstName);

                SqlParameter parameterLastName = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = newClaimantData.lastName
                };
                cmd.Parameters.Add(parameterLastName);

                SqlParameter parameterClaimStatus = new SqlParameter
                {
                    ParameterName = "@ClaimStatus",
                    Value = newClaimantData.status
                };
                cmd.Parameters.Add(parameterClaimStatus);

                SqlParameter parameterLossDate = new SqlParameter
                {
                    ParameterName = "@LossDate",
                    Value = newClaimantData.lossDate
                };
                cmd.Parameters.Add(parameterLossDate);

                SqlParameter parameterAdjusterId = new SqlParameter
                {
                    ParameterName = "@AdjusterId",
                    Value = newClaimantData.adjusterId
                };
                cmd.Parameters.Add(parameterAdjusterId);

                SqlParameter parameterCauseOfLoss = new SqlParameter
                {
                    ParameterName = "@CauseOfLoss",
                    Value = newClaimantData.causeOfLoss
                };
                cmd.Parameters.Add(parameterCauseOfLoss);

                SqlParameter parameterReportedDate = new SqlParameter
                {
                    ParameterName = "@ReportedDate",
                    Value = newClaimantData.reportedDate
                };
                cmd.Parameters.Add(parameterReportedDate);

                SqlParameter parameterLossDescription = new SqlParameter
                {
                    ParameterName = "@LossDescription",
                    Value = newClaimantData.lossDescription
                };
                cmd.Parameters.Add(parameterLossDescription);

                SqlParameter parameterModelYear = new SqlParameter
                {
                    ParameterName = "@ModelYear",
                    Value = newClaimantData.modelYear
                };
                cmd.Parameters.Add(parameterModelYear);

                SqlParameter parameterMakeDescription = new SqlParameter
                {
                    ParameterName = "@MakeDescription",
                    Value = newClaimantData.makeDescription
                };
                cmd.Parameters.Add(parameterMakeDescription);

                SqlParameter parameterModelDescription = new SqlParameter
                {
                    ParameterName = "@ModelDescription",
                    Value = newClaimantData.modelDescription
                };
                cmd.Parameters.Add(parameterModelDescription);

                SqlParameter parameterEngineDescription = new SqlParameter
                {
                    ParameterName = "@EngineDescription",
                    Value = newClaimantData.engineDescription
                };
                cmd.Parameters.Add(parameterEngineDescription);

                SqlParameter parameterExteriorColor = new SqlParameter
                {
                    ParameterName = "@ExteriorColor",
                    Value = newClaimantData.exteriorColor
                };
                cmd.Parameters.Add(parameterExteriorColor);

                SqlParameter parameterVin = new SqlParameter
                {
                    ParameterName = "@Vin",
                    Value = newClaimantData.vin
                };
                cmd.Parameters.Add(parameterVin);

                SqlParameter parameterLicensePlate = new SqlParameter
                {
                    ParameterName = "@LicensePlate",
                    Value = newClaimantData.licensePlate
                };
                cmd.Parameters.Add(parameterLicensePlate);

                SqlParameter parameterLicExpDate = new SqlParameter
                {
                    ParameterName = "@LicPlateExpDate",
                    Value = newClaimantData.licPlateExpDate
                };
                cmd.Parameters.Add(parameterLicExpDate);

                SqlParameter parameterDamageDescription = new SqlParameter
                {
                    ParameterName = "@DamageDescription",
                    Value = newClaimantData.damageDescription
                };
                cmd.Parameters.Add(parameterDamageDescription);

                SqlParameter parameterMileage = new SqlParameter
                {
                    ParameterName = "@Mileage",
                    Value = newClaimantData.mileage
                };
                cmd.Parameters.Add(parameterMileage);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    con.Close();
                }
            }
        }
    }
}