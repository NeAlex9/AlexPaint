using BaseFigure;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AlexPaint
{
    public class Serialization
    {
        public string Serialize(List<FigureData> objectToSerialize)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(objectToSerialize, options);

        }

        public List<FigureData> Deserialize(string data)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Deserialize<List<FigureData>>(data);
        }
    }
}
