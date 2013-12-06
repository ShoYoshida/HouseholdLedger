using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseholdLedger.View;
using HouseholdLedger.Service;
using HouseholdLedger.Common;

namespace HouseholdLedger.DAO
{
    public class ExpenseHome
    {

        public ExpenseView[] Load(TExpense expense) 
        {
            using (HLDContainer OContext = new HLDContainer()) {

                var rs = from ex in OContext.TExpenses
                         where ex.Date == expense.Date
                         select new
                            {
                                ex.ID,
                                ex.Item,
                                ex.Type,
                                ex.Amount,
                                ex.Payee,
                                ex.Who, 
                                ex.DelFlg,
                                ex.Date
                            };

                List<ExpenseView> expenses = new List<ExpenseView>();
                foreach (var rec in rs) { 
                    ExpenseView eView = new View.ExpenseView();
                    eView.id = rec.ID;
                    eView.item = rec.Item;
                    eView.type = CodeConversion.CnvType(rec.Type);
                    eView.amount = rec.Amount;
                    eView.payee = rec.Payee;
                    eView.who = rec.Who;
                    eView.delflg = rec.DelFlg;
                    eView.date = rec.Date.ToShortDateString();
                    expenses.Add(eView);
                }
                return expenses.ToArray();                      
            }
        }

        public void Save(TExpense expense)
        {
            using (HLDContainer OContext = new HLDContainer()) {

                if (expense.ID > 0)
                {
                    var rs = from ex in OContext.TExpenses
                             where ex.ID == expense.ID
                             select ex;

                    TExpense oldRec = rs.Single();

                    oldRec.Item = expense.Item;
                    oldRec.Type = expense.Type;
                    oldRec.Amount = expense.Amount;
                    oldRec.Payee = expense.Payee;
                    oldRec.Who = expense.Who;
                    oldRec.DelFlg = expense.DelFlg;
                    oldRec.UpdatedDate = DateTime.Now;

                }
                else
                {
                    expense.CreationDate = DateTime.Now;
                    OContext.TExpenses.AddObject(expense);
                }

                OContext.SaveChanges();            
            }
        }

        public void Remove(TExpense expense)
        {
            using (HLDContainer OContext = new HLDContainer()) {
                var rs = from ex in OContext.TExpenses
                         where ex.ID == expense.ID
                        select ex;

                OContext.DeleteObject(rs.Single());
                OContext.SaveChanges();
            }
        }

    }
}