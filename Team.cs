/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/4/2024
 * Time: 5:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace teamGenr
{
	/// <summary>
	/// Description of Team.
	/// 	
	/*
Denumirea textBox1
Tara textBox2
Judet 3	
Federatia 4
Confederatia 5
Liga 6
Sezonul 7
Data infintarii 8

Site 9
FB 10
Insta 11
YT 12
Email 13

Adresa 14
Alte date 15
		 */
	/// </summary>
	public class Team
	{
		public string Denumirea;
		public string Tara;
		public string Judet;
		public string Federatia;
		public string Confederatia;
		public string Liga;
		public string Sezonul;
		public string DataInfintarii;
		public string Site;
		public string FB;
		public string Insta;
		public string YT;
		public string Email;
		public string Adresa;
		public string AlteDate;
		
		public Team()
		{
			
		}
		public Team(string den, string tara, string jud, string fed, string conf, string liga, string sez, string data, string site, string fb,string insta, string yt, string em, string adr, string ad)
		{
			this.Denumirea = den;
			this.Tara = tara;
			this.Judet = jud;
			this.Federatia = fed;
			this.Confederatia = conf;
			this.Liga = liga;
			this.Sezonul = sez;
			this.DataInfintarii = data;
			this.Site = site;
			this.FB = fb;
			this.Insta = insta;
			this.YT = yt;
			this.Email = em;
			this.Adresa = adr;
			this.AlteDate = ad;
		}
	}
}
