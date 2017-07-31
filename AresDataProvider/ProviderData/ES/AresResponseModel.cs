/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */

using System.Collections.Generic;
using System.Xml.Serialization;

// ES Ares answer

namespace AresDataProvider.ProviderData.ES
{
	[XmlRoot(ElementName = "S", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
	public class S
	{
		[XmlElement(ElementName = "ico", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Ico { get; set; }
		[XmlElement(ElementName = "pf", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Pf { get; set; }
		[XmlElement(ElementName = "ojm", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Ojm { get; set; }
		[XmlElement(ElementName = "jmn", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Jmn { get; set; }
		[XmlElement(ElementName = "or", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Or { get; set; }
		[XmlElement(ElementName = "res", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Res { get; set; }
		[XmlElement(ElementName = "rzp", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Rzp { get; set; }
		[XmlElement(ElementName = "dph", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Dph { get; set; }
		[XmlElement(ElementName = "p_dph", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string P_dph { get; set; }
		[XmlElement(ElementName = "cedr", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Cedr { get; set; }
		[XmlElement(ElementName = "p_cedr", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string P_cedr { get; set; }
		[XmlElement(ElementName = "ros", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Ros { get; set; }
	}

	[XmlRoot(ElementName = "V", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
	public class V
	{
		[XmlElement(ElementName = "S", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public List<S> S { get; set; }
	}

	[XmlRoot(ElementName = "Help", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
	public class Help
	{
		[XmlElement(ElementName = "R", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public List<string> R { get; set; }
	}

	[XmlRoot(ElementName = "Odpoved", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_es/v_1.0.0")]
	public class Odpoved
	{
		[XmlElement(ElementName = "Help", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public Help Help { get; set; }
		[XmlElement(ElementName = "V", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public V V { get; set; }
		[XmlElement(ElementName = "Pocet_zaznamu", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_datatypes/v_1.0.4")]
		public string Pocet_zaznamu { get; set; }
	}

	[XmlRoot(ElementName = "Ares_odpovedi", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_es/v_1.0.0")]
	public class Ares_odpovedi
	{
		[XmlElement(ElementName = "Odpoved", Namespace = "http://wwwinfo.mfcr.cz/ares/xml_doc/schemas/ares/ares_answer_es/v_1.0.0")]
		public Odpoved Odpoved { get; set; }
		[XmlAttribute(AttributeName = "are", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Are { get; set; }
		[XmlAttribute(AttributeName = "dtt", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Dtt { get; set; }
		[XmlAttribute(AttributeName = "udt", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Udt { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "vystup_format")]
		public string Vystup_format { get; set; }
		[XmlAttribute(AttributeName = "odpoved_typ")]
		public string Odpoved_typ { get; set; }
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName = "odpoved_datum_cas")]
		public string Odpoved_datum_cas { get; set; }
		[XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation { get; set; }
	}

}
