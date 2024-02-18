using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuaMoney.Migrations
{
    /// <inheritdoc />
    public partial class CurrencyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert currency data as sql 
            migrationBuilder.Sql(@"INSERT INTO Currency (Id, Name) VALUES ('AED', 'UAE Dirham');
INSERT INTO Currency (Id, Name) VALUES ('AFN', 'Afghani');
INSERT INTO Currency (Id, Name) VALUES ('ALL', 'Lek');
INSERT INTO Currency (Id, Name) VALUES ('AMD', 'Armenian Dram');
INSERT INTO Currency (Id, Name) VALUES ('AOA', 'Kwanza');
INSERT INTO Currency (Id, Name) VALUES ('ARS', 'Argentine Peso');
INSERT INTO Currency (Id, Name) VALUES ('AWG', 'Aruban Florin');
INSERT INTO Currency (Id, Name) VALUES ('AZN', 'Azerbaijan Manat');
INSERT INTO Currency (Id, Name) VALUES ('BAM', 'Convertible Mark');
INSERT INTO Currency (Id, Name) VALUES ('BBD', 'Barbados Dollar');
INSERT INTO Currency (Id, Name) VALUES ('BDT', 'Taka');
INSERT INTO Currency (Id, Name) VALUES ('BGN', 'Bulgarian Lev');
INSERT INTO Currency (Id, Name) VALUES ('BHD', 'Bahraini Dinar');
INSERT INTO Currency (Id, Name) VALUES ('BIF', 'Burundi Franc');
INSERT INTO Currency (Id, Name) VALUES ('BMD', 'Bermudian Dollar');
INSERT INTO Currency (Id, Name) VALUES ('BND', 'Brunei Dollar');
INSERT INTO Currency (Id, Name) VALUES ('BOB', 'Boliviano');
INSERT INTO Currency (Id, Name) VALUES ('BOV', 'Mvdol');
INSERT INTO Currency (Id, Name) VALUES ('BRL', 'Brazilian Real');
INSERT INTO Currency (Id, Name) VALUES ('BSD', 'Bahamian Dollar');
INSERT INTO Currency (Id, Name) VALUES ('BTN', 'Ngultrum');
INSERT INTO Currency (Id, Name) VALUES ('BWP', 'Pula');
INSERT INTO Currency (Id, Name) VALUES ('BYN', 'Belarusian Ruble');
INSERT INTO Currency (Id, Name) VALUES ('BZD', 'Belize Dollar');
INSERT INTO Currency (Id, Name) VALUES ('CAD', 'Canadian Dollar');
INSERT INTO Currency (Id, Name) VALUES ('CDF', 'Congolese Franc');
INSERT INTO Currency (Id, Name) VALUES ('CHE', 'WIR Euro');
INSERT INTO Currency (Id, Name) VALUES ('CHW', 'WIR Franc');
INSERT INTO Currency (Id, Name) VALUES ('CLF', 'Unidad de Fomento');
INSERT INTO Currency (Id, Name) VALUES ('CLP', 'Chilean Peso');
INSERT INTO Currency (Id, Name) VALUES ('CNY', 'Yuan Renminbi');
INSERT INTO Currency (Id, Name) VALUES ('COP', 'Colombian Peso');
INSERT INTO Currency (Id, Name) VALUES ('COU', 'Unidad de Valor Real');
INSERT INTO Currency (Id, Name) VALUES ('CRC', 'Costa Rican Colon');
INSERT INTO Currency (Id, Name) VALUES ('CUC', 'Peso Convertible');
INSERT INTO Currency (Id, Name) VALUES ('CUP', 'Cuban Peso');
INSERT INTO Currency (Id, Name) VALUES ('CVE', 'Cabo Verde Escudo');
INSERT INTO Currency (Id, Name) VALUES ('CZK', 'Czech Koruna');
INSERT INTO Currency (Id, Name) VALUES ('DJF', 'Djibouti Franc');
INSERT INTO Currency (Id, Name) VALUES ('DOP', 'Dominican Peso');
INSERT INTO Currency (Id, Name) VALUES ('DZD', 'Algerian Dinar');
INSERT INTO Currency (Id, Name) VALUES ('EGP', 'Egyptian Pound');
INSERT INTO Currency (Id, Name) VALUES ('ERN', 'Nakfa');
INSERT INTO Currency (Id, Name) VALUES ('ETB', 'Ethiopian Birr');
INSERT INTO Currency (Id, Name) VALUES ('FJD', 'Fiji Dollar');
INSERT INTO Currency (Id, Name) VALUES ('FKP', 'Falkland Islands Pound');
INSERT INTO Currency (Id, Name) VALUES ('GEL', 'Lari');
INSERT INTO Currency (Id, Name) VALUES ('GHS', 'Ghana Cedi');
INSERT INTO Currency (Id, Name) VALUES ('GIP', 'Gibraltar Pound');
INSERT INTO Currency (Id, Name) VALUES ('GMD', 'Dalasi');
INSERT INTO Currency (Id, Name) VALUES ('GNF', 'Guinean Franc');
INSERT INTO Currency (Id, Name) VALUES ('GTQ', 'Quetzal');
INSERT INTO Currency (Id, Name) VALUES ('GYD', 'Guyana Dollar');
INSERT INTO Currency (Id, Name) VALUES ('HKD', 'Hong Kong Dollar');
INSERT INTO Currency (Id, Name) VALUES ('HNL', 'Lempira');
INSERT INTO Currency (Id, Name) VALUES ('HTG', 'Gourde');
INSERT INTO Currency (Id, Name) VALUES ('HUF', 'Forint');
INSERT INTO Currency (Id, Name) VALUES ('IDR', 'Rupiah');
INSERT INTO Currency (Id, Name) VALUES ('ILS', 'New Israeli Sheqel');
INSERT INTO Currency (Id, Name) VALUES ('IQD', 'Iraqi Dinar');
INSERT INTO Currency (Id, Name) VALUES ('IRR', 'Iranian Rial');
INSERT INTO Currency (Id, Name) VALUES ('ISK', 'Iceland Krona');
INSERT INTO Currency (Id, Name) VALUES ('JMD', 'Jamaican Dollar');
INSERT INTO Currency (Id, Name) VALUES ('JOD', 'Jordanian Dinar');
INSERT INTO Currency (Id, Name) VALUES ('JPY', 'Yen');
INSERT INTO Currency (Id, Name) VALUES ('KES', 'Kenyan Shilling');
INSERT INTO Currency (Id, Name) VALUES ('KGS', 'Som');
INSERT INTO Currency (Id, Name) VALUES ('KHR', 'Riel');
INSERT INTO Currency (Id, Name) VALUES ('KMF', 'Comorian Franc ');
INSERT INTO Currency (Id, Name) VALUES ('KPW', 'North Korean Won');
INSERT INTO Currency (Id, Name) VALUES ('KRW', 'Won');
INSERT INTO Currency (Id, Name) VALUES ('KWD', 'Kuwaiti Dinar');
INSERT INTO Currency (Id, Name) VALUES ('KYD', 'Cayman Islands Dollar');
INSERT INTO Currency (Id, Name) VALUES ('KZT', 'Tenge');
INSERT INTO Currency (Id, Name) VALUES ('LAK', 'Lao Kip');
INSERT INTO Currency (Id, Name) VALUES ('LBP', 'Lebanese Pound');
INSERT INTO Currency (Id, Name) VALUES ('LKR', 'Sri Lanka Rupee');
INSERT INTO Currency (Id, Name) VALUES ('LRD', 'Liberian Dollar');
INSERT INTO Currency (Id, Name) VALUES ('LSL', 'Loti');
INSERT INTO Currency (Id, Name) VALUES ('LYD', 'Libyan Dinar');
INSERT INTO Currency (Id, Name) VALUES ('MDL', 'Moldovan Leu');
INSERT INTO Currency (Id, Name) VALUES ('MGA', 'Malagasy Ariary');
INSERT INTO Currency (Id, Name) VALUES ('MKD', 'Denar');
INSERT INTO Currency (Id, Name) VALUES ('MMK', 'Kyat');
INSERT INTO Currency (Id, Name) VALUES ('MNT', 'Tugrik');
INSERT INTO Currency (Id, Name) VALUES ('MOP', 'Pataca');
INSERT INTO Currency (Id, Name) VALUES ('MRU', 'Ouguiya');
INSERT INTO Currency (Id, Name) VALUES ('MUR', 'Mauritius Rupee');
INSERT INTO Currency (Id, Name) VALUES ('MVR', 'Rufiyaa');
INSERT INTO Currency (Id, Name) VALUES ('MWK', 'Malawi Kwacha');
INSERT INTO Currency (Id, Name) VALUES ('MXN', 'Mexican Peso');
INSERT INTO Currency (Id, Name) VALUES ('MXV', 'Mexican Unidad de Inversion (UDI)');
INSERT INTO Currency (Id, Name) VALUES ('MYR', 'Malaysian Ringgit');
INSERT INTO Currency (Id, Name) VALUES ('MZN', 'Mozambique Metical');
INSERT INTO Currency (Id, Name) VALUES ('NAD', 'Namibia Dollar');
INSERT INTO Currency (Id, Name) VALUES ('NGN', 'Naira');
INSERT INTO Currency (Id, Name) VALUES ('NIO', 'Cordoba Oro');
INSERT INTO Currency (Id, Name) VALUES ('NPR', 'Nepalese Rupee');
INSERT INTO Currency (Id, Name) VALUES ('OMR', 'Rial Omani');
INSERT INTO Currency (Id, Name) VALUES ('PAB', 'Balboa');
INSERT INTO Currency (Id, Name) VALUES ('PEN', 'Sol');
INSERT INTO Currency (Id, Name) VALUES ('PGK', 'Kina');
INSERT INTO Currency (Id, Name) VALUES ('PHP', 'Philippine Peso');
INSERT INTO Currency (Id, Name) VALUES ('PKR', 'Pakistan Rupee');
INSERT INTO Currency (Id, Name) VALUES ('PLN', 'Zloty');
INSERT INTO Currency (Id, Name) VALUES ('PYG', 'Guarani');
INSERT INTO Currency (Id, Name) VALUES ('QAR', 'Qatari Rial');
INSERT INTO Currency (Id, Name) VALUES ('RON', 'Romanian Leu');
INSERT INTO Currency (Id, Name) VALUES ('RSD', 'Serbian Dinar');
INSERT INTO Currency (Id, Name) VALUES ('RUB', 'Russian Ruble');
INSERT INTO Currency (Id, Name) VALUES ('RWF', 'Rwanda Franc');
INSERT INTO Currency (Id, Name) VALUES ('SAR', 'Saudi Riyal');
INSERT INTO Currency (Id, Name) VALUES ('SBD', 'Solomon Islands Dollar');
INSERT INTO Currency (Id, Name) VALUES ('SCR', 'Seychelles Rupee');
INSERT INTO Currency (Id, Name) VALUES ('SDG', 'Sudanese Pound');
INSERT INTO Currency (Id, Name) VALUES ('SEK', 'Swedish Krona');
INSERT INTO Currency (Id, Name) VALUES ('SGD', 'Singapore Dollar');
INSERT INTO Currency (Id, Name) VALUES ('SHP', 'Saint Helena Pound');
INSERT INTO Currency (Id, Name) VALUES ('SLE', 'Leone');
INSERT INTO Currency (Id, Name) VALUES ('SOS', 'Somali Shilling');
INSERT INTO Currency (Id, Name) VALUES ('SRD', 'Surinam Dollar');
INSERT INTO Currency (Id, Name) VALUES ('SSP', 'South Sudanese Pound');
INSERT INTO Currency (Id, Name) VALUES ('STN', 'Dobra');
INSERT INTO Currency (Id, Name) VALUES ('SVC', 'El Salvador Colon');
INSERT INTO Currency (Id, Name) VALUES ('SYP', 'Syrian Pound');
INSERT INTO Currency (Id, Name) VALUES ('SZL', 'Lilangeni');
INSERT INTO Currency (Id, Name) VALUES ('THB', 'Baht');
INSERT INTO Currency (Id, Name) VALUES ('TJS', 'Somoni');
INSERT INTO Currency (Id, Name) VALUES ('TMT', 'Turkmenistan New Manat');
INSERT INTO Currency (Id, Name) VALUES ('TND', 'Tunisian Dinar');
INSERT INTO Currency (Id, Name) VALUES ('TOP', 'Pa’anga');
INSERT INTO Currency (Id, Name) VALUES ('TRY', 'Turkish Lira');
INSERT INTO Currency (Id, Name) VALUES ('TTD', 'Trinidad and Tobago Dollar');
INSERT INTO Currency (Id, Name) VALUES ('TWD', 'New Taiwan Dollar');
INSERT INTO Currency (Id, Name) VALUES ('TZS', 'Tanzanian Shilling');
INSERT INTO Currency (Id, Name) VALUES ('UAH', 'Hryvnia');
INSERT INTO Currency (Id, Name) VALUES ('UGX', 'Uganda Shilling');
INSERT INTO Currency (Id, Name) VALUES ('USN', 'US Dollar (Next day)');
INSERT INTO Currency (Id, Name) VALUES ('UYI', 'Uruguay Peso en Unidades Indexadas (UI)');
INSERT INTO Currency (Id, Name) VALUES ('UYU', 'Peso Uruguayo');
INSERT INTO Currency (Id, Name) VALUES ('UYW', 'Unidad Previsional');
INSERT INTO Currency (Id, Name) VALUES ('UZS', 'Uzbekistan Sum');
INSERT INTO Currency (Id, Name) VALUES ('VED', 'Bolívar Soberano');
INSERT INTO Currency (Id, Name) VALUES ('VES', 'Bolívar Soberano');
INSERT INTO Currency (Id, Name) VALUES ('VND', 'Dong');
INSERT INTO Currency (Id, Name) VALUES ('VUV', 'Vatu');
INSERT INTO Currency (Id, Name) VALUES ('WST', 'Tala');
INSERT INTO Currency (Id, Name) VALUES ('XAG', 'Silver');
INSERT INTO Currency (Id, Name) VALUES ('XAU', 'Gold');
INSERT INTO Currency (Id, Name) VALUES ('XBA', 'Bond Markets Unit European Composite Unit (EURCO)');
INSERT INTO Currency (Id, Name) VALUES ('XBB', 'Bond Markets Unit European Monetary Unit (E.M.U.-6)');
INSERT INTO Currency (Id, Name) VALUES ('XBC', 'Bond Markets Unit European Unit of Account 9 (E.U.A.-9)');
INSERT INTO Currency (Id, Name) VALUES ('XBD', 'Bond Markets Unit European Unit of Account 17 (E.U.A.-17)');
INSERT INTO Currency (Id, Name) VALUES ('XDR', 'SDR (Special Drawing Right)');
INSERT INTO Currency (Id, Name) VALUES ('XPD', 'Palladium');
INSERT INTO Currency (Id, Name) VALUES ('XPT', 'Platinum');
INSERT INTO Currency (Id, Name) VALUES ('XSU', 'Sucre');
INSERT INTO Currency (Id, Name) VALUES ('XUA', 'ADB Unit of Account');
INSERT INTO Currency (Id, Name) VALUES ('YER', 'Yemeni Rial');
INSERT INTO Currency (Id, Name) VALUES ('ZMW', 'Zambian Kwacha');
INSERT INTO Currency (Id, Name) VALUES ('ZWL', 'Zimbabwe Dollar')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE Currency");
        }
    }
}
