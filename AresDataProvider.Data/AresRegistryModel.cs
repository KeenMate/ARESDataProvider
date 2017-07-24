/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */

using System.Collections.Generic;
using System.Xml.Serialization;

namespace AresDataProvider.Data.CompanyRegister
{
	[XmlRoot(ElementName = "VH", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class VH
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string K { get; set; }
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string T { get; set; }
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
		[XmlElement(ElementName = "TV", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string TV { get; set; }
		[XmlElement(ElementName = "Typ_odkazu", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string Typ_odkazu { get; set; }
	}

	[XmlRoot(ElementName = "KKZ", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class KKZ
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string K { get; set; }
	}

	[XmlRoot(ElementName = "VY", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class VY
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string K { get; set; }
	}

	[XmlRoot(ElementName = "ZAM", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class ZAM
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string K { get; set; }
	}

	[XmlRoot(ElementName = "LI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class LI
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string K { get; set; }
	}

	[XmlRoot(ElementName = "S", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class S
	{
		[XmlElement(ElementName = "SSU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string SSU { get; set; }
		[XmlElement(ElementName = "KKZ", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public KKZ KKZ { get; set; }
		[XmlElement(ElementName = "VY", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public VY VY { get; set; }
		[XmlElement(ElementName = "ZAM", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public ZAM ZAM { get; set; }
		[XmlElement(ElementName = "LI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public LI LI { get; set; }
	}

	[XmlRoot(ElementName = "PFO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class PFO
	{
		[XmlElement(ElementName = "KPF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KPF { get; set; }
		[XmlElement(ElementName = "NPF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NPF { get; set; }
		[XmlElement(ElementName = "PFO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PFOCode { get; set; }
		[XmlElement(ElementName = "TZU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string TZU { get; set; }
	}

	[XmlRoot(ElementName = "SI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class SI
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
		[XmlElement(ElementName = "CA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string CA { get; set; }
	}

	[XmlRoot(ElementName = "ZAU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class ZAU
	{
		[XmlElement(ElementName = "S", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public S S { get; set; }
		[XmlElement(ElementName = "ICO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string ICO { get; set; }
		[XmlElement(ElementName = "OF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string OF { get; set; }
		[XmlElement(ElementName = "PFO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public PFO PFO { get; set; }
		[XmlElement(ElementName = "SI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public SI SI { get; set; }
		[XmlElement(ElementName = "DZOR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string DZOR { get; set; }
	}

	[XmlRoot(ElementName = "SD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class SD
	{
		[XmlElement(ElementName = "K", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string K { get; set; }
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string T { get; set; }
	}

	[XmlRoot(ElementName = "SZ", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class SZ
	{
		[XmlElement(ElementName = "SD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public SD SD { get; set; }
		[XmlElement(ElementName = "OV", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string OV { get; set; }
	}

	[XmlRoot(ElementName = "REG", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class REG
	{
		[XmlElement(ElementName = "SZ", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public SZ SZ { get; set; }
	}

	[XmlRoot(ElementName = "PP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class PP
	{
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public List<string> T { get; set; }
	}

	[XmlRoot(ElementName = "CIN", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class CIN
	{
		[XmlElement(ElementName = "PP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public PP PP { get; set; }
	}

	[XmlRoot(ElementName = "OSK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class OSK
	{
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string T { get; set; }
	}

	[XmlRoot(ElementName = "VK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class VK
	{
		[XmlElement(ElementName = "KC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KC { get; set; }
	}

	[XmlRoot(ElementName = "SPL", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class SPL
	{
		[XmlElement(ElementName = "PRC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PRC { get; set; }
	}

	[XmlRoot(ElementName = "ZA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class ZA
	{
		[XmlElement(ElementName = "VK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public VK VK { get; set; }
		[XmlElement(ElementName = "SPL", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public SPL SPL { get; set; }
	}

	[XmlRoot(ElementName = "EM", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class EM
	{
		[XmlElement(ElementName = "DA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string DA { get; set; }
		[XmlElement(ElementName = "H", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string H { get; set; }
		[XmlElement(ElementName = "Pocet", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string Pocet { get; set; }
	}

	[XmlRoot(ElementName = "E", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class E
	{
		[XmlElement(ElementName = "EK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string EK { get; set; }
		[XmlElement(ElementName = "ET", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string ET { get; set; }
	}

	[XmlRoot(ElementName = "Akcie", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class Akcie
	{
		[XmlElement(ElementName = "EM", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public EM EM { get; set; }
	}

	[XmlRoot(ElementName = "KAP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class KAP
	{
		[XmlElement(ElementName = "ZA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public ZA ZA { get; set; }
		[XmlElement(ElementName = "Akcie", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public Akcie Akcie { get; set; }
	}

	[XmlRoot(ElementName = "B", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class B
	{
		[XmlElement(ElementName = "IDA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string IDA { get; set; }
		[XmlElement(ElementName = "KS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KS { get; set; }
		[XmlElement(ElementName = "NS", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NS { get; set; }
		[XmlElement(ElementName = "N", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string N { get; set; }
		[XmlElement(ElementName = "NU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NU { get; set; }
		[XmlElement(ElementName = "PSC", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PSC { get; set; }
		[XmlElement(ElementName = "CA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string CA { get; set; }
		[XmlElement(ElementName = "NOK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NOK { get; set; }
		[XmlElement(ElementName = "CD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string CD { get; set; }
		[XmlElement(ElementName = "TCD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string TCD { get; set; }
		[XmlElement(ElementName = "NCO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string NCO { get; set; }
		[XmlElement(ElementName = "CO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string CO { get; set; }
	}

	[XmlRoot(ElementName = "FO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class FO
	{
		[XmlElement(ElementName = "J", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string J { get; set; }
		[XmlElement(ElementName = "P", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string P { get; set; }
		[XmlElement(ElementName = "DN", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string DN { get; set; }
		[XmlElement(ElementName = "B", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public B B { get; set; }
	}

	[XmlRoot(ElementName = "CLE", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class CLE
	{
		[XmlElement(ElementName = "DZA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string DZA { get; set; }
	}

	[XmlRoot(ElementName = "VF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class VF
	{
		[XmlElement(ElementName = "DZA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string DZA { get; set; }
	}

	[XmlRoot(ElementName = "C", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class C
	{
		[XmlElement(ElementName = "KAN", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KAN { get; set; }
		[XmlElement(ElementName = "F", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string F { get; set; }
		[XmlElement(ElementName = "FO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public FO FO { get; set; }
		[XmlElement(ElementName = "CLE", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public CLE CLE { get; set; }
		[XmlElement(ElementName = "VF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public VF VF { get; set; }
	}

	[XmlRoot(ElementName = "CSO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class CSO
	{
		[XmlElement(ElementName = "C", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public C C { get; set; }
	}

	[XmlRoot(ElementName = "SO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class SO
	{
		[XmlElement(ElementName = "CSO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public List<CSO> CSO { get; set; }
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string T { get; set; }
	}

	[XmlRoot(ElementName = "PRA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class PRA
	{
		[XmlElement(ElementName = "KAN", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KAN { get; set; }
		[XmlElement(ElementName = "FO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public FO FO { get; set; }
		[XmlElement(ElementName = "T", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string T { get; set; }
	}

	[XmlRoot(ElementName = "PRO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class PRO
	{
		[XmlElement(ElementName = "PRA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public List<PRA> PRA { get; set; }
	}

	[XmlRoot(ElementName = "CDR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class CDR
	{
		[XmlElement(ElementName = "C", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public C C { get; set; }
	}

	[XmlRoot(ElementName = "DR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class DR
	{
		[XmlElement(ElementName = "CDR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public List<CDR> CDR { get; set; }
	}

	[XmlRoot(ElementName = "PO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class PO
	{
		[XmlElement(ElementName = "OF", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string OF { get; set; }
		[XmlElement(ElementName = "SI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public SI SI { get; set; }
	}

	[XmlRoot(ElementName = "AKR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class AKR
	{
		[XmlElement(ElementName = "KAN", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string KAN { get; set; }
		[XmlElement(ElementName = "PO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public PO PO { get; set; }
	}

	[XmlRoot(ElementName = "AKI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class AKI
	{
		[XmlElement(ElementName = "AKR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public AKR AKR { get; set; }
	}

	[XmlRoot(ElementName = "Vypis_OR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
	public class Vypis_OR
	{
		[XmlElement(ElementName = "UVOD", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public UVOD UVOD { get; set; }
		[XmlElement(ElementName = "ZAU", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public ZAU ZAU { get; set; }
		[XmlElement(ElementName = "REG", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public REG REG { get; set; }
		[XmlElement(ElementName = "CIN", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public CIN CIN { get; set; }
		[XmlElement(ElementName = "OSK", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public List<OSK> OSK { get; set; }
		[XmlElement(ElementName = "KAP", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public KAP KAP { get; set; }
		[XmlElement(ElementName = "SO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public SO SO { get; set; }
		[XmlElement(ElementName = "PRO", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public PRO PRO { get; set; }
		[XmlElement(ElementName = "DR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public DR DR { get; set; }
		[XmlElement(ElementName = "AKI", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public AKI AKI { get; set; }
	}

	[XmlRoot(ElementName = "Odpoved", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_or/v_1.0.3")]
	public class Odpoved
	{
		[XmlElement(ElementName = "PID", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PID { get; set; }
		[XmlElement(ElementName = "VH", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public VH VH { get; set; }
		[XmlElement(ElementName = "E", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public E E { get; set; }
		[XmlElement(ElementName = "PZA", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public string PZA { get; set; }
		[XmlElement(ElementName = "Vypis_OR", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.3")]
		public Vypis_OR Vypis_OR { get; set; }
	}

	[XmlRoot(ElementName = "Ares_odpovedi", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_or/v_1.0.3")]
	public class Ares_odpovedi
	{
		[XmlElement(ElementName = "Odpoved", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_or/v_1.0.3")]
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
