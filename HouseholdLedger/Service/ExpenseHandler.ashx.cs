using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseholdLedger.Common;
using System.Transactions;
using HouseholdLedger.View;
using HouseholdLedger.DAO;
using HouseholdLedger.Utility;

namespace HouseholdLedger.Service
{   
    /// <summary>
    /// ExpenseHandler の概要の説明
    /// </summary>
    public class ExpenseHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            System.Diagnostics.Debug.WriteLine("Request");

            TExpense expense = new TExpense();
            string oper = string.Empty;

            if (context.Request.HttpMethod == "GET")
            {
                System.Diagnostics.Debug.WriteLine("GET");

            }
            else if (context.Request.HttpMethod == "POST")
            {
                System.Diagnostics.Debug.WriteLine("POST");
                string id = context.Request.Form["id"];
                string item = context.Request.Form["item"];
                string type = context.Request.Form["type"];
                string amount = context.Request.Form["amount"];
                string payee = context.Request.Form["payee"];
                string who = context.Request.Form["who"];
                string delflg = context.Request.Form["delflg"];
                string date = context.Request.Form["date"];
                oper = context.Request.Form["oper"];

                try
                {
                    expense.ID = StringUtil.IntZeroOrValue(id);
                    expense.Item = StringUtil.EmptyOrValue(item);
                    expense.Type = StringUtil.IntZeroOrValue(type);
                    expense.Amount = StringUtil.DecimalZeroOrValue(amount);
                    expense.Payee = StringUtil.EmptyOrValue(payee);
                    expense.Who = StringUtil.EmptyOrValue(who);
                    expense.DelFlg = StringUtil.IntZeroOrValue(delflg);
                    expense.Date = StringUtil.DateTimeNewOrValue(date);
                    System.Diagnostics.Debug.WriteLine("id:" + expense.ID);
                    System.Diagnostics.Debug.WriteLine(oper);
                }
                catch (ArgumentException)
                {
                    throw;
                }

                switch (oper)
                {
                    case ServiceConst.ADD:
                    case ServiceConst.EDIT:
                        Save(expense);
                        break;
                    case ServiceConst.DEL:
                        Remove(expense);
                        break;
                    default:
                        Load(context, expense);
                        break;
                }  

            }

        }

        private void Load(HttpContext context, TExpense expense)
        {
            context.Response.ContentType = "text/plain";

            var s = new System.Web.Script.Serialization.JavaScriptSerializer();

            ExpenseHome dao = new ExpenseHome();
            ExpenseView[] expenses = dao.Load(expense);
            context.Response.Write(s.Serialize(expenses));
            context.Response.End();
        }

        private void Save(TExpense expense)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                ExpenseHome dao = new ExpenseHome();
                dao.Save(expense);
                transaction.Complete();
            }
        }

        private void Remove(TExpense expense)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                ExpenseHome dao = new ExpenseHome();
                dao.Remove(expense);
                transaction.Complete();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}