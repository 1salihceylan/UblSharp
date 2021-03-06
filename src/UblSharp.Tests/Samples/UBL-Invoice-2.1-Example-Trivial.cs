// Generated by UblSharp.Tests.Generator
using System;
using System.Collections.Generic;
using System.Xml;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using UblSharp.XmlDigitalSignature;
using UblSharp.Tests.Util;

namespace UblSharp.Tests.Samples
{
    internal class UBLInvoice21ExampleTrivial
    {
        public static InvoiceType Create()
        {
            var doc = new InvoiceType
            {
                ID = "123",
                IssueDate = "2011-09-22",
                InvoicePeriod = new List<PeriodType>()
                {
                    new PeriodType
                    {
                        StartDate = "2011-08-01",
                        EndDate = "2011-08-31"
                    }
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Custom Cotter Pins"
                            }
                        },
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "North American Veeblefetzer"
                            }
                        },
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    PayableAmount = new AmountType
                    {
                        currencyID = "CAD",
                        Value = 100.00M
                    }
                },
                InvoiceLine = new List<InvoiceLineType>()
                {
                    new InvoiceLineType
                    {
                        ID = "1",
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "CAD",
                            Value = 100.00M
                        },
                        Item = new ItemType
                        {
                            Description = new List<TextType>()
                            {
                                new TextType
                                {
                                    Value = "Cotter pin, MIL-SPEC"
                                }
                            },
                        }
                    }
                },
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
            });
            doc.UBLVersionID = null;
            return doc;
        }
    }
}
