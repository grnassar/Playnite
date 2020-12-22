﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PlayniteServices.Filters;
using PlayniteServices.Models.IGDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PlayniteServices.Controllers.IGDB.DataGetter
{
    public class Franchises : DataGetter<Franchise>
    {
        private static readonly object cacheLock = new object();
        public Franchises(IgdbApi igdbApi) : base(igdbApi, "franchises", cacheLock)
        {
        }
    }
}
