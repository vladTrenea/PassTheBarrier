﻿using System.Collections.Generic;
using System.Linq;
using PassTheBarier.Core.Logic.Models;

namespace PassTheBarier.Core.Logic.Utils
{
	public static class NumberPrefixProvider
	{
		private static IList<NumberPrefixModel> _prefixes = new List<NumberPrefixModel>
		{
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Au,
				CountryCode = "AU",
				CountryName = "Austria",
				Prefix = "+43"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Be,
				CountryCode = "BE",
				CountryName = "Belgium",
				Prefix = "+32"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Bg,
				CountryCode = "Bulgaria",
				CountryName = "BG",
				Prefix = "+359"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Ca,
				CountryName = "Canada",
				CountryCode = "CA",
				Prefix = "+1"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Cn,
				CountryName = "China",
				CountryCode = "CN",
				Prefix = "+86"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Hr,
				CountryName = "Croatia",
				CountryCode = "HR",
				Prefix = "+385"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Dk,
				CountryName = "Denmark",
				CountryCode = "DK",
				Prefix = "+45"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.De,
				CountryName = "Germany",
				CountryCode = "DE",
				Prefix = "+49"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Fr,
				CountryName = "France",
				CountryCode = "FR",
				Prefix = "+33"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Gr,
				CountryName = "Greece",
				CountryCode = "GR",
				Prefix = "+30"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Hu,
				CountryName = "Hungary",
				CountryCode = "HU",
				Prefix = "+36"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Ie,
				CountryName = "Ireland",
				CountryCode = "IE",
				Prefix = "+353"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.It,
				CountryName = "Italy",
				CountryCode = "IT",
				Prefix = "+39"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Nl,
				CountryName = "Netherlands",
				CountryCode = "NL",
				Prefix = "+31"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.No,
				CountryName = "Norway",
				CountryCode = "NO",
				Prefix = "+47"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Pl,
				CountryName = "Poland",
				CountryCode = "PL",
				Prefix = "+48"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Pt,
				CountryName = "Portugal",
				CountryCode = "PT",
				Prefix = "+351"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Ro,
				CountryName = "Romania",
				CountryCode = "RO",
				Prefix = "+40"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Ru,
				CountryName = "Russia",
				CountryCode = "RU",
				Prefix = "+7"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Sk,
				CountryName = "Slovakia",
				CountryCode = "SK",
				Prefix = "+421"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Sl,
				CountryName = "Slovenia",
				CountryCode = "SL",
				Prefix = "+386"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Es,
				CountryName = "Spain",
				CountryCode = "ES",
				Prefix = "+34"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Se,
				CountryName = "Sweden",
				CountryCode = "SE",
				Prefix = "+46"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Ch,
				CountryName = "Switzerland",
				CountryCode = "CH",
				Prefix = "+41"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Tr,
				CountryName = "Turkey",
				CountryCode = "TR",
				Prefix = "+90"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Ua,
				CountryName = "Ukraine",
				CountryCode = "UA",
				Prefix = "+380"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Gb,
				CountryName = "United Kingdom",
				CountryCode = "GB",
				Prefix = "+44"
			},
			new NumberPrefixModel
			{
				Id = (int) CountryEnum.Us,
				CountryName = "United States",
				CountryCode = "US",
				Prefix = "+1"
			}
		};

		public static IList<NumberPrefixModel> GetNumberPrefixes()
		{
			return _prefixes.OrderBy(p => p.CountryName).ToList();
		}
	}
}