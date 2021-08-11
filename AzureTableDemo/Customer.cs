﻿using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureTableDemo
{
    public class Customer : TableEntity
    {
        public string customername { get; set; }
        public Customer(string _customername, string _city, string _customerid)
        {
            PartitionKey = _city;
            RowKey = _customerid;
            customername = _customername;
        }
    }
}
