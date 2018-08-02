﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StockManagementSystemApplication.DAL;
using StockManagementSystemApplication.Modals;

namespace StockManagementSystemApplication.BLL
{
    class StockInManager
    {
        public static Regex regex=new Regex("[0-9]");
        StockInRepository stockInRepository=new StockInRepository();
        public DataTable GetCategoryTable(Category category)
        {
            DataTable dt = stockInRepository.GetCategoryTable(category);
            return dt;
        }
        public DataTable GetCompanyTable(Company    company)
        {
            DataTable dt = stockInRepository.GetCompanyTable(company);
            return dt;
        }
        public DataTable GetItemTable(Items item)
        {
            DataTable dt = stockInRepository.GetItemTable(item);
            return dt;
        }
        public DataTable SetCategoryTable(string selectedCategoryName)
        {
            DataTable dt=new DataTable();
             dt = stockInRepository.SetCategoryTable(selectedCategoryName);
            return dt;
        }
        public DataTable SetCompanyTable(string selectedCompanyName)
        {
            DataTable dt = new DataTable();
            dt = stockInRepository.SetCompanyTable(selectedCompanyName);
        
            return dt;
        }
        public DataTable SetItemTable(string selectedItemName)
        {
            DataTable dt = new DataTable();
            dt = stockInRepository.SetItemTable(selectedItemName);
            return dt;
        }

        public bool Update(StockInClass stockIn)
        {
            bool isAdded = stockInRepository.Update(stockIn);
            return isAdded;
        }

        public int GetItemId(StockInClass stockIn)
        {
            int itemId = stockInRepository.GetItemId(stockIn);
            return itemId;
        }

        public bool Validation(string stockInQuantity)
        {
            bool isTrue = false;
            if (regex.IsMatch(stockInQuantity))
            {
                isTrue = true;
            }
            return isTrue;
        }
    }
}
