using GoMarketWebNetCoreAppMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
 
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace GoMarketWebNetCoreAppMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            PROJECT UnitsProject = new PROJECT();
            string path = @"D:\Örnek Dosya.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(PROJECT));
            StreamReader reader = new StreamReader(path);
            UnitsProject = (PROJECT)serializer.Deserialize(reader);
            Console.WriteLine(UnitsProject);
            reader.Close();

 
            foreach (var door in UnitsProject.DOORS)
            {
                var unit = UnitsProject.UNITS.FirstOrDefault(x => x.UNIQUECODE == door.MODUL);
                if (unit!=null)
                {
                    door.HasParent = true;
                    unit.DOORs.Add(door);
                }
                else
                {
                    door.HasParent = false;
                }
            }
            foreach (var handle in UnitsProject.HANDLES)
            {
                var unit = UnitsProject.UNITS.FirstOrDefault(x => x.UNIQUECODE == handle.MODUL);
                if (unit != null)
                {
                    handle.HasParent = true;
                    unit.HANDLEs.Add(handle);
                }
                else
                {
                    handle.HasParent = false;
                }

            }
            foreach (var plinthleg in UnitsProject.PLINTHLEGS)
            {
                var unit = UnitsProject.UNITS.FirstOrDefault(x => x.UNIQUECODE == plinthleg.MODUL);
                if (unit != null)
                {
                    plinthleg.HasParent = true;
                    unit.PLINTHLEGs.Add(plinthleg);
                }
                else
                {
                    plinthleg.HasParent = false;
                }
            }


            return View(UnitsProject);
        }
    }
}
