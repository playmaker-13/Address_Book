﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using Address_Book.Models;

namespace Address_Book
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Код, выполняемый при запуске приложения
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            // Initialize the product database.
            AddressBookDatabaseInitializer newAddressBookDatabaseInitializer = new AddressBookDatabaseInitializer();
            newAddressBookDatabaseInitializer.InitializeDatabase(new AddressBookDatabaseContext());
            //Database.SetInitializer(newAddressBookDatabaseInitializer);
            
        }
    }
}
