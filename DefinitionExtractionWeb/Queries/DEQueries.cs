﻿using DefinitionExtractionWeb.Models;
using DefinitionExtractionWeb.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace DefinitionExtractionWeb.Queries
{
    public class DEQueries
    {
        DEDatabaseEntities db = new DEDatabaseEntities();
        public List<Definition> GetDefinitions (DateTime beg, DateTime end, int relID, int relDescID)
        {
            
            List<Definition> def;
            def = db.Definitions
                .Where
                (definition => definition.Insert_date >= beg
                && definition.Insert_date <= end
                && (definition.Descriptor.Relations.Where(r => r.Descriptor.ID == relDescID).Select(r=>r.Relation_types).Where(r=>r.ID==relID).Count()>0
                || definition.Descriptor.Relations1.Where(r=>r.Descriptor1.ID==relDescID).Select(r => r.Relation_types).Where(r => r.ID == relID).Count() > 0)
                )
                .ToList();
            return def;
        }

        public ChartViewModel GetChartForUsers (DateTime beg, DateTime end)
        {
            var data = db.Definitions.Where(def => def.Insert_date >= beg && def.Insert_date <= end)
                .Select(def => new StatsViewModel(){ User = def.User, Definition = def }).ToList();
            return new ChartViewModel(beg, end, data);
        }

        public ChartViewModel GetChartForUsers()
        {
            var data = db.Definitions
                           .Select(def => new StatsViewModel() { User = def.User, Definition = def }).ToList();
            return new ChartViewModel(data);
        }

        public object GetUsersStatistics()
        {
            var def = db.Users.Select(user => new { UserID = user.ID,
                UserName = user.First_name + " " + user.Last_name, Count = user.Definitions.Count }).ToList();

            return def;
        }
    }
}