using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDto dto = new ApplicationDto();
            dto.OSName = "iOS";
            dto.OSVersion = "11.4";
            dto.ApplicationId = new Guid("af9a2565-17eb-46d5-b777-e7d1e3f437ab");
            dto.Manufactor = "Apple";
            dto.TimeZoneInfo = "Local;60;Local;CET;CEST;[01:01:2018;12:31:2018;60;[1;02:00:00;3;25;];[1;03:00:00;10;28;];];";
           
            try
            {

                var result = JsonConvert.SerializeObject(dto);
                var timeZoneInfo = TimeZoneInfo.FromSerializedString(dto.TimeZoneInfo);

            }
            catch (Exception ex)
            {

            }
  }

        public void TestListSerialization()
        {
            List<ApplicationDto> test = new List<ApplicationDto>();
            ApplicationDto dto = new ApplicationDto();
            dto.OSName = "iOS";
            dto.OSVersion = "11.4";
            dto.ApplicationId = new Guid("af9a2565-17eb-46d5-b777-e7d1e3f437ab");
            dto.Manufactor = "Apple";
            dto.TimeZoneInfo = "Local;60;Local;CET;CEST;[01:01:2018;12:31:2018;60;[1;02:00:00;3;25;];[1;03:00:00;10;28;];];";
            test.Add(dto);
            ApplicationDto dto1 = new ApplicationDto();
            dto1.OSName = "Android";
            dto1.OSVersion = "11.4";
            dto1.ApplicationId = new Guid("af9a2565-17eb-46d5-b777-e7d1e3f437ab");
            dto1.Manufactor = "Apple";
            dto1.TimeZoneInfo = "Local;60;Local;CET;CEST;[01:01:2018;12:31:2018;60;[1;02:00:00;3;25;];[1;03:00:00;10;28;];];";
            test.Add(dto1);
            var result = JsonConvert.SerializeObject(test);
        }
            
    }
    public class ApplicationDto
    {
        public string OSName { get; set; }
        public string OSVersion { get; set; }
        public Guid ApplicationId { get; set; }
        public int? Status { get; set; }
        public string Manufactor { get; set; }
        public string TimeZoneInfo { get; set; }
    }
}
