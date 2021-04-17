using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AlexPaint
{
    class Serialization
    {
        private string data;
        public void Serialize(BaseFigure.Figure myPaint)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            data = JsonSerializer.Serialize(myPaint, options);
        }

        public Paint Deserialize()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Deserialize<Paint>(data);
        }
    }
}
