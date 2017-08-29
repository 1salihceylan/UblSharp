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
    /// A document that describes items, prices, and price validity.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Catalogue. Details
    /// <para />ObjectClass: Catalogue
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("Catalogue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Catalogue-2")]
    [System.Xml.Serialization.XmlRootAttribute("Catalogue", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Catalogue-2", IsNullable=false)]
    public partial class CatalogueType : BaseDocument, IBaseDocument
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
        [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
        public IdentifierType @__UUID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ActionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
        public CodeType @__ActionCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
        public NameType @__Name;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RevisionDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
        public DateType @__RevisionDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("RevisionTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public TimeType @__RevisionTime;
        
        private System.Collections.Generic.List<TextType> _note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
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
        
        private System.Collections.Generic.List<TextType> _description;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public TextType[] @__Description
        {
            get
            {
                return _description?.ToArray();
            }
            set
            {
                _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
        public IdentifierType @__VersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("PreviousVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
        public IdentifierType @__PreviousVersionID;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("LineCountNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=17)]
        public NumericType @__LineCountNumeric;
        
        private System.Collections.Generic.List<PeriodType> _validityPeriod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public PeriodType[] @__ValidityPeriod
        {
            get
            {
                return _validityPeriod?.ToArray();
            }
            set
            {
                _validityPeriod = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
            }
        }
        
        private System.Collections.Generic.List<ContractType> _referencedContract;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedContract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public ContractType[] @__ReferencedContract
        {
            get
            {
                return _referencedContract?.ToArray();
            }
            set
            {
                _referencedContract = value == null ? null : new System.Collections.Generic.List<ContractType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SourceCatalogueReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public CatalogueReferenceType @__SourceCatalogueReference;
        
        private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public DocumentReferenceType[] @__DocumentReference
        {
            get
            {
                return _documentReference?.ToArray();
            }
            set
            {
                _documentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
            }
        }
        
        private System.Collections.Generic.List<SignatureType> _signature;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
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
        [System.Xml.Serialization.XmlElementAttribute("ProviderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=23)]
        public PartyType @__ProviderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=24)]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=25)]
        public SupplierPartyType @__SellerSupplierParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ContractorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=26)]
        public CustomerPartyType @__ContractorCustomerParty;
        
        private System.Collections.Generic.List<TradingTermsType> _tradingTerms;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TradingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=27)]
        public TradingTermsType[] @__TradingTerms
        {
            get
            {
                return _tradingTerms?.ToArray();
            }
            set
            {
                _tradingTerms = value == null ? null : new System.Collections.Generic.List<TradingTermsType>(value);
            }
        }
        
        private System.Collections.Generic.List<CatalogueLineType> _catalogueLine;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CatalogueLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=28)]
        public CatalogueLineType[] @__CatalogueLine
        {
            get
            {
                return _catalogueLine?.ToArray();
            }
            set
            {
                _catalogueLine = value == null ? null : new System.Collections.Generic.List<CatalogueLineType>(value);
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
        /// <para />DictionaryEntryName: Catalogue. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue
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
        /// Textual description of the document instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Description. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Description
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        /// <example>computer accessories for laptops</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Description
        {
            get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
            set { _description = value; }
        }

        
        /// <summary>
        /// A period, assigned by the seller, during which the information in the Catalogue is effective. This may be given as start and end dates or as a duration.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Validity_ Period. Period
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTermQualifier: Validity
        /// <para />PropertyTerm: Period
        /// <para />AssociatedObjectClass: Period
        /// <para />RepresentationTerm: Period
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<PeriodType> ValidityPeriod
        {
            get { return _validityPeriod ?? (_validityPeriod = new System.Collections.Generic.List<PeriodType>()); }
            set { _validityPeriod = value; }
        }

        
        /// <summary>
        /// A contract or framework agreement with which this Catalogue is associated.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Referenced_ Contract. Contract
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTermQualifier: Referenced
        /// <para />PropertyTerm: Contract
        /// <para />AssociatedObjectClass: Contract
        /// <para />RepresentationTerm: Contract
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<ContractType> ReferencedContract
        {
            get { return _referencedContract ?? (_referencedContract = new System.Collections.Generic.List<ContractType>()); }
            set { _referencedContract = value; }
        }

        
        /// <summary>
        /// A reference to another document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
        {
            get { return _documentReference ?? (_documentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
            set { _documentReference = value; }
        }

        
        /// <summary>
        /// A signature applied to this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue
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
        /// The trading terms associated with this Catalogue.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Trading Terms
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Trading Terms
        /// <para />AssociatedObjectClass: Trading Terms
        /// <para />RepresentationTerm: Trading Terms
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TradingTermsType> TradingTerms
        {
            get { return _tradingTerms ?? (_tradingTerms = new System.Collections.Generic.List<TradingTermsType>()); }
            set { _tradingTerms = value; }
        }

        
        /// <summary>
        /// A line in a Catalogue describing an item of sale.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Catalogue Line
        /// <para />Cardinality: 1..n
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Catalogue Line
        /// <para />AssociatedObjectClass: Catalogue Line
        /// <para />RepresentationTerm: Catalogue Line
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<CatalogueLineType> CatalogueLine
        {
            get { return _catalogueLine ?? (_catalogueLine = new System.Collections.Generic.List<CatalogueLineType>()); }
            set { _catalogueLine = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
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
        /// <para />DictionaryEntryName: Catalogue. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
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
        /// <para />DictionaryEntryName: Catalogue. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
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
        /// <para />DictionaryEntryName: Catalogue. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
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
        /// <para />DictionaryEntryName: Catalogue. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue
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
        /// A universally unique identifier for an instance of this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
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
        /// A code signifying whether the transaction is a replacement or an update.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Action Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Action Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        /// <example>Replace , Update .</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType ActionCode
        {
            get
            {
                if (__ActionCode == null) { __ActionCode = new CodeType(); }
                return __ActionCode;
            }
            set
            {
                __ActionCode = value;
            }
        }

        
        /// <summary>
        /// Text, assigned by the sender, that identifies this document to business users.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Name
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Name
        /// <para />RepresentationTerm: Name
        /// <para />DataType: Name. Type
        /// </summary>
        /// <example>winter 2005 collection</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public NameType Name
        {
            get
            {
                if (__Name == null) { __Name = new NameType(); }
                return __Name;
            }
            set
            {
                __Name = value;
            }
        }

        
        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue
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
        /// <para />DictionaryEntryName: Catalogue. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
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
        /// The date, assigned by the seller party, on which the information in the Catalogue was last revised.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Revision Date. Date
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Revision Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType RevisionDate
        {
            get
            {
                if (__RevisionDate == null) { __RevisionDate = new DateType(); }
                return __RevisionDate;
            }
            set
            {
                __RevisionDate = value;
            }
        }

        
        /// <summary>
        /// The time, assigned by the Seller party, at which the information in the Catalogue was last revised.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Revision Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Revision Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType RevisionTime
        {
            get
            {
                if (__RevisionTime == null) { __RevisionTime = new TimeType(); }
                return __RevisionTime;
            }
            set
            {
                __RevisionTime = value;
            }
        }

        
        /// <summary>
        /// An identifier for the current version of the Catalogue.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>1.1</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType VersionID
        {
            get
            {
                if (__VersionID == null) { __VersionID = new IdentifierType(); }
                return __VersionID;
            }
            set
            {
                __VersionID = value;
            }
        }

        
        /// <summary>
        /// An identifier for the previous version of the Catalogue that is superseded by this version.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Previous_ Version. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTermQualifier: Previous
        /// <para />PropertyTerm: Version
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>1.0</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IdentifierType PreviousVersionID
        {
            get
            {
                if (__PreviousVersionID == null) { __PreviousVersionID = new IdentifierType(); }
                return __PreviousVersionID;
            }
            set
            {
                __PreviousVersionID = value;
            }
        }

        
        /// <summary>
        /// The number of Catalogue Lines in the document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Catalogue. Line Count. Numeric
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
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
        /// A reference to the source catalogue.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Source_ Catalogue Reference. Catalogue Reference
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTermQualifier: Source
        /// <para />PropertyTerm: Catalogue Reference
        /// <para />AssociatedObjectClass: Catalogue Reference
        /// <para />RepresentationTerm: Catalogue Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CatalogueReferenceType SourceCatalogueReference
        {
            get
            {
                if (__SourceCatalogueReference == null) { __SourceCatalogueReference = new CatalogueReferenceType(); }
                return __SourceCatalogueReference;
            }
            set
            {
                __SourceCatalogueReference = value;
            }
        }

        
        /// <summary>
        /// The party providing the Catalogue.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Provider_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTermQualifier: Provider
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ProviderParty
        {
            get
            {
                if (__ProviderParty == null) { __ProviderParty = new PartyType(); }
                return __ProviderParty;
            }
            set
            {
                __ProviderParty = value;
            }
        }

        
        /// <summary>
        /// The party receiving the Catalogue.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Receiver_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

        
        /// <summary>
        /// The seller.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Seller_ Supplier Party. Supplier Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
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
        /// The customer party responsible for the contracts with which the Catalogue is associated.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Catalogue. Contractor_ Customer Party. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Catalogue
        /// <para />PropertyTermQualifier: Contractor
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType ContractorCustomerParty
        {
            get
            {
                if (__ContractorCustomerParty == null) { __ContractorCustomerParty = new CustomerPartyType(); }
                return __ContractorCustomerParty;
            }
            set
            {
                __ContractorCustomerParty = value;
            }
        }

    }
}
