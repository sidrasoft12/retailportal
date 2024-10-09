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
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic
using static System.Net.Mime.MediaTypeNames;

public class Members
{
    private int _RowNumber;
    private long _GMQuotationMemberId;
    private long _GMQuotationId;
    private string _StaffNo;
    private string _PhotoName;
    private string _FirstName;
    private string _SecondName;
    private string _LastName;
    private string _DOB;
    private string _Gender;
    private string _Relation;
    private string _Country;
    private string _MaritalStatus;
    private string _Category;
    private string _SubGroupDivision;
    private string _EffectiveDate;
    private string _Emirate;
    private string _EIDNumber;
    private string _SalaryBand;
    private string _Salary;
    private string _MobileNumber;
    private string _EmailId;
    private string _City;
    private string _ResidentialLocation;
    private string _WorkLocation;
    private string _PassportNum;
    private string _UIDNo;
    private string _UIDCount;
    private string _ResidentFileNumber;
    private string _PhotoLocation;
    private DateTime _DOB1;
    private int _UserId;
    public string _DHPOMemberId { get; set; }
    public string _BirthCertificateID { get; set; }
    private string _IsCommissionBasedSalary;
    private string _MemberType;
    private string _EntityType;
    private string _EntityId;
    private string _EstablishmentEmail;
    private bool _IsValidated;
    private string _RelationTo;
    private string _EntityContactNumber;
    private string _PolicySequence;
    private string _DHPOErrorMessage;

    private string _CardNo;
    private string _FirstNameAR;
    private string _SecondNameAR;
    private string _LastNameAR;
    private string _WorkRegion;
    private string _WorkMobile;
    private string _WorkEmail;
    private string _ResidentCountry;
    private string _ResidentRegion;
    private string _ResidentMobile;
    private string _ResidentEmail;
    private string _SalaryBandCategory;
    private bool _PrevCoverageStatus;
    private DateTime _PrevCoverageExp;
    private string _Occupation;
    private string _WorkCountry;
    private string _CompanyName;
    private decimal _IPPremium;
    private decimal _OPPremium;
    private string _PrevCoverage_Str;
    private decimal _MaternityPremium;
    private decimal _DentalPremium;
    private decimal _OpticalPremium;
    private decimal _Height;
    private decimal _Weight;
    private decimal _BMI;
    private decimal _AdditionalPremium;
    private decimal _BasePremium;
    private decimal _AML_Loading;
    private decimal _Territorial_Loading;
    private decimal _CoIns_Loading;
    private decimal _DeduC_Loading;
    private decimal _AccomType_Loading;
    private decimal _PEC_Loading;
    private decimal _Mat_limit_Loading;
    private decimal _MatCoIns_Loading;
    private decimal _OptCoIns_Loading;
    private decimal _DenCoIns_Loading;
    private decimal _Nationality_Loading;
    private decimal _Network_spl_Arr;
    private decimal _Mat_Waiting_Period_Waived;
    private decimal _Inflation;
    private decimal _Target_LR;
    private decimal _Agent_Perc;
    private decimal _TPA_Perc;
    private decimal _IC_Perc;
    private decimal _TotGross;
    private int _BrokerId;

    public int BrokerId
    {
        get { return _BrokerId; }
        set { _BrokerId = value; }
    }
    public int RowNumber
    {
        get { return _RowNumber; }
        set { _RowNumber = value; }
    }

    public long GmquotationMemberId
    {
        get { return _GMQuotationMemberId; }
        set { _GMQuotationMemberId = value; }
    }

    public long GmquotationId
    {
        get { return _GMQuotationId; }
        set { _GMQuotationId = value; }
    }

    public string StaffNo
    {
        get { return _StaffNo; }
        set { _StaffNo = value; }
    }

    public string PhotoName
    {
        get { return _PhotoName; }
        set { _PhotoName = value; }
    }

    public string FirstName
    {
        get { return _FirstName; }
        set { _FirstName = value; }
    }

    public string SecondName
    {
        get { return _SecondName; }
        set { _SecondName = value; }
    }

    public string LastName
    {
        get { return _LastName; }
        set { _LastName = value; }
    }

    public string DOB
    {
        get { return _DOB; }
        set { _DOB = value; }
    }

    public string Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }

    public string Relation
    {
        get { return _Relation; }
        set { _Relation = value; }
    }

    public string Country
    {
        get { return _Country; }
        set { _Country = value; }
    }

    public string MaritalStatus
    {
        get { return _MaritalStatus; }
        set { _MaritalStatus = value; }
    }

    public string Category
    {
        get { return _Category; }
        set { _Category = value; }
    }

    public string SubGroupDivision
    {
        get { return _SubGroupDivision; }
        set { _SubGroupDivision = value; }
    }

    public string EffectiveDate
    {
        get { return _EffectiveDate; }
        set { _EffectiveDate = value; }
    }

    public string Emirate
    {
        get { return _Emirate; }
        set { _Emirate = value; }
    }

    public string EIDNumber
    {
        get { return _EIDNumber; }
        set { _EIDNumber = value; }
    }

    public string SalaryBand
    {
        get { return _SalaryBand; }
        set { _SalaryBand = value; }
    }

    public string Salary
    {
        get { return _Salary; }
        set { _Salary = value; }
    }

    public string MobileNumber
    {
        get { return _MobileNumber; }
        set { _MobileNumber = value; }
    }

    public string EmailId
    {
        get { return _EmailId; }
        set { _EmailId = value; }
    }

    public string City
    {
        get { return _City; }
        set { _City = value; }
    }

    public string ResidentialLocation
    {
        get { return _ResidentialLocation; }
        set { _ResidentialLocation = value; }
    }

    public string WorkLocation
    {
        get { return _WorkLocation; }
        set { _WorkLocation = value; }
    }

    public string PassportNum
    {
        get { return _PassportNum; }
        set { _PassportNum = value; }
    }

    public string UIDNo
    {
        get { return _UIDNo; }
        set { _UIDNo = value; }
    }

    public string UIDCount
    {
        get { return _UIDCount; }
        set { _UIDCount = value; }
    }

    public string ResidentFileNumber
    {
        get { return _ResidentFileNumber; }
        set { _ResidentFileNumber = value; }
    }

    public string PhotoLocation
    {
        get { return _PhotoLocation; }
        set { _PhotoLocation = value; }
    }

    public DateTime DOB1
    {
        get { return _DOB1; }
        set { _DOB1 = value; }
    }

    public int UserId
    {
        get { return _UserId; }
        set { _UserId = value; }
    }

    public string DHPOMemberId
    {
        get { return _DHPOMemberId; }
        set { _DHPOMemberId = value; }
    }

    public string BirthCertificateID
    {
        get { return _BirthCertificateID; }
        set { _BirthCertificateID = value; }
    }

    public string IsCommissionBasedSalary
    {
        get { return _IsCommissionBasedSalary; }
        set { _IsCommissionBasedSalary = value; }
    }

    public string MemberType
    {
        get { return _MemberType; }
        set { _MemberType = value; }
    }

    public string EntityType
    {
        get { return _EntityType; }
        set { _EntityType = value; }
    }

    public string EntityId
    {
        get { return _EntityId; }
        set { _EntityId = value; }
    }

    public string EstablishmentEmail
    {
        get { return _EstablishmentEmail; }
        set { _EstablishmentEmail = value; }
    }

    public bool IsValidated
    {
        get { return _IsValidated; }
        set { _IsValidated = value; }
    }

    public string RelationTo
    {
        get { return _RelationTo; }
        set { _RelationTo = value; }
    }

    public string EntityContactNumber
    {
        get { return _EntityContactNumber; }
        set { _EntityContactNumber = value; }
    }

    public string PolicySequence
    {
        get { return _PolicySequence; }
        set { _PolicySequence = value; }
    }

    public string DHPOErrorMessage
    {
        get { return _DHPOErrorMessage; }
        set { _DHPOErrorMessage = value; }
    }

    public string CardNo
    {
        get { return _CardNo; }
        set { _CardNo = value; }
    }

    public string FirstNameAR
    {
        get { return _FirstNameAR; }
        set { _FirstNameAR = value; }
    }

    public string SecondNameAR
    {
        get { return _SecondNameAR; }
        set { _SecondNameAR = value; }
    }

    public string LastNameAR
    {
        get { return _LastNameAR; }
        set { _LastNameAR = value; }
    }

    public string WorkRegion
    {
        get { return _WorkRegion; }
        set { _WorkRegion = value; }
    }

    public string WorkCountry
    {
        get { return _WorkCountry; }
        set { _WorkCountry = value; }
    }

    public string WorkMobile
    {
        get { return _WorkMobile; }
        set { _WorkMobile = value; }
    }

    public string WorkEmail
    {
        get { return _WorkEmail; }
        set { _WorkEmail = value; }
    }

    public string ResidentCountry
    {
        get { return _ResidentCountry; }
        set { _ResidentCountry = value; }
    }

    public string ResidentRegion
    {
        get { return _ResidentRegion; }
        set { _ResidentRegion = value; }
    }

    public string ResidentMobile
    {
        get { return _ResidentMobile; }
        set { _ResidentMobile = value; }
    }

    public string ResidentEmail
    {
        get { return _ResidentEmail; }
        set { _ResidentEmail = value; }
    }

    public string SalaryBandCategory
    {
        get { return _SalaryBandCategory; }
        set { _SalaryBandCategory = value; }
    }

    public bool PrevCoverageStatus
    {
        get { return _PrevCoverageStatus; }
        set { _PrevCoverageStatus = value; }
    }

    public string PrevCoverage_Str
    {
        get { return _PrevCoverage_Str; }
        set { _PrevCoverage_Str = value; }
    }

    public DateTime PrevCoverageExp
    {
        get { return _PrevCoverageExp; }
        set { _PrevCoverageExp = value; }
    }

    public string Occupation
    {
        get { return _Occupation; }
        set { _Occupation = value; }
    }

    public string CompanyName
    {
        get { return _CompanyName; }
        set { _CompanyName = value; }
    }

    public decimal IPPremium
    {
        get { return _IPPremium; }
        set { _IPPremium = value; }
    }
    public decimal OPPremium
    {
        get { return _OPPremium; }
        set { _OPPremium = value; }
    }

    public decimal MaternityPremium
    {
        get { return _MaternityPremium; }
        set { _MaternityPremium = value; }
    }

    public decimal DentalPremium
    {
        get { return _DentalPremium; }
        set { _DentalPremium = value; }
    }

    public decimal OpticalPremium
    {
        get { return _OpticalPremium; }
        set { _OpticalPremium = value; }
    }

    public decimal Height
    {
        get { return _Height; }
        set { _Height = value; }
    }

    public decimal Weight
    {
        get { return _Weight; }
        set { _Weight = value; }
    }

    public decimal BMI
    {
        get { return _BMI; }
        set { _BMI = value; }
    }

    public decimal AdditionalPremium
    {
        get { return _AdditionalPremium; }
        set { _AdditionalPremium = value; }
    }

    public decimal BasePremium
    {
        get { return _BasePremium; }
        set { _BasePremium = value; }
    }

    public decimal AML_Loading
    {
        get { return _AML_Loading; }
        set { _AML_Loading = value; }
    }

    public decimal Territorial_Loading
    {
        get { return _Territorial_Loading; }
        set { _Territorial_Loading = value; }
    }

    public decimal CoIns_Loading
    {
        get { return _CoIns_Loading; }
        set { _CoIns_Loading = value; }
    }

    public decimal DeduC_Loading
    {
        get { return _DeduC_Loading; }
        set { _DeduC_Loading = value; }
    }

    public decimal AccomType_Loading
    {
        get { return _AccomType_Loading; }
        set { _AccomType_Loading = value; }
    }

    public decimal PEC_Loading
    {
        get { return _PEC_Loading; }
        set { _PEC_Loading = value; }
    }

    public decimal Mat_limit_Loading
    {
        get { return _Mat_limit_Loading; }
        set { _Mat_limit_Loading = value; }
    }

    public decimal MatCoIns_Loading
    {
        get { return _MatCoIns_Loading; }
        set { _MatCoIns_Loading = value; }
    }

    public decimal OptCoIns_Loading
    {
        get { return _OptCoIns_Loading; }
        set { _OptCoIns_Loading = value; }
    }

    public decimal DenCoIns_Loading
    {
        get { return _DenCoIns_Loading; }
        set { _DenCoIns_Loading = value; }
    }

    public decimal Nationality_Loading
    {
        get { return _Nationality_Loading; }
        set { _Nationality_Loading = value; }
    }

    public decimal Network_spl_Arr
    {
        get { return _Network_spl_Arr; }
        set { _Network_spl_Arr = value; }
    }

    public decimal Mat_Waiting_Period_Waived
    {
        get { return _Mat_Waiting_Period_Waived; }
        set { _Mat_Waiting_Period_Waived = value; }
    }

    public decimal Inflation
    {
        get { return _Inflation; }
        set { _Inflation = value; }
    }

    public decimal Target_LR
    {
        get { return _Target_LR; }
        set { _Target_LR = value; }
    }

    public decimal Agent_Perc
    {
        get { return _Agent_Perc; }
        set { _Agent_Perc = value; }
    }

    public decimal TPA_Perc
    {
        get { return _TPA_Perc; }
        set { _TPA_Perc = value; }
    }

    public decimal IC_Perc
    {
        get { return _IC_Perc; }
        set { _IC_Perc = value; }
    }

    public decimal TotGross
    {
        get { return _TotGross; }
        set { _TotGross = value; }
    }

    public IConfiguration _Config { get; set; }
    public Members(){ }
    public Members(IConfiguration configuration)
    {
        _Config = configuration;
    }
    public void SetConfiguration(IConfiguration configuration)
    {
        _Config = configuration;
    }
    public List<Members> GetMembersList(string WhereCondition, string PagingCondition, string OrderByExpression)
    {
        var lstEntity = new List<Members>();

        try
        {
            using (SqlConnection connection = new SqlConnection(_Config.GetConnectionString("ConnString")))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("usp_Get_GMQuotationMembers", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (!string.IsNullOrEmpty(WhereCondition))
                        cmd.Parameters.Add(new SqlParameter("@WhereCondition", SqlDbType.NVarChar) { Value = WhereCondition });
                    if (!string.IsNullOrEmpty(PagingCondition))
                        cmd.Parameters.Add(new SqlParameter("@PagingCondition", SqlDbType.NVarChar) { Value = PagingCondition });
                    if (!string.IsNullOrEmpty(OrderByExpression))
                        cmd.Parameters.Add(new SqlParameter("@OrderByExpression", SqlDbType.NVarChar) { Value = OrderByExpression });

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Members oEntity = new Members(_Config);
                            oEntity.RowNumber = reader["RowNumber"] == DBNull.Value ? 0 : Convert.ToInt32(reader["RowNumber"]);
                            oEntity.GmquotationMemberId = reader["GMQuotationMemberId"] == DBNull.Value ? 0 : (long)reader["GMQuotationMemberId"];
                            oEntity.GmquotationId = reader["GMQuotationId"] == DBNull.Value ? 0 : (long)reader["GMQuotationId"];
                            oEntity.StaffNo = reader["StaffNo"] == DBNull.Value ? string.Empty : (string)reader["StaffNo"];
                            oEntity.PhotoName = reader["PhotoName"] == DBNull.Value ? string.Empty : (string)reader["PhotoName"];
                            oEntity.FirstName = reader["FirstName"] == DBNull.Value ? string.Empty : (string)reader["FirstName"];
                            oEntity.SecondName = reader["SecondName"] == DBNull.Value ? string.Empty : (string)reader["SecondName"];
                            oEntity.LastName = reader["LastName"] == DBNull.Value ? string.Empty : (string)reader["LastName"];
                            oEntity.DOB = reader["DOB"] == DBNull.Value ? string.Empty : (string)reader["DOB"];
                            oEntity.Gender = reader["Gender"] == DBNull.Value ? string.Empty : (string)reader["Gender"];
                            oEntity.Relation = reader["Relation"] == DBNull.Value ? string.Empty : (string)reader["Relation"];
                            oEntity.Country = reader["Country"] == DBNull.Value ? string.Empty : (string)reader["Country"];
                            oEntity.MaritalStatus = reader["MaritalStatus"] == DBNull.Value ? string.Empty : (string)reader["MaritalStatus"];
                            oEntity.Category = reader["Category"] == DBNull.Value ? string.Empty : (string)reader["Category"];
                            oEntity.SubGroupDivision = reader["SubGroupDivision"] == DBNull.Value ? string.Empty : (string)reader["SubGroupDivision"];
                            oEntity.EffectiveDate = reader["EffectiveDate"] == DBNull.Value ? string.Empty : (string)reader["EffectiveDate"];
                            oEntity.Emirate = reader["Emirate"] == DBNull.Value ? string.Empty : (string)reader["Emirate"];
                            oEntity.EIDNumber = reader["EIDNumber"] == DBNull.Value ? string.Empty : (string)reader["EIDNumber"];
                            oEntity.SalaryBand = reader["SalaryBand"] == DBNull.Value ? string.Empty : (string)reader["SalaryBand"];
                            oEntity.Salary = reader["Salary"] == DBNull.Value ? string.Empty : (string)reader["Salary"];
                            oEntity.MobileNumber = reader["MobileNumber"] == DBNull.Value ? string.Empty : (string)reader["MobileNumber"];
                            oEntity.EmailId = reader["EmailId"] == DBNull.Value ? string.Empty : (string)reader["EmailId"];
                            oEntity.City = reader["City"] == DBNull.Value ? string.Empty : (string)reader["City"];
                            oEntity.ResidentialLocation = reader["ResidentialLocation"] == DBNull.Value ? string.Empty : (string)reader["ResidentialLocation"];
                            oEntity.WorkLocation = reader["WorkLocation"] == DBNull.Value ? string.Empty : (string)reader["WorkLocation"];
                            oEntity.PassportNum = reader["PassportNum"] == DBNull.Value ? string.Empty : (string)reader["PassportNum"];
                            oEntity.UIDNo = reader["UIDNo"] == DBNull.Value ? string.Empty : (string)reader["UIDNo"];
                            oEntity.UIDCount = reader["ResidentFileNumber"] == DBNull.Value ? string.Empty : (string)reader["ResidentFileNumber"];
                            oEntity.ResidentFileNumber = reader["ResidentFileNumber"] == DBNull.Value ? string.Empty : (string)reader["ResidentFileNumber"];
                            oEntity.PhotoLocation = reader["PhotoLocation"] == DBNull.Value ? string.Empty : (string)reader["PhotoLocation"];
                            oEntity.DOB1 = reader["DOB1"] == DBNull.Value ? new DateTime(1901, 1, 1) : (DateTime)reader["DOB1"];
                            oEntity.DHPOMemberId = reader["DHPOMemberId"] == DBNull.Value ? string.Empty : (string)reader["DHPOMemberId"];
                            oEntity.BirthCertificateID = reader["BirthCertificateID"] == DBNull.Value ? string.Empty : (string)reader["BirthCertificateID"];
                            oEntity.IsCommissionBasedSalary = reader["IsCommissionBasedSalary"] == DBNull.Value ? string.Empty : (string)reader["IsCommissionBasedSalary"];
                            oEntity.MemberType = reader["MemberType"] == DBNull.Value ? string.Empty : (string)reader["MemberType"];
                            oEntity.EntityType = reader["EntityType"] == DBNull.Value ? string.Empty : (string)reader["EntityType"];
                            oEntity.EntityId = reader["EntityId"] == DBNull.Value ? string.Empty : (string)reader["EntityId"];
                            oEntity.EstablishmentEmail = reader["EstablishmentEmail"] == DBNull.Value ? string.Empty : (string)reader["EstablishmentEmail"];
                            oEntity.IsValidated = reader["IsValidated"] == DBNull.Value ? false : (bool)reader["IsValidated"];
                            oEntity.RelationTo = reader["RelationTo"] == DBNull.Value ? string.Empty : (string)reader["RelationTo"];
                            oEntity.EntityContactNumber = reader["EntityContactNumber"] == DBNull.Value ? string.Empty : (string)reader["EntityContactNumber"];
                            oEntity.PolicySequence = reader["PolicySequence"] == DBNull.Value ? string.Empty : (string)reader["PolicySequence"];
                            oEntity.DHPOErrorMessage = reader["DHPOErrorMessage"] == DBNull.Value ? string.Empty : (string)reader["DHPOErrorMessage"];
                            oEntity.CardNo = reader["CardNo"] == DBNull.Value ? string.Empty : (string)reader["CardNo"];
                            oEntity.FirstNameAR = reader["FirstNameAR"] == DBNull.Value ? string.Empty : (string)reader["FirstNameAR"];
                            oEntity.SecondNameAR = reader["SecondNameAR"] == DBNull.Value ? string.Empty : (string)reader["SecondNameAR"];
                            oEntity.LastNameAR = reader["LastNameAR"] == DBNull.Value ? string.Empty : (string)reader["LastNameAR"];
                            oEntity.WorkRegion = reader["WorkRegion"] == DBNull.Value ? string.Empty : (string)reader["WorkRegion"];
                            oEntity.WorkMobile = reader["WorkMobile"] == DBNull.Value ? string.Empty : (string)reader["WorkMobile"];
                            oEntity.WorkEmail = reader["WorkEmail"] == DBNull.Value ? string.Empty : (string)reader["WorkEmail"];
                            oEntity.ResidentCountry = reader["ResidentCountry"] == DBNull.Value ? string.Empty : (string)reader["ResidentCountry"];
                            oEntity.ResidentRegion = reader["ResidentRegion"] == DBNull.Value ? string.Empty : (string)reader["ResidentRegion"];
                            oEntity.ResidentMobile = reader["ResidentMobile"] == DBNull.Value ? string.Empty : (string)reader["ResidentMobile"];
                            oEntity.ResidentEmail = reader["ResidentEmail"] == DBNull.Value ? string.Empty : (string)reader["ResidentEmail"];
                            oEntity.SalaryBandCategory = reader["SalaryBandCategory"] == DBNull.Value ? string.Empty : (string)reader["SalaryBandCategory"];
                            oEntity.PrevCoverageStatus = reader["PrevCoverageStatus"] == DBNull.Value ? false : (bool)reader["PrevCoverageStatus"];
                            oEntity.PrevCoverageExp = reader["PrevCoverageExp"] == DBNull.Value ? new DateTime(1901, 1, 1) : (DateTime)reader["PrevCoverageExp"];
                            oEntity.Occupation = reader["Occupation"] == DBNull.Value ? string.Empty : (string)reader["Occupation"];
                            oEntity.CompanyName = reader["CompanyName"] == DBNull.Value ? string.Empty : (string)reader["CompanyName"];
                            oEntity.WorkCountry = reader["WorkCountry"] == DBNull.Value ? string.Empty : (string)reader["WorkCountry"];
                            oEntity.IPPremium = reader["IPPremium"] == DBNull.Value ? 0 : (decimal)reader["IPPremium"];
                            oEntity.OPPremium = reader["OPPremium"] == DBNull.Value ? 0 : (decimal)reader["OPPremium"];
                            oEntity.PrevCoverage_Str = reader["PrevCoverage_Str"] == DBNull.Value ? string.Empty : (string)reader["PrevCoverage_Str"];
                            oEntity.MaternityPremium = reader["MaternityPremium"] == DBNull.Value ? 0 : (decimal)reader["MaternityPremium"];
                            oEntity.DentalPremium = reader["DentalPremium"] == DBNull.Value ? 0 : (decimal)reader["DentalPremium"];
                            oEntity.OpticalPremium = reader["OpticalPremium"] == DBNull.Value ? 0 : (decimal)reader["OpticalPremium"];
                            oEntity.Height = reader["Height"] == DBNull.Value ? 0 : (decimal)reader["Height"];
                            oEntity.Weight = reader["Weight"] == DBNull.Value ? 0 : (decimal)reader["Weight"];
                            oEntity.BMI = reader["BMI"] == DBNull.Value ? 0 : (decimal)reader["BMI"];
                            oEntity.AdditionalPremium = reader["AdditionalPremium"] == DBNull.Value ? 0 : (decimal)reader["AdditionalPremium"];
                            oEntity.BasePremium = reader["BasePremium"] == DBNull.Value ? 0 : (decimal)reader["BasePremium"];
                            oEntity.AML_Loading = reader["AML_Loading"] == DBNull.Value ? 0 : (decimal)reader["AML_Loading"];
                            oEntity.Territorial_Loading = reader["Territorial_Loading"] == DBNull.Value ? 0 : (decimal)reader["Territorial_Loading"];
                            oEntity.CoIns_Loading = reader["CoIns_Loading"] == DBNull.Value ? 0 : (decimal)reader["CoIns_Loading"];
                            oEntity.DeduC_Loading = reader["DeduC_Loading"] == DBNull.Value ? 0 : (decimal)reader["DeduC_Loading"];
                            oEntity.AccomType_Loading = reader["AccomType_Loading"] == DBNull.Value ? 0 : (decimal)reader["AccomType_Loading"];
                            oEntity.PEC_Loading = reader["PEC_Loading"] == DBNull.Value ? 0 : (decimal)reader["PEC_Loading"];
                            oEntity.Mat_limit_Loading = reader["Mat_limit_Loading"] == DBNull.Value ? 0 : (decimal)reader["Mat_limit_Loading"];
                            oEntity.MatCoIns_Loading = reader["MatCoIns_Loading"] == DBNull.Value ? 0 : (decimal)reader["MatCoIns_Loading"];
                            oEntity.OptCoIns_Loading = reader["OptCoIns_Loading"] == DBNull.Value ? 0 : (decimal)reader["OptCoIns_Loading"];
                            oEntity.DenCoIns_Loading = reader["DenCoIns_Loading"] == DBNull.Value ? 0 : (decimal)reader["DenCoIns_Loading"];
                            oEntity.Nationality_Loading = reader["Nationality_Loading"] == DBNull.Value ? 0 : (decimal)reader["Nationality_Loading"];
                            oEntity.Network_spl_Arr = reader["Network_spl_Arr"] == DBNull.Value ? 0 : (decimal)reader["Network_spl_Arr"];
                            oEntity.Mat_Waiting_Period_Waived = reader["Mat_Waiting_Period_Waived"] == DBNull.Value ? 0 : (decimal)reader["Mat_Waiting_Period_Waived"];
                            oEntity.Inflation = reader["Inflation"] == DBNull.Value ? 0 : (decimal)reader["Inflation"];
                            oEntity.Target_LR = reader["Target_LR"] == DBNull.Value ? 0 : (decimal)reader["Target_LR"];
                            oEntity.Agent_Perc = reader["Agent_Perc"] == DBNull.Value ? 0 : (decimal)reader["Agent_Perc"];
                            oEntity.TPA_Perc = reader["TPA_Perc"] == DBNull.Value ? 0 : (decimal)reader["TPA_Perc"];
                            oEntity.IC_Perc = reader["IC_Perc"] == DBNull.Value ? 0 : (decimal)reader["IC_Perc"];
                            oEntity.TotGross = reader["TotGross"] == DBNull.Value ? 0 : (decimal)reader["TotGross"];
                            lstEntity.Add(oEntity);
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exception appropriately
            lstEntity = null;
            throw new Exception("Error retrieving GMQuotations list.", ex);
        }

        return lstEntity;
    }


    public long SaveEntity(string Mode)
    {
        try
        {

            using (SqlConnection connection = new SqlConnection(_Config.GetConnectionString("ConnString")))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("usp_AddEditDelete_GMQuotationMembers", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    SqlParameter currentIdParam = new SqlParameter("@CurrentID", SqlDbType.BigInt)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(currentIdParam);

                    // Add the input parameter with the condition
                    if (_GMQuotationId != 0)
                    {
                        cmd.Parameters.Add(new SqlParameter("@GMQuotationMemberId", SqlDbType.BigInt) { Value = _GMQuotationMemberId });
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@GMQuotationMemberId", SqlDbType.BigInt) { Value = DBNull.Value });
                    }

                    cmd.Parameters.AddWithValue("@GmquotationId", _GMQuotationId);
                    cmd.Parameters.AddWithValue("@StaffNo", _StaffNo);
                    cmd.Parameters.AddWithValue("@PhotoName", _PhotoName);
                    cmd.Parameters.AddWithValue("@FirstName", _FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", _SecondName);
                    cmd.Parameters.AddWithValue("@LastName", _LastName);
                    cmd.Parameters.AddWithValue("@DOB", _DOB);
                    cmd.Parameters.AddWithValue("@Gender", _Gender);
                    cmd.Parameters.AddWithValue("@Relation", _Relation);
                    cmd.Parameters.AddWithValue("@Country", _Country);
                    cmd.Parameters.AddWithValue("@MaritalStatus", _MaritalStatus);
                    cmd.Parameters.AddWithValue("@Category", _Category);
                    cmd.Parameters.AddWithValue("@SubGroupDivision", _SubGroupDivision);
                    cmd.Parameters.AddWithValue("@EffectiveDate", _EffectiveDate);
                    cmd.Parameters.AddWithValue("@Emirate", _Emirate);
                    cmd.Parameters.AddWithValue("@EIDNumber", _EIDNumber);
                    cmd.Parameters.AddWithValue("@SalaryBand", _SalaryBand);
                    cmd.Parameters.AddWithValue("@Salary", _Salary);
                    cmd.Parameters.AddWithValue("@MobileNumber", _MobileNumber);
                    cmd.Parameters.AddWithValue("@EmailId", _EmailId);
                    cmd.Parameters.AddWithValue("@City", _City);
                    cmd.Parameters.AddWithValue("@ResidentialLocation", _ResidentialLocation);
                    cmd.Parameters.AddWithValue("@WorkLocation", _WorkLocation);
                    cmd.Parameters.AddWithValue("@PassportNum", _PassportNum);
                    cmd.Parameters.AddWithValue("@UIDNo", _UIDNo);
                    cmd.Parameters.AddWithValue("@UIDCount", _ResidentFileNumber);
                    cmd.Parameters.AddWithValue("@PhotoLocation", _PhotoLocation);
                    cmd.Parameters.AddWithValue("@DOB1", (_DOB1 < new DateTime(1753, 1, 1) || _DOB1 > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _DOB1);

                    cmd.Parameters.AddWithValue("@DHPOMemberId", _DHPOMemberId);
                    cmd.Parameters.AddWithValue("@BirthCertificateID", _BirthCertificateID);
                    cmd.Parameters.AddWithValue("@IsCommissionBasedSalary", _IsCommissionBasedSalary);
                    cmd.Parameters.AddWithValue("@MemberType", _MemberType);
                    cmd.Parameters.AddWithValue("@EntityType", _EntityType);
                    cmd.Parameters.AddWithValue("@EntityId", _EntityId);
                    cmd.Parameters.AddWithValue("@EstablishmentEmail", _EstablishmentEmail);
                    cmd.Parameters.AddWithValue("@IsValidated", _IsValidated);
                    cmd.Parameters.AddWithValue("@RelationTo", _RelationTo);
                    cmd.Parameters.AddWithValue("@EntityContactNumber", _EntityContactNumber);
                    cmd.Parameters.AddWithValue("@PolicySequence", PolicySequence);
                    cmd.Parameters.AddWithValue("@DHPOErrorMessage", _DHPOErrorMessage);
                    cmd.Parameters.AddWithValue("@CardNo", _CardNo);
                    cmd.Parameters.AddWithValue("@FirstNameAR", _FirstNameAR);
                    cmd.Parameters.AddWithValue("@SecondNameAR", _SecondNameAR);
                    cmd.Parameters.AddWithValue("@LastNameAR", _LastNameAR);
                    cmd.Parameters.AddWithValue("@WorkRegion", _WorkRegion);
                    cmd.Parameters.AddWithValue("@WorkMobile", _WorkMobile);
                    cmd.Parameters.AddWithValue("@WorkEmail", _WorkEmail);
                    cmd.Parameters.AddWithValue("@ResidentCountry", _ResidentCountry);
                    cmd.Parameters.AddWithValue("@ResidentRegion", _ResidentRegion);
                    cmd.Parameters.AddWithValue("@ResidentMobile", _ResidentMobile);
                    cmd.Parameters.AddWithValue("@ResidentEmail", _ResidentEmail);
                    cmd.Parameters.AddWithValue("@SalaryBandCategory", _SalaryBandCategory);
                    cmd.Parameters.AddWithValue("@PrevCoverageStatus", _PrevCoverageStatus);
                    cmd.Parameters.AddWithValue("@PrevCoverageExp", (_PrevCoverageExp < new DateTime(1753, 1, 1) || _PrevCoverageExp > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _PrevCoverageExp);
                    cmd.Parameters.AddWithValue("@Occupation", _Occupation);
                    cmd.Parameters.AddWithValue("@CompanyName", _CompanyName);
                    cmd.Parameters.AddWithValue("@WorkCountry", _WorkCountry);
                    cmd.Parameters.AddWithValue("@IPPremium", _IPPremium);
                    cmd.Parameters.AddWithValue("@OPPremium", _OPPremium);

                    cmd.Parameters.AddWithValue("@MaternityPremium", MaternityPremium);
                    cmd.Parameters.AddWithValue("@DentalPremium", _DentalPremium);
                    cmd.Parameters.AddWithValue("@OpticalPremium", _OpticalPremium);
                    cmd.Parameters.AddWithValue("@Height", _Height);
                    cmd.Parameters.AddWithValue("@Weight", _Weight);
                    cmd.Parameters.AddWithValue("@BMI", _BMI);
                    cmd.Parameters.AddWithValue("@AdditionalPremium", _AdditionalPremium);
                    cmd.Parameters.AddWithValue("@BasePremium", _BasePremium);
                    cmd.Parameters.AddWithValue("@AML_Loading", _AML_Loading);
                    cmd.Parameters.AddWithValue("@Territorial_Loading", _Territorial_Loading);
                    cmd.Parameters.AddWithValue("@CoIns_Loading", _CoIns_Loading);
                    cmd.Parameters.AddWithValue("@DeduC_Loading", _DeduC_Loading);
                    cmd.Parameters.AddWithValue("@AccomType_Loading", _AccomType_Loading);
                    cmd.Parameters.AddWithValue("@PEC_Loading", _PEC_Loading);
                    cmd.Parameters.AddWithValue("@Mat_limit_Loading", _Mat_limit_Loading);
                    cmd.Parameters.AddWithValue("@MatCoIns_Loading", _MatCoIns_Loading);
                    cmd.Parameters.AddWithValue("@OptCoIns_Loading", _OptCoIns_Loading);
                    cmd.Parameters.AddWithValue("@DenCoIns_Loading", _DenCoIns_Loading);
                    cmd.Parameters.AddWithValue("@Nationality_Loading", _Nationality_Loading);
                    cmd.Parameters.AddWithValue("@Network_spl_Arr", _Network_spl_Arr);
                    cmd.Parameters.AddWithValue("@Mat_Waiting_Period_Waived", _Mat_Waiting_Period_Waived);
                    cmd.Parameters.AddWithValue("@Inflation", _Inflation);
                    cmd.Parameters.AddWithValue("@Target_LR", _Target_LR);
                    cmd.Parameters.AddWithValue("@Agent_Perc", _Agent_Perc);
                    cmd.Parameters.AddWithValue("@TPA_Perc", _TPA_Perc);
                    cmd.Parameters.AddWithValue("@IC_Perc", _IC_Perc);
                    cmd.Parameters.AddWithValue("@TotGross", _TotGross);

                    cmd.Parameters.AddWithValue("@Mode", Mode);
                    cmd.Parameters.AddWithValue("@UserID", _UserId);
                    // Execute the command and retrieve the output parameter
                    if (Mode.ToLower() == "new")
                    {
                        cmd.ExecuteNonQuery();
                        _GMQuotationId = Convert.ToInt64(cmd.Parameters["@CurrentID"].Value);
                    }
                    else if (Mode.ToLower() == "edit")
                    {
                        cmd.ExecuteNonQuery();

                    }
                }
            }
        }
        catch (Exception ex)
        {

            throw new Exception("Error adding/editing members to Members list.", ex);
        }
        return _GMQuotationMemberId;
    }
}












