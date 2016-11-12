using System;

namespace Zenoti
{
	public class AppConstants
	{
		public static readonly string ELASTIC_SEARCH_URL = "http://paas:82159e72f07a8c377e7efe84f619886f@dori-us-east-1.searchly.com";
		public static readonly string ELASTIC_SEARCH_INDEX_NAME = "zenoti";
		public static readonly string ELASTIC_SEARCH_TYPE_BUSINESS = "business";
		public static readonly string ELASTIC_BUSINESS_NAME = "businessName";
		public static readonly string ELASTIC_BUSINESS_TYPE = "businessType";

		public static readonly string START = "start";
		public static readonly string SIZE = "size";
		public static readonly string BUSINESS_NAME = "business_name";
		public static readonly string BUSINESS_TYPE = "business_type";

		public static readonly int START_VALUE = 0;
		public static readonly int SIZE_VALUE = 10;

		public static readonly string INITIAL_DATA = @"[
		   {
		      ""BusinessName"":""Park Hyatt-spa"",
		      ""BusinessType"":""spa"",
		      ""link"":""https://hyderabad.park.hyatt.com/en/hotel/activities/hotel-activities/spa.html"",
		      ""address"":""Road Number 2, Sri Nagar Colony, Kamalapuri Colony, Banjara Hills, Hyderabad, Telangana 500073"",
		      ""rating"":4.5
		   },
		   {
		      ""BusinessName"":""O2 Spa"",
		      ""BusinessType"":""spa"",
		      ""link"":""https://www.o2spa.org/"",
		      ""address"":""3rd Floor, GVK One Mall, Road Number 1, Balapur Basthi, Banjara Hills, Hyderabad, Telangana 500034"",
		      ""rating"":3.0
		   },
		   {
		      ""BusinessName"":""O2 Spa Boulder Hill"",
		      ""BusinessType"":""spa"",
		      ""link"":""http://www.o2spa.org/locations/india/spa-in-hyderabad/boulder-hills-hyderbad/"",
		      ""address"":""Boulder Hills, Madhava Reddy Colony, Gachibowli, Hyderabad, Telangana 500032"",
		      ""rating"":3.2
		   },
		   {
		      ""BusinessName"":""Meghavi - Spa, Salon & O Cafe"",
		      ""BusinessType"":""spa"",
		      ""link"":""http://www.meghavispa.com/"",
		      ""address"":""34A Meghavi, MLA Colony, Road No : 12, Banjara Hills, Hyderabad, Telangana 500034"",
		      ""rating"":4.9
		   },
		   {
		      ""BusinessName"":""The 5th Element Spa"",
		      ""BusinessType"":""spa"",
		      ""link"":""http://www.thefifthelement.in/"",
		      ""address"":""259, Road No. 72, Dargha Road, Near Whisper Valley, Jubilee Hills, Film Nagar, Hyderabad, Telangana 500033"",
		      ""rating"":4.5
		   },
		   {
		      ""BusinessName"":""Sapphire Spa"",
		      ""BusinessType"":""spa"",
		      ""link"":""http://thesapphirespa.com/"",
		      ""address"":""Usha Jubilee Town Apartment, Road Number 36, Jubilee Hills, Opposite, Jubilee Hills Police Station, Hyderabad, Telangana 500033"",
		      ""rating"":3.5
		   },
		   {
		      ""BusinessName"":""Green Mint Spa"",
		      ""BusinessType"":""spa"",
		      ""link"":""https://greenmintspa.com/"",
		      ""address"":""26, Vahini nagar, Karkhana, Hyderabad, Telangana 500009"",
		      ""rating"":2.1
		   },
		   {
		      ""BusinessName"":""The Spa"",
		      ""BusinessType"":""spa"",
		      ""link"":""https://hyderabad.hyatthotels.hyatt.com/en/hotel/activities/hotel-activities/spa.html"",
		      ""address"":""Jayabheri Silicon Towers, Hitech City Rd, Financial District, Gachibowli, Hyderabad, Telangana 500032"",
		      ""rating"":4.6
		   },
		   {
		      ""BusinessName"":""Soul Spa & Salon"",
		      ""BusinessType"":""spa"",
		      ""link"":""http://www.welcometosoul.com/en/about.html"",
		      ""address"":""NBK Building, N.Vasundhara Devi, H.No 31&36 co-op hb Society Jubilee Hills, Jubilee Hills, Hyderabad, Telangana 500033"",
		      ""rating"":4.3
		   },
		   {
		      ""BusinessName"":""Opium Spa"",
		      ""BusinessType"":""spa"",
		      ""link"":""http://opiumspa.com/"",
		      ""address"":""Shop No. 1, Ground Floor, City Center Mall, Road No. 1, Banjarahills, Hyderabad, Telangana 500034"",
		      ""rating"":3.9
		   },
		   {
		      ""BusinessName"":""Pink Ladies Gym Ameerpet"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""http://pinkfitness.in/ameerpet"",
		      ""address"":""7-1-71/H, Divya Shakthi Apartment, Dharam Karam Road, Kalyan Nagar Phase 1, Ameerpet, Hyderabad, Telangana 500016"",
		      ""rating"":3.5
		   },
		   {
		      ""BusinessName"":""Fitness ONE"",
		      ""BusinessType"":""firness center"",
		      ""link"":""http://fitnessone.in/kondapur/"",
		      ""address"":""Plot No. 5, Park View Building, 2nd Floor, Above Heritage Fresh, Opp, Botanical Garden Road, Venkat Enclave, Whitefields, Kondapur, Hyderabad, Telangana 500084"",
		      ""rating"":3.1
		   },
		   {
		      ""BusinessName"":""Ozone Fitness & Spa"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""http://www.ozoneclubs.com/home.php"",
		      ""address"":""No. 6-3-349/20, Banjara Hills, Road No. 1, Hyderabad, Telangana 500034"",
		      ""rating"":3.5
		   },
		   {
		      ""BusinessName"":""Cloud Fitness | GYMS"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""http://www.thecloudfitness.com/"",
		      ""address"":""Opposite Gachhibowli Road, The Platina, Jayabheri Enclave, Gachibowli, Hyderabad, Telangana 500032"",
		      ""rating"":4.3
		   },
		   {
		      ""BusinessName"":""The Stallions Gym"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""http://www.stallionsgym.com/"",
		      ""address"":""No. 1-98/11/12, 2nd Floor, Above Corporaton Bank, Behind Vodafone Showroom, Madhapur, Hyderabad, Telangana 500081"",
		      ""rating"":4.5
		   },
		   {
		      ""BusinessName"":""Potens Fitness"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""https://potens.in/"",
		      ""address"":""Plot No. 2, Adjacent to InOrbit Mall, Durgamma Cheruvu Rd, Vittal Rao Nagar, Hitech City, Madhapur, Hyderabad, Telangana 500081"",
		      ""rating"":4.6
		   },
		   {
		      ""BusinessName"":""Steel Gym"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""http://www.steelgym.in/"",
		      ""address"":""1355, Neharika Jubilee One, Jubilee Hills Road No.1 and Road.45 Junction,, Adjacent to HDFC bank, Hyderabad, Telangana 500033"",
		      ""rating"":4.4
		   },
		   {
		      ""BusinessName"":""Lions MMA, Mixed Martial Arts & Fitness Center"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""http://tamma.in/"",
		      ""address"":""# 8-1-35/A/21 Movie Planet Building,, Near Galaxy Theatre, Above Movie Planet 5th Floor, Hyderabad, Telangana 500008"",
		      ""rating"":3.2
		   },
		   {
		      ""BusinessName"":""Speed fitness gym"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""https://www.facebook.com/speedfitnesskphb/?ref=aymt_homepage_panel"",
		      ""address"":""plot no.3/A, Phase-5, surya enclave, opp Brand Factory Rd, Kukatpally, Hyderabad, Telangana 500072"",
		      ""rating"":4.9
		   },
		   {
		      ""BusinessName"":""Anytime Fitness"",
		      ""BusinessType"":""fitness center"",
		      ""link"":""http://www.anytimefitness.co.in/gyms/IN-1005/hyderabad-andhra-pradesh-500033"",
		      ""address"":""Plot No. 71, Road No. 1 & 9, Besides TV 5 Office, Jubilee Hills, Hyderabad, Telangana 500033"",
		      ""rating"":4.4
		   },
		   {
		      ""BusinessName"":""Mirrors"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://mirrorsspaandsalon.com/"",
		      ""address"":""Plot No.66, Park View Enclave, Road No.1, Jubilee HIlls, Hyderabad, Telangana 500033"",
		      ""rating"":4.3
		   },
		   {
		      ""BusinessName"":""Bubbles Hair & Beauty - Jubilee Hills"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://bubblesindia.com/"",
		      ""address"":""Plot No 21B, Journalist Colony \""B\"", Opp.KBR Park, Jubilee Hills, Hyderabad, Telangana 500033"",
		      ""rating"":3.6
		   },
		   {
		      ""BusinessName"":""Lucas Academy & Salon"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://www.lucassalon.com/"",
		      ""address"":""4th Floor, Fortune Atrium, Road No. 36, Jubilee Hills, Opp. Chutneys, Hyderabad, Telangana 500033"",
		      ""rating"":4.2
		   },
		   {
		      ""BusinessName"":""Envi Salon & Spa"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://www.envisalon.in/"",
		      ""address"":""No. 8-2-684/3/162, Road No. 12, Banjara Hills, Hyderabad, Telangana 500034"",
		      ""rating"":4.4
		   },
		   {
		      ""BusinessName"":""Manea the salon-manea.in"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://www.manea.in/"",
		      ""address"":""No. 8-2-120/112, 1st Floor, Park View Estate, Road No. 2, Banjara Hills, Hyderabad, Telangana 500034"",
		      ""rating"":3.7
		   },
		   {
		      ""BusinessName"":""Manea The Salon"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://www.manea.in/"",
		      ""address"":""No. 1-98/7/2/5A, 1st Floor, Above Karachi Bakery, Madhapur, Hyderabad, Telangana 500071"",
		      ""rating"":3.9
		   },
		   {
		      ""BusinessName"":""Lakme Salon"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://www.lakmeindia.com/"",
		      ""address"":""No. 16-11-477/6/1, First Floor, RD Towers, Dilsukhnagar Main Road, Dilsukhnagar, Beside Bajaj Electronics, Hyderabad, Telangana 500060"",
		      ""rating"":3.2
		   },
		   {
		      ""BusinessName"":""Bubbles Hair & Beauty - Orange County"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://bubblesindia.com/"",
		      ""address"":""Financial District, Nanakram Guda, Hyderabad, Telangana 500032"",
		      ""rating"":3.2
		   },
		   {
		      ""BusinessName"":""Paris De Salon"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://parisdesalon.com/"",
		      ""address"":""#286/A Opp. KBR Park, Road # 12. MLA Colony, -500034"",
		      ""rating"":4.4
		   },
		   {
		      ""BusinessName"":""Naturals Family Salon & Spa"",
		      ""BusinessType"":""salon"",
		      ""link"":""http://www.naturals.in/"",
		      ""address"":""Plot No. 9&10, 1st Floor, Indira SNR Plaza, HUDA Colony, Gangaram, Chandanagar, Church Rd, Hyderabad, 500050"",
		      ""rating"":2.0
		   }
		]";
	}
}

