﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PlayniteServices.Filters;
using PlayniteServices.Models.IGDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PlayniteServices.Controllers.IGDB.DataGetter
{
    public class AgeRatings : DataGetter<AgeRating>
    {
        private static readonly object cacheLock = new object();
        public AgeRatings(IgdbApi igdbApi) : base(igdbApi, "age_ratings", cacheLock)
        {
        }
    }
}
