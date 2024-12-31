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
using System.Reflection;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic; // Install-Package Microsoft.VisualBasic
using Microsoft.VisualBasic.CompilerServices; // Install-Package Microsoft.VisualBasic
using NuGet.Protocol.Plugins;
using static System.Net.Mime.MediaTypeNames;

public class Mstr_PlanCategoryBenefits
{
    private int _RowNumber;
    private Int32 _PlanCategoryId;
    private string? _PlanCategoryName;
    private int _DefaultTPAId;
    private string? _DefaultTPAName;
    private Int32 _GroupId_INSIS;
    private string? _CategoryName_INSIS;
    private string? _ProductName_TPA;
    private string? _ProductDesc_TPA;
    private string? _Master_Contract_Id;
    private string? _Plan_Id;
    private string? _Plan_Name;
    private string? _AgeMin;
    private string? _AgeMax;
    private string? _Dependency;
    private string? _Gender;
    private string? _MaritalStatus;
    private string? _Authority;
    private string? _Product_Id;
    private string? _Product_Class;
    private string? _Network;
    private decimal _AggAnnualLimit;
    private decimal _OpDeductiblePerc;
    private decimal _OpDeductibleAmt;
    private decimal _InPatientMaternity;
    private decimal _DentalCover;
    private decimal _OpticalCover;
    private string? _Region;
    private string? _DistributionType;
    private string? _PlanType;
    private Int32 _DefaultInsCId;
    private string? _DefaultInsCName;
    private string? _Currency;
    private bool _IsGrossToNet;
    private string? _PlanTerritoryId;
    private string? _LimitUnit;
    private bool _SharedBenefit;
    private string? _PECInclusions;
    private string? _PECExclusions;
    private decimal _CoInsurances;
    private int _WaitingPeriodDays;
    private bool _PreAuth;
    private string? _PolicySubType;
    private string? _PolicyType;
    private decimal _LifeNetRate;
    private string? _RoomType;
    private decimal _PECCondition;
    private decimal _Maternity_CoIns;
    private decimal _Optical_CoIns;
    private decimal _Dental_CoIns;
    private decimal _Network_spl_Arr;
    private decimal _Mat_Waiting_Period_Waived;
    private decimal _Agent_Perc;
    private decimal _TPA_Perc;
    private decimal _IC_Perc;
    private bool _IsReusable;
    private string? _PolicyRef;

    private Int32 _Id;
    private Int32 _PremiumTypeId;
    private int _WaitingPeriod;
    private string? _WaitingPeriodUnit;
    private decimal _CoPayPerc;
    private decimal _CoPayAmount;
    private bool _IsCovered;
    private string? _Comments;
    private string? _PremiumType;
    private bool _HasWaitingPeriod;
    private bool _HasCoPay;
    private decimal _DeductiblePerc;
    private decimal _DeductibleAmount;
    private string? _ProviderNetwork;
    private string? _LimitType;
    private string? _LimitAmountType;
    private string? _LimitAmountCurrency;
    private decimal _LimitAmount;
    private string? _LimitAmountUnit;
    private string? _LimitAmountTerm;
    private string? _LimitCountFreq;
    private string? _LimitCountType;
    private decimal _LimitCount;
    private string? _LimitCountTerm;
    private Int64 _PlanId;
    private string? _Category;
    private Int64 _PlanBenefitId;
    private string? _DisplayDEDText;
    private string? _DisplayCopayText;
    private decimal _PremiumAmt;
    private decimal _PremiumPerc;
    private string? _Description;
    private string? _BenefitName;
    private decimal _BaseAmount;
    private string? _BaseTerm;
    private decimal _MaxAmount;
    private string? _MaxTerm;
    private string? _DisplayText;
    private Int32 _BaseCount;
    private Int32 _MaxCount;
    private string? _BaseType;
    private string? _MaxType;
    private string? _LimitText;
    private string? _TOBTag;

    private Int64 _GMQuotationCategoryAmountId;
    private Int64 _GMQuotationId;
    private Int32 _Qty;
    private decimal _Amount;
    private decimal _Contribution;
    private Int32 _TPAId;
    private string? _TPAName;
    private int _UserId;
    private decimal _TPAPercent;
    private decimal _AgentPercent;
    private decimal _TEPercent;
    private decimal _TotalLoadingPercent;
    private string? _ApprovedCat;
    private string? _Remarks;
    private string? _IPNet;
    private string? _OPNet;
    private Int32 _ProductOrigin;
    private string? _ProductCode;
    private string? _ProductId;
    private Int32 _DxbQty;
    private Int32 _INSISGroupID;
    private Int32 _DHPOProductType;
    private string? _QuoteNote;
    private string? _tob_location;
    private string? _PlanName;
    private string? _ProductClass;
    private decimal _ICPercent;
    private decimal _GrossPremium;
    private decimal _AICAmount;
    private decimal _AgentAmount;
    private decimal _TPAAmount;
    private decimal _SMOAmount;
    private decimal _TravelAssistAmount;
    private decimal _LifeAmount;
    private Int32 _RISplitPercent;
    private Int32 _ICSplitPercent;
    private decimal _RISplitAmount;
    private decimal _ICSplitAmount;
    private decimal _BasmahPCPAmount;
    private decimal _BasmahCancerAmount;
    private decimal _PSPFees;
    private decimal _VATBasmah;
    private decimal _VATPremium;
    private decimal _NetPremium;
    private decimal _FinalGrossPremium;
    private int _DiagCoPay;
    private int _PharmaCoPay;
    private string? _CatNameAuto;
    private string? _TerritorialCov;
    private decimal _OptionalCover;
    private string? _CoverType;
    private decimal _PECLimit;
    private decimal _BasePremium_Gr;
    private decimal _OptionalPremium_Gr;
    private decimal _BasePremium_Nr;
    private decimal _IPPremium_Nr;
    private decimal _OPPremium_Nr;
    private decimal _Maternity_Nr;
    private decimal _Optical_Nr;
    private decimal _Dental_Nr;
    private decimal _OptionalPremium_Nr;
    private string? _Reimbursement;
    private decimal _AdditionalPremiumAmt;
    private string? _AdditionalPremiumComment;
    private decimal _Inflation;
    private decimal _Target_LR;
    private int _BrokerId;
    private string _BrokerName;
    private string _BrokerTelephone;
    private string _BrokerEmail;
    private string _BrokerAddress;
    private string _BranchName;

    public int BrokerId
    {
        get { return _BrokerId; }
        set { _BrokerId = value; }
    }
    public string BrokerName
    {
        get { return _BrokerName; }
        set { _BrokerName = value; }
    }
    public string BrokerTelephone
    {
        get { return _BrokerTelephone; }
        set { _BrokerTelephone = value; }
    }
    public string BrokerEmail
    {
        get { return _BrokerEmail; }
        set { _BrokerEmail = value; }
    }
    public string BrokerAddress
    {
        get { return _BrokerAddress; }
        set { _BrokerAddress = value; }
    }

    public string BranchName
    {
        get { return _BranchName; }
        set { _BranchName = value; }
    }
    public int RowNumber
    {
        get { return _RowNumber; }
        set { _RowNumber = value; }
    }
    public Int32 PlanCategoryId
    {
        get { return _PlanCategoryId; }
        set { _PlanCategoryId = value; }

    }
    public string? PlanCategoryName
    {
        get { return _PlanCategoryName; }
        set { _PlanCategoryName = value; }
    }
    public int DefaultTPAId
    {
        get { return _DefaultTPAId; }
        set { _DefaultTPAId = value; }
    }
    public string? DefaultTPAName
    {
        get { return _DefaultTPAName; }
        set { _DefaultTPAName = value; }
    }
    public Int32 GroupId_INSIS
    {
        get { return _GroupId_INSIS; }
        set { _GroupId_INSIS = value; }
    }
    public string? CategoryName_INSIS
    {
        get { return _CategoryName_INSIS; }
        set { _CategoryName_INSIS = value; }
    }
    public string? ProductName_TPA
    {
        get { return _ProductName_TPA; }
        set { _ProductName_TPA = value; }
    }
    public string? ProductDesc_TPA
    {
        get { return _ProductDesc_TPA; }
        set { _ProductDesc_TPA = value; }
    }
    public string? Master_Contract_Id
    {
        get { return _Master_Contract_Id; }
        set { _Master_Contract_Id = value; }
    }
    public string? Plan_Id
    {
        get { return _Plan_Id; }
        set { _Plan_Id = value; }
    }
    public string? Plan_Name
    {
        get { return _Plan_Name; }
        set { _Plan_Name = value; }
    }
    public string? AgeMin
    {
        get { return _AgeMin; }
        set { _AgeMin = value; }
    }
    public string? AgeMax
    {
        get { return _AgeMax; }
        set { _AgeMax = value; }
    }
    public string? Dependency
    {
        get { return _Dependency; }
        set { _Dependency = value; }

    }
    public string? Gender
    {
        get { return _Gender; }
        set { _Gender = value; }
    }
    public string? MaritalStatus
    {
        get { return _MaritalStatus; }
        set { _MaritalStatus = value; }
    }
    public string? Authority
    {
        get { return _Authority; }
        set { _Authority = value; }
    }
    public string? Product_Id
    {
        get { return _Product_Id; }
        set { _Product_Id = value; }
    }
    public string? Product_Class
    {
        get { return _Product_Class; }
        set { _Product_Class = value; }
    }
    public string? Network
    {
        get { return _Network; }
        set { _Network = value; }
    }
    public decimal AggAnnualLimit
    {
        get { return _AggAnnualLimit; }
        set { _AggAnnualLimit = value; }
    }
    public decimal OpDeductiblePerc
    {
        get { return _OpDeductiblePerc; }
        set { _OpDeductiblePerc = value; }
    }
    public decimal OpDeductibleAmt
    {
        get { return _OpDeductibleAmt; }
        set { _OpDeductibleAmt = value; }
    }
    public decimal InPatientMaternity
    {
        get { return _InPatientMaternity; }
        set { _InPatientMaternity = value; }
    }
    public decimal DentalCover
    {
        get { return _DentalCover; }
        set { _DentalCover = value; }
    }
    public decimal OpticalCover
    {
        get { return _OpticalCover; }
        set { _OpticalCover = value; }
    }
    public string? Region
    {
        get { return _Region; }
        set { _Region = value; }
    }
    public string? DistributionType
    {
        get { return _DistributionType; }
        set { _DistributionType = value; }
    }
    public string? PlanType
    {
        get { return _PlanType; }
        set { _PlanType = value; }
    }
    public Int32 DefaultInsCId
    {
        get { return _DefaultInsCId; }
        set { _DefaultInsCId = value; }

    }
    public string? DefaultInsCName
    {
        get { return _DefaultInsCName; }
        set { _DefaultInsCName = value; }
    }
    public string? Currency
    {
        get { return _Currency; }
        set { _Currency = value; }
    }
    public bool IsGrossToNet
    {
        get { return _IsGrossToNet; }
        set { _IsGrossToNet = value; }
    }
    public string? PlanTerritoryId
    {
        get { return _PlanTerritoryId; }
        set { _PlanTerritoryId = value; }
    }
    public string? LimitUnit
    {
        get { return _LimitUnit; }
        set { _LimitUnit = value; }
    }
    public bool SharedBenefit
    {
        get { return _SharedBenefit; }
        set { _SharedBenefit = value; }
    }
    public string? PECInclusions
    {
        get { return _PECInclusions; }
        set { _PECInclusions = value; }
    }
    public string? PECExclusions
    {
        get { return _PECExclusions; }
        set { _PECExclusions = value; }
    }
    public decimal CoInsurances
    {
        get { return _CoInsurances; }
        set { _CoInsurances = value; }
    }
    public int WaitingPeriodDays
    {
        get { return _WaitingPeriodDays; }
        set { _WaitingPeriodDays = value; }
    }

    public bool PreAuth
    {
        get { return _PreAuth; }
        set { _PreAuth = value; }
    }

    public string? PolicyType
    {
        get { return _PolicyType; }
        set { _PolicyType = value; }
    }
    public string? PolicySubType
    {
        get { return _PolicySubType; }
        set { _PolicySubType = value; }
    }
    public decimal LifeNetRate
    {
        get { return _LifeNetRate; }
        set { _LifeNetRate = value; }
    }

    public decimal PECCondition
    {
        get { return _PECCondition; }
        set { _PECCondition = value; }
    }
    public string? RoomType
    {
        get { return _RoomType; }
        set { _RoomType = value; }
    }
    public decimal Maternity_CoIns
    {
        get { return _Maternity_CoIns; }
        set { _Maternity_CoIns = value; }
    }
    public decimal Optical_CoIns
    {
        get { return _Optical_CoIns; }
        set { _Optical_CoIns = value; }
    }
    public decimal Dental_CoIns
    {
        get { return _Dental_CoIns; }
        set { _Dental_CoIns = value; }
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
    public bool IsReusable
    {
        get { return _IsReusable; }
        set { _IsReusable = value; }
    }
    public string? PolicyRef
    {
        get { return _PolicyRef; }
        set { _PolicyRef = value; }
    }


    public Int32 Id
    {
        get { return _Id; }
        set { _Id = value; }
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
    public string? WaitingPeriodUnit
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
    public string? Comments
    {
        get { return _Comments; }
        set { _Comments = value; }
    }
    public string? PremiumType
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
    public decimal DeductiblePerc
    {
        get { return _DeductiblePerc; }
        set { _DeductiblePerc = value; }
    }
    public decimal DeductibleAmount
    {
        get { return _DeductibleAmount; }
        set { _DeductibleAmount = value; }
    }
    public string? ProviderNetwork
    {
        get { return _ProviderNetwork; }
        set { _ProviderNetwork = value; }
    }

    public string? LimitType
    {
        get { return _LimitType; }
        set { _LimitType = value; }
    }
    public string? LimitAmountType
    {
        get { return _LimitAmountType; }
        set { _LimitAmountType = value; }
    }
    public string? LimitAmountCurrency
    {
        get { return _LimitAmountCurrency; }
        set { _LimitAmountCurrency = value; }
    }
    public decimal LimitAmount
    {
        get { return _LimitAmount; }
        set { _LimitAmount = value; }
    }
    public string? LimitAmountUnit
    {
        get { return _LimitAmountUnit; }
        set { _LimitAmountUnit = value; }
    }
    public string? LimitAmountTerm
    {
        get { return _LimitAmountTerm; }
        set { _LimitAmountTerm = value; }
    }
    public string? LimitCountFreq
    {
        get { return _LimitCountFreq; }
        set { _LimitCountFreq = value; }
    }
    public string? LimitCountType
    {
        get { return _LimitCountType; }
        set { _LimitCountType = value; }
    }
    public decimal LimitCount
    {
        get { return _LimitCount; }
        set { _LimitCount = value; }
    }
    public string? LimitCountTerm
    {
        get { return _LimitCountTerm; }
        set { _LimitCountTerm = value; }
    }
    public Int64 PlanId
    {
        get { return _PlanId; }
        set { _PlanId = value; }
    }
    public string? Category
    {
        get { return _Category; }
        set { _Category = value; }
    }
    public Int64 PlanBenefitId
    {
        get { return _PlanBenefitId; }
        set { _PlanBenefitId = value; }
    }
    public string? DisplayDEDText
    {
        get { return _DisplayDEDText; }
        set { _DisplayDEDText = value; }
    }
    public string? DisplayCopayText
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
    public string? Description
    {
        get { return _Description; }
        set { _Description = value; }
    }
    public string? BenefitName
    {
        get { return _BenefitName; }
        set { _BenefitName = value; }
    }
    public decimal BaseAmount
    {
        get { return _BaseAmount; }
        set { _BaseAmount = value; }
    }
    public string? BaseTerm
    {
        get { return _BaseTerm; }
        set { _BaseTerm = value; }
    }
    public decimal MaxAmount
    {
        get { return _MaxAmount; }
        set { _MaxAmount = value; }
    }
    public string? MaxTerm
    {
        get { return _MaxTerm; }
        set { _MaxTerm = value; }
    }
    public string? DisplayText
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
    public string? BaseType
    {
        get { return _BaseType; }
        set { _BaseType = value; }
    }
    public string? MaxType
    {
        get { return _MaxType; }
        set { _MaxType = value; }
    }
    public string? LimitText
    {
        get { return _LimitText; }
        set { _LimitText = value; }
    }
    public string? TOBTag
    {
        get { return _TOBTag; }
        set { _TOBTag = value; }
    }

    public Int64 GMQuotationCategoryAmountId
    {
        get { return _GMQuotationCategoryAmountId; }
        set { _GMQuotationCategoryAmountId = value; }
    }

    public Int64 GMQuotationId
    {
        get { return _GMQuotationId; }
        set { _GMQuotationId = value; }
    }

    public Int32 Qty
    {
        get { return _Qty; }
        set { _Qty = value; }
    }

    public decimal Amount
    {
        get { return _Amount; }
        set { _Amount = value; }
    }

    public decimal Contribution
    {
        get { return _Contribution; }
        set { _Contribution = value; }
    }

    public Int32 TPAId
    {
        get { return _TPAId; }
        set { _TPAId = value; }
    }

    public string? TPAName
    {
        get { return _TPAName; }
        set { _TPAName = value; }
    }
    public int UserId
    {
        get { return _UserId; }
        set { _UserId = value; }
    }

    public decimal TPAPercent
    {
        get { return _TPAPercent; }
        set { _TPAPercent = value; }
    }

    public decimal AgentPercent
    {
        get { return _AgentPercent; }
        set { _AgentPercent = value; }
    }

    public decimal TEPercent
    {
        get { return _TEPercent; }
        set { _TEPercent = value; }
    }

    public decimal TotalLoadingPercent
    {
        get { return _TotalLoadingPercent; }
        set { _TotalLoadingPercent = value; }
    }

    public string? ApprovedCat
    {
        get { return _ApprovedCat; }
        set { _ApprovedCat = value; }
    }

    public string? Remarks
    {
        get { return _Remarks; }
        set { _Remarks = value; }
    }

    public string? IPNet
    {
        get { return _IPNet; }
        set { _IPNet = value; }
    }

    public string? OPNet
    {
        get { return _OPNet; }
        set { _OPNet = value; }
    }

    public Int32 ProductOrigin
    {
        get { return _ProductOrigin; }
        set { _ProductOrigin = value; }
    }

    public string? ProductCode
    {
        get { return _ProductCode; }
        set { _ProductCode = value; }
    }

    public string? ProductId
    {
        get { return _ProductId; }
        set { _ProductId = value; }
    }

    public Int32 DxbQty
    {
        get { return _DxbQty; }
        set { _DxbQty = value; }
    }

    public Int32 INSISGroupID
    {
        get { return _INSISGroupID; }
        set { _INSISGroupID = value; }
    }

    public Int32 DHPOProductType
    {
        get { return _DHPOProductType; }
        set { _DHPOProductType = value; }
    }

    public string? QuoteNote
    {
        get { return _QuoteNote; }
        set { _QuoteNote = value; }
    }

    public string? TobLocation
    {
        get { return _tob_location; }
        set { _tob_location = value; }
    }

    public string? PlanName
    {
        get { return _PlanName; }
        set { _PlanName = value; }
    }

    public string? ProductClass
    {
        get { return _ProductClass; }
        set { _ProductClass = value; }
    }

    public decimal ICPercent
    {
        get { return _ICPercent; }
        set { _ICPercent = value; }
    }
    public decimal GrossPremium
    {
        get { return _GrossPremium; }
        set { _GrossPremium = value; }
    }

    public decimal AICAmount
    {
        get { return _AICAmount; }
        set { _AICAmount = value; }
    }

    public decimal AgentAmount
    {
        get { return _AgentAmount; }
        set { _AgentAmount = value; }
    }

    public decimal TPAAmount
    {
        get { return _TPAAmount; }
        set { _TPAAmount = value; }
    }

    public decimal SMOAmount
    {
        get { return _SMOAmount; }
        set { _SMOAmount = value; }
    }

    public decimal TravelAssistAmount
    {
        get { return _TravelAssistAmount; }
        set { _TravelAssistAmount = value; }
    }

    public decimal LifeAmount
    {
        get { return _LifeAmount; }
        set { _LifeAmount = value; }
    }

    public Int32 RISplitPercent
    {
        get { return _RISplitPercent; }
        set { _RISplitPercent = value; }
    }

    public Int32 ICSplitPercent
    {
        get { return _ICSplitPercent; }
        set { _ICSplitPercent = value; }
    }

    public decimal RISplitAmount
    {
        get { return _RISplitAmount; }
        set { _RISplitAmount = value; }
    }

    public decimal ICSplitAmount
    {
        get { return _ICSplitAmount; }
        set { _ICSplitAmount = value; }
    }

    public decimal BasmahPCPAmount
    {
        get { return _BasmahPCPAmount; }
        set { _BasmahPCPAmount = value; }
    }

    public decimal BasmahCancerAmount
    {
        get { return _BasmahCancerAmount; }
        set { _BasmahCancerAmount = value; }
    }

    public decimal PSPFees
    {
        get { return _PSPFees; }
        set { _PSPFees = value; }
    }

    public decimal VATBasmah
    {
        get { return _VATBasmah; }
        set { _VATBasmah = value; }
    }

    public decimal VATPremium
    {
        get { return _VATPremium; }
        set { _VATPremium = value; }
    }

    public decimal NetPremium
    {
        get { return _NetPremium; }
        set { _NetPremium = value; }
    }

    public decimal FinalGrossPremium
    {
        get { return _FinalGrossPremium; }
        set { _FinalGrossPremium = value; }
    }

    public int DiagCoPay
    {
        get { return _DiagCoPay; }
        set { _DiagCoPay = value; }
    }

    public int PharmaCoPay
    {
        get { return _PharmaCoPay; }
        set { _PharmaCoPay = value; }
    }

    public string? CatNameAuto
    {
        get { return _CatNameAuto; }
        set { _CatNameAuto = value; }
    }

    public string? TerritorialCov
    {
        get { return _TerritorialCov; }
        set { _TerritorialCov = value; }
    }

    public decimal OptionalCover
    {
        get { return _OptionalCover; }
        set { _OptionalCover = value; }
    }

    public string? CoverType
    {
        get { return _CoverType; }
        set { _CoverType = value; }
    }

    public decimal PECLimit
    {
        get { return _PECLimit; }
        set { _PECLimit = value; }
    }

    public decimal BasePremiumGr
    {
        get { return _BasePremium_Gr; }
        set { _BasePremium_Gr = value; }
    }

    public decimal OptionalPremiumGr
    {
        get { return _OptionalPremium_Gr; }
        set { _OptionalPremium_Gr = value; }
    }

    public decimal BasePremiumNr
    {
        get { return _BasePremium_Nr; }
        set { _BasePremium_Nr = value; }
    }

    public decimal IPPremiumNr
    {
        get { return _IPPremium_Nr; }
        set { _IPPremium_Nr = value; }
    }

    public decimal OPPremiumNr
    {
        get { return _OPPremium_Nr; }
        set { _OPPremium_Nr = value; }
    }

    public decimal MaternityNr
    {
        get { return _Maternity_Nr; }
        set { _Maternity_Nr = value; }
    }

    public decimal OpticalNr
    {
        get { return _Optical_Nr; }
        set { _Optical_Nr = value; }
    }

    public decimal DentalNr
    {
        get { return _Dental_Nr; }
        set { _Dental_Nr = value; }
    }

    public decimal OptionalPremiumNr
    {
        get { return _OptionalPremium_Nr; }
        set { _OptionalPremium_Nr = value; }
    }

    public string? Reimbursement
    {
        get { return _Reimbursement; }
        set { _Reimbursement = value; }
    }

    public decimal AdditionalPremiumAmt
    {
        get { return _AdditionalPremiumAmt; }
        set { _AdditionalPremiumAmt = value; }
    }

    public string? AdditionalPremiumComment
    {
        get { return _AdditionalPremiumComment; }
        set { _AdditionalPremiumComment = value; }
    }

    public decimal Inflation
    {
        get { return _Inflation; }
        set { _Inflation = value; }
    }

    public decimal TargetLR
    {
        get { return _Target_LR; }
        set { _Target_LR = value; }
    }


    public IConfiguration? _Config { get; set; }
    public Mstr_PlanCategoryBenefits() { }
    public Mstr_PlanCategoryBenefits(IConfiguration? configuration)
    {
        _Config = configuration ?? throw new ArgumentNullException(nameof(configuration), "Configuration cannot be null.");
    }
    public void SetConfiguration(IConfiguration configuration)
    {
        _Config = configuration;
    }

    public List<Mstr_PlanCategoryBenefits> GetMstr_PlanCategoryBenefitsList(string WhereCondition, string PagingCondition, string OrderByExpression)
    {
        var lstEntity = new List<Mstr_PlanCategoryBenefits>();

        try
        {
            using (SqlConnection connection = new SqlConnection(_Config.GetConnectionString("ConnString")))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("usp_Get_Mstr_PlanCategories", connection))
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
                            Mstr_PlanCategoryBenefits oEntity = new Mstr_PlanCategoryBenefits(_Config);
                            oEntity.RowNumber = reader["RowNumber"] == DBNull.Value ? 0 : Convert.ToInt32(reader["RowNumber"]);
                            oEntity.PlanCategoryId = reader["PlanCategoryId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PlanCategoryId"]);
                            oEntity.PlanCategoryName = reader["PlanCategoryName"] == DBNull.Value ? string.Empty : (string)reader["PlanCategoryName"];
                            oEntity.DefaultTPAId = reader["DefaultTPAId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DefaultTPAId"]);
                            oEntity.DefaultTPAName = reader["DefaultTPAName"] == DBNull.Value ? string.Empty : (string)reader["DefaultTPAName"];
                            oEntity.GroupId_INSIS = reader["GroupId_INSIS"] == DBNull.Value ? 0 : Convert.ToInt32(reader["GroupId_INSIS"]);
                            oEntity.CategoryName_INSIS = reader["CategoryName_INSIS"] == DBNull.Value ? string.Empty : (string)reader["CategoryName_INSIS"];
                            oEntity.ProductName_TPA = reader["ProductName_TPA"] == DBNull.Value ? string.Empty : (string)reader["ProductName_TPA"];
                            oEntity.ProductDesc_TPA = reader["ProductDesc_TPA"] == DBNull.Value ? string.Empty : (string)reader["ProductDesc_TPA"];
                            oEntity.Product_Id = reader["Product_Id"] == DBNull.Value ? string.Empty : (string)reader["Product_Id"];
                            oEntity.Product_Class = reader["Product_Class"] == DBNull.Value ? string.Empty : (string)reader["Product_Class"];
                            oEntity.Master_Contract_Id = reader["Master_Contract_Id"] == DBNull.Value ? string.Empty : (string)reader["Master_Contract_Id"];
                            oEntity.Plan_Id = reader["Plan_Id"] == DBNull.Value ? string.Empty : (string)reader["Plan_Id"];
                            oEntity.Plan_Name = reader["Plan_Name"] == DBNull.Value ? string.Empty : (string)reader["Plan_Name"];
                            oEntity.AgeMin = reader["AgeMin"] == DBNull.Value ? string.Empty : (string)reader["AgeMin"];
                            oEntity.AgeMax = reader["AgeMax"] == DBNull.Value ? string.Empty : (string)reader["AgeMax"];
                            oEntity.Dependency = reader["Dependency"] == DBNull.Value ? string.Empty : (string)reader["Dependency"];
                            oEntity.Gender = reader["Gender"] == DBNull.Value ? string.Empty : (string)reader["Gender"];
                            oEntity.MaritalStatus = reader["MaritalStatus"] == DBNull.Value ? string.Empty : (string)reader["MaritalStatus"];
                            oEntity.Authority = reader["Authority"] == DBNull.Value ? string.Empty : (string)reader["Authority"];
                            oEntity.Network = reader["Network"] == DBNull.Value ? string.Empty : (string)reader["Network"];
                            oEntity.AggAnnualLimit = reader["AggAnnualLimit"] == DBNull.Value ? 0 : (decimal)reader["AggAnnualLimit"];
                            oEntity.OpDeductiblePerc = reader["OpDeductiblePerc"] == DBNull.Value ? 0 : (decimal)reader["AggAnnualLimit"];
                            oEntity.OpDeductibleAmt = reader["OpDeductibleAmt"] == DBNull.Value ? 0 : (decimal)reader["OpDeductibleAmt"];
                            oEntity.InPatientMaternity = reader["InPatientMaternity"] == DBNull.Value ? 0 : (decimal)reader["InPatientMaternity"];
                            oEntity.DentalCover = reader["DentalCover"] == DBNull.Value ? 0 : (decimal)reader["DentalCover"];
                            oEntity.OpticalCover = reader["OpticalCover"] == DBNull.Value ? 0 : (decimal)reader["OpticalCover"];
                            oEntity.Region = reader["Region"] == DBNull.Value ? string.Empty : (string)reader["Region"];
                            oEntity.DistributionType = reader["DistributionType"] == DBNull.Value ? string.Empty : (string)reader["DistributionType"];
                            oEntity.PlanType = reader["PlanType"] == DBNull.Value ? string.Empty : (string)reader["PlanType"];
                            oEntity.DefaultInsCId = reader["DefaultInsCId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DefaultInsCId"]);
                            oEntity.DefaultInsCName = reader["DefaultInsCName"] == DBNull.Value ? string.Empty : (string)reader["DefaultInsCName"];
                            oEntity.Currency = reader["Currency"] == DBNull.Value ? string.Empty : (string)reader["Currency"];
                            oEntity.PlanTerritoryId = reader["PlanTerritoryId"] == DBNull.Value ? string.Empty : (string)reader["PlanTerritoryId"];
                            oEntity.LimitUnit = reader["LimitUnit"] == DBNull.Value ? string.Empty : (string)reader["LimitUnit"];
                            oEntity.SharedBenefit = reader["SharedBenefit"] == DBNull.Value ? false : (bool)reader["SharedBenefit"];
                            oEntity.PECInclusions = reader["PECInclusions"] == DBNull.Value ? string.Empty : (string)reader["PECInclusions"];
                            oEntity.PECExclusions = reader["PECExclusions"] == DBNull.Value ? string.Empty : (string)reader["PECExclusions"];
                            oEntity.CoInsurances = reader["CoInsurances"] == DBNull.Value ? 0 : (decimal)reader["CoInsurances"];
                            oEntity.WaitingPeriodDays = reader["WaitingPeriodDays"] == DBNull.Value ? 0 : Convert.ToInt16(reader["WaitingPeriodDays"]);
                            oEntity.PreAuth = reader["PreAuth"] == DBNull.Value ? false : (bool)reader["PreAuth"];
                            oEntity.PolicySubType = reader["PolicySubType"] == DBNull.Value ? string.Empty : (string)reader["PolicySubType"];
                            oEntity.PolicyType = reader["PolicyType"] == DBNull.Value ? string.Empty : (string)reader["PolicyType"];
                            oEntity.LifeNetRate = reader["LifeNetRate"] == DBNull.Value ? 0 : (decimal)reader["LifeNetRate"];
                            oEntity.RoomType = reader["RoomType"] == DBNull.Value ? string.Empty : (string)reader["RoomType"];
                            oEntity.PECCondition = reader["PECCondition"] == DBNull.Value ? 0 : (decimal)reader["PECCondition"];
                            oEntity.Maternity_CoIns = reader["Maternity_CoIns"] == DBNull.Value ? 0 : (decimal)reader["Maternity_CoIns"];
                            oEntity.Optical_CoIns = reader["Optical_CoIns"] == DBNull.Value ? 0 : (decimal)reader["Optical_CoIns"];
                            oEntity.Dental_CoIns = reader["Dental_CoIns"] == DBNull.Value ? 0 : (decimal)reader["Dental_CoIns"];
                            oEntity.Network_spl_Arr = reader["Network_spl_Arr"] == DBNull.Value ? 0 : (decimal)reader["Network_spl_Arr"];
                            oEntity.Mat_Waiting_Period_Waived = reader["Mat_Waiting_Period_Waived"] == DBNull.Value ? 0 : (decimal)reader["Mat_Waiting_Period_Waived"];
                            oEntity.Agent_Perc = reader["Agent_Perc"] == DBNull.Value ? 0 : (decimal)reader["Agent_Perc"];
                            oEntity.TPA_Perc = reader["TPA_Perc"] == DBNull.Value ? 0 : (decimal)reader["TPA_Perc"];
                            oEntity.IC_Perc = reader["IC_Perc"] == DBNull.Value ? 0 : (decimal)reader["IC_Perc"];
                            oEntity.IsReusable = reader["IsReusable"] == DBNull.Value ? false : (bool)reader["IsReusable"];
                            oEntity.PolicyRef = reader["PolicyRef"] == DBNull.Value ? string.Empty : (string)reader["PolicyRef"];
                            lstEntity.Add(oEntity);
                            recordCounter++;
                        }
                    }
                }
                using (SqlCommand cmd1 = new SqlCommand("usp_Get_Mstr_PlanCategoryBenefits", connection))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;

                    if (!string.IsNullOrEmpty(WhereCondition))
                        cmd1.Parameters.Add(new SqlParameter("@WhereCondition", SqlDbType.NVarChar) { Value = WhereCondition });

                    if (!string.IsNullOrEmpty(PagingCondition))
                    {
                        // Add logic to modify PagingCondition for top 5 records.
                        PagingCondition = "RowNumber>=1 and RowNumber<=5"; // Adjust based on your stored procedure
                        cmd1.Parameters.Add(new SqlParameter("@PagingCondition", SqlDbType.NVarChar) { Value = PagingCondition });
                    }

                    if (!string.IsNullOrEmpty(OrderByExpression))
                        cmd1.Parameters.Add(new SqlParameter("@OrderByExpression", SqlDbType.NVarChar) { Value = OrderByExpression });

                    using (SqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        int recordCounter = 0; // Counter to limit number of records to top 5.
                        while (reader1.Read() && recordCounter < 5)
                        {
                            Mstr_PlanCategoryBenefits oEntity = new Mstr_PlanCategoryBenefits(_Config);
                            oEntity.RowNumber = reader1["RowNumber"] == DBNull.Value ? 0 : Convert.ToInt32(reader1["RowNumber"]);
                            oEntity.Id = reader1["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader1["Id"]);
                            oEntity.PremiumTypeId = reader1["PremiumTypeId"] == DBNull.Value ? 0 : Convert.ToInt32(reader1["PremiumTypeId"]);
                            oEntity.WaitingPeriod = reader1["WaitingPeriod"] == DBNull.Value ? 0 : Convert.ToInt16(reader1["WaitingPeriod"]);
                            oEntity.WaitingPeriodUnit = reader1["WaitingPeriodUnit"] == DBNull.Value ? string.Empty : (string)reader1["WaitingPeriodUnit"];
                            oEntity.CoPayPerc = reader1["CoPayPerc"] == DBNull.Value ? 0 : (decimal)reader1["CoPayPerc"];
                            oEntity.CoPayAmount = reader1["CoPayAmount"] == DBNull.Value ? 0 : (decimal)reader1["CoPayAmount"];
                            oEntity.IsCovered = reader1["IsCovered"] == DBNull.Value ? false : (bool)reader1["IsCovered"];
                            oEntity.Comments = reader1["Comments"] == DBNull.Value ? string.Empty : (string)reader1["Comments"];
                            oEntity.PremiumType = reader1["PremiumType"] == DBNull.Value ? string.Empty : (string)reader1["PremiumType"];
                            oEntity.HasWaitingPeriod = reader1["HasWaitingPeriod"] == DBNull.Value ? false : (bool)reader1["HasWaitingPeriod"];
                            oEntity.HasCoPay = reader1["HasCoPay"] == DBNull.Value ? false : (bool)reader1["HasCoPay"];
                            oEntity.DeductiblePerc = reader1["DeductiblePerc"] == DBNull.Value ? 0 : (decimal)reader1["DeductiblePerc"];
                            oEntity.DeductibleAmount = reader1["DeductibleAmount"] == DBNull.Value ? 0 : (decimal)reader1["DeductibleAmount"];
                            oEntity.ProviderNetwork = reader1["ProviderNetwork"] == DBNull.Value ? string.Empty : (string)reader1["ProviderNetwork"];
                            oEntity.SharedBenefit = reader1["SharedBenefit"] == DBNull.Value ? false : (bool)reader1["SharedBenefit"];
                            oEntity.PECInclusions = reader1["PECInclusions"] == DBNull.Value ? string.Empty : (string)reader1["PECInclusions"];
                            oEntity.PECExclusions = reader1["PECExclusions"] == DBNull.Value ? string.Empty : (string)reader1["PECExclusions"];
                            oEntity.PreAuth = reader1["PreAuth"] == DBNull.Value ? false : (bool)reader1["PreAuth"];
                            oEntity.LimitType = reader1["LimitType"] == DBNull.Value ? string.Empty : (string)reader1["LimitType"];
                            oEntity.LimitAmountType = reader1["LimitAmountType"] == DBNull.Value ? string.Empty : (string)reader1["LimitAmountType"];
                            oEntity.LimitAmountCurrency = reader1["LimitAmountCurrency"] == DBNull.Value ? string.Empty : (string)reader1["LimitAmountCurrency"];
                            oEntity.LimitAmount = reader1["LimitAmount"] == DBNull.Value ? 0 : (decimal)reader1["LimitAmount"];
                            oEntity.LimitAmountUnit = reader1["LimitAmountUnit"] == DBNull.Value ? string.Empty : (string)reader1["LimitAmountUnit"];
                            oEntity.LimitAmountTerm = reader1["LimitAmountTerm"] == DBNull.Value ? string.Empty : (string)reader1["LimitAmountTerm"];
                            oEntity.LimitCountFreq = reader1["LimitCountFreq"] == DBNull.Value ? string.Empty : (string)reader1["LimitCountFreq"];
                            oEntity.LimitCountType = reader1["LimitCountType"] == DBNull.Value ? string.Empty : (string)reader1["LimitCountType"];
                            oEntity.LimitCount = reader1["LimitCount"] == DBNull.Value ? 0 : (decimal)reader1["LimitCount"];
                            oEntity.LimitCountTerm = reader1["LimitCountTerm"] == DBNull.Value ? string.Empty : (string)reader1["LimitCountTerm"];
                            oEntity.PlanId = reader1["PlanId"] == DBNull.Value ? 0 : Convert.ToInt64(reader1["PlanId"]);
                            oEntity.Category = reader1["Category"] == DBNull.Value ? string.Empty : (string)reader1["Category"];
                            oEntity.PlanBenefitId = reader1["PlanBenefitId"] == DBNull.Value ? 0 : Convert.ToInt64(reader1["PlanBenefitId"]);
                            oEntity.DisplayDEDText = reader1["DisplayDEDText"] == DBNull.Value ? string.Empty : (string)reader1["DisplayDEDText"];
                            oEntity.DisplayCopayText = reader1["DisplayCopayText"] == DBNull.Value ? string.Empty : (string)reader1["DisplayCopayText"];
                            oEntity.PremiumAmt = reader1["PremiumAmt"] == DBNull.Value ? 0 : (decimal)reader1["PremiumAmt"];
                            oEntity.PremiumPerc = reader1["PremiumPerc"] == DBNull.Value ? 0 : (decimal)reader1["PremiumPerc"];
                            oEntity.Description = reader1["Description"] == DBNull.Value ? string.Empty : (string)reader1["Description"];
                            oEntity.BenefitName = reader1["BenefitName"] == DBNull.Value ? string.Empty : (string)reader1["BenefitName"];
                            oEntity.BaseAmount = reader1["BaseAmount"] == DBNull.Value ? 0 : (decimal)reader1["BaseAmount"];
                            oEntity.BaseTerm = reader1["BaseTerm"] == DBNull.Value ? string.Empty : (string)reader1["BaseTerm"];
                            oEntity.MaxAmount = reader1["MaxAmount"] == DBNull.Value ? 0 : (decimal)reader1["MaxAmount"];
                            oEntity.MaxTerm = reader1["MaxTerm"] == DBNull.Value ? string.Empty : (string)reader1["MaxTerm"];
                            oEntity.DisplayText = reader1["DisplayText"] == DBNull.Value ? string.Empty : (string)reader1["DisplayText"];
                            oEntity.BaseCount = reader1["BaseCount"] == DBNull.Value ? 0 : Convert.ToInt32(reader1["BaseCount"]);
                            oEntity.MaxCount = reader1["MaxCount"] == DBNull.Value ? 0 : Convert.ToInt32(reader1["MaxCount"]);
                            oEntity.BaseType = reader1["BaseType"] == DBNull.Value ? string.Empty : (string)reader1["BaseType"];
                            oEntity.MaxType = reader1["MaxType"] == DBNull.Value ? string.Empty : (string)reader1["MaxType"];
                            oEntity.LimitText = reader1["LimitText"] == DBNull.Value ? string.Empty : (string)reader1["LimitText"];
                            oEntity.TOBTag = reader1["TOBTag"] == DBNull.Value ? string.Empty : (string)reader1["TOBTag"];

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
    public long SaveEntity(string Mode)
    {
        try
        {

            using (SqlConnection connection = new SqlConnection(_Config.GetConnectionString("ConnString")))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("usp_AddEditDelete_GMQuotationCategoryAmounts", connection))
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
                        cmd.Parameters.Add(new SqlParameter("@GMQuotationCategoryAmountId", SqlDbType.BigInt) { Value = _GMQuotationCategoryAmountId });
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@GMQuotationCategoryAmountId", SqlDbType.BigInt) { Value = DBNull.Value });
                    }



                    cmd.Parameters.AddWithValue("@PlanCategoryId", _PlanCategoryId);
                    cmd.Parameters.AddWithValue("@PlanCategoryName", "_PlanCategoryName");
                    cmd.Parameters.AddWithValue("@Amount", _Amount);

                    cmd.Parameters.AddWithValue("@GmquotationId", _GMQuotationId);
                    cmd.Parameters.AddWithValue("@Qty", _Qty);
                    cmd.Parameters.AddWithValue("@Contribution", _Contribution);
                    cmd.Parameters.AddWithValue("@TPAId", _TPAId);
                    cmd.Parameters.AddWithValue("@TPAName", "_TPAName");
                    cmd.Parameters.AddWithValue("@TEPercent", _TEPercent);
                    cmd.Parameters.AddWithValue("@TPAPercent", _TPAPercent);
                    cmd.Parameters.AddWithValue("@AgentPercent", _AgentPercent);
                    cmd.Parameters.AddWithValue("@TotalLoadingPercent", _TotalLoadingPercent);
                    cmd.Parameters.AddWithValue("@ApprovedCat", "_ApprovedCat");
                    cmd.Parameters.AddWithValue("@Remarks", "_Remarks");
                    cmd.Parameters.AddWithValue("@IPNet", "_IPNet");
                    cmd.Parameters.AddWithValue("@OPNet", "_OPNet");
                    cmd.Parameters.AddWithValue("@ProductOrigin", _ProductOrigin);
                    cmd.Parameters.AddWithValue("@ProductCode", "_ProductCode");
                    cmd.Parameters.AddWithValue("@ProductId", "_ProductId");
                    cmd.Parameters.AddWithValue("@Plan_Name", _Plan_Name);
                    cmd.Parameters.AddWithValue("@Network", "_Network");
                    cmd.Parameters.AddWithValue("@Product_Class", "_Product_Class");
                    cmd.Parameters.AddWithValue("@AggAnnualLimit", _AggAnnualLimit);
                    cmd.Parameters.AddWithValue("@OpDeductiblePerc", _OpDeductiblePerc);
                    cmd.Parameters.AddWithValue("@OpDeductibleAmt", _OpDeductibleAmt);
                    cmd.Parameters.AddWithValue("@InPatientMaternity", _InPatientMaternity);
                    cmd.Parameters.AddWithValue("@DentalCover", _DentalCover);
                    cmd.Parameters.AddWithValue("@OpticalCover", _OpticalCover);
                    cmd.Parameters.AddWithValue("@DxbQty", _DxbQty);
                    cmd.Parameters.AddWithValue("@DHPOProductType", _DHPOProductType);

                    cmd.Parameters.AddWithValue("@Mode", Mode);
                    cmd.Parameters.AddWithValue("@ICPercent", _ICPercent);
                    cmd.Parameters.AddWithValue("@GrossPremium", _GrossPremium);
                    cmd.Parameters.AddWithValue("@AICAmount", _AICAmount);
                    cmd.Parameters.AddWithValue("@AgentAmount", _AgentAmount);
                    cmd.Parameters.AddWithValue("@TPAAmount", TPAAmount);
                    cmd.Parameters.AddWithValue("@SMOAmount", _SMOAmount);
                    cmd.Parameters.AddWithValue("@TravelAssistAmount", _TravelAssistAmount);
                    cmd.Parameters.AddWithValue("@LifeAmount", _LifeAmount);
                    cmd.Parameters.AddWithValue("@RISplitPercent", _RISplitPercent);
                    cmd.Parameters.AddWithValue("@ICSplitPercent", _ICSplitPercent);
                    cmd.Parameters.AddWithValue("@RISplitAmount", _RISplitAmount);
                    cmd.Parameters.AddWithValue("@ICSplitAmount", _ICSplitAmount);
                    cmd.Parameters.AddWithValue("@BasmahPCPAmount", _BasmahPCPAmount);
                    cmd.Parameters.AddWithValue("@BasmahCancerAmount", _BasmahCancerAmount);
                    cmd.Parameters.AddWithValue("@PSPFees", _PSPFees);
                    cmd.Parameters.AddWithValue("@VATBasmah", _VATBasmah);
                    cmd.Parameters.AddWithValue("@VATPremium", _VATPremium);
                    cmd.Parameters.AddWithValue("@NetPremium", _NetPremium);
                    cmd.Parameters.AddWithValue("@FinalGrossPremium", _FinalGrossPremium);
                    cmd.Parameters.AddWithValue("@DiagCoPay", _DiagCoPay);
                    cmd.Parameters.AddWithValue("@PharmaCoPay", _PharmaCoPay);
                    cmd.Parameters.AddWithValue("@CatNameAuto", "_CatNameAuto");
                    cmd.Parameters.AddWithValue("@TerritorialCov", "_TerritorialCov");
                    cmd.Parameters.AddWithValue("@CoPayPerc", _CoPayPerc);
                    cmd.Parameters.AddWithValue("@CoPayAmount", _CoPayAmount);
                    cmd.Parameters.AddWithValue("@DisplayCopayText", "_DisplayCopayText");
                    cmd.Parameters.AddWithValue("@DisplayDEDText", "_DisplayDEDText");
                    cmd.Parameters.AddWithValue("@OptionalCover", _OptionalCover);
                    cmd.Parameters.AddWithValue("@CoverType", "_CoverType");
                    cmd.Parameters.AddWithValue("@PECLimit", _PECLimit);

                    cmd.Parameters.AddWithValue("@RoomType", "_RoomType");
                    cmd.Parameters.AddWithValue("@BasePremium_Gr", _BasePremium_Gr);
                    cmd.Parameters.AddWithValue("@OptionalPremium_Gr", _OptionalPremium_Gr);
                    cmd.Parameters.AddWithValue("@BasePremium_Nr", _BasePremium_Nr);
                    cmd.Parameters.AddWithValue("@IPPremium_Nr", _IPPremium_Nr);
                    cmd.Parameters.AddWithValue("@OPPremium_Nr", _OPPremium_Nr);
                    cmd.Parameters.AddWithValue("@Maternity_Nr", _Maternity_Nr);
                    cmd.Parameters.AddWithValue("@Optical_Nr", _Optical_Nr);
                    cmd.Parameters.AddWithValue("@Dental_Nr", _Dental_Nr);
                    cmd.Parameters.AddWithValue("@OptionalPremium_Nr", _OptionalPremium_Nr);
                    cmd.Parameters.AddWithValue("@Reimbursement", "_Reimbursement");
                    cmd.Parameters.AddWithValue("@AdditionalPremiumAmt", _AdditionalPremiumAmt);
                    cmd.Parameters.AddWithValue("@AdditionalPremiumComment", "_AdditionalPremiumComment");
                    cmd.Parameters.AddWithValue("@Inflation", _Inflation);
                    cmd.Parameters.AddWithValue("@Target_LR", _Target_LR);
                    cmd.Parameters.AddWithValue("@UserID", _UserId);
                    // Execute the command and retrieve the output parameter
                    if (Mode.ToLower() == "new")
                    {
                        cmd.ExecuteNonQuery();
                        _GMQuotationCategoryAmountId = Convert.ToInt64(cmd.Parameters["@CurrentID"].Value);
                    }
                    else if (Mode.ToLower() == "edit")
                    {
                        cmd.ExecuteNonQuery();

                    }
                }
                using (SqlCommand cmd1 = new SqlCommand("usp_AddEditDelete_GMQuotationPlanCategoryBenefits", connection))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;


                    SqlParameter currentIdParam = new SqlParameter("@CurrentID", SqlDbType.BigInt)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd1.Parameters.Add(currentIdParam);

                    //Add the input parameter with the condition
                    if (_GMQuotationId != 0)
                    {
                        cmd1.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = _GMQuotationCategoryAmountId });
                    }
                    else
                    {
                        cmd1.Parameters.Add(new SqlParameter("@Id", SqlDbType.BigInt) { Value = DBNull.Value });
                    }


                    cmd1.Parameters.AddWithValue("@PlanCategoryId", _PlanCategoryId);
                    cmd1.Parameters.AddWithValue("@GMQuotationId", _GMQuotationId);
                    cmd1.Parameters.AddWithValue("@PremiumTypeId", _PremiumTypeId);
                    cmd1.Parameters.AddWithValue("@WaitingPeriod", _WaitingPeriod);
                    cmd1.Parameters.AddWithValue("@WaitingPeriodUnit", "_WaitingPeriodUnit");
                    cmd1.Parameters.AddWithValue("@CoPayPerc", _CoPayPerc);
                    cmd1.Parameters.AddWithValue("@CoPayAmount", _CoPayAmount);
                    cmd1.Parameters.AddWithValue("@IsCovered", _IsCovered);
                    cmd1.Parameters.AddWithValue("@Comments", "_Comments");
                    cmd1.Parameters.AddWithValue("@DeductiblePerc", _DeductiblePerc);
                    cmd1.Parameters.AddWithValue("@DeductibleAmount", _DeductibleAmount);
                    cmd1.Parameters.AddWithValue("@ProviderNetwork", "_ProviderNetwork");
                    cmd1.Parameters.AddWithValue("@SharedBenefit", _SharedBenefit);
                    cmd1.Parameters.AddWithValue("@PECInclusions", "_PECInclusions");
                    cmd1.Parameters.AddWithValue("@PECExclusions", "_PECExclusions");
                    cmd1.Parameters.AddWithValue("@PreAuth", _PreAuth);
                    cmd1.Parameters.AddWithValue("@LimitType", "_LimitType");
                    cmd1.Parameters.AddWithValue("@LimitAmountType", "_LimitAmountType");
                    cmd1.Parameters.AddWithValue("@LimitAmountCurrency", "_LimitAmountCurrency");
                    cmd1.Parameters.AddWithValue("@LimitAmount", _LimitAmount);
                    cmd1.Parameters.AddWithValue("@LimitAmountUnit", "_LimitAmountUnit");
                    cmd1.Parameters.AddWithValue("@LimitAmountTerm", "_LimitAmountTerm");
                    cmd1.Parameters.AddWithValue("@LimitCountFreq", "_LimitCountFreq");
                    cmd1.Parameters.AddWithValue("@LimitCountType", "_LimitCountType");
                    cmd1.Parameters.AddWithValue("@LimitCount", _LimitCount);
                    cmd1.Parameters.AddWithValue("@LimitCountTerm", "_LimitCountTerm");

                    cmd1.Parameters.AddWithValue("@PlanId", _PlanId);
                    cmd1.Parameters.AddWithValue("@PlanBenefitId", _PlanBenefitId);
                    cmd1.Parameters.AddWithValue("@Category", "_Category");
                    cmd1.Parameters.AddWithValue("@DisplayCopayText", "_DisplayCopayText");
                    cmd1.Parameters.AddWithValue("@DisplayDEDText", "_DisplayDEDText");
                    cmd1.Parameters.AddWithValue("@PremiumAmt", _PremiumAmt);
                    cmd1.Parameters.AddWithValue("@PremiumPerc", _PremiumPerc);
                    cmd1.Parameters.AddWithValue("@Description", "_Description");
                    cmd1.Parameters.AddWithValue("@BenefitName", "_BenefitName");
                    cmd1.Parameters.AddWithValue("@BaseAmount", _BaseAmount);
                    cmd1.Parameters.AddWithValue("@BaseTerm", "_BaseTerm");
                    cmd1.Parameters.AddWithValue("@MaxAmount", _MaxAmount);
                    cmd1.Parameters.AddWithValue("@MaxTerm", "_MaxTerm");
                    cmd1.Parameters.AddWithValue("@DisplayText", "_DisplayText");
                    cmd1.Parameters.AddWithValue("@BaseCount", _BaseCount);
                    cmd1.Parameters.AddWithValue("@MaxCount", _MaxCount);
                    cmd1.Parameters.AddWithValue("@BaseType", "_BaseType");
                    cmd1.Parameters.AddWithValue("@MaxType", "_MaxType");
                    cmd1.Parameters.AddWithValue("@LimitText", "_LimitText");
                    cmd1.Parameters.AddWithValue("@TOBTag", "_TOBTag");
                    cmd1.Parameters.AddWithValue("@Mode", Mode);
                    cmd1.Parameters.AddWithValue("@UserID", _UserId);
                    //Execute the command and retrieve the output parameter
                    if (Mode.ToLower() == "new")
                    {
                        cmd1.ExecuteNonQuery();
                        _Id = Convert.ToInt32(cmd1.Parameters["@CurrentID"].Value);
                    }
                    else if (Mode.ToLower() == "edit")
                    {
                        cmd1.ExecuteNonQuery();

                    }
                }
            }
        }


        catch (Exception ex)
        {

            throw new Exception("Error adding/editing members to Members list.", ex);
        }
        return _Id;
    }
}


