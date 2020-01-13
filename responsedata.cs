using System;
using System.Collections.Generic;
using System.Text;

namespace idk
{
    public class truck
    {
        public int? TruckId { get; set; }
        public string TruckName { get; set; }
        public int? DriverUserId { get; set; }
        public string Vin { get; set; }
        public string FunctionalityTier { get; set; }
        public int? FunctionalityTierId { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public string EldName { get; set; }
        public int? TruckClassId { get; set; }
        public string TruckClassName { get; set; }
        public int? ClientDispatchId { get; set; }
        public int? ClientId { get; set; }
        public string UserNotes { get; set; }
        public int? GpsUpdateMinutes { get; set; }
        public int? IsType { get; set; }
        
        public tag[] tags { get; set; }

    }
    public class Apiresponse<T>
    {
        public Metadata metadata { get; set; }
        public T[] data { get; set; }


    }


    public class Metadata
    {
        public Pagination pagination {get; set;}
        public string Sort { get; set; }
    }
    public class Pagination
    {
        public int? Page { get; set; }
        public int? PerPage { get; set; }
        public int? TotalPageCount { get; set; }
        public int? TotalRecordCount { get; set; }
    }
    
    public class tag
    {
        public int? TagId { get; set; }
        public string Name { get; set; }
        public int? TagGroupID { get; set; }
    }
}


