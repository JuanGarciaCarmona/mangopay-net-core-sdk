﻿using MangoPay.SDK.Core.Converters;
using System;
using System.Collections.Generic;

namespace MangoPay.SDK.Core.Filters
{
    /// <summary>Filter for reports list.</summary>
	public class FilterReportsList
    {
        /// <summary>End date: return only transactions that have CreationDate BEFORE this date.</summary>
        public DateTime? BeforeDate;

        /// <summary>Start date: return only transactions that have CreationDate AFTER this date.</summary>
		public DateTime? AfterDate;

        /// <summary>Gets map of fields and values.</summary>
        /// <returns>Returns collection of field_name-field_value pairs.</returns>
        public Dictionary<string, string> GetValues()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            UnixDateTimeConverter dateConverter = new UnixDateTimeConverter();

            if (BeforeDate.HasValue) result.Add(Constants.BEFOREDATE, dateConverter.ConvertToUnixFormat(BeforeDate).Value.ToString());
            if (AfterDate.HasValue) result.Add(Constants.AFTERDATE, dateConverter.ConvertToUnixFormat(AfterDate).Value.ToString());

            return result;
        }
    }
}
