/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/4/2024
 * Time: 5:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace teamGenr
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Team t = new Team(this.textBox1.Text,this.textBox2.Text,this.textBox3.Text,this.textBox4.Text,this.textBox5.Text,this.textBox6.Text,this.textBox7.Text,
			                 this.textBox8.Text,this.textBox9.Text,this.textBox10.Text,this.textBox11.Text,this.textBox12.Text,this.textBox13.Text,this.textBox14.Text,this.textBox15.Text);
			string sxml =  "<?xml version='1.0' encoding='UTF-8'?>";
			sxml += "<echipa>\r\n";
			sxml += "<denumire>"+t.Denumirea+"</denumire>"+"\r\n";
			sxml += "<tara>"+t.Tara+"</tara>"+"\r\n";
			sxml += "<judet>"+t.Judet+"</judet>"+"\r\n";
			sxml += "<federatia>"+t.Federatia+"</federatia>"+"\r\n";
			sxml += "<confederatia>"+t.Confederatia+"</confederatia>"+"\r\n";
			sxml += "<liga>"+t.Liga+"</liga>"+"\r\n";
			sxml += "<sezon>"+t.Sezonul+"</sezon>"+"\r\n";
			sxml += "<data>"+t.DataInfintarii+"</data>"+"\r\n";
			sxml += "<site>"+t.Site+"</site>"+"\r\n";
			sxml += "<fb>"+ t.FB+"</fb>"+"\r\n";
			sxml += "<insta>"+ t.Insta+"</insta>"+"\r\n";
			sxml += "<yt>"+t.YT+"</yt>"+"\r\n";
			sxml += "<email>"+t.Email+"</email>"+"\r\n";
			sxml += "<adresa>"+t.Adresa+"</adresa>"+"\r\n";
			sxml += "<altedate>"+ t.AlteDate+"</altedate>"+"\r\n";	
			sxml += "</echipa>\r\n";
			Clipboard.SetText(sxml);
			Text = "Control + V to paste from Clipboard XML file ";
		}
		
		/*
<?xml version='1.0' encoding='UTF-8'?>
<echipa>
<denumire>fchermannstadt</denumire>
<tara>romania</tara>
<judet>sibiu</judet>
<federatia>frf</federatia>
<confederatia>uefa</confederatia>
<liga>superliga</liga>
<sezon>2024-2025</sezon>
<data>2016</data>
<site>www.fchermannstadt.ro</site>
<fb>fchermannstadt</fb>
<insta>s</insta>
<yt>s</yt>
<email>s</email>
<adresa>alea m eminescu sibiu</adresa>
<altedate>s</altedate>
</echipa>


<?xml version='1.0' encoding='UTF-8'?><echipa>
<denumire>a</denumire>
<tara>b</tara>
<judet>c</judet>
<federatia>d</federatia>
<confederatia>e</confederatia>
<liga>f</liga>
<sezon>g</sezon>
<data>h</data>
<site>k</site>
<fb>l</fb>
<insta>m</insta>
<yt>n</yt>
<email>o</email>
<adresa>i</adresa>
<altedate>j</altedate>
</echipa>


		 */
		
		/*
Denumire textBox1
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
	}
}
