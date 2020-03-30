﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace TurnipExchange.Data
{
	public class TimeZone : BaseEntity
	{
		public string Abbreviation { get; set; }
		public string Name { get; set; }
		public string UtcOffset { get; set; }

		public ICollection<User> Users { get; set; }

		public static void Seed(EntityTypeBuilder<TimeZone> builder)
		{
			builder.HasData(new TimeZone { Id = 1, Abbreviation = "ACDT", Name = "Australian Central Daylight Savings Time", UtcOffset = "UTC+10:30" });
			builder.HasData(new TimeZone { Id = 2, Abbreviation = "ACST", Name = "Australian Central Standard Time", UtcOffset = "UTC +09:30" });
			builder.HasData(new TimeZone { Id = 3, Abbreviation = "ACT", Name = "Acre Time", UtcOffset = "UTC−05" });
			builder.HasData(new TimeZone { Id = 4, Abbreviation = "ADT", Name = "Atlantic Daylight Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 5, Abbreviation = "AEDT", Name = "Australian Eastern Daylight Savings Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 6, Abbreviation = "AEST", Name = "Australian Eastern Standard Time", UtcOffset = "UTC+10" });
			builder.HasData(new TimeZone { Id = 7, Abbreviation = "AET", Name = "Australian Eastern Time", UtcOffset = "UTC+10/UTC+11" });
			builder.HasData(new TimeZone { Id = 8, Abbreviation = "AFT", Name = "Afghanistan Time", UtcOffset = "UTC+04:30" });
			builder.HasData(new TimeZone { Id = 9, Abbreviation = "AKDT", Name = "Alaska Daylight Time", UtcOffset = "UTC−08" });
			builder.HasData(new TimeZone { Id = 10, Abbreviation = "AKST", Name = "Alaska Standard Time", UtcOffset = "UTC−09" });
			builder.HasData(new TimeZone { Id = 11, Abbreviation = "ALMT", Name = "Alma-Ata Time", UtcOffset = "UTC+06" });
			builder.HasData(new TimeZone { Id = 12, Abbreviation = "AMST", Name = "Amazon Summer Time (Brazil)", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 13, Abbreviation = "AMT", Name = "Amazon Time (Brazil)", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 14, Abbreviation = "AMT", Name = "Armenia Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 15, Abbreviation = "ANAT", Name = "Anadyr Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 16, Abbreviation = "AQTT", Name = "Aqtobe Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 17, Abbreviation = "ART", Name = "Argentina Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 18, Abbreviation = "AST", Name = "Arabia Standard Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 19, Abbreviation = "AST", Name = "Atlantic Standard Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 20, Abbreviation = "AWST", Name = "Australian Western Standard Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 21, Abbreviation = "AZOST", Name = "Azores Summer Time", UtcOffset = "UTC±00" });
			builder.HasData(new TimeZone { Id = 22, Abbreviation = "AZOT", Name = "Azores Standard Time", UtcOffset = "UTC−01" });
			builder.HasData(new TimeZone { Id = 23, Abbreviation = "AZT", Name = "Azerbaijan Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 24, Abbreviation = "BDT", Name = "Brunei Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 25, Abbreviation = "BIOT", Name = "British Indian Ocean Time", UtcOffset = "UTC+06" });
			builder.HasData(new TimeZone { Id = 26, Abbreviation = "BIT", Name = "Baker Island Time", UtcOffset = "UTC−12" });
			builder.HasData(new TimeZone { Id = 27, Abbreviation = "BOT", Name = "Bolivia Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 28, Abbreviation = "BRST", Name = "Brasília Summer Time", UtcOffset = "UTC−02" });
			builder.HasData(new TimeZone { Id = 29, Abbreviation = "BRT", Name = "Brasília Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 30, Abbreviation = "BST", Name = "Bangladesh Standard Time", UtcOffset = "UTC+06" });
			builder.HasData(new TimeZone { Id = 31, Abbreviation = "BST", Name = "Bougainville Standard Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 32, Abbreviation = "BST", Name = "British Summer Time (British Standard Time from Feb 1968 to Oct 1971)", UtcOffset = "UTC+01" });
			builder.HasData(new TimeZone { Id = 33, Abbreviation = "BTT", Name = "Bhutan Time", UtcOffset = "UTC+06" });
			builder.HasData(new TimeZone { Id = 34, Abbreviation = "CAT", Name = "Central Africa Time", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 35, Abbreviation = "CCT", Name = "Cocos Islands Time", UtcOffset = "UTC+06:30" });
			builder.HasData(new TimeZone { Id = 36, Abbreviation = "CDT", Name = "Central Daylight Time (North America)", UtcOffset = "UTC−05" });
			builder.HasData(new TimeZone { Id = 37, Abbreviation = "CDT", Name = "Cuba Daylight Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 38, Abbreviation = "CEST", Name = "Central European Summer Time (Cf. HAEC)", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 39, Abbreviation = "CET", Name = "Central European Time", UtcOffset = "UTC+01" });
			builder.HasData(new TimeZone { Id = 40, Abbreviation = "CHADT", Name = "Chatham Daylight Time", UtcOffset = "UTC+13:45" });
			builder.HasData(new TimeZone { Id = 41, Abbreviation = "CHAST", Name = "Chatham Standard Time", UtcOffset = "UTC+12:45" });
			builder.HasData(new TimeZone { Id = 42, Abbreviation = "CHOT", Name = "Choibalsan Standard Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 43, Abbreviation = "CHOST", Name = "Choibalsan Summer Time", UtcOffset = "UTC+09" });
			builder.HasData(new TimeZone { Id = 44, Abbreviation = "CHST", Name = "Chamorro Standard Time", UtcOffset = "UTC+10" });
			builder.HasData(new TimeZone { Id = 45, Abbreviation = "CHUT", Name = "Chuuk Time", UtcOffset = "UTC+10" });
			builder.HasData(new TimeZone { Id = 46, Abbreviation = "CIST", Name = "Clipperton Island Standard Time", UtcOffset = "UTC−08" });
			builder.HasData(new TimeZone { Id = 47, Abbreviation = "CIT", Name = "Central Indonesia Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 48, Abbreviation = "CKT", Name = "Cook Island Time", UtcOffset = "UTC−10" });
			builder.HasData(new TimeZone { Id = 49, Abbreviation = "CLST", Name = "Chile Summer Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 50, Abbreviation = "CLT", Name = "Chile Standard Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 51, Abbreviation = "COST", Name = "Colombia Summer Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 52, Abbreviation = "COT", Name = "Colombia Time", UtcOffset = "UTC−05" });
			builder.HasData(new TimeZone { Id = 53, Abbreviation = "CST", Name = "Central Standard Time (North America)", UtcOffset = "UTC−06" });
			builder.HasData(new TimeZone { Id = 54, Abbreviation = "CST", Name = "China Standard Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 55, Abbreviation = "CST", Name = "Cuba Standard Time", UtcOffset = "UTC−05" });
			builder.HasData(new TimeZone { Id = 56, Abbreviation = "CT", Name = "China Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 57, Abbreviation = "CVT", Name = "Cape Verde Time", UtcOffset = "UTC−01" });
			builder.HasData(new TimeZone { Id = 58, Abbreviation = "CXT", Name = "Christmas Island Time", UtcOffset = "UTC+07" });
			builder.HasData(new TimeZone { Id = 59, Abbreviation = "DAVT", Name = "Davis Time", UtcOffset = "UTC+07" });
			builder.HasData(new TimeZone { Id = 60, Abbreviation = "DDUT", Name = "Dumont d'Urville Time", UtcOffset = "UTC+10" });
			builder.HasData(new TimeZone { Id = 61, Abbreviation = "DFT", Name = "AIX-specific equivalent of Central European Time[NB 1]", UtcOffset = "UTC+01" });
			builder.HasData(new TimeZone { Id = 62, Abbreviation = "EASST", Name = "Easter Island Summer Time", UtcOffset = "UTC−05" });
			builder.HasData(new TimeZone { Id = 63, Abbreviation = "EAST", Name = "Easter Island Standard Time", UtcOffset = "UTC−06" });
			builder.HasData(new TimeZone { Id = 64, Abbreviation = "EAT", Name = "East Africa Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 65, Abbreviation = "ECT", Name = "Eastern Caribbean Time (does not recognise DST)", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 66, Abbreviation = "ECT", Name = "Ecuador Time", UtcOffset = "UTC−05" });
			builder.HasData(new TimeZone { Id = 67, Abbreviation = "EDT", Name = "Eastern Daylight Time (North America)", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 68, Abbreviation = "EEST", Name = "Eastern European Summer Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 69, Abbreviation = "EET", Name = "Eastern European Time", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 70, Abbreviation = "EGST", Name = "Eastern Greenland Summer Time", UtcOffset = "UTC±00" });
			builder.HasData(new TimeZone { Id = 71, Abbreviation = "EGT", Name = "Eastern Greenland Time", UtcOffset = "UTC−01" });
			builder.HasData(new TimeZone { Id = 72, Abbreviation = "EIT", Name = "Eastern Indonesian Time", UtcOffset = "UTC+09" });
			builder.HasData(new TimeZone { Id = 73, Abbreviation = "EST", Name = "Eastern Standard Time (North America)", UtcOffset = "UTC−05" });
			builder.HasData(new TimeZone { Id = 74, Abbreviation = "FET", Name = "Further-eastern European Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 75, Abbreviation = "FJT", Name = "Fiji Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 76, Abbreviation = "FKST", Name = "Falkland Islands Summer Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 77, Abbreviation = "FKT", Name = "Falkland Islands Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 78, Abbreviation = "FNT", Name = "Fernando de Noronha Time", UtcOffset = "UTC−02" });
			builder.HasData(new TimeZone { Id = 79, Abbreviation = "GALT", Name = "Galápagos Time", UtcOffset = "UTC−06" });
			builder.HasData(new TimeZone { Id = 80, Abbreviation = "GAMT", Name = "Gambier Islands Time", UtcOffset = "UTC−09" });
			builder.HasData(new TimeZone { Id = 81, Abbreviation = "GET", Name = "Georgia Standard Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 82, Abbreviation = "GFT", Name = "French Guiana Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 83, Abbreviation = "GILT", Name = "Gilbert Island Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 84, Abbreviation = "GIT", Name = "Gambier Island Time", UtcOffset = "UTC−09" });
			builder.HasData(new TimeZone { Id = 85, Abbreviation = "GMT", Name = "Greenwich Mean Time", UtcOffset = "UTC±00" });
			builder.HasData(new TimeZone { Id = 86, Abbreviation = "GST", Name = "South Georgia and the South Sandwich Islands Time", UtcOffset = "UTC−02" });
			builder.HasData(new TimeZone { Id = 87, Abbreviation = "GST", Name = "Gulf Standard Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 88, Abbreviation = "GYT", Name = "Guyana Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 89, Abbreviation = "HDT", Name = "Hawaii–Aleutian Daylight Time", UtcOffset = "UTC−09" });
			builder.HasData(new TimeZone { Id = 90, Abbreviation = "HAEC", Name = "Heure Avancée d'Europe Centrale French-language name for CEST", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 91, Abbreviation = "HST", Name = "Hawaii–Aleutian Standard Time", UtcOffset = "UTC−10" });
			builder.HasData(new TimeZone { Id = 92, Abbreviation = "HKT", Name = "Hong Kong Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 93, Abbreviation = "HMT", Name = "Heard and McDonald Islands Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 94, Abbreviation = "HOVST", Name = "Hovd Summer Time (not used from 2017-present)", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 95, Abbreviation = "HOVT", Name = "Hovd Time", UtcOffset = "UTC+07" });
			builder.HasData(new TimeZone { Id = 96, Abbreviation = "ICT", Name = "Indochina Time", UtcOffset = "UTC+07" });
			builder.HasData(new TimeZone { Id = 97, Abbreviation = "IDLW", Name = "International Day Line West time zone", UtcOffset = "UTC−12" });
			builder.HasData(new TimeZone { Id = 98, Abbreviation = "IDT", Name = "Israel Daylight Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 99, Abbreviation = "IOT", Name = "Indian Ocean Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 100, Abbreviation = "IRDT", Name = "Iran Daylight Time", UtcOffset = "UTC+04:30" });
			builder.HasData(new TimeZone { Id = 101, Abbreviation = "IRKT", Name = "Irkutsk Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 102, Abbreviation = "IRST", Name = "Iran Standard Time", UtcOffset = "UTC+03:30" });
			builder.HasData(new TimeZone { Id = 103, Abbreviation = "IST", Name = "Indian Standard Time", UtcOffset = "UTC+05:30" });
			builder.HasData(new TimeZone { Id = 104, Abbreviation = "IST", Name = "Irish Standard Time", UtcOffset = "UTC+01" });
			builder.HasData(new TimeZone { Id = 105, Abbreviation = "IST", Name = "Israel Standard Time", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 106, Abbreviation = "JST", Name = "Japan Standard Time", UtcOffset = "UTC+09" });
			builder.HasData(new TimeZone { Id = 107, Abbreviation = "KALT", Name = "Kaliningrad Time", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 108, Abbreviation = "KGT", Name = "Kyrgyzstan Time", UtcOffset = "UTC+06" });
			builder.HasData(new TimeZone { Id = 109, Abbreviation = "KOST", Name = "Kosrae Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 110, Abbreviation = "KRAT", Name = "Krasnoyarsk Time", UtcOffset = "UTC+07" });
			builder.HasData(new TimeZone { Id = 111, Abbreviation = "KST", Name = "Korea Standard Time", UtcOffset = "UTC+09" });
			builder.HasData(new TimeZone { Id = 112, Abbreviation = "LHST", Name = "Lord Howe Standard Time", UtcOffset = "UTC+10:30" });
			builder.HasData(new TimeZone { Id = 113, Abbreviation = "LHST", Name = "Lord Howe Summer Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 114, Abbreviation = "LINT", Name = "Line Islands Time", UtcOffset = "UTC+14" });
			builder.HasData(new TimeZone { Id = 115, Abbreviation = "MAGT", Name = "Magadan Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 116, Abbreviation = "MART", Name = "Marquesas Islands Time", UtcOffset = "UTC−09:30" });
			builder.HasData(new TimeZone { Id = 117, Abbreviation = "MAWT", Name = "Mawson Station Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 118, Abbreviation = "MDT", Name = "Mountain Daylight Time (North America)", UtcOffset = "UTC−06" });
			builder.HasData(new TimeZone { Id = 119, Abbreviation = "MET", Name = "Middle European Time", UtcOffset = "UTC+01" });
			builder.HasData(new TimeZone { Id = 120, Abbreviation = "MEST", Name = "Middle European Summer Time", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 121, Abbreviation = "MHT", Name = "Marshall Islands Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 122, Abbreviation = "MIST", Name = "Macquarie Island Station Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 123, Abbreviation = "MIT", Name = "Marquesas Islands Time", UtcOffset = "UTC−09:30" });
			builder.HasData(new TimeZone { Id = 124, Abbreviation = "MMT", Name = "Myanmar Standard Time", UtcOffset = "UTC+06:30" });
			builder.HasData(new TimeZone { Id = 125, Abbreviation = "MSK", Name = "Moscow Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 126, Abbreviation = "MST", Name = "Malaysia Standard Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 127, Abbreviation = "MST", Name = "Mountain Standard Time (North America)", UtcOffset = "UTC−07" });
			builder.HasData(new TimeZone { Id = 128, Abbreviation = "MUT", Name = "Mauritius Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 129, Abbreviation = "MVT", Name = "Maldives Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 130, Abbreviation = "MYT", Name = "Malaysia Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 131, Abbreviation = "NCT", Name = "New Caledonia Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 132, Abbreviation = "NDT", Name = "Newfoundland Daylight Time", UtcOffset = "UTC−02:30" });
			builder.HasData(new TimeZone { Id = 133, Abbreviation = "NFT", Name = "Norfolk Island Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 134, Abbreviation = "NOVT", Name = "Novosibirsk Time", UtcOffset = "UTC+07" });
			builder.HasData(new TimeZone { Id = 135, Abbreviation = "NPT", Name = "Nepal Time", UtcOffset = "UTC+05:45" });
			builder.HasData(new TimeZone { Id = 136, Abbreviation = "NST", Name = "Newfoundland Standard Time", UtcOffset = "UTC−03:30" });
			builder.HasData(new TimeZone { Id = 137, Abbreviation = "NT", Name = "Newfoundland Time", UtcOffset = "UTC−03:30" });
			builder.HasData(new TimeZone { Id = 138, Abbreviation = "NUT", Name = "Niue Time", UtcOffset = "UTC−11" });
			builder.HasData(new TimeZone { Id = 139, Abbreviation = "NZDT", Name = "New Zealand Daylight Time", UtcOffset = "UTC+13" });
			builder.HasData(new TimeZone { Id = 140, Abbreviation = "NZST", Name = "New Zealand Standard Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 141, Abbreviation = "OMST", Name = "Omsk Time", UtcOffset = "UTC+06" });
			builder.HasData(new TimeZone { Id = 142, Abbreviation = "ORAT", Name = "Oral Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 143, Abbreviation = "PDT", Name = "Pacific Daylight Time (North America)", UtcOffset = "UTC−07" });
			builder.HasData(new TimeZone { Id = 144, Abbreviation = "PET", Name = "Peru Time", UtcOffset = "UTC−05" });
			builder.HasData(new TimeZone { Id = 145, Abbreviation = "PETT", Name = "Kamchatka Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 146, Abbreviation = "PGT", Name = "Papua New Guinea Time", UtcOffset = "UTC+10" });
			builder.HasData(new TimeZone { Id = 147, Abbreviation = "PHOT", Name = "Phoenix Island Time", UtcOffset = "UTC+13" });
			builder.HasData(new TimeZone { Id = 148, Abbreviation = "PHT", Name = "Philippine Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 149, Abbreviation = "PKT", Name = "Pakistan Standard Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 150, Abbreviation = "PMDT", Name = "Saint Pierre and Miquelon Daylight Time", UtcOffset = "UTC−02" });
			builder.HasData(new TimeZone { Id = 151, Abbreviation = "PMST", Name = "Saint Pierre and Miquelon Standard Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 152, Abbreviation = "PONT", Name = "Pohnpei Standard Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 153, Abbreviation = "PST", Name = "Pacific Standard Time (North America)", UtcOffset = "UTC−08" });
			builder.HasData(new TimeZone { Id = 154, Abbreviation = "PST", Name = "Philippine Standard Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 155, Abbreviation = "PYST", Name = "Paraguay Summer Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 156, Abbreviation = "PYT", Name = "Paraguay Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 157, Abbreviation = "RET", Name = "Réunion Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 158, Abbreviation = "ROTT", Name = "Rothera Research Station Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 159, Abbreviation = "SAKT", Name = "Sakhalin Island Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 160, Abbreviation = "SAMT", Name = "Samara Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 161, Abbreviation = "SAST", Name = "South African Standard Time", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 162, Abbreviation = "SBT", Name = "Solomon Islands Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 163, Abbreviation = "SCT", Name = "Seychelles Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 164, Abbreviation = "SDT", Name = "Samoa Daylight Time", UtcOffset = "UTC−10" });
			builder.HasData(new TimeZone { Id = 165, Abbreviation = "SGT", Name = "Singapore Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 166, Abbreviation = "SLST", Name = "Sri Lanka Standard Time", UtcOffset = "UTC+05:30" });
			builder.HasData(new TimeZone { Id = 167, Abbreviation = "SRET", Name = "Srednekolymsk Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 168, Abbreviation = "SRT", Name = "Suriname Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 169, Abbreviation = "SST", Name = "Samoa Standard Time", UtcOffset = "UTC−11" });
			builder.HasData(new TimeZone { Id = 170, Abbreviation = "SST", Name = "Singapore Standard Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 171, Abbreviation = "SYOT", Name = "Showa Station Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 172, Abbreviation = "TAHT", Name = "Tahiti Time", UtcOffset = "UTC−10" });
			builder.HasData(new TimeZone { Id = 173, Abbreviation = "THA", Name = "Thailand Standard Time", UtcOffset = "UTC+07" });
			builder.HasData(new TimeZone { Id = 174, Abbreviation = "TFT", Name = "French Southern and Antarctic Time[12]", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 175, Abbreviation = "TJT", Name = "Tajikistan Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 176, Abbreviation = "TKT", Name = "Tokelau Time", UtcOffset = "UTC+13" });
			builder.HasData(new TimeZone { Id = 177, Abbreviation = "TLT", Name = "Timor Leste Time", UtcOffset = "UTC+09" });
			builder.HasData(new TimeZone { Id = 178, Abbreviation = "TMT", Name = "Turkmenistan Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 179, Abbreviation = "TRT", Name = "Turkey Time", UtcOffset = "UTC+03" });
			builder.HasData(new TimeZone { Id = 180, Abbreviation = "TOT", Name = "Tonga Time", UtcOffset = "UTC+13" });
			builder.HasData(new TimeZone { Id = 181, Abbreviation = "TVT", Name = "Tuvalu Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 182, Abbreviation = "ULAST", Name = "Ulaanbaatar Summer Time", UtcOffset = "UTC+09" });
			builder.HasData(new TimeZone { Id = 183, Abbreviation = "ULAT", Name = "Ulaanbaatar Standard Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 184, Abbreviation = "UTC", Name = "Coordinated Universal Time", UtcOffset = "UTC±00" });
			builder.HasData(new TimeZone { Id = 185, Abbreviation = "UYST", Name = "Uruguay Summer Time", UtcOffset = "UTC−02" });
			builder.HasData(new TimeZone { Id = 186, Abbreviation = "UYT", Name = "Uruguay Standard Time", UtcOffset = "UTC−03" });
			builder.HasData(new TimeZone { Id = 187, Abbreviation = "UZT", Name = "Uzbekistan Time", UtcOffset = "UTC+05" });
			builder.HasData(new TimeZone { Id = 188, Abbreviation = "VET", Name = "Venezuelan Standard Time", UtcOffset = "UTC−04" });
			builder.HasData(new TimeZone { Id = 189, Abbreviation = "VLAT", Name = "Vladivostok Time", UtcOffset = "UTC+10" });
			builder.HasData(new TimeZone { Id = 190, Abbreviation = "VOLT", Name = "Volgograd Time", UtcOffset = "UTC+04" });
			builder.HasData(new TimeZone { Id = 191, Abbreviation = "VOST", Name = "Vostok Station Time", UtcOffset = "UTC+06" });
			builder.HasData(new TimeZone { Id = 192, Abbreviation = "VUT", Name = "Vanuatu Time", UtcOffset = "UTC+11" });
			builder.HasData(new TimeZone { Id = 193, Abbreviation = "WAKT", Name = "Wake Island Time", UtcOffset = "UTC+12" });
			builder.HasData(new TimeZone { Id = 194, Abbreviation = "WAST", Name = "West Africa Summer Time", UtcOffset = "UTC+02" });
			builder.HasData(new TimeZone { Id = 195, Abbreviation = "WAT", Name = "West Africa Time", UtcOffset = "UTC+01" });
			builder.HasData(new TimeZone { Id = 196, Abbreviation = "WEST", Name = "Western European Summer Time", UtcOffset = "UTC+01" });
			builder.HasData(new TimeZone { Id = 197, Abbreviation = "WET", Name = "Western European Time", UtcOffset = "UTC±00" });
			builder.HasData(new TimeZone { Id = 198, Abbreviation = "WIT", Name = "Western Indonesian Time", UtcOffset = "UTC+07" });
			builder.HasData(new TimeZone { Id = 199, Abbreviation = "WGST", Name = "West Greenland Summer Time", UtcOffset = "UTC-02" });
			builder.HasData(new TimeZone { Id = 200, Abbreviation = "WGT", Name = "West Greenland Time", UtcOffset = "UTC-03" });
			builder.HasData(new TimeZone { Id = 201, Abbreviation = "WST", Name = "Western Standard Time", UtcOffset = "UTC+08" });
			builder.HasData(new TimeZone { Id = 202, Abbreviation = "YAKT", Name = "Yakutsk Time", UtcOffset = "UTC+09" });
			builder.HasData(new TimeZone { Id = 203, Abbreviation = "YEKT", Name = "Yekaterinburg Time", UtcOffset = "UTC+05" });
		}
	}
}