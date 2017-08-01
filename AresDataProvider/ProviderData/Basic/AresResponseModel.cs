/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace AresDataProvider.ProviderData.Basic
{
	[XmlRoot(ElementName = "VH", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class VH
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string K { get; set; }
	}

	[XmlRoot(ElementName = "E", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class E
	{
		[XmlElement(ElementName = "EK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string EK { get; set; }
		[XmlElement(ElementName = "ET", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string ET { get; set; }
	}

	[XmlRoot(ElementName = "UVOD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class UVOD
	{
		[XmlElement(ElementName = "ND", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string ND { get; set; }
		[XmlElement(ElementName = "ADB", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string ADB { get; set; }
		[XmlElement(ElementName = "DVY", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string DVY { get; set; }
		[XmlElement(ElementName = "CAS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string CAS { get; set; }
		[XmlElement(ElementName = "Typ_odkazu", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string Typ_odkazu { get; set; }
	}

	[XmlRoot(ElementName = "ICO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class ICO
	{
		[XmlAttribute(AttributeName = "zdroj")]
		public string Zdroj { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "OF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class OF
	{
		[XmlAttribute(AttributeName = "zdroj")]
		public string Zdroj { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "PF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class PF
	{
		[XmlElement(ElementName = "KPF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KPF { get; set; }
		[XmlElement(ElementName = "NPF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NPF { get; set; }
		[XmlAttribute(AttributeName = "zdroj")]
		public string Zdroj { get; set; }
	}

	[XmlRoot(ElementName = "AD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class AD
	{
		[XmlElement(ElementName = "UC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string UC { get; set; }
		[XmlElement(ElementName = "PB", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PB { get; set; }
		[XmlAttribute(AttributeName = "zdroj")]
		public string Zdroj { get; set; }
	}

	[XmlRoot(ElementName = "AU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class AU
	{
		[XmlElement(ElementName = "KOL", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KOL { get; set; }
		[XmlElement(ElementName = "KK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KK { get; set; }
		[XmlElement(ElementName = "KOK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KOK { get; set; }
		[XmlElement(ElementName = "KO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KO { get; set; }
		[XmlElement(ElementName = "KCO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KCO { get; set; }
		[XmlElement(ElementName = "KMC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KMC { get; set; }
		[XmlElement(ElementName = "PSC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string PSC { get; set; }
		[XmlElement(ElementName = "KUL", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KUL { get; set; }
		[XmlElement(ElementName = "CD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string CD { get; set; }
		[XmlElement(ElementName = "TCD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string TCD { get; set; }
		[XmlElement(ElementName = "CO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string CO { get; set; }
		[XmlElement(ElementName = "KA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KA { get; set; }
		[XmlElement(ElementName = "KOB", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/uvis_datatypes/v_1.0.3")]
		public string KOB { get; set; }
	}

	[XmlRoot(ElementName = "AA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class AA
	{
		[XmlElement(ElementName = "IDA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string IDA { get; set; }
		[XmlElement(ElementName = "KS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KS { get; set; }
		[XmlElement(ElementName = "NS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NS { get; set; }
		[XmlElement(ElementName = "NOK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NOK { get; set; }
		[XmlElement(ElementName = "N", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string N { get; set; }
		[XmlElement(ElementName = "NCO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NCO { get; set; }
		[XmlElement(ElementName = "NMC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NMC { get; set; }
		[XmlElement(ElementName = "NU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NU { get; set; }
		[XmlElement(ElementName = "CD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string CD { get; set; }
		[XmlElement(ElementName = "TCD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string TCD { get; set; }
		[XmlElement(ElementName = "CO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string CO { get; set; }
		[XmlElement(ElementName = "PSC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PSC { get; set; }
		[XmlElement(ElementName = "AU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public AU AU { get; set; }
		[XmlAttribute(AttributeName = "zdroj")]
		public string Zdroj { get; set; }
	}

	[XmlRoot(ElementName = "ZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class ZU
	{
		[XmlElement(ElementName = "KZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KZU { get; set; }
		[XmlElement(ElementName = "NZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NZU { get; set; }
	}

	[XmlRoot(ElementName = "FU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class FU
	{
		[XmlElement(ElementName = "KFU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KFU { get; set; }
		[XmlElement(ElementName = "NFU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NFU { get; set; }
	}

	[XmlRoot(ElementName = "RRZ", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class RRZ
	{
		[XmlElement(ElementName = "ZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public ZU ZU { get; set; }
		[XmlElement(ElementName = "FU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public FU FU { get; set; }
	}

	[XmlRoot(ElementName = "KPP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class KPP
	{
		[XmlAttribute(AttributeName = "zdroj")]
		public string Zdroj { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "PP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class PP
	{
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string T { get; set; }
		[XmlAttribute(AttributeName = "zdroj")]
		public string Zdroj { get; set; }
	}

	[XmlRoot(ElementName = "PPI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class PPI
	{
		[XmlElement(ElementName = "PP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public PP PP { get; set; }
	}

	[XmlRoot(ElementName = "Obor_cinnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class Obor_cinnosti
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string K { get; set; }
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string T { get; set; }
	}

	[XmlRoot(ElementName = "Obory_cinnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class Obory_cinnosti
	{
		[XmlElement(ElementName = "Obor_cinnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public List<Obor_cinnosti> Obor_cinnosti { get; set; }
	}

	[XmlRoot(ElementName = "VBAS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class VBAS
	{
		[XmlElement(ElementName = "ICO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public ICO ICO { get; set; }
		[XmlElement(ElementName = "OF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public OF OF { get; set; }
		[XmlElement(ElementName = "DV", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string DV { get; set; }
		[XmlElement(ElementName = "PF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public PF PF { get; set; }
		[XmlElement(ElementName = "AD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public AD AD { get; set; }
		[XmlElement(ElementName = "AA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public AA AA { get; set; }
		[XmlElement(ElementName = "PSU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PSU { get; set; }
		[XmlElement(ElementName = "RRZ", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public RRZ RRZ { get; set; }
		[XmlElement(ElementName = "KPP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public KPP KPP { get; set; }
		[XmlElement(ElementName = "PPI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public PPI PPI { get; set; }
		[XmlElement(ElementName = "Obory_cinnosti", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public Obory_cinnosti Obory_cinnosti { get; set; }
	}

	[XmlRoot(ElementName = "Odpoved", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_basic/v_1.0.3")]
	public class Odpoved
	{
		[XmlElement(ElementName = "PID", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PID { get; set; }
		[XmlElement(ElementName = "E", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public E E { get; set; }
		[XmlElement(ElementName = "VH", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public VH VH { get; set; }
		[XmlElement(ElementName = "PZA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PZA { get; set; }
		[XmlElement(ElementName = "UVOD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public UVOD UVOD { get; set; }
		[XmlElement(ElementName = "VBAS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public VBAS VBAS { get; set; }
	}

	[XmlRoot(ElementName = "Ares_odpovedi", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_basic/v_1.0.3")]
	public class Ares_odpovedi
	{
		[XmlElement(ElementName = "Odpoved", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_basic/v_1.0.3")]
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
