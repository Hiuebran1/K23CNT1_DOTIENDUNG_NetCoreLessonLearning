using Microsoft.AspNetCore.Mvc;

namespace Dtdlesson7.Models
{
    public class DtdEmployee 
    {

        public int DtdId { get; set; }
        public string DtdName { get; set; }
        public string DtdBirthDay { get; set; }
        public string Email { get; set; }
        public string DtdPhone { get; set; }
    }
}
