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

public class GMQuotations
{
    private int _RowNumber;
    private long _GMQuotationId;
    private DateTime _Date;
    private string? _QuotationNumber;
    private string? _PlanType;
    private string? _ParticipantName;
    private string? _ParticipantTelephone;
    private string? _ParticipantAddress;
    private int _BrokerId;
    private string? _QuotationApprovedNum;
    private DateTime _PlanStartDate;
    private DateTime _PlanEndDate;
    private string? _PaymentFrequency;
    private int _IssuedById;
    private string? _PlanCurrency;
    private double _BrokerFeeTotal;
    private string? _CurrentWfStatus;
    private short _MemberCount;
    private string? _UDF1;
    private string? _UDF2;
    private string? _UDF3;
    private DateTime _UDF4;
    private DateTime _UDF5;
    private bool _IsQuoteRequested;
    private bool _IsQuoteSent;
    private bool _IsUWApproved;
    private bool _IsClientApproved;
    private bool _IsSuspendedClient;
    private bool _IsCardPrinted;
    private bool _IsCardCollected;
    private bool _IsCancelled;
    private bool _IsRenew;
    private string? _ParticipantEmail;
    private string? _BrokerName;
    private string? _BrokerTelephone;
    private string? _BrokerAddress;
    private string? _BrokerEmail;
    private bool _IsPolicyDocPrinted;
    private bool _IsPolicyDocAcknowledged;
    private DateTime _CardCollectedDate;
    private DateTime _DocCollectedDate;
    private string? _PaymentDates;
    private string? _PaymentAmounts;
    private string? _PremiumFreq;
    private short _NumberOfPayments;
    private int _UserId;
    private string? _PlanCategoryName;
    private string? _TPAName;
    private bool _IsDHACompliant;
    private bool _IsHAADCompliant;
    private bool _IsOtherCompliant;
    private bool _IsVirgin;
    private bool _IsEpreinced;
    private string? _ReInsurerComments;
    private int _BranchId;
    private string? _DistributionType;
    private string? _QuoteNum;
    private string? _ApprovedNum;
    private string? _POBox;
    private string? _ParticipantCity;
    private string? _Brokercity;
    private string? _BrokerWebsite;
    private string? _BrokerFax;
    private string? _UWRemarks;
    private string? _VATNumber;
    private double _TotalGrossVAT;
    private double _TotalFinalGross;
    private DateTime _SubmittedDate;
    private string? _EstablishmentNumber;
    private string? _TPAId;
    private double _BasmahInitiativeFee;
    private double _BasmahInitiativeVAT;
    private string? _QuotationType;
    private string? _Location;
    private double _TotalNetVAT;
    private double _Reduction;
    private double _TotalFinalNet;
    private bool _IsAssignAllTPA;
    private bool _IsAssignAllLocation;
    private string? _UWUserId;
    private long _UWId;
    private string? _UWUserName;
    private string? _UWEmailId;
    private bool _IsActive;
    private bool _IsDeleted;
    private bool _IsConverted;
    private string? _Guideline;
    private int _DxbQty;
    private DateTime _QuotationApproveDate;
    private string? _CompanyRegNum;
    private long _PolicyHolderPIN;
    private string? _Region;
    private string? _SubRegion;
    private string? _PreviousInsurerId;
    private DateTime _PreviousInsurerExpiryDate;
    private string? _BranchName;
    private string? _Country;
    private string? _DistributorCode;
    private string? _PolicyHolderTRN;
    private string? _Authority;
    private double _BrokerFeeVAT;
    private string? _SponsorType;
    private DateTime _ExpiryDate;
    private long _PersonId;
    private string? _ErrorDescPolicy;
    private double _TotalGross;
    private double _TotalNet;
    //For Dashboard
    private string? _Status;
    private int _TotalCount;
    private double _TotalAmount;
    private string? _AICComments;
    private long _InsCId;
    private string? _TPAComments;
    private string? _AuthorityComments;
    private string? _PaymentComments;
    private bool _HasReductionByPerc;
    private double _ReductionPerc;
    private string? _GeoCoverage;
    private string? _PolicyType;
    private string? _PolicySubType;
    private double _InstalmentSurcharge;
    private string? _RenewalSubType;
    private double _TPAAmount;
    private double _AICAmount;
    private double _AgentAmount;
    private string? _Allowed1;
    private string? _Allowed2;
    private string? _IndustryName;
    private string? _ReImbursement;
    private string? _TPAPercent;
    private string? _ICPercent;
    private string? _AgentPercent;
    private double _BasePremium_Gr;
    private double _IPPremium_Gr;
    private double _OPPremium_Gr;
    private double _Maternity_Gr;
    private double _Optical_Gr;
    private double _Dental_Gr;
    private double _OptionalPremium_Gr;
    private double _BasePremium_Nr;
    private double _IPPremium_Nr;
    private double _OPPremium_Nr;
    private double _Maternity_Nr;
    private double _Optical_Nr;
    private double _Dental_Nr;
    private double _OptionalPremium_Nr;
    private long _ParentId;
    private string? _QuotationNumber_Rev;
    private string? _OutsideProviders;
    private short _RevCount;
    private double _ReductionMC;
    private double _ReductionMCPerc;
    private bool _HasReductionMCbyPerc;
    private double _AdditionalClaims;
    private double _AdditionalClaimsPerc;
    private string? _AdditionalClaimsType;
    private bool _HasAdditionalClaimsbyPerc;
    private double _AdditionalNonClaims;
    private double _AdditionalNonClaimsPerc;
    private bool _HasAdditionalNonClaimsbyPerc;
    private bool _HasGroupSizeDiscountbyPerc;
    private double _GroupSizeDiscountAmount;
    private double _GroupSizeDiscountPerc;
    private long _ClientId;
    private long _ParentId_Renew;
    private string? _QuotationRenewal_Number;
    private double _AdditionalPremium_Nr;
    private double _AdditionalPremium_Gr;
    private double _ICPFees;
    private double _LifePremium_Nr;
    private double _LifePremium_Gr;
    private double _SMOPremium_Nr;
    private double _SMOPremium_Gr;
    private double _TravelPremium_Nr;
    private double _TravelPremium_Gr;

    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Telephone { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    //public string? BranchName { get; set; }
    public string? Website { get; set; }
    public string? Fax { get; set; }

    //private double _CreatedBy;
    //private double _CreatedOn;
    //private double _UpdatedBy;
    //private double _UpdatedOn;
    //private double _QuoteStatus;
    //private double _Comments;
    public int RowNumber
    {
        get
        {
            return _RowNumber;
        }
        set
        {
            _RowNumber = value;
        }
    }

    public long GMQuotationId
    {
        get
        {
            return _GMQuotationId;
        }
        set
        {
            _GMQuotationId = value;
        }
    }

    public DateTime Date
    {
        get
        {
            return _Date;
        }
        set
        {
            _Date = value;
        }
    }

    public string? QuotationNumber
    {
        get
        {
            return _QuotationNumber;
        }
        set
        {
            _QuotationNumber = value;
        }
    }

    public string? PlanType
    {
        get
        {
            return _PlanType;
        }
        set
        {
            _PlanType = value;
        }
    }

    public string? ParticipantName
    {
        get
        {
            return _ParticipantName;
        }
        set
        {
            _ParticipantName = value;
        }
    }

    public string? ParticipantTelephone
    {
        get
        {
            return _ParticipantTelephone;
        }
        set
        {
            _ParticipantTelephone = value;
        }
    }

    public string? ParticipantAddress
    {
        get
        {
            return _ParticipantAddress;
        }
        set
        {
            _ParticipantAddress = value;
        }
    }

    public int BrokerId
    {
        get
        {
            return _BrokerId;
        }
        set
        {
            _BrokerId = value;
        }
    }

    public string? QuotationApprovedNum
    {
        get
        {
            return _QuotationApprovedNum;
        }
        set
        {
            _QuotationApprovedNum = value;
        }
    }

    public DateTime PlanStartDate
    {
        get
        {
            return _PlanStartDate;
        }
        set
        {
            _PlanStartDate = value;
        }
    }

    public DateTime PlanEndDate
    {
        get
        {
            return _PlanEndDate;
        }
        set
        {
            _PlanEndDate = value;
        }
    }

    public string? PaymentFrequency
    {
        get
        {
            return _PaymentFrequency;
        }
        set
        {
            _PaymentFrequency = value;
        }
    }

    public int BranchId
    {
        get
        {
            return _BranchId;
        }
        set
        {
            _BranchId = value;
        }
    }
    public string? DistributionType
    {
        get
        {
            return _DistributionType;
        }
        set
        {
            _DistributionType = value;
        }
    }
    public int IssuedById
    {
        get
        {
            return _IssuedById;
        }
        set
        {
            _IssuedById = value;
        }
    }

    public string? PlanCurrency
    {
        get
        {
            return _PlanCurrency;
        }
        set
        {
            _PlanCurrency = value;
        }
    }

    public double BrokerFeeTotal
    {
        get
        {
            return _BrokerFeeTotal;
        }
        set
        {
            _BrokerFeeTotal = value;
        }
    }

    public string? CurrentWfStatus
    {
        get
        {
            return _CurrentWfStatus;
        }
        set
        {
            _CurrentWfStatus = value;
        }
    }

    public short MemberCount
    {
        get
        {
            return _MemberCount;
        }
        set
        {
            _MemberCount = value;
        }
    }

    public string? UDF1
    {
        get
        {
            return _UDF1;
        }
        set
        {
            _UDF1 = value;
        }
    }

    public string? UDF2
    {
        get
        {
            return _UDF2;
        }
        set
        {
            _UDF2 = value;
        }
    }

    public string? UDF3
    {
        get
        {
            return _UDF3;
        }
        set
        {
            _UDF3 = value;
        }
    }

    public DateTime UDF4
    {
        get
        {
            return _UDF4;
        }
        set
        {
            _UDF4 = value;
        }
    }

    public DateTime UDF5
    {
        get
        {
            return _UDF5;
        }
        set
        {
            _UDF5 = value;
        }
    }

    public bool IsQuoteRequested
    {
        get
        {
            return _IsQuoteRequested;
        }
        set
        {
            _IsQuoteRequested = value;
        }
    }

    public bool IsQuoteSent
    {
        get
        {
            return _IsQuoteSent;
        }
        set
        {
            _IsQuoteSent = value;
        }
    }

    public bool IsUWApproved
    {
        get
        {
            return _IsUWApproved;
        }
        set
        {
            _IsUWApproved = value;
        }
    }

    public bool IsClientApproved
    {
        get
        {
            return _IsClientApproved;
        }
        set
        {
            _IsClientApproved = value;
        }
    }

    public bool IsSuspendedClient
    {
        get
        {
            return _IsSuspendedClient;
        }
        set
        {
            _IsSuspendedClient = value;
        }
    }

    public bool IsCardPrinted
    {
        get
        {
            return _IsCardPrinted;
        }
        set
        {
            _IsCardPrinted = value;
        }
    }

    public bool IsCardCollected
    {
        get
        {
            return _IsCardCollected;
        }
        set
        {
            _IsCardCollected = value;
        }
    }

    public bool IsCancelled
    {
        get
        {
            return _IsCancelled;
        }
        set
        {
            _IsCancelled = value;
        }
    }

    public bool IsRenew
    {
        get
        {
            return _IsRenew;
        }
        set
        {
            _IsRenew = value;
        }
    }

    public string? ParticipantEmail
    {
        get
        {
            return _ParticipantEmail;
        }
        set
        {
            _ParticipantEmail = value;
        }
    }

    public string? BrokerName
    {
        get
        {
            return _BrokerName;
        }
        set
        {
            _BrokerName = value;
        }
    }

    public string? BrokerTelephone
    {
        get
        {
            return _BrokerTelephone;
        }
        set
        {
            _BrokerTelephone = value;
        }
    }

    public string? BrokerAddress
    {
        get
        {
            return _BrokerAddress;
        }
        set
        {
            _BrokerAddress = value;
        }
    }

    public string? BrokerEmail
    {
        get
        {
            return _BrokerEmail;
        }
        set
        {
            _BrokerEmail = value;
        }
    }

    public bool IsPolicyDocPrinted
    {
        get
        {
            return _IsPolicyDocPrinted;
        }
        set
        {
            _IsPolicyDocPrinted = value;
        }
    }

    public bool IsPolicyDocAcknowledged
    {
        get
        {
            return _IsPolicyDocAcknowledged;
        }
        set
        {
            _IsPolicyDocAcknowledged = value;
        }
    }

    public DateTime CardCollectedDate
    {
        get
        {
            return _CardCollectedDate;
        }
        set
        {
            _CardCollectedDate = value;
        }
    }

    public DateTime DocCollectedDate
    {
        get
        {
            return _DocCollectedDate;
        }
        set
        {
            _DocCollectedDate = value;
        }
    }

    public string? PaymentDates
    {
        get
        {
            return _PaymentDates;
        }
        set
        {
            _PaymentDates = value;
        }
    }

    public string? PaymentAmounts
    {
        get
        {
            return _PaymentAmounts;
        }
        set
        {
            _PaymentAmounts = value;
        }
    }

    public string? PremiumFreq
    {
        get
        {
            return _PremiumFreq;
        }
        set
        {
            _PremiumFreq = value;
        }
    }

    public short NumberOfPayments
    {
        get
        {
            return _NumberOfPayments;
        }
        set
        {
            _NumberOfPayments = value;
        }
    }

    public int UserId
    {
        get
        {
            return _UserId;
        }
        set
        {
            _UserId = value;
        }
    }

    public string? PlanCategoryName
    {
        get
        {
            return _PlanCategoryName;
        }
        set
        {
            _PlanCategoryName = value;
        }
    }
    public string? TPAName
    {
        get
        {
            return _TPAName;
        }
        set
        {
            _TPAName = value;
        }
    }

    public bool IsDHACompliant
    {
        get
        {
            return _IsDHACompliant;
        }
        set
        {
            _IsDHACompliant = value;
        }
    }
    public bool IsHAADCompliant
    {
        get
        {
            return _IsHAADCompliant;
        }
        set
        {
            _IsHAADCompliant = value;
        }
    }
    public bool IsOtherCompliant
    {
        get
        {
            return _IsOtherCompliant;
        }
        set
        {
            _IsOtherCompliant = value;
        }
    }

    public bool IsVirgin
    {
        get
        {
            return _IsVirgin;
        }
        set
        {
            _IsVirgin = value;
        }
    }
    public bool IsEpreinced
    {
        get
        {
            return _IsEpreinced;
        }
        set
        {
            _IsEpreinced = value;
        }
    }
    public string? ReInsurerComments
    {
        get
        {
            return _ReInsurerComments;
        }
        set
        {
            _ReInsurerComments = value;
        }
    }

    public string? QuoteNum
    {
        get
        {
            return _QuoteNum;
        }
        set
        {
            _QuoteNum = value;
        }
    }
    public string? ApprovedNum
    {
        get
        {
            return _ApprovedNum;
        }
        set
        {
            _ApprovedNum = value;
        }
    }
    public string? POBox
    {
        get
        {
            return _POBox;
        }
        set
        {
            _POBox = value;
        }
    }

    public string? ParticipantCity
    {
        get
        {
            return _ParticipantCity;
        }
        set
        {
            _ParticipantCity = value;
        }
    }

    public string? Brokercity
    {
        get
        {
            return _Brokercity;
        }
        set
        {
            _Brokercity = value;
        }
    }

    public string? BrokerWebsite
    {
        get
        {
            return _BrokerWebsite;
        }
        set
        {
            _BrokerWebsite = value;
        }
    }

    public string? BrokerFax
    {
        get
        {
            return _BrokerFax;
        }
        set
        {
            _BrokerFax = value;
        }
    }

    public string? UWRemarks
    {
        get
        {
            return _UWRemarks;
        }
        set
        {
            _UWRemarks = value;
        }
    }

    public string? VATNumber
    {
        get
        {
            return _VATNumber;
        }
        set
        {
            _VATNumber = value;
        }
    }

    public double TotalGrossVAT
    {
        get
        {
            return _TotalGrossVAT;
        }
        set
        {
            _TotalGrossVAT = value;
        }
    }

    public double TotalFinalGross
    {
        get
        {
            return _TotalFinalGross;
        }
        set
        {
            _TotalFinalGross = value;
        }
    }

    public DateTime SubmittedDate
    {
        get
        {
            return _SubmittedDate;
        }
        set
        {
            _SubmittedDate = value;
        }
    }

    public string? EstablishmentNumber
    {
        get
        {
            return _EstablishmentNumber;
        }
        set
        {
            _EstablishmentNumber = value;
        }
    }

    public double BasmahInitiativeFee
    {
        get
        {
            return _BasmahInitiativeFee;
        }
        set
        {
            _BasmahInitiativeFee = value;
        }
    }

    public double BasmahInitiativeVAT
    {
        get
        {
            return _BasmahInitiativeVAT;
        }
        set
        {
            _BasmahInitiativeVAT = value;
        }
    }

    public string? TPAId
    {
        get
        {
            return _TPAId;
        }
        set
        {
            _TPAId = value;
        }
    }
    public string? QuotationType
    {
        get
        {
            return _QuotationType;
        }
        set
        {
            _QuotationType = value;
        }
    }
    public string? Location
    {
        get
        {
            return _Location;
        }
        set
        {
            _Location = value;
        }
    }
    public double TotalNetVAT
    {
        get
        {
            return _TotalNetVAT;
        }
        set
        {
            _TotalNetVAT = value;
        }
    }
    public double Reduction
    {
        get
        {
            return _Reduction;
        }
        set
        {
            _Reduction = value;
        }
    }
    public double TotalFinalNet
    {
        get
        {
            return _TotalFinalNet;
        }
        set
        {
            _TotalFinalNet = value;
        }
    }
    public bool IsAssignAllLocation
    {
        get
        {
            return _IsAssignAllLocation;
        }
        set
        {
            _IsAssignAllLocation = value;
        }
    }

    public bool IsAssignAllTPA
    {
        get
        {
            bool IsAssignAllTPARet = default;
            return IsAssignAllTPARet;
        }
        set
        {
            _IsAssignAllTPA = value;
        }
    }

    public string? UWUserId
    {
        get
        {
            return _UWUserId;
        }
        set
        {
            _UWUserId = value;
        }
    }

    public long UWId
    {
        get
        {
            return _UWId;
        }
        set
        {
            _UWId = value;
        }
    }
    public string? UWUserName
    {
        get
        {
            return _UWUserName;
        }
        set
        {
            _UWUserName = value;
        }
    }

    public string? UWEmailId
    {
        get
        {
            return _UWEmailId;
        }
        set
        {
            _UWEmailId = value;
        }
    }

    public bool IsActive
    {
        get
        {
            return _IsActive;
        }
        set
        {
            _IsActive = value;
        }
    }

    public bool IsDeleted
    {
        get
        {
            return _IsDeleted;
        }
        set
        {
            _IsDeleted = value;
        }
    }

    public bool IsConverted
    {
        get
        {
            return _IsConverted;
        }
        set
        {
            _IsConverted = value;
        }
    }

    public string? Guideline
    {
        get
        {
            return _Guideline;
        }
        set
        {
            _Guideline = value;
        }
    }

    public int DxbQty
    {
        get
        {
            return _DxbQty;
        }
        set
        {
            _DxbQty = value;
        }
    }

    public DateTime QuotationApproveDate
    {
        get
        {
            return _QuotationApproveDate;
        }
        set
        {
            _QuotationApproveDate = value;
        }
    }
    public string? Status
    {
        get
        {
            return _Status;
        }
        set
        {
            _Status = value;
        }
    }
    public int TotalCount
    {
        get
        {
            return _TotalCount;
        }
        set
        {
            _TotalCount = value;
        }
    }
    public double TotalAmount
    {
        get
        {
            return _TotalAmount;
        }
        set
        {
            _TotalAmount = value;
        }
    }
    public string? CompanyRegNum
    {
        get
        {
            return _CompanyRegNum;
        }
        set
        {
            _CompanyRegNum = value;
        }
    }
    public long PolicyHolderPIN
    {
        get
        {
            return _PolicyHolderPIN;
        }
        set
        {
            _PolicyHolderPIN = value;
        }
    }
    public string? Region
    {
        get
        {
            return _Region;
        }
        set
        {
            _Region = value;
        }
    }

    public string? SubRegion
    {
        get
        {
            return _SubRegion;
        }
        set
        {
            _SubRegion = value;
        }
    }

    public string? PreviousInsurerId
    {
        get
        {
            return _PreviousInsurerId;
        }
        set
        {
            _PreviousInsurerId = value;
        }
    }

    public DateTime PreviousInsurerExpiryDate
    {
        get
        {
            return _PreviousInsurerExpiryDate;
        }
        set
        {
            _PreviousInsurerExpiryDate = value;
        }
    }

    public string? DistributorCode
    {
        get
        {
            return _DistributorCode;
        }
        set
        {
            _DistributorCode = value;
        }
    }

    public string? PolicyHolderTRN
    {
        get
        {
            return _PolicyHolderTRN;
        }
        set
        {
            _PolicyHolderTRN = value;
        }
    }

    public double TotalGross
    {
        get
        {
            return _TotalGross;
        }
        set
        {
            _TotalGross = value;
        }
    }

    public double TotalNet
    {
        get
        {
            return _TotalNet;
        }
        set
        {
            _TotalNet = value;
        }
    }

    public string? Authority
    {
        get
        {
            return _Authority;
        }
        set
        {
            _Authority = value;
        }
    }

    public double BrokerFeeVAT
    {
        get
        {
            return _BrokerFeeVAT;
        }
        set
        {
            _BrokerFeeVAT = value;
        }
    }

    public string? SponsorType
    {
        get
        {
            return _SponsorType;
        }
        set
        {
            _SponsorType = value;
        }
    }
    public DateTime ExpiryDate
    {
        get
        {
            return _ExpiryDate;
        }
        set
        {
            _ExpiryDate = value;
        }
    }

    public long PersonId
    {
        get
        {
            return _PersonId;
        }
        set
        {
            _PersonId = value;
        }
    }

    public string? ErrorDescPolicy
    {
        get
        {
            return _ErrorDescPolicy;
        }
        set
        {
            _ErrorDescPolicy = value;
        }
    }

    public string? BranchName
    {
        get
        {
            return _BranchName;
        }
        set
        {
            _BranchName = value;
        }
    }
    public string? Country
    {
        get
        {
            return _Country;
        }
        set
        {
            _Country = value;
        }
    }

    public long InsCId
    {
        get
        {
            return _InsCId;
        }
        set
        {
            _InsCId = value;
        }
    }

    public string? PaymentComments
    {
        get
        {
            return _PaymentComments;
        }
        set
        {
            _PaymentComments = value;
        }
    }

    public bool HasReductionByPerc
    {
        get
        {
            return _HasReductionByPerc;
        }
        set
        {
            _HasReductionByPerc = value;
        }
    }

    public double ReductionPerc
    {
        get
        {
            return _ReductionPerc;
        }
        set
        {
            _ReductionPerc = value;
        }
    }

    public string? GeoCoverage
    {
        get
        {
            return _GeoCoverage;
        }
        set
        {
            _GeoCoverage = value;
        }
    }

    public string? AICComments
    {
        get
        {
            return _AICComments;
        }
        set
        {
            _AICComments = value;
        }
    }

    public string? TPAComments
    {
        get
        {
            return _TPAComments;
        }
        set
        {
            _TPAComments = value;
        }
    }

    public string? AuthorityComments
    {
        get
        {
            return _AuthorityComments;
        }
        set
        {
            _AuthorityComments = value;
        }
    }

    public string? BusinessClass
    {
        get
        {
            return _IsRenew ? "Renew" : "New";
        }
    }

    public string? PolicySubType
    {
        get
        {
            return _PolicySubType;
        }
        set
        {
            _PolicySubType = value;
        }
    }

    public string? PolicyType
    {
        get
        {
            return _PolicyType;
        }
        set
        {
            _PolicyType = value;
        }
    }

    public double InstalmentSurcharge
    {
        get
        {
            return _InstalmentSurcharge;
        }
        set
        {
            _InstalmentSurcharge = value;
        }
    }

    public string? RenewalSubType
    {
        get
        {
            return _RenewalSubType;
        }
        set
        {
            _RenewalSubType = value;
        }
    }

    public double TPAAmount
    {
        get
        {
            return _TPAAmount;
        }
        set
        {
            _TPAAmount = value;
        }
    }


    public double AICAmount
    {
        get
        {
            return _AICAmount;
        }
        set
        {
            _AICAmount = value;
        }
    }
    public double AgentAmount
    {
        get
        {
            return _AgentAmount;
        }
        set
        {
            _AgentAmount = value;
        }
    }

    public string? Allowed1
    {
        get
        {
            return _Allowed1;
        }
        set
        {
            _Allowed1 = value;
        }
    }

    public string? Allowed2
    {
        get
        {
            return _Allowed2;
        }
        set
        {
            _Allowed2 = value;
        }
    }

    public string? IndustryName
    {
        get
        {
            return _IndustryName;
        }
        set
        {
            _IndustryName = value;
        }
    }

    public string? Reimbursement
    {
        get
        {
            return _ReImbursement;
        }
        set
        {
            _ReImbursement = value;
        }
    }

    public double TPAPercent
    {
        get
        {
            return Conversions.ToDouble(_TPAPercent);
        }
        set
        {
            _TPAPercent = value.ToString();
        }
    }
    public double ICPercent
    {
        get
        {
            return Conversions.ToDouble(_ICPercent);
        }
        set
        {
            _ICPercent = value.ToString();
        }
    }
    public double AgentPercent
    {
        get
        {
            return Conversions.ToDouble(_AgentPercent);
        }
        set
        {
            _AgentPercent = value.ToString();
        }
    }

    public double BasePremium_Gr
    {
        get
        {
            return _BasePremium_Gr;
        }
        set
        {
            _BasePremium_Gr = value;
        }
    }

    public double IPPremium_Gr
    {
        get
        {
            return _IPPremium_Gr;
        }
        set
        {
            _IPPremium_Gr = value;
        }
    }

    public double OPPremium_Gr
    {
        get
        {
            return _OPPremium_Gr;
        }
        set
        {
            _OPPremium_Gr = value;
        }
    }

    public double Maternity_Gr
    {
        get
        {
            return _Maternity_Gr;
        }
        set
        {
            _Maternity_Gr = value;
        }
    }

    public double Optical_Gr
    {
        get
        {
            return _Optical_Gr;
        }
        set
        {
            _Optical_Gr = value;
        }
    }

    public double Dental_Gr
    {
        get
        {
            return _Dental_Gr;
        }
        set
        {
            _Dental_Gr = value;
        }
    }

    public double OptionalPremium_Gr
    {
        get
        {
            return _OptionalPremium_Gr;
        }
        set
        {
            _OptionalPremium_Gr = value;
        }
    }

    public double BasePremium_Nr
    {
        get
        {
            return _BasePremium_Nr;
        }
        set
        {
            _BasePremium_Nr = value;
        }
    }

    public double IPPremium_Nr
    {
        get
        {
            return _IPPremium_Nr;
        }
        set
        {
            _IPPremium_Nr = value;
        }
    }

    public double OPPremium_Nr
    {
        get
        {
            return _OPPremium_Nr;
        }
        set
        {
            _OPPremium_Nr = value;
        }
    }

    public double Maternity_Nr
    {
        get
        {
            return _Maternity_Nr;
        }
        set
        {
            _Maternity_Nr = value;
        }
    }

    public double Optical_Nr
    {
        get
        {
            return _Optical_Nr;
        }
        set
        {
            _Optical_Nr = value;
        }
    }

    public double Dental_Nr
    {
        get
        {
            return _Dental_Nr;
        }
        set
        {
            _Dental_Nr = value;
        }
    }

    public double OptionalPremium_Nr
    {
        get
        {
            return _OptionalPremium_Nr;
        }
        set
        {
            _OptionalPremium_Nr = value;
        }
    }
    public long ParentId
    {
        get
        {
            return _ParentId;
        }
        set
        {
            _ParentId = value;
        }
    }
    public string? QuotationNumber_Rev
    {
        get
        {
            return _QuotationNumber_Rev;
        }
        set
        {
            _QuotationNumber_Rev = value;
        }
    }
    public short RevCount
    {
        get
        {
            return _RevCount;
        }
        set
        {
            _RevCount = value;
        }
    }

    public string? OutsideProviders
    {
        get
        {
            return _OutsideProviders;
        }
        set
        {
            _OutsideProviders = value;
        }
    }

    public bool HasReductionMCByPerc
    {
        get
        {
            return _HasReductionMCbyPerc;
        }
        set
        {
            _HasReductionMCbyPerc = value;
        }
    }

    public double ReductionMCPerc
    {
        get
        {
            return _ReductionMCPerc;
        }
        set
        {
            _ReductionMCPerc = value;
        }
    }
    public double ReductionMC
    {
        get
        {
            return _ReductionMC;
        }
        set
        {
            _ReductionMC = value;
        }
    }

    public bool HasAdditionalClaimsbyPerc
    {
        get
        {
            return _HasAdditionalClaimsbyPerc;
        }
        set
        {
            _HasAdditionalClaimsbyPerc = value;
        }
    }

    public double AdditionalClaimsPerc
    {
        get
        {
            return _AdditionalClaimsPerc;
        }
        set
        {
            _AdditionalClaimsPerc = value;
        }
    }
    public double AdditionalClaims
    {
        get
        {
            return _AdditionalClaims;
        }
        set
        {
            _AdditionalClaims = value;
        }
    }
    public string? AdditionalClaimsType
    {
        get
        {
            return _AdditionalClaimsType;
        }
        set
        {
            _AdditionalClaimsType = value;
        }
    }
    public bool HasAdditionalNonClaimsbyPerc
    {
        get
        {
            return _HasAdditionalNonClaimsbyPerc;
        }
        set
        {
            _HasAdditionalNonClaimsbyPerc = value;
        }
    }

    public double AdditionalNonClaimsPerc
    {
        get
        {
            return _AdditionalNonClaimsPerc;
        }
        set
        {
            _AdditionalNonClaimsPerc = value;
        }
    }
    public double AdditionalNonClaims
    {
        get
        {
            return _AdditionalNonClaims;
        }
        set
        {
            _AdditionalNonClaims = value;
        }
    }

    public bool HasGroupSizeDiscountbyPerc
    {
        get
        {
            return _HasGroupSizeDiscountbyPerc;
        }
        set
        {
            _HasGroupSizeDiscountbyPerc = value;
        }
    }
    public double GroupSizeDiscountAmount
    {
        get
        {
            return _GroupSizeDiscountAmount;
        }
        set
        {
            _GroupSizeDiscountAmount = value;
        }
    }
    public double GroupSizeDiscountPerc
    {
        get
        {
            return _GroupSizeDiscountPerc;
        }
        set
        {
            _GroupSizeDiscountPerc = value;
        }
    }
    public long ClientId
    {
        get
        {
            return _ClientId;
        }
        set
        {
            _ClientId = value;
        }
    }

    public long ParentId_Renew
    {
        get
        {
            return _ParentId_Renew;
        }
        set
        {
            _ParentId_Renew = value;
        }
    }
    public string? QuotationRenewal_Number
    {
        get
        {
            return _QuotationRenewal_Number;
        }
        set
        {
            _QuotationRenewal_Number = value;
        }
    }

    public double AdditionalPremium_Nr
    {
        get
        {
            return _AdditionalPremium_Nr;
        }
        set
        {
            _AdditionalPremium_Nr = value;
        }
    }
    public double AdditionalPremium_Gr
    {
        get
        {
            return _AdditionalPremium_Gr;
        }
        set
        {
            _AdditionalPremium_Gr = value;
        }
    }
    public double ICPFees
    {
        get
        {
            return _ICPFees;
        }
        set
        {
            _ICPFees = value;
        }
    }
    public double LifePremium_Nr
    {
        get
        {
            return _LifePremium_Nr;
        }
        set
        {
            _LifePremium_Nr = value;
        }
    }
    public double LifePremium_Gr
    {
        get
        {
            return _LifePremium_Gr;
        }
        set
        {
            _LifePremium_Gr = value;
        }
    }

    public double SMOPremium_Nr
    {
        get
        {
            return _SMOPremium_Nr;
        }
        set
        {
            _SMOPremium_Nr = value;
        }
    }
    public double SMOPremium_Gr
    {
        get
        {
            return _SMOPremium_Gr;
        }
        set
        {
            _SMOPremium_Gr = value;
        }
    }
    public double TravelPremium_Nr
    {
        get
        {
            return _TravelPremium_Nr;
        }
        set
        {
            _TravelPremium_Nr = value;
        }
    }
    public double TravelPremium_Gr
    {
        get
        {
            return _TravelPremium_Gr;
        }
        set
        {
            _TravelPremium_Gr = value;
        }
    }



    public IConfiguration? _Config { get; set; }
    public GMQuotations() { }
    public GMQuotations(IConfiguration? configuration)
    {
        _Config = configuration ?? throw new ArgumentNullException(nameof(configuration), "Configuration cannot be null.");
    }
    public void SetConfiguration(IConfiguration configuration)
    {
        _Config = configuration;
    }

    public List<GMQuotations> GetGMQuotationsList(string WhereCondition, string PagingCondition, string OrderByExpression)
    {
        var lstEntity = new List<GMQuotations>();

        try
        {
            using (SqlConnection connection = new SqlConnection(_Config.GetConnectionString("ConnString")))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("usp_Get_GMQuotations", connection))
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
                            GMQuotations oEntity = new GMQuotations(_Config);

                            oEntity.RowNumber = reader["RowNumber"] == DBNull.Value ? 0 : Convert.ToInt32(reader["RowNumber"]);
                            oEntity.GMQuotationId = reader["GMQuotationId"] == DBNull.Value ? 0 : (long)reader["GMQuotationId"];
                            oEntity.Date = reader["Date"] == DBNull.Value ? new DateTime(1900, 1, 1) : (DateTime)reader["Date"];
                            oEntity.QuotationNumber = reader["QuotationNumber"] == DBNull.Value ? string.Empty : (string)reader["QuotationNumber"];
                            oEntity.PlanType = reader["PlanType"] == DBNull.Value ? string.Empty : (string)reader["PlanType"];
                            oEntity.ParticipantName = reader["ParticipantName"] == DBNull.Value ? string.Empty : (string)reader["ParticipantName"];
                            oEntity.ParticipantTelephone = reader["ParticipantTelephone"] == DBNull.Value ? string.Empty : (string)reader["ParticipantTelephone"];
                            oEntity.ParticipantAddress = reader["ParticipantAddress"] == DBNull.Value ? string.Empty : (string)reader["ParticipantAddress"];
                            oEntity.ParticipantEmail = reader["ParticipantEmail"] == DBNull.Value ? string.Empty : (string)reader["ParticipantEmail"];
                            oEntity.BrokerId = reader["BrokerId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["BrokerId"]);
                            oEntity.BrokerName = reader["BrokerName"] == DBNull.Value ? string.Empty : (string)reader["BrokerName"];
                            oEntity.BrokerTelephone = reader["BrokerTelephone"] == DBNull.Value ? string.Empty : (string)reader["BrokerTelephone"];
                            oEntity.BrokerAddress = reader["BrokerAddress"] == DBNull.Value ? string.Empty : (string)reader["BrokerAddress"];
                            oEntity.BrokerEmail = reader["BrokerEmail"] == DBNull.Value ? string.Empty : (string)reader["BrokerEmail"];
                            oEntity.QuotationApprovedNum = reader["QuotationApprovedNum"] == DBNull.Value ? string.Empty : (string)reader["QuotationApprovedNum"];
                            oEntity.PlanStartDate = reader["PlanStartDate"] == DBNull.Value ? new DateTime(1900, 1, 1) : (DateTime)reader["PlanStartDate"];
                            oEntity.CardCollectedDate = reader["CardCollectedDate"] == DBNull.Value ? new DateTime(1900, 1, 1) : (DateTime)reader["CardCollectedDate"];
                            oEntity.DocCollectedDate = reader["DocCollectedDate"] == DBNull.Value ? new DateTime(1900, 1, 1) : (DateTime)reader["DocCollectedDate"];
                            oEntity.PlanEndDate = reader["PlanEndDate"] == DBNull.Value ? new DateTime(1900, 1, 1) : (DateTime)reader["PlanEndDate"];
                            oEntity.PaymentFrequency = reader["PaymentFrequency"] == DBNull.Value ? string.Empty : (string)reader["PaymentFrequency"];
                            oEntity.IssuedById = reader["IssuedById"] == DBNull.Value ? 0 : Convert.ToInt32(reader["IssuedById"]);
                            oEntity.PlanCurrency = reader["PlanCurrency"] == DBNull.Value ? string.Empty : (string)reader["PlanCurrency"];
                            oEntity.BrokerFeeTotal = reader["BrokerFeeTotal"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["BrokerFeeTotal"]);
                            oEntity.CurrentWfStatus = reader["CurrentWfStatus"] == DBNull.Value ? string.Empty : (string)reader["CurrentWfStatus"];
                            oEntity.MemberCount = reader["MemberCount"] == DBNull.Value ? (short)0 : (short)reader["MemberCount"];
                            oEntity.UDF1 = reader["UDF1"] == DBNull.Value ? string.Empty : (string)reader["UDF1"];
                            oEntity.UDF2 = reader["UDF2"] == DBNull.Value ? string.Empty : (string)reader["UDF2"];
                            oEntity.UDF3 = reader["UDF3"] == DBNull.Value ? string.Empty : (string)reader["UDF3"];
                            oEntity.UDF4 = reader["UDF4"] == DBNull.Value ? new DateTime(1901, 1, 1) : (DateTime)reader["UDF4"];
                            oEntity.UDF5 = reader["UDF5"] == DBNull.Value ? new DateTime(1901, 1, 1) : (DateTime)reader["UDF5"];
                            oEntity.IsQuoteRequested = reader["IsQuoteRequested"] == DBNull.Value ? false : (bool)reader["IsQuoteRequested"];
                            oEntity.IsQuoteSent = reader["IsQuoteSent"] == DBNull.Value ? false : (bool)reader["IsQuoteSent"];
                            oEntity.IsUWApproved = reader["IsUWApproved"] == DBNull.Value ? false : (bool)reader["IsUWApproved"];
                            oEntity.IsClientApproved = reader["IsClientApproved"] == DBNull.Value ? false : (bool)reader["IsClientApproved"];
                            oEntity.IsSuspendedClient = reader["IsSuspendedClient"] == DBNull.Value ? false : (bool)reader["IsSuspendedClient"];
                            oEntity.IsCardPrinted = reader["IsCardPrinted"] == DBNull.Value ? false : (bool)reader["IsCardPrinted"];
                            oEntity.IsCardCollected = reader["IsCardCollected"] == DBNull.Value ? false : (bool)reader["IsCardCollected"];
                            oEntity.IsCancelled = reader["IsCancelled"] == DBNull.Value ? false : (bool)reader["IsCancelled"];
                            oEntity.IsPolicyDocPrinted = reader["IsPolicyDocPrinted"] == DBNull.Value ? false : (bool)reader["IsPolicyDocPrinted"];
                            oEntity.IsPolicyDocAcknowledged = reader["IsPolicyDocAcknowledged"] == DBNull.Value ? false : (bool)reader["IsPolicyDocAcknowledged"];
                            oEntity.IsRenew = reader["IsRenew"] == DBNull.Value ? false : (bool)reader["IsRenew"];
                            oEntity.PaymentDates = reader["PaymentDates"] == DBNull.Value ? string.Empty : (string)reader["PaymentDates"];
                            oEntity.PaymentAmounts = reader["PaymentAmounts"] == DBNull.Value ? string.Empty : (string)reader["PaymentAmounts"];
                            oEntity.PremiumFreq = reader["PremiumFreq"] == DBNull.Value ? string.Empty : (string)reader["PremiumFreq"];
                            oEntity.NumberOfPayments = reader["NumberOfPayments"] == DBNull.Value ? (short)1 : (short)reader["NumberOfPayments"];
                            oEntity.IsDHACompliant = reader["IsDHACompliant"] == DBNull.Value ? false : (bool)reader["IsDHACompliant"];
                            oEntity.IsHAADCompliant = reader["IsHAADCompliant"] == DBNull.Value ? false : (bool)reader["IsHAADCompliant"];
                            oEntity.IsOtherCompliant = reader["IsOtherCompliant"] == DBNull.Value ? false : (bool)reader["IsOtherCompliant"];
                            oEntity.IsVirgin = reader["IsVirgin"] == DBNull.Value ? false : (bool)reader["IsVirgin"];
                            oEntity.IsEpreinced = reader["IsEpreinced"] == DBNull.Value ? false : (bool)reader["IsEpreinced"];
                            oEntity.ReInsurerComments = reader["ReInsurerComments"] == DBNull.Value ? string.Empty : (string)reader["ReInsurerComments"];
                            oEntity.QuoteNum = reader["QuoteNum"] == DBNull.Value ? string.Empty : (string)reader["QuoteNum"];
                            oEntity.ApprovedNum = reader["ApprovedNum"] == DBNull.Value ? string.Empty : (string)reader["ApprovedNum"];
                            oEntity.POBox = reader["POBox"] == DBNull.Value ? string.Empty : (string)reader["POBox"];
                            oEntity.ParticipantCity = reader["ParticipantCity"] == DBNull.Value ? string.Empty : (string)reader["ParticipantCity"];
                            oEntity.Brokercity = reader["Brokercity"] == DBNull.Value ? string.Empty : (string)reader["Brokercity"];
                            oEntity.BrokerWebsite = reader["BrokerWebsite"] == DBNull.Value ? string.Empty : (string)reader["BrokerWebsite"];
                            oEntity.BrokerFax = reader["BrokerFax"] == DBNull.Value ? string.Empty : (string)reader["BrokerFax"];
                            oEntity.UWRemarks = reader["UWRemarks"] == DBNull.Value ? string.Empty : (string)reader["UWRemarks"];
                            oEntity.VATNumber = reader["VATNumber"] == DBNull.Value ? string.Empty : (string)reader["VATNumber"];
                            oEntity.TotalGrossVAT = reader["TotalGrossVAT"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["TotalGrossVAT"]);
                            oEntity.TotalFinalGross = reader["TotalFinalGross"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["TotalFinalGross"]);
                            oEntity.EstablishmentNumber = reader["EstablishmentNumber"] == DBNull.Value ? string.Empty : (string)reader["EstablishmentNumber"];
                            oEntity.TPAId = reader["TPAId"] == DBNull.Value ? string.Empty : (string)reader["TPAId"];
                            oEntity.BasmahInitiativeFee = reader["BasmahInitiativeFee"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["BasmahInitiativeFee"]);
                            // .BasmahInitiativeVAT = If(IsDBNull(dr.Item("BasmahInitiativeVAT")), 0, dr.Item("BasmahInitiativeVAT"))
                            oEntity.QuotationType = reader["QuotationType"] == DBNull.Value ? string.Empty : (string)reader["QuotationType"];
                            oEntity.Location = reader["Location"] == DBNull.Value ? string.Empty : (string)reader["Location"];
                            oEntity.TotalNetVAT = reader["TotalNetVAT"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["TotalNetVAT"]);
                            oEntity.Reduction = reader["Reduction"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["Reduction"]);
                            oEntity.TotalFinalNet = reader["TotalFinalNet"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["TotalFinalNet"]);
                            oEntity.IsAssignAllTPA = reader["IsAssignAllTPA"] == DBNull.Value ? false : (bool)reader["IsAssignAllTPA"];
                            oEntity.IsAssignAllLocation = reader["IsAssignAllLocation"] == DBNull.Value ? false : (bool)reader["IsAssignAllLocation"];
                            oEntity.UWUserId = reader["UWUserId"] == DBNull.Value ? string.Empty : (string)reader["UWUserId"];
                            oEntity.IsConverted = reader["IsConverted"] == DBNull.Value ? false : (bool)reader["IsConverted"];
                            oEntity.CompanyRegNum = reader["CompanyRegNum"] == DBNull.Value ? string.Empty : (string)reader["CompanyRegNum"];
                            oEntity.PolicyHolderPIN = reader["PolicyHolderPIN"] == DBNull.Value ? 0L : (long)reader["PolicyHolderPIN"];
                            oEntity.Region = reader["Region"] == DBNull.Value ? string.Empty : (string)reader["Region"];
                            oEntity.SubRegion = reader["SubRegion"] == DBNull.Value ? string.Empty : (string)reader["SubRegion"];
                            oEntity.BranchId = reader["BranchId"] == DBNull.Value ? 0 : (int)reader["BranchId"];
                            oEntity.DistributionType = reader["DistributionType"] == DBNull.Value ? string.Empty : (string)reader["DistributionType"];

                            oEntity.PreviousInsurerId = reader["PreviousInsurerId"] == DBNull.Value ? string.Empty : reader["PreviousInsurerId"].ToString();
                            oEntity.PreviousInsurerExpiryDate = reader["PreviousInsurerExpiryDate"] == DBNull.Value ? new DateTime(1900, 1, 1) : (DateTime)reader["PreviousInsurerExpiryDate"];
                            oEntity.DistributorCode = reader["DistributorCode"] == DBNull.Value ? string.Empty : (string)reader["DistributorCode"];
                            oEntity.PolicyHolderTRN = reader["PolicyHolderTRN"] == DBNull.Value ? string.Empty : (string)reader["PolicyHolderTRN"];
                            oEntity.TotalGross = reader["TotalGross"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["TotalGross"]);
                            oEntity.TotalNet = reader["TotalNet"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["TotalNet"]);
                            oEntity.Authority = reader["Authority"] == DBNull.Value ? string.Empty : (string)reader["Authority"];
                            oEntity.BrokerFeeVAT = reader["BrokerFeeVAT"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["BrokerFeeVAT"]);
                            oEntity.SponsorType = reader["SponsorType"] == DBNull.Value ? string.Empty : (string)reader["SponsorType"];
                            oEntity.ExpiryDate = reader["ExpiryDate"] == DBNull.Value ? new DateTime(1900, 1, 1) : (DateTime)reader["ExpiryDate"];
                            oEntity.PersonId = reader["PersonId"] == DBNull.Value ? 0L : (long)reader["PersonId"];
                            oEntity.ErrorDescPolicy = reader["ErrorDescPolicy"] == DBNull.Value ? string.Empty : (string)reader["ErrorDescPolicy"];
                            oEntity.TPAName = reader["TPAName"] == DBNull.Value ? string.Empty : (string)reader["TPAName"];
                            oEntity.BranchName = reader["BranchName"] == DBNull.Value ? string.Empty : (string)reader["BranchName"];
                            oEntity.Country = reader["Country"] == DBNull.Value ? string.Empty : (string)reader["Country"];
                            oEntity.InsCId = reader["InsCId"] == DBNull.Value ? 0L : (long)reader["InsCId"];
                            oEntity.PaymentComments = reader["PaymentComments"] == DBNull.Value ? string.Empty : (string)reader["PaymentComments"];
                            oEntity.HasReductionByPerc = reader["HasReductionbyPerc"] == DBNull.Value ? false : Convert.ToBoolean(reader["HasReductionbyPerc"]);
                            oEntity.ReductionPerc = reader["ReductionPerc"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["ReductionPerc"]);
                            oEntity.GeoCoverage = reader["GeoCoverage"] == DBNull.Value ? string.Empty : (string)reader["GeoCoverage"];
                            oEntity.PolicyType = reader["PolicyType"] == DBNull.Value ? string.Empty : (string)reader["PolicyType"];
                            oEntity.PolicySubType = reader["PolicySubType"] == DBNull.Value ? string.Empty : (string)reader["PolicySubType"];
                            oEntity.InstalmentSurcharge = reader["InstalmentSurcharge"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["InstalmentSurcharge"]);
                            oEntity.RenewalSubType = reader["RenewalSubType"] == DBNull.Value ? string.Empty : (string)reader["RenewalSubType"];
                            oEntity.TPAAmount = reader["TPAAmount"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["TPAAmount"]);
                            oEntity.AICAmount = reader["AICAmount"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["AICAmount"]);
                            oEntity.AgentAmount = reader["AgentAmount"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["AgentAmount"]);
                            oEntity.IndustryName = reader["IndustryName"] == DBNull.Value ? string.Empty : (string)reader["IndustryName"];
                            oEntity.Reimbursement = reader["Reimbursement"] == DBNull.Value ? string.Empty : (string)reader["Reimbursement"];
                            oEntity.TPAPercent = reader["TPAPercent"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["TPAPercent"]);
                            oEntity.ICPercent = reader["ICPercent"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["ICPercent"]);
                            oEntity.AgentPercent = reader["AgentPercent"] == DBNull.Value ? 0.0 : Convert.ToDouble(reader["AgentPercent"]);
                            oEntity.BasePremium_Gr = Convert.ToDouble(reader["BasePremium_Gr"] is DBNull ? 0 : reader["BasePremium_Gr"]);
                            oEntity.IPPremium_Gr = Convert.ToDouble(reader["IPPremium_Gr"] is DBNull ? 0 : reader["IPPremium_Gr"]);
                            oEntity.OPPremium_Gr = Convert.ToDouble(reader["OPPremium_Gr"] is DBNull ? 0 : reader["OPPremium_Gr"]);
                            oEntity.Maternity_Gr = Convert.ToDouble(reader["Maternity_Gr"] is DBNull ? 0 : reader["Maternity_Gr"]);
                            oEntity.Optical_Gr = Convert.ToDouble(reader["Optical_Gr"] is DBNull ? 0 : reader["Optical_Gr"]);
                            oEntity.Dental_Gr = Convert.ToDouble(reader["Dental_Gr"] is DBNull ? 0 : reader["Dental_Gr"]);
                            oEntity.OptionalPremium_Gr = Convert.ToDouble(reader["OptionalPremium_Gr"] is DBNull ? 0 : reader["OptionalPremium_Gr"]);
                            oEntity.BasePremium_Nr = Convert.ToDouble(reader["BasePremium_Nr"] is DBNull ? 0 : reader["BasePremium_Nr"]);
                            oEntity.IPPremium_Nr = Convert.ToDouble(reader["IPPremium_Nr"] is DBNull ? 0 : reader["IPPremium_Nr"]);
                            oEntity.OPPremium_Nr = Convert.ToDouble(reader["OPPremium_Nr"] is DBNull ? 0 : reader["OPPremium_Nr"]);
                            oEntity.Maternity_Nr = Convert.ToDouble(reader["Maternity_Nr"] is DBNull ? 0 : reader["Maternity_Nr"]);
                            oEntity.Optical_Nr = Convert.ToDouble(reader["Optical_Nr"] is DBNull ? 0 : reader["Optical_Nr"]);
                            oEntity.Dental_Nr = Convert.ToDouble(reader["Dental_Nr"] is DBNull ? 0 : reader["Dental_Nr"]);
                            oEntity.OptionalPremium_Nr = Convert.ToDouble(reader["OptionalPremium_Nr"] is DBNull ? 0 : reader["OptionalPremium_Nr"]);

                            oEntity.ParentId = Convert.ToInt64(reader["ParentId"] is DBNull ? 0 : reader["ParentId"]);
                            oEntity.QuotationNumber_Rev = Convert.ToString(reader["QuotationNumber_Rev"] is DBNull ? string.Empty : reader["QuotationNumber_Rev"]);
                            oEntity.OutsideProviders = Convert.ToString(reader["OutsideProviders"] is DBNull ? string.Empty : reader["OutsideProviders"]);
                            oEntity.RevCount = Convert.ToInt16(reader["RevCount"] is DBNull ? 0 : reader["RevCount"]);

                            oEntity.ReductionMC = Convert.ToDouble(reader["ReductionMC"] is DBNull ? 0 : reader["ReductionMC"]);
                            oEntity.ReductionMCPerc = Convert.ToDouble(reader["ReductionMCPerc"] is DBNull ? 0 : reader["ReductionMCPerc"]);
                            oEntity.HasReductionMCByPerc = Convert.ToBoolean(reader["HasReductionMCbyPerc"] is DBNull ? false : reader["HasReductionMCbyPerc"]);

                            oEntity.AdditionalClaims = Convert.ToDouble(reader["AdditionalClaims"] is DBNull ? 0 : reader["AdditionalClaims"]);
                            oEntity.AdditionalClaimsPerc = Convert.ToDouble(reader["AdditionalClaimsPerc"] is DBNull ? 0 : reader["AdditionalClaimsPerc"]);
                            oEntity.HasAdditionalClaimsbyPerc = Convert.ToBoolean(reader["HasAdditionalClaimsbyPerc"] is DBNull ? false : reader["HasAdditionalClaimsbyPerc"]);
                            oEntity.AdditionalClaimsType = Convert.ToString(reader["AdditionalClaimsType"] is DBNull ? string.Empty : reader["AdditionalClaimsType"]);

                            oEntity.AdditionalNonClaims = Convert.ToDouble(reader["AdditionalNonClaims"] is DBNull ? 0 : reader["AdditionalNonClaims"]);
                            oEntity.AdditionalNonClaimsPerc = Convert.ToDouble(reader["AdditionalNonClaimsPerc"] is DBNull ? 0 : reader["AdditionalNonClaimsPerc"]);
                            oEntity.HasAdditionalNonClaimsbyPerc = Convert.ToBoolean(reader["HasAdditionalNonClaimsbyPerc"] is DBNull ? false : reader["HasAdditionalNonClaimsbyPerc"]);
                            oEntity.HasGroupSizeDiscountbyPerc = Convert.ToBoolean(reader["HasGroupSizeDiscountbyPerc"] is DBNull ? false : reader["HasGroupSizeDiscountbyPerc"]);
                            oEntity.GroupSizeDiscountAmount = Convert.ToDouble(reader["GroupSizeDiscountAmount"] is DBNull ? 0 : reader["GroupSizeDiscountAmount"]);
                            oEntity.GroupSizeDiscountPerc = Convert.ToDouble(reader["GroupSizeDiscountPerc"] is DBNull ? 0 : reader["GroupSizeDiscountPerc"]);
                            oEntity.ClientId = Convert.ToInt64(reader["ClientId"] is DBNull ? 0 : reader["ClientId"]);
                            oEntity.ParentId_Renew = Convert.ToInt64(reader["ParentId_Renew"] is DBNull ? 0 : reader["ParentId_Renew"]);
                            oEntity.AdditionalPremium_Gr = Convert.ToDouble(reader["AdditionalPremium_Gr"] is DBNull ? 0 : reader["AdditionalPremium_Gr"]);
                            oEntity.AdditionalPremium_Nr = Convert.ToDouble(reader["AdditionalPremium_Nr"] is DBNull ? 0 : reader["AdditionalPremium_Nr"]);
                            oEntity.ICPFees = Convert.ToDouble(reader["ICPFees"] is DBNull ? 0 : reader["ICPFees"]);
                            oEntity.LifePremium_Gr = Convert.ToDouble(reader["LifePremium_Gr"] is DBNull ? 0 : reader["LifePremium_Gr"]);
                            oEntity.LifePremium_Nr = Convert.ToDouble(reader["LifePremium_Nr"] is DBNull ? 0 : reader["LifePremium_Nr"]);
                            oEntity.SMOPremium_Gr = Convert.ToDouble(reader["SMOPremium_Gr"] is DBNull ? 0 : reader["SMOPremium_Gr"]);
                            oEntity.SMOPremium_Nr = Convert.ToDouble(reader["SMOPremium_Nr"] is DBNull ? 0 : reader["SMOPremium_Nr"]);
                            oEntity.TravelPremium_Gr = Convert.ToDouble(reader["TravelPremium_Gr"] is DBNull ? 0 : reader["TravelPremium_Gr"]);
                            oEntity.TravelPremium_Nr = Convert.ToDouble(reader["TravelPremium_Nr"] is DBNull ? 0 : reader["TravelPremium_Nr"]);

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
        Console.WriteLine("ParticipantName", ParticipantName);
        try
        {

            using (SqlConnection connection = new SqlConnection(_Config.GetConnectionString("ConnString")))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("usp_AddEditDelete_GMQuotations", connection))
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
                        cmd.Parameters.Add(new SqlParameter("@GMQuotationId", SqlDbType.BigInt) { Value = _GMQuotationId });
                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@GMQuotationId", SqlDbType.BigInt) { Value = DBNull.Value });
                    }

                    // Add input parameters with null checks for non-nullable types

                    cmd.Parameters.AddWithValue("@Date", (_Date < new DateTime(1753, 1, 1) || _Date > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _Date);
                    //cmd.Parameters.AddWithValue("@GMQuotationId", _GMQuotationId != 0 ? (object)_GMQuotationId : DBNull.Value);
                    cmd.Parameters.AddWithValue("@QuotationNumber", _QuotationNumber);
                    cmd.Parameters.AddWithValue("@PlanType", "Retail");
                    cmd.Parameters.AddWithValue("@ParticipantName", _ParticipantName);
                    cmd.Parameters.AddWithValue("@ParticipantTelephone", _ParticipantTelephone);
                    cmd.Parameters.AddWithValue("@ParticipantAddress", _ParticipantAddress);
                    cmd.Parameters.AddWithValue("@ParticipantEmail", _ParticipantEmail);
                    cmd.Parameters.AddWithValue("@BrokerId", _BrokerId);
                    cmd.Parameters.AddWithValue("@BrokerName", _BrokerName);
                    cmd.Parameters.AddWithValue("@BrokerTelephone", _BrokerTelephone);
                    cmd.Parameters.AddWithValue("@BrokerAddress", _BrokerAddress);
                    cmd.Parameters.AddWithValue("@BrokerEmail", _BrokerEmail);
                    cmd.Parameters.AddWithValue("@QuotationApprovedNum", _QuotationApprovedNum);
                    cmd.Parameters.AddWithValue("@PlanStartDate", (_PlanStartDate < new DateTime(1753, 1, 1) || _PlanStartDate > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _PlanStartDate);
                    cmd.Parameters.AddWithValue("@PlanEndDate", (_PlanEndDate < new DateTime(1753, 1, 1) || _PlanEndDate > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _PlanEndDate);
                    cmd.Parameters.AddWithValue("@PaymentFrequency", _PaymentFrequency);
                    cmd.Parameters.AddWithValue("@IssuedById", _IssuedById);
                    cmd.Parameters.AddWithValue("@PlanCurrency", _PlanCurrency);
                    cmd.Parameters.AddWithValue("@BrokerFeeTotal", _BrokerFeeTotal);
                    cmd.Parameters.AddWithValue("@CurrentWfStatus", _CurrentWfStatus);
                    cmd.Parameters.AddWithValue("@MemberCount", _MemberCount);
                    cmd.Parameters.AddWithValue("@UDF1", _UDF1);
                    cmd.Parameters.AddWithValue("@UDF2", _UDF2);
                    cmd.Parameters.AddWithValue("@UDF3", _UDF3);
                    cmd.Parameters.AddWithValue("@UDF4", (_UDF4 < new DateTime(1753, 1, 1) || _UDF4 > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _UDF4);
                    cmd.Parameters.AddWithValue("@UDF5", (_UDF5 < new DateTime(1753, 1, 1) || _UDF5 > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _UDF5);

                    cmd.Parameters.AddWithValue("@IsQuoteRequested", _IsQuoteRequested);
                    cmd.Parameters.AddWithValue("@IsQuoteSent", _IsQuoteSent);
                    cmd.Parameters.AddWithValue("@IsUWApproved", _IsUWApproved);
                    cmd.Parameters.AddWithValue("@IsClientApproved", _IsClientApproved);
                    cmd.Parameters.AddWithValue("@IsSuspendedClient", _IsSuspendedClient);
                    cmd.Parameters.AddWithValue("@IsCardPrinted", _IsCardPrinted);
                    cmd.Parameters.AddWithValue("@IsCardCollected", _IsCardCollected);
                    cmd.Parameters.AddWithValue("@IsCancelled", _IsCancelled);
                    cmd.Parameters.AddWithValue("@IsPolicyDocPrinted", _IsPolicyDocPrinted);
                    cmd.Parameters.AddWithValue("@IsPolicyDocAcknowledged", _IsPolicyDocAcknowledged);
                    cmd.Parameters.AddWithValue("@IsRenew", _IsRenew);
                    cmd.Parameters.AddWithValue("@PaymentDates", _PaymentDates);
                    cmd.Parameters.AddWithValue("@PaymentAmounts", _PaymentAmounts);
                    cmd.Parameters.AddWithValue("@PremiumFreq", _PremiumFreq);
                    cmd.Parameters.AddWithValue("@NumberOfPayments", _NumberOfPayments);

                    cmd.Parameters.AddWithValue("@IsDHACompliant", _IsDHACompliant);
                    cmd.Parameters.AddWithValue("@IsHAADCompliant", _IsHAADCompliant);
                    cmd.Parameters.AddWithValue("@IsOtherCompliant", _IsOtherCompliant);
                    cmd.Parameters.AddWithValue("@IsVirgin", _IsVirgin);
                    cmd.Parameters.AddWithValue("@IsEpreinced", _IsEpreinced);
                    cmd.Parameters.AddWithValue("@ReInsurerComments", _ReInsurerComments);

                    cmd.Parameters.AddWithValue("@QuoteNum", _QuoteNum);
                    cmd.Parameters.AddWithValue("@ApprovedNum", _ApprovedNum);
                    cmd.Parameters.AddWithValue("@POBox", _POBox);
                    cmd.Parameters.AddWithValue("@ParticipantCity", _ParticipantCity);
                    cmd.Parameters.AddWithValue("@Brokercity", _Brokercity);
                    cmd.Parameters.AddWithValue("@BrokerWebsite", _BrokerWebsite);
                    cmd.Parameters.AddWithValue("@BrokerFax", _BrokerFax);
                    cmd.Parameters.AddWithValue("@UWRemarks", _UWRemarks);
                    cmd.Parameters.AddWithValue("@VATNumber", _VATNumber);
                    cmd.Parameters.AddWithValue("@TotalGrossVAT", _TotalGrossVAT);
                    cmd.Parameters.AddWithValue("@TotalFinalGross", _TotalFinalGross);
                    cmd.Parameters.AddWithValue("@EstablishmentNumber", _EstablishmentNumber);
                    cmd.Parameters.AddWithValue("@BasmahInitiativeFee", _BasmahInitiativeFee);
                    cmd.Parameters.AddWithValue("@BasmahInitiativeVAT", _BasmahInitiativeVAT);
                    cmd.Parameters.AddWithValue("@QuotationType", _QuotationType);
                    cmd.Parameters.AddWithValue("@Location", _Location);
                    cmd.Parameters.AddWithValue("@TPAId", _TPAId);
                    cmd.Parameters.AddWithValue("@TotalNetVAT", _TotalNetVAT);
                    cmd.Parameters.AddWithValue("@Reduction", _Reduction);
                    cmd.Parameters.AddWithValue("@TotalFinalNet", _TotalFinalNet);
                    cmd.Parameters.AddWithValue("@IsAssignAllTPA", _IsAssignAllTPA);
                    cmd.Parameters.AddWithValue("@IsAssignAllLocation", _IsAssignAllLocation);
                    cmd.Parameters.AddWithValue("@IsConverted", _IsConverted);

                    cmd.Parameters.AddWithValue("@Guideline", _Guideline);
                    cmd.Parameters.AddWithValue("@DxbQty", _DxbQty);
                    cmd.Parameters.AddWithValue("@QuotationApproveDate", (_QuotationApproveDate < new DateTime(1753, 1, 1) || _QuotationApproveDate > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _QuotationApproveDate);


                    cmd.Parameters.AddWithValue("@BranchId", _BranchId);
                    cmd.Parameters.AddWithValue("@DistributionType", _DistributionType);

                    cmd.Parameters.AddWithValue("@CompanyRegNum", _CompanyRegNum);
                    cmd.Parameters.AddWithValue("@PolicyHolderPIN", _PolicyHolderPIN);
                    cmd.Parameters.AddWithValue("@Region", _Region);
                    cmd.Parameters.AddWithValue("@SubRegion", _SubRegion);

                    cmd.Parameters.AddWithValue("@PreviousInsurerId", _PreviousInsurerId);
                    cmd.Parameters.AddWithValue("@PreviousInsurerExpiryDate", (_PreviousInsurerExpiryDate < new DateTime(1753, 1, 1) || _PreviousInsurerExpiryDate > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _PreviousInsurerExpiryDate);
                    cmd.Parameters.AddWithValue("@TPAName", _TPAName);
                    cmd.Parameters.AddWithValue("@BranchName", BranchName);
                    cmd.Parameters.AddWithValue("@SponsorType", _SponsorType);
                    cmd.Parameters.AddWithValue("@ExpiryDate", (_ExpiryDate < new DateTime(1753, 1, 1) || _ExpiryDate > new DateTime(9999, 12, 31)) ? (object)DBNull.Value : _ExpiryDate);
                    cmd.Parameters.AddWithValue("@Country", _Country);
                    cmd.Parameters.AddWithValue("@DistributorCode", _DistributorCode);
                    cmd.Parameters.AddWithValue("@PolicyHolderTRN", _PolicyHolderTRN);
                    cmd.Parameters.AddWithValue("@TotalGross", _TotalGross);
                    cmd.Parameters.AddWithValue("@TotalNet", _TotalNet);
                    cmd.Parameters.AddWithValue("@Authority", _Authority);
                    cmd.Parameters.AddWithValue("@BrokerFeeVAT", _BrokerFeeVAT);
                    cmd.Parameters.AddWithValue("@PersonId", _PersonId);
                    cmd.Parameters.AddWithValue("@ErrorDescPolicy", _ErrorDescPolicy);
                    cmd.Parameters.AddWithValue("@InsCId", _InsCId);
                    cmd.Parameters.AddWithValue("@PaymentComments", _PaymentComments);
                    cmd.Parameters.AddWithValue("@HasReductionbyPerc", _HasReductionByPerc);
                    cmd.Parameters.AddWithValue("@ReductionPerc", _ReductionPerc);
                    cmd.Parameters.AddWithValue("@GeoCoverage", _GeoCoverage);
                    cmd.Parameters.AddWithValue("@PolicyType", _PolicyType);
                    cmd.Parameters.AddWithValue("@PolicySubType", _PolicySubType);
                    cmd.Parameters.AddWithValue("@InstalmentSurcharge", _InstalmentSurcharge);
                    cmd.Parameters.AddWithValue("@RenewalSubType", _RenewalSubType);

                    cmd.Parameters.AddWithValue("@TPAAmount", _TPAAmount);
                    cmd.Parameters.AddWithValue("@AICAmount", _AICAmount);
                    cmd.Parameters.AddWithValue("@AgentAmount", _AgentAmount);
                    cmd.Parameters.AddWithValue("@Allowed1", _Allowed1);
                    cmd.Parameters.AddWithValue("@Allowed2", _Allowed2);
                    cmd.Parameters.AddWithValue("@IndustryName", _IndustryName);
                    cmd.Parameters.AddWithValue("@ReImbursement", _ReImbursement);
                    cmd.Parameters.AddWithValue("@BasePremium_Gr", _BasePremium_Gr);
                    cmd.Parameters.AddWithValue("@IPPremium_Gr", _IPPremium_Gr);
                    cmd.Parameters.AddWithValue("@OPPremium_Gr", _OPPremium_Gr);
                    cmd.Parameters.AddWithValue("@Maternity_Gr", _Maternity_Gr);
                    cmd.Parameters.AddWithValue("@Optical_Gr", _Optical_Gr);
                    cmd.Parameters.AddWithValue("@Dental_Gr", _Dental_Gr);
                    cmd.Parameters.AddWithValue("@OptionalPremium_Gr", _OptionalPremium_Gr);
                    cmd.Parameters.AddWithValue("@BasePremium_Nr", _BasePremium_Nr);
                    cmd.Parameters.AddWithValue("@IPPremium_Nr", _IPPremium_Nr);
                    cmd.Parameters.AddWithValue("@OPPremium_Nr", _OPPremium_Nr);
                    cmd.Parameters.AddWithValue("@Maternity_Nr", _Maternity_Nr);
                    cmd.Parameters.AddWithValue("@Optical_Nr", _Optical_Nr);
                    cmd.Parameters.AddWithValue("@Dental_Nr", _Dental_Nr);
                    cmd.Parameters.AddWithValue("@OptionalPremium_Nr", _OptionalPremium_Nr);

                    cmd.Parameters.AddWithValue("@ParentId", _ParentId);
                    cmd.Parameters.AddWithValue("@QuotationNumber_Rev", _QuotationNumber_Rev);
                    cmd.Parameters.AddWithValue("@RevCount", _RevCount);
                    cmd.Parameters.AddWithValue("@OutsideProviders", _OutsideProviders);

                    cmd.Parameters.AddWithValue("@HasReductionMCbyPerc", _HasReductionMCbyPerc);
                    cmd.Parameters.AddWithValue("@ReductionMC", _ReductionMC);
                    cmd.Parameters.AddWithValue("@ReductionMCPerc", _ReductionMCPerc);

                    cmd.Parameters.AddWithValue("@HasAdditionalClaimsbyPerc", _HasAdditionalClaimsbyPerc);
                    cmd.Parameters.AddWithValue("@AdditionalClaimsPerc", _AdditionalClaimsPerc);
                    cmd.Parameters.AddWithValue("@AdditionalClaims", _AdditionalClaims);
                    cmd.Parameters.AddWithValue("@AdditionalClaimsType", _AdditionalClaimsType);

                    cmd.Parameters.AddWithValue("@HasAdditionalNonClaimsbyPerc", _HasAdditionalNonClaimsbyPerc);
                    cmd.Parameters.AddWithValue("@AdditionalNonClaimsPerc", _AdditionalNonClaimsPerc);
                    cmd.Parameters.AddWithValue("@AdditionalNonClaims", _AdditionalNonClaims);

                    cmd.Parameters.AddWithValue("@HasGroupSizeDiscountbyPerc", _HasGroupSizeDiscountbyPerc);
                    cmd.Parameters.AddWithValue("@GroupSizeDiscountAmount", _GroupSizeDiscountAmount);
                    cmd.Parameters.AddWithValue("@GroupSizeDiscountPerc", _GroupSizeDiscountPerc);

                    cmd.Parameters.AddWithValue("@TPAPercent", _TPAPercent);
                    cmd.Parameters.AddWithValue("@ICPercent", _ICPercent);
                    cmd.Parameters.AddWithValue("@AgentPercent", _AgentPercent);
                    cmd.Parameters.AddWithValue("@ClientId", _ClientId);
                    cmd.Parameters.AddWithValue("@ParentId_Renew", _ParentId_Renew);
                    cmd.Parameters.AddWithValue("@AdditionalPremium_Nr", _AdditionalPremium_Nr);
                    cmd.Parameters.AddWithValue("@AdditionalPremium_Gr", _AdditionalPremium_Gr);
                    cmd.Parameters.AddWithValue("@ICPFees", _ICPFees);
                    cmd.Parameters.AddWithValue("@LifePremium_Nr", _LifePremium_Nr);
                    cmd.Parameters.AddWithValue("@LifePremium_Gr", _LifePremium_Gr);
                    cmd.Parameters.AddWithValue("@SMOPremium_Nr", _SMOPremium_Nr);
                    cmd.Parameters.AddWithValue("@SMOPremium_Gr", _SMOPremium_Gr);
                    cmd.Parameters.AddWithValue("@TravelPremium_Nr", _TravelPremium_Nr);
                    cmd.Parameters.AddWithValue("@TravelPremium_Gr", _TravelPremium_Gr);

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

            throw new Exception("Error adding/editing quotations to GMQuotations list.", ex);
        }
        return _GMQuotationId;
    }





}














