using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DMVApplication.Models
{
   
    public class DriversDetails
    {
        [Required]
        [RegularExpression("^[A-Z]{1,1}[0-9]{5,5}$")]
        public string LicenceID { get; set; }
        [Required]
        public string DriverFirstName { get; set; }
        public string DriverLastName { get; set; }
        public DateTime ExpirateDate { get; set; }
    
    }

    //public class Licence
    //{
    //    public string LicenceID { get; set; }
    //}

  

    //public class DriversLicence
    //{
    //    public DriversDetails DriverID { get; set; }
    //    public Licence LicenceID { get; set; }
    //    public Status ApplicationStatus { get; set; }

    //}

    public class DriversDetailsList
    {
        List<DriversDetails> DriversList = new List<DriversDetails>
                                    {
                                        new DriversDetails { LicenceID= "B12345", DriverFirstName ="Sam", DriverLastName ="Mat", ExpirateDate = new DateTime (2019,03,30) },
                                        new DriversDetails { LicenceID= "A45673", DriverFirstName ="Dev", DriverLastName ="Chi" , ExpirateDate = new DateTime (2019,08,30)},
                                        new DriversDetails { LicenceID= "F87986", DriverFirstName ="Sah", DriverLastName ="Mad", ExpirateDate = new DateTime (2019,08,30)},
                                        new DriversDetails { LicenceID= "U45689", DriverFirstName ="Shau", DriverLastName ="Mat", ExpirateDate = new DateTime (2019,08,30)},
                                        new DriversDetails { LicenceID= "R56789", DriverFirstName ="Kim", DriverLastName ="Shi", ExpirateDate = new DateTime (2019,08,30)}
                                    };
        public List<DriversDetails> GetDriversDetailsList()
        {
            return DriversList;
        }

        public DriversDetails GetDriversDetails(DriversDetails dd)
        {
            return DriversList.FirstOrDefault(l => l.DriverFirstName == dd.DriverFirstName && l.LicenceID == dd.LicenceID);
        }
        public DriversDetails GetDriversDetails(string lid)
        {
            return DriversList.FirstOrDefault(l => l.LicenceID == lid);
        }

    }

    //public class LicenceList
    //{
    //    List<Licence> lLicenceList = new List<Licence>
    //                                {
    //                                    new Licence { LicenceID = "B12345"},
    //                                    new Licence { LicenceID = "A45673"},
    //                                    new Licence { LicenceID ="F87986"},
    //                                    new Licence { LicenceID ="U45689" },
    //                                    new Licence { LicenceID ="R56789"}
    //                                };
    //    public List<Licence> GetLicenceList()
    //    {
    //        return lLicenceList;
    //    }

    //}



}
