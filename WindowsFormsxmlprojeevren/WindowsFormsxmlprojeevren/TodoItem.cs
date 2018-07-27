using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsxmlprojeevren
{
    public class TodoItem
    { // Guid benzersiz bir kod üreterek Id değişkenine 
        // o kodu tanımlar 
        // her veri satırı için otomatik olarak benzersiz bir id tanımlamış oluruz. 
        public Guid Id { get; set; }
        public string GorevMetni { get; set; }
        public DateTime TamamlanmaTarihi { get; set; }
        public bool Tamamlandi { get; set; }

        public override string ToString()
        {
            if (!Tamamlandi) { return GorevMetni; }
            else { return string.Format(TamamlanmaTarihi.ToShortDateString() + " " + GorevMetni); }


        }

    }
}
