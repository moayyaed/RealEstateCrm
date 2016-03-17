﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using WebApp.Entities;

namespace WebApp
{
    public static class CityExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectList(this IEnumerable<City> cityList, bool addedEmpty = false)
        {
            var items = cityList.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            if (addedEmpty)
            {
                items.Insert(0, new SelectListItem { Value = "", Selected = true, Text = "Все города" });
            }
            return items;
        }
    }
}
