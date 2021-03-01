using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace spc_client
{
    [POCOViewModel()]
    public class MainViewModel
    {

        // Bindable property will be created from this property.
        public virtual string Title { get; set; }
        // Just a method for readability
        public string GetTitleAsHumanReadableString()
        {
            if (Title == null)
                return "(Null)";
            if (Title.Length == 0)
                return "(Empty)";
            if (string.IsNullOrWhiteSpace(Title))
                return "(WhiteSpace)";
            return Title;
        }
    }
}
