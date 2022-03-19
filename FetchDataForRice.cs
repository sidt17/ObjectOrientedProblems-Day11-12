using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Threading.Tasks;

namespace InventoryDataManagementDemo
{
    public class fetchdataforrice
    {
        public Rice Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    Rice rice= JsonConvert.DeserializeObject<Rice>(json);
                    return rice;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

    }
}
