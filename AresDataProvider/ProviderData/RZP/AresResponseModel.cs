/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace AresDataProvider.ProviderData.RZP
{
	[XmlRoot(ElementName = "VH", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class VH
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string K { get; set; }
	}

	[XmlRoot(ElementName = "UVOD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class UVOD
	{
		[XmlElement(ElementName = "ND", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string ND { get; set; }
		[XmlElement(ElementName = "ADB", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string ADB { get; set; }
		[XmlElement(ElementName = "DVY", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string DVY { get; set; }
		[XmlElement(ElementName = "CAS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string CAS { get; set; }
		[XmlElement(ElementName = "TV", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string TV { get; set; }
		[XmlElement(ElementName = "Typ_odkazu", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string Typ_odkazu { get; set; }
	}

	[XmlRoot(ElementName = "PF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class PF
	{
		[XmlElement(ElementName = "KPF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string KPF { get; set; }
		[XmlElement(ElementName = "NPF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string NPF { get; set; }
		[XmlElement(ElementName = "PFO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string PFO { get; set; }
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string T { get; set; }
	}

	[XmlRoot(ElementName = "ZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class ZU
	{
		[XmlElement(ElementName = "KZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string KZU { get; set; }
		[XmlElement(ElementName = "NZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string NZU { get; set; }
	}

	[XmlRoot(ElementName = "ZAU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class ZAU
	{
		[XmlElement(ElementName = "S", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string S { get; set; }
		[XmlElement(ElementName = "Datum_zmeny", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string Datum_zmeny { get; set; }
		[XmlElement(ElementName = "ICO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string ICO { get; set; }
		[XmlElement(ElementName = "OF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string OF { get; set; }
		[XmlElement(ElementName = "PF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public PF PF { get; set; }
		[XmlElement(ElementName = "ZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public ZU ZU { get; set; }
		[XmlElement(ElementName = "ZI1", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string ZI1 { get; set; }
		[XmlElement(ElementName = "Vsech_zivnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string Vsech_zivnosti { get; set; }
		[XmlElement(ElementName = "Aktivnich_zivnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string Aktivnich_zivnosti { get; set; }
		[XmlElement(ElementName = "Aktivnich_provozoven", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string Aktivnich_provozoven { get; set; }
	}

	[XmlRoot(ElementName = "A", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class A
	{
		[XmlElement(ElementName = "IDA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string IDA { get; set; }
		[XmlElement(ElementName = "N", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string N { get; set; }
		[XmlElement(ElementName = "NCO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string NCO { get; set; }
		[XmlElement(ElementName = "NU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string NU { get; set; }
		[XmlElement(ElementName = "CD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string CD { get; set; }
		[XmlElement(ElementName = "TCD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string TCD { get; set; }
		[XmlElement(ElementName = "CO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string CO { get; set; }
		[XmlElement(ElementName = "CA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string CA { get; set; }
		[XmlElement(ElementName = "PSC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string PSC { get; set; }
		[XmlAttribute(AttributeName = "kvadres")]
		public string Kvadres { get; set; }
	}

	[XmlRoot(ElementName = "Adresy", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class Adresy
	{
		[XmlElement(ElementName = "A", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public A A { get; set; }
	}

	[XmlRoot(ElementName = "B", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class B
	{
		[XmlElement(ElementName = "IDA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string IDA { get; set; }
		[XmlElement(ElementName = "N", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string N { get; set; }
		[XmlElement(ElementName = "NCO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string NCO { get; set; }
		[XmlElement(ElementName = "NU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string NU { get; set; }
		[XmlElement(ElementName = "CD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string CD { get; set; }
		[XmlElement(ElementName = "TCD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string TCD { get; set; }
		[XmlElement(ElementName = "PSC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string PSC { get; set; }
		[XmlElement(ElementName = "KS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string KS { get; set; }
		[XmlElement(ElementName = "NS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string NS { get; set; }
	}

	[XmlRoot(ElementName = "Osoba", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class Osoba
	{
		[XmlElement(ElementName = "Role", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string Role { get; set; }
		[XmlElement(ElementName = "J", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string J { get; set; }
		[XmlElement(ElementName = "P", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string P { get; set; }
		[XmlElement(ElementName = "DN", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string DN { get; set; }
		[XmlElement(ElementName = "TP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string TP { get; set; }
		[XmlElement(ElementName = "B", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public B B { get; set; }
	}

	[XmlRoot(ElementName = "Osoby", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class Osoby
	{
		[XmlElement(ElementName = "Osoba", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public List<Osoba> Osoba { get; set; }
	}

	[XmlRoot(ElementName = "Z", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class Z
	{
		[XmlElement(ElementName = "S", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string S { get; set; }
		[XmlElement(ElementName = "Druh", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string Druh { get; set; }
		[XmlElement(ElementName = "PP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string PP { get; set; }
		[XmlElement(ElementName = "Vznik", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string Vznik { get; set; }
		[XmlElement(ElementName = "Obory_cinnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public Obory_cinnosti Obory_cinnosti { get; set; }
	}

	[XmlRoot(ElementName = "Obor_cinnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class Obor_cinnosti
	{
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string T { get; set; }
	}

	[XmlRoot(ElementName = "Obory_cinnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class Obory_cinnosti
	{
		[XmlElement(ElementName = "Obor_cinnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public List<Obor_cinnosti> Obor_cinnosti { get; set; }
	}

	[XmlRoot(ElementName = "ZI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class ZI
	{
		[XmlElement(ElementName = "Z", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public Z Z { get; set; }
	}

	[XmlRoot(ElementName = "Vypis_RZP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
	public class Vypis_RZP
	{
		[XmlElement(ElementName = "ZAU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public ZAU ZAU { get; set; }
		[XmlElement(ElementName = "Adresy", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public Adresy Adresy { get; set; }
		[XmlElement(ElementName = "Osoby", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public Osoby Osoby { get; set; }
		[XmlElement(ElementName = "ZI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public ZI ZI { get; set; }
	}

	[XmlRoot(ElementName = "Odpoved", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_rzp/v_1.0.5")]
	public class Odpoved
	{
		[XmlElement(ElementName = "PID", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string PID { get; set; }
		[XmlElement(ElementName = "VH", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public VH VH { get; set; }
		[XmlElement(ElementName = "PZA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public string PZA { get; set; }
		[XmlElement(ElementName = "UVOD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public UVOD UVOD { get; set; }
		[XmlElement(ElementName = "Vypis_RZP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.5")]
		public Vypis_RZP Vypis_RZP { get; set; }
	}

	[XmlRoot(ElementName = "Ares_odpovedi", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_rzp/v_1.0.5")]
	public class Ares_odpovedi
	{
		[XmlElement(ElementName = "Odpoved", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_rzp/v_1.0.5")]
		public Odpoved Odpoved { get; set; }
		[XmlAttribute(AttributeName = "are", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Are { get; set; }
		[XmlAttribute(AttributeName = "D", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string D { get; set; }
		[XmlAttribute(AttributeName = "U", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string U { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "odpoved_datum_cas")]
		public string Odpoved_datum_cas { get; set; }
		[XmlAttribute(AttributeName = "odpoved_pocet")]
		public string Odpoved_pocet { get; set; }
		[XmlAttribute(AttributeName = "odpoved_typ")]
		public string Odpoved_typ { get; set; }
		[XmlAttribute(AttributeName = "vystup_format")]
		public string Vystup_format { get; set; }
		[XmlAttribute(AttributeName = "xslt")]
		public string Xslt { get; set; }
		[XmlAttribute(AttributeName = "validation_XSLT")]
		public string Validation_XSLT { get; set; }
		[XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
	}

}
