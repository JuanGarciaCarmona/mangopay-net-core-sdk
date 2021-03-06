﻿using MangoPay.SDK.Core.Converters;
using MangoPay.SDK.Core.Enumerations;
using Newtonsoft.Json;
using System;

namespace MangoPay.SDK.Entities.GET
{
    public class UboDeclarationDTO : EntityBase
    {
        public UboDeclarationDTO()
        {
        }

        /// <summary>Date of creation.</summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ProcessedDate { get; set; }

        public UboDeclarationType Status { get; set; }

        [JsonConverter(typeof(EnumerationConverter))]
        public UboRefusedReasonType Reason { get; set; }

        public string Message { get; set; }

        public UboDTO[] Ubos { get; set; }
    }
}