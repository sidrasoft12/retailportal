using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
namespace RetailPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic
using static System.Net.Mime.MediaTypeNames;

public class PlanCategoryBenefits
{
    private int _RowNumber;
    private Int64 _Id;
    private Int64 _PlanCategoryId;
    private Int64 _GMQuotationId;
    private Int32 _PremiumTypeId;
    private int _WaitingPeriod;
    private string _WaitingPeriodUnit;
    private decimal _CoPayPerc;
    private decimal _CoPayAmount;
    private bool _IsCovered;
    private string _Comments;
    private string _PremiumType;
    private bool _HasWaitingPeriod;
    private bool _HasCoPay;
    private string _DeductiblePerc;
    private decimal _DeductibleAmount;
    private string _ProviderNetwork;
    private bool _SharedBenefit;
    private string _PECInclusions;
    private string _PECExclusions;
    private bool _PreAuth;
    private string _LimitType;
    private string _LimitAmountType;
    private string _LimitAmountCurrency;
    private decimal _LimitAmount;
    private string _LimitAmountUnit;
    private string _LimitAmountTerm;
    private string _LimitCountFreq;
    private string _LimitCountType;
    private decimal _LimitCount;
    private string _LimitCountTerm;
    //private int _UserId;
    private Int64 _PlanId;
    private string _Category;
    private Int64 _PlanBenefitId;
    private string _DisplayDEDText;
    private string _DisplayCopayText;
    private decimal _PremiumAmt;
    private decimal _PremiumPerc;
    private string _Description;
    private string _BenefitName;
    private decimal _BaseAmount;
    private string _BaseTerm;
    private decimal _MaxAmount;
    private string _MaxTerm;
    private string _DisplayText;
    private Int32 _BaseCount;
    private Int32 _MaxCount;
    private string _BaseType;
    private string _MaxType;
    private string _LimitText;
    private string _TOBTag;

    public int RowNumber
    {
        get { return _RowNumber; }
        set { _RowNumber = value; }
    }
    public Int64 Id
    {
        get { return _Id; }
        set { _Id = value; }
    }
    public Int64 PlanCategoryId
    {
        get { return _PlanCategoryId; }
        set { _PlanCategoryId = value; }
    }
    public Int64 GMQuotationId
    {
        get { return _GMQuotationId; }
        set { _GMQuotationId = value; }
    }

    public Int32 PremiumTypeId
    {
        get { return _PremiumTypeId; }
        set { _PremiumTypeId = value; }
    }

    public int WaitingPeriod
    {
        get { return _WaitingPeriod; }
        set { _WaitingPeriod = value; }
    }
    public string WaitingPeriodUnit
    {
        get { return _WaitingPeriodUnit; }
        set { _WaitingPeriodUnit = value; }
    }

    public decimal CoPayPerc
    {
        get { return _CoPayPerc; }
        set { _CoPayPerc = value; }
    }
    public decimal CoPayAmount
    {
        get { return _CoPayAmount; }
        set { _CoPayAmount = value; }
    }
    public bool IsCovered
    {
        get { return _IsCovered; }
        set { _IsCovered = value; }
    }
    public string Comments
    {
        get { return _Comments; }
        set { _Comments = value; }
    }
    public string PremiumType
    {
        get { return _PremiumType; }
        set { _PremiumType = value; }
    }
    public bool HasWaitingPeriod
    {
        get { return _HasWaitingPeriod; }
        set { _HasWaitingPeriod = value; }
    }
    public bool HasCoPay
    {
        get { return _HasCoPay; }
        set { _HasCoPay = value; }
    }
    public string DeductiblePerc
    {
        get { return _DeductiblePerc; }
        set { _DeductiblePerc = value; }
    }
    public decimal DeductibleAmount
    {
        get { return _DeductibleAmount; }
        set { _DeductibleAmount = value; }
    }
    public string ProviderNetwork
    {
        get { return _ProviderNetwork; }
        set { _ProviderNetwork = value; }
    }
    public bool SharedBenefit
    {
        get { return _SharedBenefit; }
        set { _SharedBenefit = value; }
    }
    public string PECInclusions
    {
        get { return _PECInclusions; }
        set { _PECInclusions = value; }
    }
    public string PECExclusions



    {
        get { return _PECExclusions; }
        set { _PECExclusions = value; }
    }
    public bool PreAuth
    {
        get { return _PreAuth; }
        set { _PreAuth = value; }
    }
    public string LimitType
    {
        get { return _LimitType; }
        set { _LimitType = value; }
    }
    public string LimitAmountType
    {
        get { return _LimitAmountType; }
        set { _LimitAmountType = value; }
    }
    public string LimitAmountCurrency
    {
        get { return _LimitAmountCurrency; }
        set { _LimitAmountCurrency = value; }
    }
    public decimal LimitAmount
    {
        get { return _LimitAmount; }
        set { _LimitAmount = value; }
    }
    public string LimitAmountUnit
    {
        get { return _LimitAmountUnit; }
        set { _LimitAmountUnit = value; }
    }
    public string LimitAmountTerm
    {
        get { return _LimitAmountTerm; }
        set { _LimitAmountTerm = value; }
    }
    public string LimitCountFreq
    {
        get { return _LimitCountFreq; }
        set { _LimitCountFreq = value; }
    }
    public string LimitCountType
    {
        get { return _LimitCountType; }
        set { _LimitCountType = value; }
    }
    public decimal LimitCount
    {
        get { return _LimitCount; }
        set { _LimitCount = value; }
    }
    public string LimitCountTerm
    {
        get { return _LimitCountTerm; }
        set { _LimitCountTerm = value; }
    }
    //public int UserId
    //{
    //    get { return _UserId; }
    //    set { _UserId = value; }
    //}
    public Int64 PlanId
    {
        get { return _PlanId; }
        set { _PlanId = value; }
    }
    public string Category
    {
        get { return _Category; }
        set { _Category = value; }
    }
    public Int64 PlanBenefitId
    {
        get { return _PlanBenefitId; }
        set { _PlanBenefitId = value; }
    }
    public string DisplayDEDText
    {
        get { return _DisplayDEDText; }
        set { _DisplayDEDText = value; }
    }
    public string DisplayCopayText
    {
        get { return _DisplayCopayText; }
        set { _DisplayCopayText = value; }
    }
    public decimal PremiumAmt
    {
        get { return _PremiumAmt; }
        set { _PremiumAmt = value; }
    }
    public decimal PremiumPerc
    {
        get { return _PremiumPerc; }
        set { _PremiumPerc = value; }
    }
    public string Description
    {
        get { return _Description; }
        set { _Description = value; }
    }
    public string BenefitName
    {
        get { return _BenefitName; }
        set { _BenefitName = value; }
    }
    public decimal BaseAmount
    {
        get { return _BaseAmount; }
        set { _BaseAmount = value; }
    }
    public string BaseTerm
    {
        get { return _BaseTerm; }
        set { _BaseTerm = value; }
    }
    public decimal MaxAmount
    {
        get { return MaxAmount; }
        set { _MaxAmount = value; }
    }
    public string MaxTerm
    {
        get { return _MaxTerm; }
        set { _MaxTerm = value; }
    }
    public string DisplayText
    {
        get { return _DisplayText; }
        set { _DisplayText = value; }
    }
    public Int32 BaseCount
    {
        get { return _BaseCount; }
        set { _BaseCount = value; }
    }
    public Int32 MaxCount
    {
        get { return _MaxCount; }
        set { _MaxCount = value; }
    }
    public string BaseType
    {
        get { return _BaseType; }
        set { _BaseType = value; }
    }
    public string MaxType
    {
        get { return _MaxType; }
        set { _MaxType = value; }
    }
    public string LimitText
    {
        get { return _LimitText; }
        set { _LimitText = value; }
    }
    public string TOBTag
    {
        get { return _TOBTag; }
        set { _TOBTag = value; }
    }

    public IConfiguration _Config { get; set; }
    public PlanCategoryBenefits() { }
    public PlanCategoryBenefits(IConfiguration configuration)
    {
        _Config = configuration;
    }
    public void SetConfiguration(IConfiguration configuration)
    {
        _Config = configuration;
    }

    public List<PlanCategoryBenefits> GetPlanCategoryBenefitsList(string WhereCondition, string PagingCondition, string OrderByExpression)
    {
        var lstEntity = new List<PlanCategoryBenefits>();

        try
        {
            using (SqlConnection connection = new SqlConnection(_Config.GetConnectionString("ConnString")))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("usp_Get_GMQuotationPlanCategoryBenefits", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (!string.IsNullOrEmpty(WhereCondition))
                        cmd.Parameters.Add(new SqlParameter("@WhereCondition", SqlDbType.NVarChar) { Value = WhereCondition });

                    if (!string.IsNullOrEmpty(PagingCondition))
                    {
                        // Add logic to modify PagingCondition for top 5 records.
                        PagingCondition = "RowNumber>=1 and RowNumber<=5"; // Adjust based on your stored procedure
                        cmd.Parameters.Add(new SqlParameter("@PagingCondition", SqlDbType.NVarChar) { Value = PagingCondition });
                    }

                    if (!string.IsNullOrEmpty(OrderByExpression))
                        cmd.Parameters.Add(new SqlParameter("@OrderByExpression", SqlDbType.NVarChar) { Value = OrderByExpression });

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int recordCounter = 0; // Counter to limit number of records to top 5.
                        while (reader.Read() && recordCounter < 5)
                        {
                            PlanCategoryBenefits oEntity = new PlanCategoryBenefits(_Config);
                            oEntity.RowNumber = reader["RowNumber"] == DBNull.Value ? 0 :Convert.ToInt32(reader["RowNumber"]);
                            oEntity.Id = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt64(reader["Id"]);
                            oEntity.PlanCategoryId = reader["PlanCategoryId"] == DBNull.Value ? 0 : Convert.ToInt64(reader["PlanCategoryId"]);
                            oEntity.GMQuotationId = reader["GMQuotationId"] == DBNull.Value ? 0 : Convert.ToInt64(reader["GMQuotationId"]);
                            oEntity.PremiumTypeId = reader["PremiumTypeId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PremiumTypeId"]);
                            oEntity.WaitingPeriod = reader["WaitingPeriod"] == DBNull.Value ? 0 : Convert.ToInt16(reader["WaitingPeriod"]);
                            oEntity.WaitingPeriodUnit = reader["WaitingPeriodUnit"] == DBNull.Value ? string.Empty : (string)reader["WaitingPeriodUnit"];
                            oEntity.CoPayPerc = reader["CoPayPerc"] == DBNull.Value ? 0 : (decimal)reader["CoPayPerc"];
                            oEntity.CoPayAmount = reader["CoPayAmount"] == DBNull.Value ? 0 : (decimal)reader["CoPayAmount"];
                            oEntity.IsCovered = reader["IsCovered"] == DBNull.Value ? false : (bool)reader["IsCovered"];
                            oEntity.Comments = reader["Comments"] == DBNull.Value ? string.Empty : (string)reader["Comments"];
                            oEntity.PremiumType = reader["PremiumType"] == DBNull.Value ? string.Empty : (string)reader["PremiumType"];
                            oEntity.HasWaitingPeriod = reader["HasWaitingPeriod"] == DBNull.Value ? false : (bool)reader["HasWaitingPeriod"];
                            oEntity.HasCoPay = reader["HasCoPay"] == DBNull.Value ? false : (bool)reader["HasCoPay"];
                            oEntity.DeductiblePerc = reader["DeductiblePerc"] == DBNull.Value ? string.Empty : (string)reader["DeductiblePerc"];
                            oEntity.DeductibleAmount = reader["DeductibleAmount"] == DBNull.Value ? 0 : (decimal)reader["DeductibleAmount"];
                            oEntity.ProviderNetwork = reader["ProviderNetwork"] == DBNull.Value ? string.Empty : (string)reader["ProviderNetwork"];
                            oEntity.SharedBenefit = reader["SharedBenefit"] == DBNull.Value ? false : (bool)reader["SharedBenefit"];
                            oEntity.PECInclusions = reader["PECInclusions"] == DBNull.Value ? string.Empty : (string)reader["PECInclusions"];
                            oEntity.PECExclusions = reader["PECExclusions"] == DBNull.Value ? string.Empty : (string)reader["PECExclusions"];
                            oEntity.PreAuth = reader["PreAuth"] == DBNull.Value ? false : (bool)reader["PreAuth"];
                            oEntity.LimitType = reader["LimitType"] == DBNull.Value ? string.Empty : (string)reader["LimitType"];
                            oEntity.LimitAmountType = reader["LimitAmountType"] == DBNull.Value ? string.Empty : (string)reader["LimitAmountType"];
                            oEntity.LimitAmountCurrency = reader["LimitAmountCurrency"] == DBNull.Value ? string.Empty : (string)reader["LimitAmountCurrency"];
                            oEntity.LimitAmount = reader["LimitAmount"] == DBNull.Value ? 0 : (decimal)reader["LimitAmount"];
                            oEntity.LimitAmountUnit = reader["LimitAmountUnit"] == DBNull.Value ? string.Empty : (string)reader["LimitAmountUnit"];
                            oEntity.LimitAmountTerm = reader["LimitAmountTerm"] == DBNull.Value ? string.Empty : (string)reader["LimitAmountTerm"];
                            oEntity.LimitCountFreq = reader["LimitCountFreq"] == DBNull.Value ? string.Empty : (string)reader["LimitCountFreq"];
                            oEntity.LimitCountType = reader["LimitCountType"] == DBNull.Value ? string.Empty : (string)reader["LimitCountType"];
                            oEntity.LimitCount = reader["LimitCount"] == DBNull.Value ? 0 : (decimal)reader["LimitCount"];
                            oEntity.LimitCountTerm = reader["LimitCountTerm"] == DBNull.Value ? string.Empty : (string)reader["LimitCountTerm"];
                            oEntity.PlanId = reader["PlanId"] == DBNull.Value ? 0 : Convert.ToInt64(reader["PlanId"]);
                            oEntity.Category = reader["Category"] == DBNull.Value ? string.Empty : (string)reader["Category"];
                            oEntity.PlanBenefitId = reader["PlanBenefitId"] == DBNull.Value ? 0 : Convert.ToInt64(reader["PlanBenefitId"]);
                            oEntity.DisplayDEDText = reader["DisplayDEDText"] == DBNull.Value ? string.Empty : (string)reader["DisplayDEDText"];
                            oEntity.DisplayCopayText = reader["DisplayCopayText"] == DBNull.Value ? string.Empty : (string)reader["DisplayCopayText"];
                            oEntity.PremiumAmt = reader["PremiumAmt"] == DBNull.Value ? 0 : (decimal)reader["PremiumAmt"];
                            oEntity.PremiumPerc = reader["PremiumPerc"] == DBNull.Value ? 0 : (decimal)reader["PremiumPerc"];
                            oEntity.Description = reader["Description"] == DBNull.Value ? string.Empty : (string)reader["Description"];
                            oEntity.BenefitName = reader["BenefitName"] == DBNull.Value ? string.Empty : (string)reader["BenefitName"];
                            oEntity.BaseAmount = reader["BaseAmount"] == DBNull.Value ? 0 : (decimal)reader["BaseAmount"];
                            oEntity.BaseTerm = reader["BaseTerm"] == DBNull.Value ? string.Empty : (string)reader["BaseTerm"];
                            oEntity.MaxAmount = reader["MaxAmount"] == DBNull.Value ? 0 : (decimal)reader["MaxAmount"];
                            oEntity.MaxTerm = reader["MaxTerm"] == DBNull.Value ? string.Empty : (string)reader["MaxTerm"];
                            oEntity.DisplayText = reader["DisplayText"] == DBNull.Value ? string.Empty : (string)reader["DisplayText"];
                            oEntity.BaseCount = reader["BaseCount"] == DBNull.Value ? 0 : Convert.ToInt32(reader["BaseCount"]);
                            oEntity.MaxCount = reader["MaxCount"] == DBNull.Value ? 0 : Convert.ToInt32(reader["MaxCount"]);
                            oEntity.BaseType = reader["BaseType"] == DBNull.Value ? string.Empty : (string)reader["BaseType"];
                            oEntity.MaxType = reader["MaxType"] == DBNull.Value ? string.Empty : (string)reader["MaxType"];
                            oEntity.LimitText = reader["LimitText"] == DBNull.Value ? string.Empty : (string)reader["LimitText"];
                            oEntity.TOBTag = reader["TOBTag"] == DBNull.Value ? string.Empty : (string)reader["TOBTag"];

                            lstEntity.Add(oEntity);
                            recordCounter++;
                        }
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            // Log the SQL exception details
            Console.WriteLine("SQL Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Handle exception appropriately
            lstEntity = null;
            throw new Exception("Error retrieving GMQuotations list.", ex);
        }

        return lstEntity;
    }


}

