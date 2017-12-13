using System;
using System.Collections.Generic;
using System.Linq;

namespace MapsDistanceMatrix.Buzzi
{
    public class BuzziFormatAddress
    {
        public BuzziFormatAddress(string line1, string line2, string line3, string line4, string city, string state, string postalCode, string country)
        {
            Line1 = line1;
            Line2 = line2;
            Line3 = line3;
            Line4 = line4;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        public string Line1 { get; }

        public string Line2 { get; }

        public string Line3 { get; }

        public string Line4 { get; }

        public string City { get; }

        public string State { get; }

        public string PostalCode { get; }

        public string Country { get; }

        public override string ToString()
        {
            return ApiRequestFormat;
        }

        public string ApiRequestFormat
        {
            get
            {
                const string delimiter = ",";
                string[] addressElements = {Line1, Line2, Line3, Line4, City, State, PostalCode, Country};
                return string.Join(delimiter, from string s in addressElements where !string.IsNullOrWhiteSpace(s) select s);
            }
        }

        protected bool Equals(BuzziFormatAddress other)
        {
            return 
                string.Equals(Line1, other.Line1) &&
                string.Equals(Line2, other.Line2) && 
                string.Equals(Line3, other.Line3) && 
                string.Equals(Line4, other.Line4) && 
                string.Equals(City, other.City) && 
                string.Equals(State, other.State) && 
                string.Equals(PostalCode, other.PostalCode) && 
                string.Equals(Country, other.Country);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Line1 != null ? Line1.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Line2 != null ? Line2.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Line3 != null ? Line3.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Line4 != null ? Line4.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (City != null ? City.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (State != null ? State.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PostalCode != null ? PostalCode.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Country != null ? Country.GetHashCode() : 0);
                return hashCode;
            }
        }

        #region List<BuzziFormatAddress> Generator

        public static List<BuzziFormatAddress> GetRandomAddresses(int count)
        {
            count = Math.Max(0, count);
            return (from BuzziFormatAddress b in Addresses orderby Guid.NewGuid() select b).Take(count).ToList();
        }

        public static readonly List<BuzziFormatAddress> Addresses = new List<BuzziFormatAddress>
        {
            new BuzziFormatAddress("777 Brockton Avenue", null, null, null, "Abington", "MA", "02351", "USA"),
            new BuzziFormatAddress("30 Memorial Drive", null, null, null, "Avon", "MA", "02322", "USA"),
            new BuzziFormatAddress("250 Hartford Avenue", null, null, null, "Bellingham", "MA", "02019", "USA"),
            new BuzziFormatAddress("700 Oak Street", null, null, null, "Brockton", "MA", "02301", "USA"),
            new BuzziFormatAddress("66-4 Parkhurst Rd", null, null, null, "Chelmsford", "MA", "01824", "USA"),
            new BuzziFormatAddress("591 Memorial Dr", null, null, null, "Chicopee", "MA", "01020", "USA"),
            new BuzziFormatAddress("55 Brooksby Village Way", null, null, null, "Danvers", "MA", "01923", "USA"),
            new BuzziFormatAddress("42 Fairhaven Commons Way", null, null, null, "Fairhaven", "MA", "02719", "USA"),
            new BuzziFormatAddress("121 Worcester Rd", null, null, null, "Framingham", "MA", "01701", "USA"),
            new BuzziFormatAddress("677 Timpany Blvd", null, null, null, "Gardner", "MA", "01440", "USA"),
            new BuzziFormatAddress("337 Russell St", null, null, null, "Hadley", "MA", "01035", "USA"),
            new BuzziFormatAddress("295 Plymouth Street", null, null, null, "Halifax", "MA", "02338", "USA"),
            new BuzziFormatAddress("1775 Washington St", null, null, null, "Hanover", "MA", "02339", "USA"),
            new BuzziFormatAddress("280 Washington Street", null, null, null, "Hudson", "MA", "01749", "USA"),
            new BuzziFormatAddress("20 Soojian Dr", null, null, null, "Leicester", "MA", "01524", "USA"),
            new BuzziFormatAddress("11 Jungle Road", null, null, null, "Leominster", "MA", "01453", "USA"),
            new BuzziFormatAddress("301 Massachusetts Ave", null, null, null, "Lunenburg", "MA", "01462", "USA"),
            new BuzziFormatAddress("780 Lynnway", null, null, null, "Lynn", "MA", "01905", "USA"),
            new BuzziFormatAddress("70 Pleasant Valley Street", null, null, null, "Methuen", "MA", "01844", "USA"),
            new BuzziFormatAddress("200 Otis Street", null, null, null, "Northborough", "MA", "01532", "USA"),
            new BuzziFormatAddress("180 North King Street", null, null, null, "Northhampton", "MA", "01060", "USA"),
            new BuzziFormatAddress("555 East Main St", null, null, null, "Orange", "MA", "01364", "USA"),
            new BuzziFormatAddress("555 Hubbard Ave-Suite 12", null, null, null, "Pittsfield", "MA", "01201", "USA"),
            new BuzziFormatAddress("300 Colony Place", null, null, null, "Plymouth", "MA", "02360", "USA"),
            new BuzziFormatAddress("301 Falls Blvd", null, null, null, "Quincy", "MA", "02169", "USA"),
            new BuzziFormatAddress("36 Paramount Drive", null, null, null, "Raynham", "MA", "02767", "USA"),
            new BuzziFormatAddress("450 Highland Ave", null, null, null, "Salem", "MA", "01970", "USA"),
            new BuzziFormatAddress("1180 Fall River Avenue", null, null, null, "Seekonk", "MA", "02771", "USA"),
            new BuzziFormatAddress("1105 Boston Road", null, null, null, "Springfield", "MA", "01119", "USA"),
            new BuzziFormatAddress("100 Charlton Road", null, null, null, "Sturbridge", "MA", "01566", "USA"),
            new BuzziFormatAddress("262 Swansea Mall Dr", null, null, null, "Swansea", "MA", "02777", "USA"),
            new BuzziFormatAddress("333 Main Street", null, null, null, "Tewksbury", "MA", "01876", "USA"),
            new BuzziFormatAddress("550 Providence Hwy", null, null, null, "Walpole", "MA", "02081", "USA"),
            new BuzziFormatAddress("352 Palmer Road", null, null, null, "Ware", "MA", "01082", "USA"),
            new BuzziFormatAddress("3005 Cranberry Hwy Rt 6 28", null, null, null, "Wareham", "MA", "02538", "USA"),
            new BuzziFormatAddress("250 Rt 59", null, null, null, "Airmont", "NY", "10901", "USA"),
            new BuzziFormatAddress("141 Washington Ave Extension", null, null, null, "Albany", "NY", "12205", "USA"),
            new BuzziFormatAddress("13858 Rt 31 W", null, null, null, "Albion", "NY", "14411", "USA"),
            new BuzziFormatAddress("2055 Niagara Falls Blvd", null, null, null, "Amherst", "NY", "14228", "USA"),
            new BuzziFormatAddress("101 Sanford Farm Shpg Center", null, null, null, "Amsterdam", "NY", "12010", "USA"),
            new BuzziFormatAddress("297 Grant Avenue", null, null, null, "Auburn", "NY", "13021", "USA"),
            new BuzziFormatAddress("4133 Veterans Memorial Drive", null, null, null, "Batavia", "NY", "14020", "USA"),
            new BuzziFormatAddress("6265 Brockport Spencerport Rd", null, null, null, "Brockport", "NY", "14420", "USA"),
            new BuzziFormatAddress("5399 W Genesse St", null, null, null, "Camillus", "NY", "13031", "USA"),
            new BuzziFormatAddress("3191 County rd 10", null, null, null, "Canandaigua", "NY", "14424", "USA"),
            new BuzziFormatAddress("30 Catskill", null, null, null, "Catskill", "NY", "12414", "USA"),
            new BuzziFormatAddress("161 Centereach Mall", null, null, null, "Centereach", "NY", "11720", "USA"),
            new BuzziFormatAddress("100 Thruway Plaza", null, null, null, "Cheektowaga", "NY", "14225", "USA"),
            new BuzziFormatAddress("8064 Brewerton Rd", null, null, null, "Cicero", "NY", "13039", "USA"),
            new BuzziFormatAddress("5033 Transit Road", null, null, null, "Clarence", "NY", "14031", "USA"),
            new BuzziFormatAddress("3949 Route 31", null, null, null, "Clay", "NY", "13041", "USA"),
            new BuzziFormatAddress("139 Merchant Place", null, null, null, "Cobleskill", "NY", "12043", "USA"),
            new BuzziFormatAddress("85 Crooked Hill Road", null, null, null, "Commack", "NY", "11725", "USA"),
            new BuzziFormatAddress("872 Route 13", null, null, null, "Cortlandville", "NY", "13045", "USA"),
            new BuzziFormatAddress("901 Route 110", null, null, null, "Farmingdale", "NY", "11735", "USA"),
            new BuzziFormatAddress("2400 Route 9", null, null, null, "Fishkill", "NY", "12524", "USA"),
            new BuzziFormatAddress("10401 Bennett Road", null, null, null, "Fredonia", "NY", "14063", "USA"),
            new BuzziFormatAddress("1818 State Route 3", null, null, null, "Fulton", "NY", "13069", "USA"),
            new BuzziFormatAddress("4300 Lakeville Road", null, null, null, "Geneseo", "NY", "14454", "USA"),
            new BuzziFormatAddress("990 Route 5 20", null, null, null, "Geneva", "NY", "14456", "USA"),
            new BuzziFormatAddress("311 RT 9W", null, null, null, "Glenmont", "NY", "12077", "USA"),
            new BuzziFormatAddress("200 Dutch Meadows Ln", null, null, null, "Glenville", "NY", "12302", "USA"),
            new BuzziFormatAddress("100 Elm Ridge Center Dr", null, null, null, "Greece", "NY", "14626", "USA"),
            new BuzziFormatAddress("1549 Rt 9", null, null, null, "Halfmoon", "NY", "12065", "USA"),
            new BuzziFormatAddress("5360 Southwestern Blvd", null, null, null, "Hamburg", "NY", "14075", "USA"),
            new BuzziFormatAddress("103 North Caroline St", null, null, null, "Herkimer", "NY", "13350", "USA"),
            new BuzziFormatAddress("1000 State Route 36", null, null, null, "Hornell", "NY", "14843", "USA"),
            new BuzziFormatAddress("1400 County Rd 64", null, null, null, "Horseheads", "NY", "14845", "USA"),
            new BuzziFormatAddress("135 Fairgrounds Memorial Pkwy", null, null, null, "Ithaca", "NY", "14850", "USA"),
            new BuzziFormatAddress("233 5th Ave Ext", null, null, null, "Johnstown", "NY", "12095", "USA"),
            new BuzziFormatAddress("601 Frank Stottile Blvd", null, null, null, "Kingston", "NY", "12401", "USA"),
            new BuzziFormatAddress("350 E Fairmount Ave", null, null, null, "Lakewood", "NY", "14750", "USA"),
            new BuzziFormatAddress("4975 Transit Rd", null, null, null, "Lancaster", "NY", "14086", "USA"),
            new BuzziFormatAddress("579 Troy-Schenectady Road", null, null, null, "Latham", "NY", "12110", "USA"),
            new BuzziFormatAddress("5783 So Transit Road", null, null, null, "Lockport", "NY", "14094", "USA"),
            new BuzziFormatAddress("7155 State Rt 12 S", null, null, null, "Lowville", "NY", "13367", "USA"),
            new BuzziFormatAddress("425 Route 31", null, null, null, "Macedon", "NY", "14502", "USA"),
            new BuzziFormatAddress("3222 State Rt 11", null, null, null, "Malone", "NY", "12953", "USA"),
            new BuzziFormatAddress("200 Sunrise Mall", null, null, null, "Massapequa", "NY", "11758", "USA"),
            new BuzziFormatAddress("43 Stephenville St", null, null, null, "Massena", "NY", "13662", "USA"),
            new BuzziFormatAddress("470 Route 211 East", null, null, null, "Middletown", "NY", "10940", "USA"),
            new BuzziFormatAddress("288 Larkin", null, null, null, "Monroe", "NY", "10950", "USA"),
            new BuzziFormatAddress("41 Anawana Lake Road", null, null, null, "Monticello", "NY", "12701", "USA"),
            new BuzziFormatAddress("1201 Rt 300", null, null, null, "Newburgh", "NY", "12550", "USA"),
            new BuzziFormatAddress("255 W Main St", null, null, null, "Avon", "CT", "06001", "USA"),
            new BuzziFormatAddress("120 Commercial Parkway", null, null, null, "Branford", "CT", "06405", "USA"),
            new BuzziFormatAddress("1400 Farmington Ave", null, null, null, "Bristol", "CT", "06010", "USA"),
            new BuzziFormatAddress("161 Berlin Road", null, null, null, "Cromwell", "CT", "06416", "USA"),
            new BuzziFormatAddress("67 Newton Rd", null, null, null, "Danbury", "CT", "06810", "USA"),
            new BuzziFormatAddress("656 New Haven Ave", null, null, null, "Derby", "CT", "06418", "USA"),
            new BuzziFormatAddress("150 Gold Star Hwy", null, null, null, "Groton", "CT", "06340", "USA"),
            new BuzziFormatAddress("900 Boston Post Road", null, null, null, "Guilford", "CT", "06437", "USA"),
            new BuzziFormatAddress("2300 Dixwell Ave", null, null, null, "Hamden", "CT", "06514", "USA"),
            new BuzziFormatAddress("495 Flatbush Ave", null, null, null, "Hartford", "CT", "06106", "USA"),
            new BuzziFormatAddress("180 River Rd", null, null, null, "Lisbon", "CT", "06351", "USA"),
            new BuzziFormatAddress("420 Buckland Hills Dr", null, null, null, "Manchester", "CT", "06040", "USA"),
            new BuzziFormatAddress("1365 Boston Post Road", null, null, null, "Milford", "CT", "06460", "USA"),
            new BuzziFormatAddress("1100 New Haven Road", null, null, null, "Naugatuck", "CT", "06770", "USA"),
            new BuzziFormatAddress("3164 Berlin Turnpike", null, null, null, "Newington", "CT", "06111", "USA"),
            new BuzziFormatAddress("650 Main Ave", null, null, null, "Norwalk", "CT", "06851", "USA"),
            new BuzziFormatAddress("680 Connecticut Avenue", null, null, null, "Norwalk", "CT", "06854", "USA"),
            new BuzziFormatAddress("220 Salem Turnpike", null, null, null, "Norwich", "CT", "06360", "USA"),
            new BuzziFormatAddress("625 School Street", null, null, null, "Putnam", "CT", "06260", "USA"),
            new BuzziFormatAddress("465 Bridgeport Avenue", null, null, null, "Shelton", "CT", "06484", "USA"),
            new BuzziFormatAddress("235 Queen St", null, null, null, "Southington", "CT", "06489", "USA"),
            new BuzziFormatAddress("150 Barnum Avenue Cutoff", null, null, null, "Stratford", "CT", "06614", "USA"),
            new BuzziFormatAddress("970 Torringford Street", null, null, null, "Torrington", "CT", "06790", "USA"),
            new BuzziFormatAddress("844 No Colony Road", null, null, null, "Wallingford", "CT", "06492", "USA"),
            new BuzziFormatAddress("910 Wolcott St", null, null, null, "Waterbury", "CT", "06705", "USA"),
            new BuzziFormatAddress("155 Waterford Parkway No", null, null, null, "Waterford", "CT", "06385", "USA"),
            new BuzziFormatAddress("2473 Hackworth Road", null, null, null, "Adamsville", "AL", "35005", "USA"),
            new BuzziFormatAddress("630 Coonial Promenade Pkwy", null, null, null, "Alabaster", "AL", "35007", "USA"),
            new BuzziFormatAddress("540 West Bypass", null, null, null, "Andalusia", "AL", "36420", "USA"),
            new BuzziFormatAddress("5560 Mcclellan Blvd", null, null, null, "Anniston", "AL", "36206", "USA"),
            new BuzziFormatAddress("1450 No Brindlee Mtn Pkwy", null, null, null, "Arab", "AL", "35016", "USA"),
            new BuzziFormatAddress("1011 US Hwy 72 East", null, null, null, "Athens", "AL", "35611", "USA"),
            new BuzziFormatAddress("973 Gilbert Ferry Road Se", null, null, null, "Attalla", "AL", "35954", "USA"),
            new BuzziFormatAddress("1717 South College Street", null, null, null, "Auburn", "AL", "36830", "USA"),
            new BuzziFormatAddress("750 Academy Drive", null, null, null, "Bessemer", "AL", "35022", "USA"),
            new BuzziFormatAddress("312 Palisades Blvd", null, null, null, "Birmingham", "AL", "35209", "USA"),
            new BuzziFormatAddress("1600 Montclair Rd", null, null, null, "Birmingham", "AL", "35210", "USA"),
            new BuzziFormatAddress("5919 Trussville Crossings Pkwy", null, null, null, "Birmingham", "AL", "35235", "USA"),
            new BuzziFormatAddress("9248 Parkway East", null, null, null, "Birmingham", "AL", "35206", "USA"),
            new BuzziFormatAddress("1972 Hwy 431", null, null, null, "Boaz", "AL", "35957", "USA"),
            new BuzziFormatAddress("10675 Hwy 5", null, null, null, "Brent", "AL", "35034", "USA"),
            new BuzziFormatAddress("2041 Douglas Avenue", null, null, null, "Brewton", "AL", "36426", "USA"),
            new BuzziFormatAddress("5100 Hwy 31", null, null, null, "Calera", "AL", "35040", "USA"),
            new BuzziFormatAddress("1950 W Main St", null, null, null, "Centre", "AL", "35960", "USA"),
            new BuzziFormatAddress("16077 Highway 280", null, null, null, "Chelsea", "AL", "35043", "USA"),
            new BuzziFormatAddress("1415 7Th Street South", null, null, null, "Clanton", "AL", "35045", "USA"),
            new BuzziFormatAddress("626 Olive Street Sw", null, null, null, "Cullman", "AL", "35055", "USA"),
            new BuzziFormatAddress("27520 Hwy 98", null, null, null, "Daphne", "AL", "36526", "USA"),
            new BuzziFormatAddress("2800 Spring Avn SW", null, null, null, "Decatur", "AL", "35603", "USA"),
            new BuzziFormatAddress("969 Us Hwy 80 West", null, null, null, "Demopolis", "AL", "36732", "USA"),
            new BuzziFormatAddress("3300 South Oates Street", null, null, null, "Dothan", "AL", "36301", "USA"),
            new BuzziFormatAddress("4310 Montgomery Hwy", null, null, null, "Dothan", "AL", "36303", "USA"),
            new BuzziFormatAddress("600 Boll Weevil Circle", null, null, null, "Enterprise", "AL", "36330", "USA"),
            new BuzziFormatAddress("3176 South Eufaula Avenue", null, null, null, "Eufaula", "AL", "36027", "USA"),
            new BuzziFormatAddress("7100 Aaron Aronov Drive", null, null, null, "Fairfield", "AL", "35064", "USA"),
            new BuzziFormatAddress("10040 County Road 48", null, null, null, "Fairhope", "AL", "36533", "USA"),
            new BuzziFormatAddress("3186 Hwy 171 North", null, null, null, "Fayette", "AL", "35555", "USA"),
            new BuzziFormatAddress("3100 Hough Rd", null, null, null, "Florence", "AL", "35630", "USA"),
            new BuzziFormatAddress("2200 South Mckenzie St", null, null, null, "Foley", "AL", "36535", "USA"),
            new BuzziFormatAddress("340 East Meighan Blvd", null, null, null, "Gadsden", "AL", "35903", "USA"),
            new BuzziFormatAddress("890 Odum Road", null, null, null, "Gardendale", "AL", "35071", "USA"),
            new BuzziFormatAddress("1608 W Magnolia Ave", null, null, null, "Geneva", "AL", "36340", "USA"),
            new BuzziFormatAddress("501 Willow Lane", null, null, null, "Greenville", "AL", "36037", "USA"),
            new BuzziFormatAddress("11697 US Hwy 431", null, null, null, "Guntersville", "AL", "35976", "USA"),
            new BuzziFormatAddress("42417 Hwy 195", null, null, null, "Haleyville", "AL", "35565", "USA"),
            new BuzziFormatAddress("1706 Military Street South", null, null, null, "Hamilton", "AL", "35570", "USA"),
            new BuzziFormatAddress("1201 Hwy 31 NW", null, null, null, "Hartselle", "AL", "35640", "USA"),
            new BuzziFormatAddress("209 Lakeshore Parkway", null, null, null, "Homewood", "AL", "35209", "USA"),
            new BuzziFormatAddress("2780 John Hawkins Pkwy", null, null, null, "Hoover", "AL", "35244", "USA"),
            new BuzziFormatAddress("5335 Hwy 280 South", null, null, null, "Hoover", "AL", "35242", "USA"),
            new BuzziFormatAddress("1007 Red Farmer Drive", null, null, null, "Hueytown", "AL", "35023", "USA"),
            new BuzziFormatAddress("2900 S Mem PkwyDrake Ave", null, null, null, "Huntsville", "AL", "35801", "USA"),
            new BuzziFormatAddress("11610 Memorial Pkwy South", null, null, null, "Huntsville", "AL", "35803", "USA"),
            new BuzziFormatAddress("2200 Sparkman Drive", null, null, null, "Huntsville", "AL", "35810", "USA"),
            new BuzziFormatAddress("330 Sutton Rd", null, null, null, "Huntsville", "AL", "35763", "USA"),
            new BuzziFormatAddress("6140A Univ Drive", null, null, null, "Huntsville", "AL", "35806", "USA"),
            new BuzziFormatAddress("4206 N College Ave", null, null, null, "Jackson", "AL", "36545", "USA"),
            new BuzziFormatAddress("1625 Pelham South", null, null, null, "Jacksonville", "AL", "36265", "USA"),
            new BuzziFormatAddress("1801 Hwy 78 East", null, null, null, "Jasper", "AL", "35501", "USA"),
            new BuzziFormatAddress("8551 Whitfield Ave", null, null, null, "Leeds", "AL", "35094", "USA"),
            new BuzziFormatAddress("8650 Madison Blvd", null, null, null, "Madison", "AL", "35758", "USA"),
            new BuzziFormatAddress("145 Kelley Blvd", null, null, null, "Millbrook", "AL", "36054", "USA"),
            new BuzziFormatAddress("1970 S University Blvd", null, null, null, "Mobile", "AL", "36609", "USA"),
            new BuzziFormatAddress("6350 Cottage Hill Road", null, null, null, "Mobile", "AL", "36609", "USA"),
            new BuzziFormatAddress("101 South Beltline Highway", null, null, null, "Mobile", "AL", "36606", "USA"),
            new BuzziFormatAddress("2500 Dawes Road", null, null, null, "Mobile", "AL", "36695", "USA"),
            new BuzziFormatAddress("5245 Rangeline Service Rd", null, null, null, "Mobile", "AL", "36619", "USA"),
            new BuzziFormatAddress("685 Schillinger Rd", null, null, null, "Mobile", "AL", "36695", "USA"),
            new BuzziFormatAddress("3371 S Alabama Ave", null, null, null, "Monroeville", "AL", "36460", "USA"),
            new BuzziFormatAddress("10710 Chantilly Pkwy", null, null, null, "Montgomery", "AL", "36117", "USA"),
            new BuzziFormatAddress("3801 Eastern Blvd", null, null, null, "Montgomery", "AL", "36116", "USA"),
            new BuzziFormatAddress("6495 Atlanta Hwy", null, null, null, "Montgomery", "AL", "36117", "USA"),
            new BuzziFormatAddress("851 Ann St", null, null, null, "Montgomery", "AL", "36107", "USA"),
            new BuzziFormatAddress("15445 Highway 24", null, null, null, "Moulton", "AL", "35650", "USA"),
            new BuzziFormatAddress("5710 Mcfarland Blvd", null, null, null, "Northport", "AL", "35476", "USA"),
            new BuzziFormatAddress("2900 Pepperrell Pkwy", null, null, null, "Opelika", "AL", "36801", "USA"),
            new BuzziFormatAddress("92 Plaza Lane", null, null, null, "Oxford", "AL", "36203", "USA"),
            new BuzziFormatAddress("1537 Hwy 231 South", null, null, null, "Ozark", "AL", "36360", "USA"),
            new BuzziFormatAddress("2181 Pelham Pkwy", null, null, null, "Pelham", "AL", "35124", "USA"),
            new BuzziFormatAddress("1903 Cobbs Ford Rd", null, null, null, "Prattville", "AL", "36066", "USA"),
            new BuzziFormatAddress("4180 Us Hwy 431", null, null, null, "Roanoke", "AL", "36274", "USA"),
            new BuzziFormatAddress("13675 Hwy 43", null, null, null, "Russellville", "AL", "35653", "USA"),
            new BuzziFormatAddress("1095 Industrial Pkwy", null, null, null, "Saraland", "AL", "36571", "USA"),
            new BuzziFormatAddress("24833 Johnt Reidprkw", null, null, null, "Scottsboro", "AL", "35768", "USA"),
            new BuzziFormatAddress("1501 Hwy 14 East", null, null, null, "Selma", "AL", "36703", "USA"),
            new BuzziFormatAddress("7855 Moffett Rd", null, null, null, "Semmes", "AL", "36575", "USA"),
            new BuzziFormatAddress("150 Springville Station Blvd", null, null, null, "Springville", "AL", "35146", "USA"),
            new BuzziFormatAddress("690 Hwy 78", null, null, null, "Sumiton", "AL", "35148", "USA"),
            new BuzziFormatAddress("41301 US Hwy 280", null, null, null, "Sylacauga", "AL", "35150", "USA"),
            new BuzziFormatAddress("214 Haynes Street", null, null, null, "Talladega", "AL", "35160", "USA"),
            new BuzziFormatAddress("1300 Gilmer Ave", null, null, null, "Tallassee", "AL", "36078", "USA"),
            new BuzziFormatAddress("34301 Hwy 43", null, null, null, "Thomasville", "AL", "36784", "USA"),
            new BuzziFormatAddress("1420 Us 231 South", null, null, null, "Troy", "AL", "36081", "USA"),
            new BuzziFormatAddress("1501 Skyland Blvd E", null, null, null, "Tuscaloosa", "AL", "35405", "USA"),
            new BuzziFormatAddress("3501 20th Av", null, null, null, "Valley", "AL", "36854", "USA"),
            new BuzziFormatAddress("4538 Us Hwy 231", null, null, null, "Wetumpka", "AL", "36092", "USA"),
            new BuzziFormatAddress("2575 Us Hwy 43", null, null, null, "Winfield", "AL", "35594", "USA")
        };
        
        #endregion
    }
}
