using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Address_Book.Models;
using System.Web.ModelBinding;

namespace Address_Book
{
    public partial class AllRecordsShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Record> GetRecords()
        {
            var _db = new Address_Book.Models.AddressBookDatabaseContext();
            IQueryable<Record> query = _db.Records;
            return query;
        }
    }


  
}