// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UnqualifiedDataTypes;
    using CommonAggregateComponents;
    using CommonExtensionComponents;
    
    
    /// <summary>
    /// A document used to request a Quotation for goods and services from a Seller.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Request For Quotation. Details
    /// <para />ObjectClass: Request For Quotation
    /// <para />AlternativeBusinessTerms: Purchase Order
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RequestForQuotation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RequestForQuotation-2")]
    [System.Xml.Serialization.XmlRootAttribute("RequestForQuotation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RequestForQuotation-2", IsNullable=false)]
    public partial class RequestForQuotationType : BaseDocument, IBaseDocument
    {
        
        private System.Collections.Generic.List<UBLExtensionType> _uBLExtensions;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayAttribute("UBLExtensions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable=false)]
        public UBLExtensionType[] @__UBLExtensions
        {
            get
            {
                return _uBLExtensions?.ToArray();
            }
            set
            {
                _uBLExtensions = value == null ? null : new System.Collections.Generic.List<UBLExtensionType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UBLVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
        public IdentifierType @__UBLVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomizationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
        public IdentifierType @__CustomizationID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
        public IdentifierType @__ProfileID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ProfileExecutionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
        public IdentifierType @__ProfileExecutionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
        public IdentifierType @__ID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SubmissionDueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public DateType @__SubmissionDueDate;
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public TextType[] @__Note
        {
            get
            {
                return _note?.ToArray();
            }
            set
            {
                _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("PricingCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public CodeType @__PricingCurrencyCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public NumericType @__LineCountNumeric;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RequestedValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=14)]
        public PeriodType @__RequestedValidityPeriod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CatalogueDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public DocumentReferenceType @__CatalogueDocumentReference;
        
        private System.Collections.Generic.List<DocumentReferenceType> _additionalDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=16)]
        public DocumentReferenceType[] @__AdditionalDocumentReference
        {
            get
            {
                return _additionalDocumentReference?.ToArray();
            }
            set
            {
                _additionalDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
            }
        }
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=17)]
        public SignatureType[] @__Signature
        {
            get
            {
                return _signature?.ToArray();
            }
            set
            {
                _signature = value == null ? null : new System.Collections.Generic.List<SignatureType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public CustomerPartyType @__OriginatorCustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("BuyerCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public CustomerPartyType @__BuyerCustomerParty;
        
        private System.Collections.Generic.List<DeliveryType> _delivery;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public DeliveryType[] @__Delivery
        {
            get
            {
                return _delivery?.ToArray();
            }
            set
            {
                _delivery = value == null ? null : new System.Collections.Generic.List<DeliveryType>(value);
            }
        }
        
        private System.Collections.Generic.List<DeliveryTermsType> _deliveryTerms;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
        public DeliveryTermsType[] @__DeliveryTerms
        {
            get
            {
                return _deliveryTerms?.ToArray();
            }
            set
            {
                _deliveryTerms = value == null ? null : new System.Collections.Generic.List<DeliveryTermsType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DestinationCountry", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=23)]
        public CountryType @__DestinationCountry;
        
        private System.Collections.Generic.List<ContractType> _contract;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=24)]
        public ContractType[] @__Contract
        {
            get
            {
                return _contract?.ToArray();
            }
            set
            {
                _contract = value == null ? null : new System.Collections.Generic.List<ContractType>(value);
            }
        }
        
        private System.Collections.Generic.List<RequestForQuotationLineType> _requestForQuotationLine;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RequestForQuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=25)]
        public RequestForQuotationLineType[] @__RequestForQuotationLine
        {
            get
            {
                return _requestForQuotationLine?.ToArray();
            }
            set
            {
                _requestForQuotationLine = value == null ? null : new System.Collections.Generic.List<RequestForQuotationLineType>(value);
            }
        }
        
        /// <summary>
        /// A container for all extensions present in the document.
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<UBLExtensionType> IBaseDocument.UBLExtensions
        {
            get { return _uBLExtensions ?? (_uBLExtensions = new System.Collections.Generic.List<UBLExtensionType>()); }
            set { _uBLExtensions = value; }
        }

        
        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
            set { _note = value; }
        }

        
        /// <summary>
        /// A reference to an additional document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Additional_ Document Reference. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Additional
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> AdditionalDocumentReference
        {
            get { return _additionalDocumentReference ?? (_additionalDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
            set { _additionalDocumentReference = value; }
        }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Signature
        /// <para />AssociatedObjectClass: Signature
        /// <para />RepresentationTerm: Signature
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        System.Collections.Generic.List<SignatureType> IBaseDocument.Signature
        {
            get { return _signature ?? (_signature = new System.Collections.Generic.List<SignatureType>()); }
            set { _signature = value; }
        }

        
        /// <summary>
        /// A delivery associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Delivery
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Delivery
        /// <para />AssociatedObjectClass: Delivery
        /// <para />RepresentationTerm: Delivery
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DeliveryType> Delivery
        {
            get { return _delivery ?? (_delivery = new System.Collections.Generic.List<DeliveryType>()); }
            set { _delivery = value; }
        }

        
        /// <summary>
        /// A set of delivery terms associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Delivery Terms
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Delivery Terms
        /// <para />AssociatedObjectClass: Delivery Terms
        /// <para />RepresentationTerm: Delivery Terms
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DeliveryTermsType> DeliveryTerms
        {
            get { return _deliveryTerms ?? (_deliveryTerms = new System.Collections.Generic.List<DeliveryTermsType>()); }
            set { _deliveryTerms = value; }
        }

        
        /// <summary>
        /// A contract associated with this Request for Quotation..
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Contract
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Contract
        /// <para />AssociatedObjectClass: Contract
        /// <para />RepresentationTerm: Contract
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ContractType> Contract
        {
            get { return _contract ?? (_contract = new System.Collections.Generic.List<ContractType>()); }
            set { _contract = value; }
        }

        
        /// <summary>
        /// A line specifying a kind of item of sale.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Request For Quotation Line
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Request For Quotation Line
        /// <para />AssociatedObjectClass: Request For Quotation Line
        /// <para />RepresentationTerm: Request For Quotation Line
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<RequestForQuotationLineType> RequestForQuotationLine
        {
            get { return _requestForQuotationLine ?? (_requestForQuotationLine = new System.Collections.Generic.List<RequestForQuotationLineType>()); }
            set { _requestForQuotationLine = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>2.0.5</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UBLVersionID
        {
            get
            {
                if (__UBLVersionID == null) { __UBLVersionID = new IdentifierType(); }
                return __UBLVersionID;
            }
            set
            {
                __UBLVersionID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined customization of UBL for a specific use.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>NES</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.CustomizationID
        {
            get
            {
                if (__CustomizationID == null) { __CustomizationID = new IdentifierType(); }
                return __CustomizationID;
            }
            set
            {
                __CustomizationID = value;
            }
        }

        
        /// <summary>
        /// Identifies a user-defined profile of the customization of UBL being used.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BasicProcurementProcess</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileID
        {
            get
            {
                if (__ProfileID == null) { __ProfileID = new IdentifierType(); }
                return __ProfileID;
            }
            set
            {
                __ProfileID = value;
            }
        }

        
        /// <summary>
        /// Identifies an instance of executing a profile, to associate all transactions in a collaboration.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Profile Execution Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>BPP-1001</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ProfileExecutionID
        {
            get
            {
                if (__ProfileExecutionID == null) { __ProfileExecutionID = new IdentifierType(); }
                return __ProfileExecutionID;
            }
            set
            {
                __ProfileExecutionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for this document, assigned by the sender.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.ID
        {
            get
            {
                if (__ID == null) { __ID = new IdentifierType(); }
                return __ID;
            }
            set
            {
                __ID = value;
            }
        }

        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        
        /// <summary>
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        IdentifierType IBaseDocument.UUID
        {
            get
            {
                if (__UUID == null) { __UUID = new IdentifierType(); }
                return __UUID;
            }
            set
            {
                __UUID = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Issue Time. Time
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        
        /// <summary>
        /// The due date for submission of the Quotation.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Submission Due Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Submission Due Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType SubmissionDueDate
        {
            get
            {
                if (__SubmissionDueDate == null) { __SubmissionDueDate = new DateType(); }
                return __SubmissionDueDate;
            }
            set
            {
                __SubmissionDueDate = value;
            }
        }

        
        /// <summary>
        /// The currency that the Seller should use to price the Quotation.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Pricing_ Currency Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Pricing
        /// <para />PropertyTerm: Currency Code
        /// <para />RepresentationTerm: Code
        /// <para />DataTypeQualifier: Currency
        /// <para />DataType: Currency_ Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType PricingCurrencyCode
        {
            get
            {
                if (__PricingCurrencyCode == null) { __PricingCurrencyCode = new CodeType(); }
                return __PricingCurrencyCode;
            }
            set
            {
                __PricingCurrencyCode = value;
            }
        }

        
        /// <summary>
        /// The number of Request For Quotation Lines in this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Request For Quotation. Line Count. Numeric
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTerm: Line Count
        /// <para />RepresentationTerm: Numeric
        /// <para />DataType: Numeric. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public NumericType LineCountNumeric
        {
            get
            {
                if (__LineCountNumeric == null) { __LineCountNumeric = new NumericType(); }
                return __LineCountNumeric;
            }
            set
            {
                __LineCountNumeric = value;
            }
        }

        
        /// <summary>
        /// The validity period requested for this Quotation.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Requested Validity_ Period. Period
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Requested Validity
        /// <para />PropertyTerm: Period
        /// <para />AssociatedObjectClass: Period
        /// <para />RepresentationTerm: Period
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PeriodType RequestedValidityPeriod
        {
            get
            {
                if (__RequestedValidityPeriod == null) { __RequestedValidityPeriod = new PeriodType(); }
                return __RequestedValidityPeriod;
            }
            set
            {
                __RequestedValidityPeriod = value;
            }
        }

        
        /// <summary>
        /// The Catalogue on which this Request for Quotation is based.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Catalogue_ Document Reference. Document Reference
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Catalogue
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType CatalogueDocumentReference
        {
            get
            {
                if (__CatalogueDocumentReference == null) { __CatalogueDocumentReference = new DocumentReferenceType(); }
                return __CatalogueDocumentReference;
            }
            set
            {
                __CatalogueDocumentReference = value;
            }
        }

        
        /// <summary>
        /// The originator.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Originator_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Originator
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType OriginatorCustomerParty
        {
            get
            {
                if (__OriginatorCustomerParty == null) { __OriginatorCustomerParty = new CustomerPartyType(); }
                return __OriginatorCustomerParty;
            }
            set
            {
                __OriginatorCustomerParty = value;
            }
        }

        
        /// <summary>
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Seller
        /// <para />PropertyTerm: Supplier Party
        /// <para />AssociatedObjectClass: Supplier Party
        /// <para />RepresentationTerm: Supplier Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                if (__SellerSupplierParty == null) { __SellerSupplierParty = new SupplierPartyType(); }
                return __SellerSupplierParty;
            }
            set
            {
                __SellerSupplierParty = value;
            }
        }

        
        /// <summary>
        /// The buyer.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Buyer_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Buyer
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                if (__BuyerCustomerParty == null) { __BuyerCustomerParty = new CustomerPartyType(); }
                return __BuyerCustomerParty;
            }
            set
            {
                __BuyerCustomerParty = value;
            }
        }

        
        /// <summary>
        /// The country of destination of potential orders (for customs purposes).
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Request For Quotation. Destination_ Country. Country
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Request For Quotation
        /// <para />PropertyTermQualifier: Destination
        /// <para />PropertyTerm: Country
        /// <para />AssociatedObjectClass: Country
        /// <para />RepresentationTerm: Country
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CountryType DestinationCountry
        {
            get
            {
                if (__DestinationCountry == null) { __DestinationCountry = new CountryType(); }
                return __DestinationCountry;
            }
            set
            {
                __DestinationCountry = value;
            }
        }

    }
}
