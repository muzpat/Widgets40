using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Widgets40.Controllers
{
    public class myret
    {

        public string JuniorAreaId { get; set; }
        public string SubgroupId { get; set; }
        public string ProductSubgroupCodeDescription { get; set; }
        public string seasonname { get; set; }
        public string TPNB { get; set; }
        public string TPND { get; set; }
        public string ProductDescription { get; set; }
        public string TotalBuy { get; set; }
        public string SeasonDescription { get; set; }
        public string LYTotalBuy { get; set; }
        public string SeasonalGroupId { get; set; }
    }

    public class myDiaData
    {

        public string tpnb { get; set; }
        public string expressbuy { get; set; }
        public string exportvolume { get; set; }
        public string largestorebuy { get; set; }
        public string samplingvolume { get; set; }
        public string totalbuy { get; set; }
        public string orphanId { get; set; }

    }


    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public ActionResult Index()
        {
            //  ViewBag.dictSeasons = dictSeasons;
            //  ViewBag.mySeason = season;
            //
            //  var Grp = (from cg in db.Products
            //             orderby cg.CustomerGroup ascending
            //             group cg by cg.CustomerGroup
            //              into GroupCG
            //             select new
            //             {
            //                 val1 = GroupCG.FirstOrDefault().CustomerGroup,
            //                 val2 = GroupCG.FirstOrDefault().CustomerGroup
            //
            //             });
            //
            //     Dictionary<string, string> dictdropdownlist = (from x in Grp select x).ToDictionary(x => x.val1,x => x.val1);


            var ddl = ;
            ddl.ID = "newDDL";

            ddl.Items.Add(new ListItem("1", "Christmas2019"));
            ddl.Items.Add(new ListItem("2", "Christmas2020"));

            ViewBag.DropDown = new List<SelectListItem>{ new SelectListItem{
                Text="Christmas2019",
                Value = "2"
            },
            new SelectListItem{
                Text="Christmas2020",
                Value = "1"
            }};

            ViewBag.custgroupdropdown = ddl;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult GetSeasonalGroupProducts()
        {
            List<myret> tbl = new List<myret>();
            myret aReturn = new myret();
            aReturn.JuniorAreaId = "aaa";
            aReturn.ProductDescription = "Big Item";
            aReturn.ProductSubgroupCodeDescription = "A1";
            aReturn.seasonname = "winter";
            aReturn.SeasonDescription = "Christmas2019";
            aReturn.SubgroupId = "1";
            aReturn.TotalBuy = "99";
            aReturn.TPNB = "7777";
            aReturn.TPND = "66666";
            aReturn.LYTotalBuy = "55";
            aReturn.SeasonalGroupId = "1";
            tbl.Add(aReturn);

            aReturn = new myret();
            aReturn.JuniorAreaId = "aaazzzz";
            aReturn.ProductDescription = "Bigger Item";
            aReturn.ProductSubgroupCodeDescription = "A1";
            aReturn.seasonname = "winter2";
            aReturn.SeasonDescription = "Christmas2020";
            aReturn.SubgroupId = "2";
            aReturn.TotalBuy = "888";
            aReturn.TPNB = "73277";
            aReturn.TPND = "63266";
            aReturn.SeasonalGroupId = "2";
            aReturn.LYTotalBuy = "5532";
            tbl.Add(aReturn);

            string s = JsonConvert.SerializeObject(tbl);
            return Json(s, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult getTPNBLYbuys()
        {
            List<myDiaData> tbl = new List<myDiaData>();
            myDiaData aReturn = new myDiaData();
            aReturn.exportvolume = "10";
            aReturn.expressbuy = "11";
            aReturn.largestorebuy = "12";
            aReturn.samplingvolume = "17";
            aReturn.totalbuy = "202";
            aReturn.tpnb = "5555";
            aReturn.orphanId = "aaa";
            tbl.Add(aReturn);
            string s = JsonConvert.SerializeObject(tbl);
            return Json(s, JsonRequestBehavior.AllowGet);

        }

    }
}