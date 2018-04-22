using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfeToBeBot_v2._0.Utilities {
    static class Helper {

        public static string CreateContactCode() {
            string code = System.IO.Path.GetRandomFileName();
            code = code.Contains(".") ? code.Replace(".", "") : code;

            return code;
        }

        public static byte[] GetBytesFromImage(Image image) {
            using (var ms = new System.IO.MemoryStream()) {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Image GetImageFromBytes(byte[] bytes) {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes)) {
                return Image.FromStream(ms);
            }
        }
    }
}
