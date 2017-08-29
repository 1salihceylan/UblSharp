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
    /// A supplement to an Invoice or Credit Note, containing information on the consumption of services provided by utility suppliers to private and public customers, including electricity, gas, water, and telephone services.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Utility Statement. Details
    /// <para />ObjectClass: Utility Statement
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UtilityStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UtilityStatement-2")]
    [System.Xml.Serialization.XmlRootAttribute("UtilityStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UtilityStatement-2", IsNullable=false)]
    public partial class UtilityStatementType : BaseDocument, IBaseDocument
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
        [System.Xml.Serialization.XmlElementAttribute("UtilityStatementTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
        public CodeType @__UtilityStatementTypeCode;
        
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
        [System.Xml.Serialization.XmlElementAttribute("DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
        public CodeType @__DocumentCurrencyCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
        public CodeType @__AccountingCostCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
        public TextType @__AccountingCost;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ParentDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=15)]
        public DocumentReferenceType @__ParentDocumentReference;
        
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
        [System.Xml.Serialization.XmlElementAttribute("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=18)]
        public PartyType @__SenderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=19)]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=20)]
        public CustomerPartyType @__CustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SubscriberParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=21)]
        public PartyType @__SubscriberParty;
        
        private System.Collections.Generic.List<OnAccountPaymentType> _mainOnAccountPayment;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("MainOnAccountPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=22)]
        public OnAccountPaymentType[] @__MainOnAccountPayment
        {
            get
            {
                return _mainOnAccountPayment?.ToArray();
            }
            set
            {
                _mainOnAccountPayment = value == null ? null : new System.Collections.Generic.List<OnAccountPaymentType>(value);
            }
        }
        
        private System.Collections.Generic.List<SubscriberConsumptionType> _subscriberConsumption;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SubscriberConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", Order=23)]
        public SubscriberConsumptionType[] @__SubscriberConsumption
        {
            get
            {
                return _subscriberConsumption?.ToArray();
            }
            set
            {
                _subscriberConsumption = value == null ? null : new System.Collections.Generic.List<SubscriberConsumptionType>(value);
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
        /// <para />DictionaryEntryName: Utility Statement. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        /// <example>Concerning account remark</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
            set { _note = value; }
        }

        
        /// <summary>
        /// A reference to an additional document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Additional_ Document Reference. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
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
        /// <para />DictionaryEntryName: Utility Statement. Signature
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
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
        /// A payment on an account.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Main_ On Account Payment. On Account Payment
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Main
        /// <para />PropertyTerm: On Account Payment
        /// <para />AssociatedObjectClass: On Account Payment
        /// <para />RepresentationTerm: On Account Payment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<OnAccountPaymentType> MainOnAccountPayment
        {
            get { return _mainOnAccountPayment ?? (_mainOnAccountPayment = new System.Collections.Generic.List<OnAccountPaymentType>()); }
            set { _mainOnAccountPayment = value; }
        }

        
        /// <summary>
        /// A utility statement for a particular consumption point.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Subscriber Consumption
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Subscriber Consumption
        /// <para />AssociatedObjectClass: Subscriber Consumption
        /// <para />RepresentationTerm: Subscriber Consumption
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<SubscriberConsumptionType> SubscriberConsumption
        {
            get { return _subscriberConsumption ?? (_subscriberConsumption = new System.Collections.Generic.List<SubscriberConsumptionType>()); }
            set { _subscriberConsumption = value; }
        }

        
        /// <summary>
        /// Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. UBL Version Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: UBL Version Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>2.0</example>
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
        /// <para />DictionaryEntryName: Utility Statement. Customization Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Customization Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>OIOUBL-2.02</example>
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
        /// <para />DictionaryEntryName: Utility Statement. Profile Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Profile Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>Reference-Utility-1.0</example>
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
        /// <para />DictionaryEntryName: Utility Statement. Profile Execution Identifier. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
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
        /// <para />DictionaryEntryName: Utility Statement. Identifier
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Identifier
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>61014906x-1</example>
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
        /// <para />DictionaryEntryName: Utility Statement. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
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
        /// <para />DictionaryEntryName: Utility Statement. UUID. Identifier
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: UUID
        /// <para />RepresentationTerm: Identifier
        /// <para />DataType: Identifier. Type
        /// </summary>
        /// <example>9756b4d0-8815-1029-857a-e388fe63f499</example>
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
        /// <para />DictionaryEntryName: Utility Statement. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        /// <example>2007-12-12</example>
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
        /// <para />DictionaryEntryName: Utility Statement. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        /// <example>12:32:56</example>
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
        /// A code signifying the type of Utility Statement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Utility Statement Type Code. Code
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Utility Statement Type Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        /// <example>Electricity</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType UtilityStatementTypeCode
        {
            get
            {
                if (__UtilityStatementTypeCode == null) { __UtilityStatementTypeCode = new CodeType(); }
                return __UtilityStatementTypeCode;
            }
            set
            {
                __UtilityStatementTypeCode = value;
            }
        }

        
        /// <summary>
        /// A code signifying the default currency for this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Document_ Currency Code. Code
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Document
        /// <para />PropertyTerm: Currency Code
        /// <para />RepresentationTerm: Code
        /// <para />DataTypeQualifier: Currency
        /// <para />DataType: Currency_ Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType DocumentCurrencyCode
        {
            get
            {
                if (__DocumentCurrencyCode == null) { __DocumentCurrencyCode = new CodeType(); }
                return __DocumentCurrencyCode;
            }
            set
            {
                __DocumentCurrencyCode = value;
            }
        }

        
        /// <summary>
        /// The buyer&apos;s accounting cost code, applied to the UtilityStatement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Accounting Cost Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Accounting Cost Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        /// <example>5050.0</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType AccountingCostCode
        {
            get
            {
                if (__AccountingCostCode == null) { __AccountingCostCode = new CodeType(); }
                return __AccountingCostCode;
            }
            set
            {
                __AccountingCostCode = value;
            }
        }

        
        /// <summary>
        /// The buyer&apos;s accounting cost code, applied to the UtilityStatement, expressed as text.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Accounting Cost. Text
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Accounting Cost
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TextType AccountingCost
        {
            get
            {
                if (__AccountingCost == null) { __AccountingCost = new TextType(); }
                return __AccountingCost;
            }
            set
            {
                __AccountingCost = value;
            }
        }

        
        /// <summary>
        /// A reference to the parent Invoice or Credit Note.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Parent_ Document Reference. Document Reference
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Parent
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType ParentDocumentReference
        {
            get
            {
                if (__ParentDocumentReference == null) { __ParentDocumentReference = new DocumentReferenceType(); }
                return __ParentDocumentReference;
            }
            set
            {
                __ParentDocumentReference = value;
            }
        }

        
        /// <summary>
        /// The party sending this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Sender_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Sender
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SenderParty
        {
            get
            {
                if (__SenderParty == null) { __SenderParty = new PartyType(); }
                return __SenderParty;
            }
            set
            {
                __SenderParty = value;
            }
        }

        
        /// <summary>
        /// The party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Receiver_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
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
        /// The buyer, if different from the receiver of the document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType CustomerParty
        {
            get
            {
                if (__CustomerParty == null) { __CustomerParty = new CustomerPartyType(); }
                return __CustomerParty;
            }
            set
            {
                __CustomerParty = value;
            }
        }

        
        /// <summary>
        /// The subscriber (user or receiver of the service), if different from the buyer and from the party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Subscriber_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Subscriber
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SubscriberParty
        {
            get
            {
                if (__SubscriberParty == null) { __SubscriberParty = new PartyType(); }
                return __SubscriberParty;
            }
            set
            {
                __SubscriberParty = value;
            }
        }

    }
}
