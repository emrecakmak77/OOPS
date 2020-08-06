using Newtonsoft.Json;
using OOPS.DTO.ProjectBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPS.WebUI.Core
{
    public static class OOPSConvert
    {
        public static string OOPSJsonSerialize(object data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return json;
        }

        public static UserDTO OOPSJsonDeSerializeUserDTO(string data)
        {
            return JsonConvert.DeserializeObject<UserDTO>(data);
        }
    }
}
