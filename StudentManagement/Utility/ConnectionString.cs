﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Utility
{
    public static class ConnectionString
    {

        private static string cName = "Data Source=.\\(localdb)mssqllocaldb;Initial Catalog=ToDoList; Integrated Security = true";

        public static string CName { get => cName; }
    }
}
